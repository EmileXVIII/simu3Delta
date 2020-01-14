using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;
using UI_Library.Code.GestionImage;

namespace UI_Library.Code.Objects
{
    class Torsor:FloatVector
    {
        public Point3 AplicationPoint { get; ,set =>{ } }
        public Torsor(float[] coordinates) : base(coordinates) { }
    }
}
