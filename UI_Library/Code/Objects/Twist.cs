using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Objects
{
    public class Twist : FloatVector
    {
        public float L { get => this[0]; }
        public float M { get => this[1]; }
        public float N { get => this[2]; }
        public Twist(float L, float M, float N) : base(new float[] { L,M,N }) { }
    }
}
