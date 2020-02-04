using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UI_Library.Code.GestionImage
{
    class Figure : List<Point3>
    {
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
            StreamReader file = new StreamReader(@"C:\emile.dir\perso\Ynov\projets\Simu3DeltaC#\monfichier.txt");
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
    }
}
