using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.Exceptions;
using UI_Library.Code.Operations;

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
        public Figure figure { get; set; }
        float IGz;
        float E;
        public RDMengine(Figure figure,float IGz,float E)
        {
            this.figure = figure;
            this.IGz = IGz;
            this.E = E;
        }
        private Point3 getPt(bool start,bool right,int posPtAround,int nbBoucles,int rightIncrement,Figure figure)
        {
            int posPtAroundSubstractPosPtStart = start ? (nbBoucles - 1) : nbBoucles;
            int increment = right ? rightIncrement : -rightIncrement;
            return figure[
                   Modulo.posModulo(posPtAround + posPtAroundSubstractPosPtStart * increment, figure.Count)
                ];
        }
        public void applyScrew(Screw screw)
        {
            Point3[] ptsAround = this.figure.getPtsAround(screw.aplicationPoint.toPoint3());
            if (ptsAround == null) throw new NotInFigureExeption();
            FloatVector directorPtAround = ptsAround[1].toVector().substract(ptsAround[0].toVector()).normalize();
            FloatVector ptOnFigure = ptsAround[0].toVector().add(directorPtAround.multiplyByScalar(screw.aplicationPoint.scalarProduct(directorPtAround)));
            Screw screwOnFigure = Screw.fromWrenchAndTwist(screw.getWrench(), screw.getTwist(),ptOnFigure);
            List<Figure> listMoves = new List<Figure>();
            listMoves.Add(this.calculateDeformation(ptsAround[0], ptsAround[1], screwOnFigure, null, true));
            Point3 ptmax = this.getFarestPoint(screwOnFigure);
            int i = 0;
            int[] posPtsAround = new int[] { Array.IndexOf(this.figure.ToArray(), ptsAround[0]), Array.IndexOf(this.figure.ToArray(), ptsAround[1]) };
            int increment = posPtsAround[0] < posPtsAround[1] ? 1 : -1;
            bool endLeft = false, endRight = false;
            int nbBoucles = 1;
            List<Point3[]> ptsUsedToCalc = new List<Point3[]>();
            ptsUsedToCalc.Add(ptsAround);
            while (!endLeft||!endRight)
            {
                Point3 ptStart, ptEnd;
                foreach (bool right in new bool[]{ true, false})
                {
                    ptStart = this.getPt(true, right, posPtsAround[0], nbBoucles, increment, this.figure);
                    ptEnd = this.getPt(false, right, posPtsAround[1], nbBoucles, increment, this.figure);
                    ptsUsedToCalc.Add(new Point3[] { ptStart, ptEnd });
                    listMoves.Add((right?endRight:endLeft)? null : this.calculateDeformation(ptStart, ptEnd, null, screwOnFigure.changeApplicationPoint(ptStart.toVector()), false));
                    if (ptEnd == ptmax)
                    {
                        if (right)
                        {
                            endRight = true;
                        }
                        else endLeft = true;
                    }
                };
                i += 2;
                nbBoucles++;
            }
            this.figure = this.getNewFigure(this.figure, listMoves,ptsUsedToCalc, ptmax);
        }
        private Figure getNewFigure(Figure oldFigure,List<Figure> listMoves, List<Point3[]> ptsUsedToCalc, Point3 ptmax)
        {
            int indWhereWeAreInList = listMoves.Count - 1;
            int indStart = oldFigure.IndexOf(ptmax);
            Figure newFigure1 = new Figure();
            Figure newFigure2 = new Figure();
            List<Point3> toApply1= new List<Point3>();
            List<Point3> toApply2 = new List<Point3>();
            while (indWhereWeAreInList != 0)
            {
                if (listMoves[indWhereWeAreInList] != null)
                {
                    this.calculateNextNewFigurePart(ref newFigure1, indWhereWeAreInList, listMoves, ptsUsedToCalc, ref toApply1);
                }
                indWhereWeAreInList--;
                if (listMoves[indWhereWeAreInList] != null)
                {
                    this.calculateNextNewFigurePart(ref newFigure2, indWhereWeAreInList, listMoves, ptsUsedToCalc, ref toApply2);
                }
                indWhereWeAreInList--;
            }
            List<Figure> listMovesRight = new List<Figure>();
            List<Figure> listMovesLeft = new List<Figure>();
            List<Point3[]> ptsUsedToCalcRight = new List<Point3[]>();
            List<Point3[]> ptsUsedToCalcLeft = new List<Point3[]>();
            Point3[] ptStartAndEnd = ptsUsedToCalc[indWhereWeAreInList];
            Figure moves = listMoves[0];
            Point3 ptRight = ptStartAndEnd[1];
            Point3 ptLeft = ptStartAndEnd[0];
            FloatVector vector = ptRight.toVector().substract(ptLeft.toVector());
            vector = vector.multiplyByScalar(1 / 2);
            Point3 ptMid = ptLeft.toVector().add(vector).toPoint3();
            ptsUsedToCalcLeft.Add(new Point3[] { ptMid, ptLeft });
            ptsUsedToCalcRight.Add(new Point3[] { ptMid, ptRight });
            Figure movesLeft = (Figure)moves.Take((int)(moves.Count / 2));
            movesLeft.Reverse();
            Figure movesRight = (Figure)moves.Skip((int)(moves.Count / 2)).Take(moves.Count - (int)(moves.Count / 2));
            listMovesLeft.Add(movesLeft);
            listMovesRight.Add(movesRight);
            this.calculateNextNewFigurePart(ref newFigure1, 0, listMovesRight, ptsUsedToCalcRight, ref toApply1);
            this.calculateNextNewFigurePart(ref newFigure2, 0, listMovesLeft, ptsUsedToCalcLeft, ref toApply2);
            newFigure2.Reverse();
            foreach(Point3 point in newFigure2)
            {
                newFigure1.Add(point);
            }
            newFigure1.Add(ptmax);
            return newFigure1;
        }
        private void calculateNextNewFigurePart(ref Figure newFigure, int indWhereWeAreInList, List<Figure> listMoves, List<Point3[]> ptsUsedToCalc, ref List<Point3> toApply)
        {
            Point3[] ptStartAndEnd = ptsUsedToCalc[indWhereWeAreInList];
            Figure moves = listMoves[indWhereWeAreInList];
            Point3 ptStart = ptStartAndEnd[0];
            Point3 ptEnd = ptStartAndEnd[1];
            FloatVector vector = ptEnd.toVector().substract(ptStart.toVector()).normalize();
            int i = 0;
            FloatVector tempPoint;
            Point3 checkPoint;
            Figure tempsFigure = new Figure();
            do
            {
                tempPoint = ptStart.toVector().add(vector.multiplyByScalar(i));
                checkPoint = tempPoint.toPoint3();
                if (i == 0 || !moves[i].toVector().isEquals(tempPoint.vectorWhithAllCoordinatesEquals(0)))
                {
                    foreach (Point3 point in toApply)
                    {
                        tempPoint = tempPoint.add(point.toVector());
                    }
                    tempsFigure.Add(tempPoint.toPoint3());
                }
                i++;
            }
            while (checkPoint != ptEnd);
            tempsFigure.Reverse();
            foreach(Point3 point in tempsFigure)
            {
                newFigure.Add(point);
            }
            toApply.Add(moves[0]);
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
                figure.Add(projector.projectToOriginalBase(pointResult,false).toPoint3());
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
                figure.Add(projector.projectToOriginalBase(pointResult,false).toPoint3());
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
            count += pt1.substract(pt2).getNorm();

        }
        private Point3 getFarestPoint (Screw screw)
        {
            Point3 pt = screw.aplicationPoint.toPoint3();
            Double countUp = 0, countDown = 0;
            Point3[] ptsAround = this.figure.getPtsAround(pt);
            if (ptsAround == null) return null;
            int[] indPtsAround = new int[] { this.figure.IndexOf(ptsAround[0]), this.figure.IndexOf(ptsAround[1]) };
            int lenFig = this.figure.Count;
            int idown = indPtsAround.Min(); int iup = indPtsAround.Max();
            countUp += screw.aplicationPoint.substract(this.figure[iup].toVector()).getNorm();
            countDown += screw.aplicationPoint.substract(this.figure[idown].toVector()).getNorm();
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
