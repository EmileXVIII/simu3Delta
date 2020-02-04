using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.Exceptions;

namespace UI_Library.Code.RDMengine
{
    class RDMengine
    {
        /*
         * Hypostesis
         *      no bonce effect
         *      problem can be resolve in static
         */
        Figure figureUp=null;
        Figure figureDown = null;
        Figure figure { get; set; }
        public RDMengine(Figure figure)
        {
            this.figure = figure;
        }
        public void applyScrew(Screw screw)
        {
            if (!this.checkIfPtInFigure(screw.aplicationPoint))
            {
                throw new NotInFigureExeption();
            }                
        }
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
        private bool getFarestPlan (Screw screw)
        {
            throw new NotImplementedException();
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
