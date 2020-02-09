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
            Point3[] results = this.figure.getPtsAround(screw.aplicationPoint.toPoint3());
            if (results == null) throw new NotInFigureExeption();
            else if(this.figure.IndexOf(screw.aplicationPoint.toPoint3()) ==-1)
                this.figure.addPoint(screw.aplicationPoint.toPoint3(), results[0],results[1]);
        }
        private Figure calculateDeformation(Point3 ptStart,Point3 ptEnd,Screw screw,Screw screwPtStart)
        {
            if (ptStart.toVector().substract(ptEnd.toVector()).isProportional(ptEnd.toVector().substract(screw.aplicationPoint)))
            {
                return normalDeformation(ptStart,ptEnd,screw, screwPtStart);
            }
            else
            {
                return curbDeformation(ptStart, ptEnd, screw);
            }
        }
        private Figure curbDeformation(Point3 ptStart, Point3 ptEnd, Screw screw)
        {

        }
        private float[] getDeformationFunctionArgs(float l,float M, float Z)
        {
            float X0 = (float)Math.Pow(l, 3) * Z / 6;
            X0 -= (float)Math.Pow(l, 2) * M / 2;
            float X1 = (float)Math.Pow(l, 2) * Z / 2;
            X1 -= l * M;
            float X2 = M / 2;
            float X3 = -Z / 6;
            return new float[] { X0, X1, X2, X3 };

        }
        private FunctionPolynomial getDeformationFunctionY(float l, float M, float Z)
        {
            float[] deformationFunctionArgs = this.getDeformationFunctionArgs(l, M, Z);
            return new FunctionPolynomial(deformationFunctionArgs);

        }
        private FunctionPolynomial getDeformationFunctionZ(float l, float N, float Y)
        {
            float[] deformationFunctionArgs = this.getDeformationFunctionArgs(l, N, Y);
            for (int i = 0; i < deformationFunctionArgs.Length; i++)
            {
                deformationFunctionArgs[i] = -deformationFunctionArgs[i];
            }
            return new FunctionPolynomial(deformationFunctionArgs);

        }
        private Figure normalDeformation(Point3 ptStart, Point3 ptEnd, Screw screw, Screw screwPtStart)
        {
            float distPtStartPtEnd = ptEnd.toVector().substract(ptStart.toVector()).getNorm();
            float lScrew = screw.aplicationPoint.substract(ptStart.toVector()).getNorm();
            Figure figure= new Figure();
            if (distPtStartPtEnd < 2) return figure;
            Projector projector = new Projector(Projector.getUsualBase());
            projector.constructFinalBase(ptEnd.toVector().substract(ptStart.toVector()),ptStart.toVector());
            FloatVector ptStartFinalBase=projector.projectToFinalBase(ptStart.toVector())
                , ptEndFinalBase = projector.projectToFinalBase(ptEnd.toVector());

            Screw screwFinalBase = screw.project(projector,true);


            Screw screwPtStartFinalBase = screwPtStart.project(projector, true);
            float l = distPtStartPtEnd;

            FunctionPolynomial ftcStartY = this.getDeformationFunctionY(l, screwPtStartFinalBase.M, screwPtStartFinalBase.Z);

            FunctionPolynomial ftcStartZ = this.getDeformationFunctionZ(l, screwPtStartFinalBase.N, screwPtStartFinalBase.Y);

            FunctionPolynomial ftcEndY= this.getDeformationFunctionY(l, screwPtStartFinalBase.M + screwFinalBase.M + lScrew * screwFinalBase.Z, screwPtStartFinalBase.Z + screwFinalBase.Z);

            FunctionPolynomial ftcEndZ = this.getDeformationFunctionZ(l, screwPtStartFinalBase.N + screwFinalBase.N + lScrew * screwFinalBase.Y, screwPtStartFinalBase.Y + screwFinalBase.Y);

            FloatVector pointResult = ptStartFinalBase.vectorWhithAllCoordinatesEquals(0);
            float X = ptStartFinalBase[0];
            do
            {
                pointResult[0] = X;
                if (X < lScrew)
                {
                    pointResult[1] = ftcStartY.calcY(X);
                    pointResult[2] = ftcStartZ.calcY(X);
                }
                else
                {
                    pointResult[1] = ftcEndY.calcY(X);
                    pointResult[2] = ftcEndZ.calcY(X);
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
            Point3 pt = screw.aplicationPoint;
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
