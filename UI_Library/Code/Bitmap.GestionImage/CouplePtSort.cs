using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.GestionImage
{
    class CouplePtSort
    {
        Point3 min_priv;
        Point3 max_priv;
        public CouplePtSort(Point3 pt1, Point3 pt2)
        {
            this.min_priv = pt1;
            this.max_priv = pt2;
            if (pt1.X > pt2.X)
            {
                this.min_priv = pt2;
                this.max_priv = pt1;
            }
        }
        public Point3 max()
        {
            return this.max_priv;
        }
        public Point3 min()
        {
            return this.min_priv;
        }
    }
}
