using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.GestionImage
{
    class PtUpAndDown
    {
        Figure myFigure;
        CouplePtSort coupleUp;
        CouplePtSort coupleDown;
        public bool downIncrement { get; }
        public PtUpAndDown(Figure figure, int indDep)
        {
            this.myFigure = figure;

            this.downIncrement =
                this.myFigure[(indDep + 1) % this.myFigure.Count].Y > this.myFigure[(indDep - 1) % this.myFigure.Count].Y
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
            this.coupleUp = new CouplePtSort(this.myFigure[ind], this.myFigure[getIndNext(true, ind)]);
        }
        public void setDown(int ind)
        {
            this.coupleDown = new CouplePtSort(this.myFigure[ind], this.myFigure[getIndNext(false, ind)]);
        }

    }
}
