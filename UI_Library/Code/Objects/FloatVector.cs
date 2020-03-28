using System;
using System.Collections.Generic;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Operations;

namespace UI_Library.Code.Objects
{
    public class FloatVector : Vector<float>
    {
        public FloatVector(float[] coordinates) : base(coordinates) { }

        public static FloatVector fromVectorOfFloat(Vector<float> vector)
        {
            return new FloatVector(vector.coordinates);
        }
        public FloatVector add(Vector<float> vector)
        {
            Vector<float> newVector = base.Clone();
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] += vector[i];
            }
            return FloatVector.fromVectorOfFloat(newVector);
        }

        public FloatVector vectorWhithAllCoordinatesEquals(float coordinate)
        {
            List<float> list = new List<float>();
            for(int i = 0; i < this.coordinates.Length; i++)
            {
                list.Add(coordinate);
            }
            return new FloatVector(list.ToArray());
        } 

        public FloatVector normalize()
        {
            return this.multiply(this.vectorWhithAllCoordinatesEquals(1 / this.getNorm()));
        }

        public float getNorm()
        {
            double norm = 0;
            foreach(float coordinate in this.coordinates)
            {
                norm += Math.Pow(coordinate, 2);
            }
            return (float)Math.Pow(norm, 0.5);
        }

        public FloatVector substract(Vector<float> vector)
        {
            Vector<float> newVector = base.Clone();
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] -= vector[i];
            }
            return FloatVector.fromVectorOfFloat(newVector);
        }

        public FloatVector multiply(Vector<float> vector)
        {
            Vector<float> newVector = base.Clone();
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] *= vector[i];
            }
            return FloatVector.fromVectorOfFloat(newVector);
        }

        public FloatVector multiplyByScalar(float scalar)
        {
            return this.multiply(this.vectorWhithAllCoordinatesEquals(scalar));
        }

        public float scalarProduct(Vector<float> vector)
        {
            Vector<float> newVector = this.Clone();
            float res = 0;
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] *= vector[i];
                res += newVector[i];
            }
            return res;
        }

        public bool isEquals(Vector<float> vector)
        {
            if (this.coordinates.Length != vector.coordinates.Length) return false;
            int len = this.coordinates.Length;
            for(int i=0;i<len;i++)
            {
                if (this.coordinates[i] != vector.coordinates[i]) return false;
            }
            return true;
        }
        public bool isProportional(Vector<float> vector)
        {
            if (this.coordinates.Length != vector.coordinates.Length) return false;
            int len = this.coordinates.Length;
            int i = 0;
            while (i< len && this.coordinates[i] == 0) i += 1;
            if (i == len) return this.coordinates==vector.coordinates;
            float k = vector.coordinates[i] / this.coordinates[i];
            for (i = i+1; i < len; i++)
            {
                if (vector.coordinates[i] != this.coordinates[i] * k) return false;
            }
            return true;
        }
        public Point3 toPoint3()
        {
            if (this.length != 3) return null;
            return new Point3((long)this[0], (long)this[1], (long)this[2]);
        }
        public FloatVector vectorialProduct(Vector<float> vector)
        {
            {
                Vector<float> newVector = this.Clone();
                for (int i = 0; i < this.length; i++)
                {
                    newVector[i] *= this[Modulo.posModulo(i + 1, this.length)] * vector[Modulo.posModulo(i + 2, this.length)]
                                    - this[Modulo.posModulo(i + 2, this.length)] * vector[Modulo.posModulo(i + 1, this.length)];
                }
                return FloatVector.fromVectorOfFloat(newVector);
            }
        }
    }
}
