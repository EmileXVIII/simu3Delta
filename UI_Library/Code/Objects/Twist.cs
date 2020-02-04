using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;

namespace UI_Library.Code.Objects
{
    class Twist : FloatVector
    {
        public float L { get => this[0]; }
        public float M { get => this[1]; }
        public float N { get => this[2]; }
        public Twist(float L, float M, float N) : base(new float[] { L,M,N }) { }
    }
}
