using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Objects
{
    public class ListWhithPermutations<T>:List<T>
    {
        public void cyclicPermutation(bool toRight=true,uint n=1)
        {
            int maxInd = this.Count-1;
            if (maxInd < 1) return;
            if(toRight)
            {
                T k = this[maxInd];
                this.RemoveAt(maxInd);
                this.Insert(0, k);
            }
            else
            {
                T k = this[0];
                this.RemoveAt(0);
                this.Add(k);
            }
            if (n > 1) cyclicPermutation(toRight, n - 1);
        }
    }
}
