using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;

namespace UI_Library.Code.Objects
{
    class Convertor
    {
        private FloatVector toFloatVectorPrivate(Vector<Object> vector)
        {
            float[] coordinates = new float[vector.coordinates.Length];
            for (int i=0;i<vector.coordinates.Length;i++) {
                coordinates[i] = (float)vector.coordinates[i];
            }
            return new FloatVector(coordinates);
        }
        public FloatVector toFloatVector(Vector<float> vector)
        {
            return this.toFloatVectorPrivate(vector);
        }
        public FloatVector toFloatVector(Vector<int> vector)
        {
            return this.toFloatVectorPrivate(vector);
        }
    }
}
