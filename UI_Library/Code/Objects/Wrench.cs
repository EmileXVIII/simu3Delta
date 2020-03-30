using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Objects
{
    public class Wrench : FloatVector
    {
        public float X { get => this[0]; }
        public float Y { get => this[1]; }
        public float Z { get => this[2]; }
        public Wrench(float X, float Y, float Z) : base(new float[] { X, Y, Z }) { }
    }
}
