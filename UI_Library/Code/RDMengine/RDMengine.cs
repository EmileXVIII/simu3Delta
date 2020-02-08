using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.Exceptions;
using UI_Library.Code.Operations
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
        public RDMengine(Figure figure)
        {
            this.figure = figure;
        }
        public void applyScrew(Screw screw)
        {
            Point3[] results = this.figure.getPtsAround(screw.aplicationPoint);
            if (results == null) throw new NotInFigureExeption();
            else if(this.figure.IndexOf(screw.aplicationPoint)==-1)
                this.figure.addPoint(screw.aplicationPoint,results[0],results[1]);
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
