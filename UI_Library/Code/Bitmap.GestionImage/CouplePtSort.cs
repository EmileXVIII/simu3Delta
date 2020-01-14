using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.GestionImage
{
    class CouplePtSort
    {
        Point2 min_priv;
        Point2 max_priv;
        public CouplePtSort(Point2 pt1, Point2 pt2)
        {
            this.min_priv = pt1;
            this.max_priv = pt2;
            if (pt1.X > pt2.X)
            {
                this.min_priv = pt2;
                this.max_priv = pt1;
            }
        }
        public Point2 max()
        {
            return this.max_priv;
        }
        public Point2 min()
        {
            return this.min_priv;
        }
    }
}
