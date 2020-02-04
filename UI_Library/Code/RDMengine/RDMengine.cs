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
            throw new NotImplementedException();
        }
        private bool getFarestPlan (Screw screw)
        {
            throw new NotImplementedException();
        }
        private Figure resize(bool up)
        {
            Point3 centerOfGravity = this.getCenterOfGravity();
            List<Point3> newFigure = new List<Point3>();
            foreach (Point3 point in this.figure)
            {
                float X, Y, Z;
                X = this.incrementIf(this.isHigher(point.X, centerOfGravity.X), point.X);
                Y = this.incrementIf(this.isHigher(point.Y, centerOfGravity.Y), point.Y);
                Z = this.incrementIf(this.isHigher(point.Z, centerOfGravity.Z), point.Z);
                newFigure.Add(new Point3((int)X, (int)Y, (int)Z));
            }
            return (Figure)newFigure;
        }
        private Point3 getCenterOfGravity()
        {
            throw new NotImplementedException();
        }
        private bool isHigher(float X,float Y)
        {
            return X > Y;
        }
        private float incrementIf(bool condition,float toIncrement)
        {
            return condition ? toIncrement + 1 : toIncrement - 1;
        }

    }
}
