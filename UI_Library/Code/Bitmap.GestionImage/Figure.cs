using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UI_Library.Code.Exceptions;
using UI_Library.Code.Operations;

namespace UI_Library.Code.GestionImage
{
    public class Figure : List<Point3>
    {
        public Figure slice(int indStart, int indEnd=-1)
        {
            if (indEnd == -1) indEnd = this.Count;
            Figure slicedFigure = new Figure();
            int i = indStart;
            while (i < indEnd)
            {
                slicedFigure.Add(this[i]);
                i++;
            }
            return slicedFigure;
        }
        public int getIndMinX()
        {
            float minX = this[0].X;
            int i = 0;
            int ind = 0;
            while (i++ < this.Count - 1)
            {
                if (this[i].X < minX)
                {
                    minX = this[i].X;
                    ind = i;
                }
            }
            return ind;
        }
        public void readFile()
        {
            StreamReader file = new StreamReader(@"C:/emile.dir/perso/Ynov/projets/Simu3DeltaC#/monfichier.txt");
            string line = file.ReadLine(); ;
            while (line != null)
            {
                string[] lineAtSplit = line.Split(',');
                Point3 aPoint = new Point2(Convert.ToInt16(lineAtSplit[0]), Convert.ToInt16(lineAtSplit[1]));
                this.Add(aPoint);
                line = file.ReadLine();
            }
            file.Close();
            float X = this[0].X;
            int i = 0;
            bool isAverticalLigne = true;
            while (isAverticalLigne && i<this.Count)
            {
                if (this[i].X != X) isAverticalLigne = false;
                i++;
            }
            if (isAverticalLigne) throw new ArgumentException("Vertical lines as object are not supported");
        }
        public void addPoint(Point3 pointToAdd, Point3 prevPoint, Point3 nextPoint)
        {
            int i = 0;
            int lenFigure = this.Count;
            while(i+1<lenFigure && ((this[i]!=prevPoint && this[i+1] != nextPoint)|| (this[i] != nextPoint && this[i + 1] != prevPoint))) { i++; }
            if (i + 1 == lenFigure) throw new NotInFigureExeption();
            else
            {
                this.Insert(i + 1, pointToAdd);
            }
        }
        //return null if ptInFigure not in figure
        public Point3[] getPtsAround(Point3 ptInFigure,uint precision=1)
        {
            Point3 ptPrev, ptNext;
            int i = -1;
            FtcLine ftcLine;
            float calcY;
            do
            {
                i++;
                ptPrev = this[i];
                ptNext = this[Modulo.posModulo(i + 1, this.Count)];
                ftcLine = FtcLine.fromPoints(ptPrev.toVector(), ptNext.toVector());
                calcY = ftcLine.calcY(ptInFigure.X);
            }
            while (i + 1 < this.Count && (calcY > ptInFigure.Y + precision || calcY < ptInFigure.Y - precision));
            if (i + 1 == this.Count) return null;
            return new Point3[] {ptPrev,ptNext};
        }
    }
}
