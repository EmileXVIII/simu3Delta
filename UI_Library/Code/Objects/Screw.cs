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
        public FloatVector aplicationPoint { get; set;}

        public Screw changeApplicationPoint(FloatVector point)
        {
            if (this.aplicationPoint==null) throw new NoApplicationPointException();
            FloatVector wrench = this.getWrench();
            FloatVector twist = this.getTwist();
            FloatVector oldPoint = this.aplicationPoint;
            FloatVector newPoint = point;
            twist = twist.add(newPoint.substract(oldPoint).vectorialProduct(wrench));
            return Screw.fromWrenchAndTwist(wrench, twist, newPoint);
        }
        public Screw project(Projector projector,bool toFinalBase=true)
        {
            FloatVector screwWrench = this.getWrench();
            FloatVector screwTwist = this.getTwist();
            screwWrench =projector.project(screwWrench,toFinalBase);
            screwTwist = projector.project(screwTwist,toFinalBase);
            Screw screw = Screw.fromWrenchAndTwist(screwWrench, screwTwist, projector.project(this.aplicationPoint,toFinalBase));
            return screw;
        }
        public FloatVector getWrench()
        {
            return new Wrench(this.X, this.Y, this.Z );
        }
        public FloatVector getTwist()
        {
            return new Twist(this.L, this.M, this.N );
        }
        public static Screw fromWrenchAndTwist(FloatVector wrench, FloatVector twist, FloatVector applicationPoint)
        {
            return new Screw(wrench.coordinates.Take(3).Concat(twist.coordinates.Take(3)).ToArray(),applicationPoint);
        }
        public Screw(float[] coordinates, FloatVector applicationPoint) : base(coordinates) 
        {
            this.aplicationPoint = applicationPoint;
        }
    }
}
