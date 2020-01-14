using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.GestionImage
{
    class Point3
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public Point3(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
    class Point2 : Point3
    {
        public Point2(int X, int Y) : base(X,Y,0)
        {
        }
    }
}
