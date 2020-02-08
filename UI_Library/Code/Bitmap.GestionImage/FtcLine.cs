using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;

namespace UI_Library.Code.GestionImage
{
    class FtcLine
    {
        // a*X + b =Y
        float a;
        float b;
        public bool isAftn { get; }
        public FtcLine(FloatVector pt1, FloatVector pt2)
        {
            float X1, Y1, X2, Y2;
            X1 = pt1.coordinates[0];
            Y1 = pt1.coordinates[1];
            X2 = pt2.coordinates[0];
            Y2 = pt2.coordinates[1];
            this.isAftn = true;
            if (pt1.coordinates[0] == pt2.coordinates[0])
            {
                this.isAftn = false;
            }
            else
            {
                this.a = (Y1 - Y2) / (X1 - X2);
                this.b = Y2 - a * X2;
            }
        }
        static public FtcLine fromVector(FloatVector vector,Point3 point)
        {
            return new FtcLine(point.toVector(), point.toVector().add(vector));
        }
        public float calcY(float X)
        {
            if (!this.isAftn) return -1;
            return a * X + b;
        }
    }
}
