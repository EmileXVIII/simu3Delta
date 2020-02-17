using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.Operations;

namespace UI_Library.Code.GestionImage
{
    public class PtUpAndDown
    {
        Figure myFigure;
        CouplePtSort coupleUp;
        CouplePtSort coupleDown;
        public bool downIncrement { get; }
        public PtUpAndDown(Figure figure, int indDep)
        {
            this.myFigure = figure;

            this.downIncrement =
                this.myFigure[Modulo.posModulo((indDep + 1) , this.myFigure.Count)].Y > this.myFigure[Modulo.posModulo((indDep - 1), this.myFigure.Count)].Y
                    ? false
                    : true;
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
            return Modulo.posModulo(((up ? !this.downIncrement : this.downIncrement) ? ind + 1 : ind - 1) , this.myFigure.Count);
        }
        public void setUp(int ind)
        {
            this.coupleUp = new CouplePtSort(this.myFigure[ind], this.myFigure[getIndNext(true, ind)]);
            if (this.coupleUp.max().X == this.coupleUp.min().X) this.setUp(this.getIndNext(true, ind));
        }
        public void setDown(int ind)
        {
            this.coupleDown = new CouplePtSort(this.myFigure[ind], this.myFigure[getIndNext(false, ind)]);
            if (this.coupleDown.max().X == this.coupleDown.min().X) this.setUp(this.getIndNext(false, ind));
        }

    }
}
