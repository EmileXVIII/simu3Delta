using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UI_Library.Code.GestionImage
{
    class Figure : List<Point>
    {
        public int getIndMinX()
        {
            float minX = this[0].X;
            int i = 0;
            int ind = 0;
            while (i++ < this.Count -1)
            {
                if (this[i].X < minX)
                {
                    minX = this[i].X;
                    ind = i;
                }
            }
            return ind;
        } 
    }
    class PictureFromScatterPlot
    {
        Figure myFigure;
        /*
        public Bitmap Convert()
        {
            int abscisse = 0;
            int ordonnee = 0;

        }
        */
        public bool isIn(int X, int Y)
        {
            int minInd = myFigure.getIndMinX();
            if (X < myFigure[minInd].X)
            {
                return false;
            }
            int iUp = minInd;
            int iDown = minInd;
            PtUpAndDown myCouplesUpAndDown = new PtUpAndDown(myFigure, minInd);
                while (myCouplesUpAndDown.getUp().max().X < X && iUp < myFigure.Count)
                {
                    iUp -= myCouplesUpAndDown.downIncrement ? +1 : -1;
                    myCouplesUpAndDown.setUp(iUp);
                }
                if (iUp >= myFigure.Count) { return false; }
                FtcLine myftcUp = new FtcLine(myCouplesUpAndDown.getUp().max(), myCouplesUpAndDown.getUp().min());
                if (myftcUp.calcY(X) < Y)
                {
                    return false;
                }

                while (myCouplesUpAndDown.getDown().max().X < X && iDown < myFigure.Count)
                {
                    iDown += myCouplesUpAndDown.downIncrement ? +1 : -1;
                    myCouplesUpAndDown.setDown(iDown);
                }
                if (iUp >= myFigure.Count) { return false; }
                FtcLine myftcDown = new FtcLine(myCouplesUpAndDown.getDown().max(), myCouplesUpAndDown.getDown().min());
                if (myftcDown.calcY(X) > Y)
                {
                    return false;
                }
                return true;
        }
    }
    class FtcLine {
        // a*X + b =Y
        float a;
        float b;
        bool isAftn = true;
        public FtcLine(Point pt1, Point pt2)
        {
            if (pt1.X == pt2.X) { 
                isAftn = false; 
            }
            else
            {
                this.a = (pt1.Y - pt2.Y) / (pt1.X - pt2.X);
                this.b = pt2.Y - a * pt2.X;
            }
        }
        public float calcY(float X)
        {
            return a * X + b;
        }
    }
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class CouplePtSort{
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
    class PtUpAndDown
    {
        List<Point> myFigure ;
        CouplePtSort coupleUp ;
        CouplePtSort coupleDown ;
        public bool downIncrement { get; }
        public PtUpAndDown(Figure myFigure, int indDep)
        {
            this.myFigure = myFigure;

            this.downIncrement =
                myFigure[(indDep + 1) % myFigure.Count].Y > myFigure[(indDep - 1) % myFigure.Count].Y
                    ? true
                    : false;
            this.setUp(indDep);
            this.setDown(indDep);
        }
        public CouplePtSort getUp()
        {
            return this.coupleUp;
        }
        public CouplePtSort getDown()
        {
            return this.coupleDown;
        }
        private int getIndNext(bool up, int ind)
        {
            return ((up ? !this.downIncrement : this.downIncrement) ? ind + 1 : ind - 1) % this.myFigure.Count;
        }
        public void setUp(int ind)
        {
            this.coupleUp = new CouplePtSort(myFigure[ind], myFigure[getIndNext(true, ind)]);
        }
        public void setDown(int ind)
        {
            this.coupleUp = new CouplePtSort(myFigure[ind], myFigure[getIndNext(false, ind)]);
        }

    }

}
