using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.Objects;

namespace UI_Library.Code.GestionImage
{
    public class Point3
    {
        public long X { get; }
        public long Y { get; }
        public long Z { get; }
        public Point3(long X, long Y, long Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public FloatVector toVector()
        {
            return new FloatVector(new float[] { this.X, this.Y, this.Z });
        }
    }
    public class Point2 : Point3
    {
        public Point2(long X, long Y) : base(X,Y,0)
        {
        }
    }
}
