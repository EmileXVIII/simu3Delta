using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.GestionImage
{
    class CouplePtSort
    {
        Point min_priv;
        Point max_priv;
        public CouplePtSort(Point pt1, Point pt2)
        {
            this.min_priv = pt1;
            this.max_priv = pt2;
            if (pt1.X > pt2.X)
            {
                this.min_priv = pt2;
                this.max_priv = pt1;
            }
        }
        public Point max()
        {
            return this.max_priv;
        }
        public Point min()
        {
            return this.min_priv;
        }
    }
}
