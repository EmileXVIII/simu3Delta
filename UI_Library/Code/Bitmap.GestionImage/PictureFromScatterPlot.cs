using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using UI_Library.Code.Operations;

namespace UI_Library.Code.GestionImage
{
    public class PictureFromScatterPlot
    {

        public Figure myFigure { get; set; }
        public System.Drawing.Bitmap Convert(int width, int hight)
        {
            this.myFigure = new Figure();
            this.myFigure.readFile();
            int abscisse = 0;
            int ordonnee = 0;
            System.Drawing.Bitmap myBitmap = new System.Drawing.Bitmap(width, hight);
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
            //myBitmap.Save(@"C:\emile.dir\perso\Ynov\projets\Simu3DeltaC#\myImg.png");
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
            int nbBoucles = 0;
            while (myCouplesUpAndDown.getUp().max().X < X && nbBoucles++ < this.myFigure.Count)
            {
                iUp -= myCouplesUpAndDown.downIncrement ? +1 : -1;
                iUp = Modulo.posModulo(iUp, this.myFigure.Count);
                myCouplesUpAndDown.setUp(iUp);
            }
            if (nbBoucles >= this.myFigure.Count) { return false; }
            if (X == -1 && Y == -1)
            {
                int rrr = 0;
            }
            FtcLine myftcUp = FtcLine.fromPoints(myCouplesUpAndDown.getUp().max().toVector(), myCouplesUpAndDown.getUp().min().toVector());
            if (myftcUp.calcY(X) < Y)
            {
                return false;
            }
            nbBoucles = 0;
            while (myCouplesUpAndDown.getDown().max().X < X && nbBoucles++ < this.myFigure.Count)
            {
                iDown += myCouplesUpAndDown.downIncrement ? +1 : -1;
                iDown = Modulo.posModulo(iDown, this.myFigure.Count);
                myCouplesUpAndDown.setDown(iDown);
            }
            if (nbBoucles >= this.myFigure.Count) { return false; }
            FtcLine myftcDown = FtcLine.fromPoints(myCouplesUpAndDown.getDown().max().toVector(), myCouplesUpAndDown.getDown().min().toVector());
            if (myftcDown.calcY(X) > Y)
            {
                return false;
            }
            return true;
        }
    }


}