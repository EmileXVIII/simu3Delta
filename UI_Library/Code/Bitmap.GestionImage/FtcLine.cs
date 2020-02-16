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
        static public FtcLine fromPoints(FloatVector pt1, FloatVector pt2)
        {
            float X1, Y1, X2, Y2;
            X1 = pt1.coordinates[0];
            Y1 = pt1.coordinates[1];
            X2 = pt2.coordinates[0];
            Y2 = pt2.coordinates[1];
            if (pt1.coordinates[0] == pt2.coordinates[0])
            {
                return new FtcLine(0, 0, true);
            }
            else
            {
                float a = (Y1 - Y2) / (X1 - X2);
                float b = Y2 - a * X2;
                return new FtcLine(a, b);
            }
        }
        static public FtcLine fromVector(FloatVector vector,Point3 point)
        {
            return FtcLine.fromPoints(point.toVector(), point.toVector().add(vector));
        }
        public FtcLine(float a, float b,bool error=false)
        {
            this.a = a;
            this.b = b;
            this.isAftn = !error;
        }
        public float calcY(float X)
        {
            if (!this.isAftn) return -1;
            return a * X + b;
        }
    }
}
