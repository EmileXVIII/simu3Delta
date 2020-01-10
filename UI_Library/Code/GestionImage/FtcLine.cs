using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.GestionImage
{
    class FtcLine
    {
        // a*X + b =Y
        float a;
        float b;
        public bool isAftn { get; }
        public FtcLine(Point pt1, Point pt2)
        {
            this.isAftn = true;
            if (pt1.X == pt2.X)
            {
                this.isAftn = false;
            }
            else
            {
                this.a = (float)(pt1.Y - pt2.Y) / (float)(pt1.X - pt2.X);
                this.b = pt2.Y - a * pt2.X;
            }
        }
        public float calcY(float X)
        {
            if (!this.isAftn) return -1;
            return a * X + b;
        }
    }
}
