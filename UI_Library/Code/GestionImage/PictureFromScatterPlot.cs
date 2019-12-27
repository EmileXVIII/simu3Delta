using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UI_Library.Code.GestionImage
{
    class PictureFromScatterPlot
    {

        Figure myFigure;
        public Bitmap Convert(int width, int hight)
        {
            myFigure = new Figure();
            myFigure.readFile();
            int abscisse = 0;
            int ordonnee = 0;
            Bitmap myBitmap = new Bitmap(width, hight);
            for (abscisse = 0 ; abscisse < width ; abscisse++)
            {
                for (ordonnee = 0 ; ordonnee < hight ; ordonnee++)
                {
                    Color colorPixel;
                    if ( isIn(abscisse, ordonnee) ) {
                        colorPixel = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        colorPixel = Color.FromArgb(1);
                    }
                    myBitmap.SetPixel(abscisse, ordonnee, colorPixel);
                }
            }
            return myBitmap;
        }
        public bool isIn(int X, int Y)
        {
            int minInd = this.myFigure.getIndMinX();
            if (X < this.myFigure[minInd].X)
            {
                return false;
            }
            int iUp = minInd;
            int iDown = minInd;
            PtUpAndDown myCouplesUpAndDown = new PtUpAndDown( this.myFigure, minInd);
                while (myCouplesUpAndDown.getUp().max().X < X && iUp < this.myFigure.Count)
                {
                    iUp -= myCouplesUpAndDown.downIncrement ? +1 : -1;
                    myCouplesUpAndDown.setUp(iUp);
                }
                if (iUp >= this.myFigure.Count) { return false; }
                FtcLine myftcUp = new FtcLine(myCouplesUpAndDown.getUp().max(), myCouplesUpAndDown.getUp().min());
                if (myftcUp.calcY(X) < Y)
                {
                    return false;
                }

                while (myCouplesUpAndDown.getDown().max().X < X && iDown < this.myFigure.Count)
                {
                    iDown += myCouplesUpAndDown.downIncrement ? +1 : -1;
                    myCouplesUpAndDown.setDown(iDown);
                }
                if (iUp >= this.myFigure.Count) { return false; }
                FtcLine myftcDown = new FtcLine(myCouplesUpAndDown.getDown().max(), myCouplesUpAndDown.getDown().min());
                if (myftcDown.calcY(X) > Y)
                {
                    return false;
                }
                return true;
        }
    }


}