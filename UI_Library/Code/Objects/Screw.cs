using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Exceptions;

namespace UI_Library.Code.Objects
{
    class Screw:FloatVector //Screw = Torseau
    {
        public float X { get => this[0]; }
        public float Y { get => this[1]; }
        public float Z { get => this[2]; }
        public float L { get => this[3]; }
        public float M { get => this[4]; }
        public float N { get => this[5]; }
        public Point3 aplicationPoint { get; set;}

        private Screw changeApplicationPoint(Point3 point)
        {
            if (this.aplicationPoint==null) throw new NoApplicationPointException();
            FloatVector wrench = this.getWrench();
            FloatVector twist = this.getTwist();
            FloatVector oldPoint = this.aplicationPoint.toVector();
            FloatVector newPoint = point.toVector();
            twist = twist.add(newPoint.substract(oldPoint).vectorialProduct(wrench));
            return this.fromWrenchAndTwist(wrench, twist, point);
        }
        public FloatVector getWrench()
        {
            return new Wrench(this.X, this.Y, this.Z );
        }
        public FloatVector getTwist()
        {
            return new Twist(this.L, this.M, this.N );
        }
        public Screw fromWrenchAndTwist(FloatVector wrench, FloatVector twist, Point3 applicationPoint)
        {
            return new Screw(wrench.coordinates.Take(3).Concat(twist.coordinates.Take(3)).ToArray(),applicationPoint);
        }
        public Screw(float[] coordinates,Point3 applicationPoint) : base(coordinates) 
        {
            this.aplicationPoint = applicationPoint;
        }
    }
}
