using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.Exceptions;
using UI_Library.Code.Operations;
using UI_Library.Code.CrashObject.Properties;

namespace UI_Library.Code.RDMengine
{
    class RDMengine
    {
        /*
         * Hypostesis
         *      no bonce effect
         *      problem can be resolve in static
         */
        //Figure figureUp=null;
        //Figure figureDown = null;
        Figure figure { get; set; }
        float IGz;
        float E;
        public RDMengine(Figure figure,float IGz,float E)
        {
            this.figure = figure;
            this.IGz = IGz;
            this.E = E;
        }
        public void applyScrew(Screw screw)
        {
            Point3[] ptsAround = this.figure.getPtsAround(screw.aplicationPoint.toPoint3());
            if (ptsAround == null) throw new NotInFigureExeption();
            FloatVector directorPtAround = ptsAround[1].toVector().substract(ptsAround[0].toVector()).normalize();
            FloatVector ptOnFigure = ptsAround[0].toVector().add(directorPtAround.multiplyByScalar(screw.aplicationPoint.scalarProduct(directorPtAround)));
            Screw screwOnFigure = Screw.fromWrenchAndTwist(screw.getWrench(), screw.getTwist(),ptOnFigure);
            throw new NotImplementedException();/*






            */
        }
        private Figure calculateDeformation(Point3 ptStart,Point3 ptEnd,Screw screw,Screw screwPtStart,bool firstStep)
        {
            if (!firstStep)
            {
                return normalDeformation(ptStart,ptEnd,screwPtStart);
            }
            else
            {
                return curbDeformation(ptStart, ptEnd, screw);
            }
        }
        private float[] getDeformationFunctionArgsNoHyperstatism(float l, float k, float M0, float Z0, bool start) // screw en A , bati
        {
            float A = -M0 * l + Z0 * (float)Math.Pow(l, 2) / 2;
            float B = -M0 * (float)Math.Pow(l, 2) / 2 + (float)Math.Pow(l, 3) * Z0 / 6 - A * l;
            return getDeformationFunctionArgsFromFormule(l,k,M0,Z0,A,B);

        }
        private float[] getDeformationFunctionArgsHyperstatismDeg1(float l, float k, float M0, float B, bool start)// screw en A, y en A ou z en A , bati
        {
            float Z0 = 3 * (B - M0 * (float)Math.Pow(l, 2) / 2);
            float A = -M0 * l + Z0 * (float)Math.Pow(l, 2) / 2;

            return getDeformationFunctionArgsFromFormule(l, k, M0, Z0, A, B);

        }
        private float[] getDeformationFunctionArgsHyperstatismDeg2(float l,float k,float M,float Z,bool start)// bati, screw en B, bati
        {
            float k2Ml2 = (float)Math.Pow(k, 2) - (float)Math.Pow(l, 2);
            float Z0 = M + Z * k;
            Z0 *= (float)(Math.Pow(k, 2))/2 + l * (k - (1/2) * l) + (k - l) * (k - (1/2) * l);
            Z0 += Z * ((float)Math.Pow(k, 3) / 6 - (k2Ml2 * (k - (1/2) * l)));
            float M0 = (M + k * Z) * (k - l) - (k2Ml2 * Z / 2) + ((float)Math.Pow(l, 2) / 2) * Z0;
            M0 /= l;
            float A, B;
            if (start)
            {
                A = 0; B = 0;
                return this.getDeformationFunctionArgsFromFormule(l, k, M0, Z0, A, B);
            }
            else 
            {
                A = -(M0 + M + k * Z) * l + ((float)Math.Pow(l, 2) / 2) * (Z0 + Z);
                B = -(M0 + M + k * Z) * ((float)Math.Pow(l, 2) / 2) + ((float)Math.Pow(l, 3) / 6) * (Z0 + Z) - A * l;
                return this.getDeformationFunctionArgsFromFormule(l, k, M0 + M + k * Z, Z0 + Z, A, B);
            }

        }
        private float[] getDeformationFunctionArgsFromFormule(float l, float k, float M0, float Z0, float A, float B)
        {
            return new float[] { B, A, M0 / 2, -Z0 / 6, };
        }
        private delegate float[] GetDeformationFunctionArgs(float l, float k, float M, float Z, bool start);
        private GetDeformationFunctionArgs getDeformationFunction(int hyperstatism)
        {
            GetDeformationFunctionArgs getDeformationFunctionArgs;
            switch (hyperstatism)
            {
                case 2:
                    getDeformationFunctionArgs = this.getDeformationFunctionArgsHyperstatismDeg2;
                    break;
                case 1:
                    getDeformationFunctionArgs = this.getDeformationFunctionArgsHyperstatismDeg1;
                    break;
                case 0:
                default:
                    getDeformationFunctionArgs = this.getDeformationFunctionArgsNoHyperstatism;
                    break;
            }
            return getDeformationFunctionArgs;
        }
        private FunctionPolynomial getDeformationFunctionY(float l, float k, float M, float Z, bool start, int hyperstatism)
        {
            GetDeformationFunctionArgs getDeformationFunctionArgs = this.getDeformationFunction(hyperstatism);
            float[] deformationFunctionArgs = getDeformationFunctionArgs(l, k,M,Z, start);
            return new FunctionPolynomial(deformationFunctionArgs);

        }
        private FunctionPolynomial getDeformationFunctionZ(float l, float k, float N, float Y, bool start, int hyperstatism)
        {
            GetDeformationFunctionArgs getDeformationFunctionArgs = this.getDeformationFunction(hyperstatism);
            float[] deformationFunctionArgs = getDeformationFunctionArgs(l, k, N, Y, start);
            for (int i = 0; i < deformationFunctionArgs.Length; i++)
            {
                deformationFunctionArgs[i] = -deformationFunctionArgs[i];
            }
            return new FunctionPolynomial(deformationFunctionArgs);

        }
        private Figure normalDeformation(Point3 ptStart, Point3 ptEnd, Screw screwPtStart)
        {
            float distPtStartPtEnd = ptEnd.toVector().substract(ptStart.toVector()).getNorm();
            Figure figure= new Figure();
            if (distPtStartPtEnd < 2) return figure;
            Projector projector = new Projector(Projector.getUsualBase());
            projector.constructFinalBase(ptEnd.toVector().substract(ptStart.toVector()),ptStart.toVector());
            FloatVector ptStartFinalBase=projector.projectToFinalBase(ptStart.toVector())
                , ptEndFinalBase = projector.projectToFinalBase(ptEnd.toVector());

            Screw screwPtStartFinalBase = screwPtStart.project(projector, true);
            float l = distPtStartPtEnd;

            FunctionPolynomial ftcY = this.getDeformationFunctionY(l,0, screwPtStartFinalBase.M, screwPtStartFinalBase.Z,true,0);

            FunctionPolynomial ftcZ = this.getDeformationFunctionZ(l, 0, screwPtStartFinalBase.M, screwPtStartFinalBase.Z, true, 0);

            FloatVector pointResult = ptStartFinalBase.vectorWhithAllCoordinatesEquals(0);
            float X = ptStartFinalBase[0];
            do
            {
                pointResult[0] = X;
                pointResult[1] = ftcY.calcY(X)/(this.E*this.IGz);
                pointResult[2] = ftcZ.calcY(X)/ (this.E * this.IGz);
                X += 1;
                figure.Add(projector.projectToOriginalBase(pointResult).toPoint3());
            }
            while (X <= ptEndFinalBase[0]);
            return figure;
        }
        private Figure curbDeformation(Point3 ptStart, Point3 ptEnd, Screw screw)
        {
            float distPtStartPtEnd = ptEnd.toVector().substract(ptStart.toVector()).getNorm();
            float lScrew = screw.aplicationPoint.substract(ptStart.toVector()).getNorm();
            Figure figure = new Figure();
            if (distPtStartPtEnd < 2) return figure;
            Projector projector = new Projector(Projector.getUsualBase());
            projector.constructFinalBase(ptEnd.toVector().substract(ptStart.toVector()), ptStart.toVector());
            FloatVector ptStartFinalBase = projector.projectToFinalBase(ptStart.toVector())
                , ptEndFinalBase = projector.projectToFinalBase(ptEnd.toVector());

            Screw screwFinalBase = screw.project(projector, true);
            float l = distPtStartPtEnd;
            float k = lScrew;

            FunctionPolynomial ftcStartY = this.getDeformationFunctionY(l, k, screwFinalBase.M, screwFinalBase.Z, true, 2);

            FunctionPolynomial ftcStartZ = this.getDeformationFunctionZ(l, k, screwFinalBase.M, screwFinalBase.Z, true, 2);

            FunctionPolynomial ftcEndY = this.getDeformationFunctionY(l, k, screwFinalBase.M, screwFinalBase.Z, true, 2);

            FunctionPolynomial ftcEndZ = this.getDeformationFunctionZ(l, k, screwFinalBase.M, screwFinalBase.Z, false, 2);

            FloatVector pointResult = ptStartFinalBase.vectorWhithAllCoordinatesEquals(0);
            float X = ptStartFinalBase[0];
            do
            {
                pointResult[0] = X;
                if (X < lScrew)
                {
                    pointResult[1] = ftcStartY.calcY(X) / (this.E * this.IGz);
                    pointResult[2] = ftcStartZ.calcY(X) / (this.E * this.IGz);
                }
                else
                {
                    pointResult[1] = ftcEndY.calcY(X) / (this.E * this.IGz);
                    pointResult[2] = ftcEndZ.calcY(X) / (this.E * this.IGz);
                }
                X += 1;
                figure.Add(projector.projectToOriginalBase(pointResult).toPoint3());
            }
            while (X <= ptEndFinalBase[0]);
            return figure;
        }
        private Dictionary<string,FtcLine> project(FloatVector vectorUseToProject)
        {
            Dictionary<string, FtcLine> dict = new Dictionary<string, FtcLine>();
            return dict;
        }
        /*
        private bool checkIfPtInFigure(Point3 point)
        {
            if (this.figureUp!=null) this.figureUp = resize(this.figure,true,1);
            if (this.figureUp !=null) this.figureDown = resize(this.figure,false,2);
            PictureFromScatterPlot pictureFromScaterPlot = new PictureFromScatterPlot();
            pictureFromScaterPlot.myFigure = this.figureUp;
            bool isInsidefigure = pictureFromScaterPlot.isIn(point.X, point.Y);
            pictureFromScaterPlot.myFigure = this.figureDown;
            bool isOnfigure = !pictureFromScaterPlot.isIn(point.X, point.Y);
            return isInsidefigure && isOnfigure;
        }
        */
        private bool checkIfPtInFigure(Point3 point)
        {
            return this.figure.getPtsAround(point, 1) != null;
        }
        private void incraseCount(ref int ind, ref Double count,int lenFigure,int k)
        {
            FloatVector pt1 = this.figure[ind].toVector();
            ind = Modulo.posModulo(ind + k, lenFigure);
            FloatVector pt2 = this.figure[ind].toVector();
            Double temps = 0;
            for (int i = 0; i < pt1.coordinates.Length; i++)
            {
                temps += Math.Pow(pt1.coordinates[i] - pt2.coordinates[i], 2);
            }
            count += Math.Pow(temps, 0.5);

        }
        private Point3 getFarestPoint (Screw screw)
        {
            Point3 pt = screw.aplicationPoint.toPoint3();
            Double countUp = 0, countDown = 0;
            int indPt = this.figure.IndexOf(pt);
            int lenFig = this.figure.Count;
            int idown = Modulo.posModulo(indPt - 1, lenFig), iup= Modulo.posModulo(indPt + 1, lenFig);
            while (idown != iup)
            {
                if (countUp > countDown)
                {
                    this.incraseCount(ref idown, ref countDown,lenFig,-1);
                }
                else this.incraseCount(ref iup, ref countUp, lenFig,1);
            }
            return this.figure[idown];
        }
        private Figure resize(Figure figure, bool up,int n)
        {
            Point3 centerOfGravity = this.getCenterOfGravity();
            List<Point3> newFigure = new List<Point3>();
            foreach (Point3 point in figure)
            {
                int X, Y, Z;
                if (up)
                {
                    X = this.incrementIf(n,this.isHigher(point.X, centerOfGravity.X), point.X);
                    Y = this.incrementIf(n,this.isHigher(point.Y, centerOfGravity.Y), point.Y);
                    Z = this.incrementIf(n,this.isHigher(point.Z, centerOfGravity.Z), point.Z);
                }
                else
                {
                    X = this.incrementIf(n,!this.isHigher(point.X, centerOfGravity.X), point.X);
                    Y = this.incrementIf(n,!this.isHigher(point.Y, centerOfGravity.Y), point.Y);
                    Z = this.incrementIf(n,!this.isHigher(point.Z, centerOfGravity.Z), point.Z);
                }
                newFigure.Add(new Point3(X, Y, Z));
            }
            return (Figure)newFigure;
        }
        private Point3 getCenterOfGravity()
        {
            throw new NotImplementedException();
        }
        private bool isHigher(int X,int Y)
        {
            return X > Y;
        }
        private int incrementIf(int incremetBy, bool condition,int toIncrement)
        {
            return condition ? toIncrement + incremetBy : toIncrement - incremetBy;
        }

    }
}
