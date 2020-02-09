using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;
using UI_Library.Code.GestionImage;

namespace UI_Library.Code.Objects
{
    class Projector
    {
        FloatVector[] originalBase;
        FloatVector[] finalBase;
        FloatVector originalOrigin;
        FloatVector finalOrigin;
        static public FloatVector[] getUsualBase()
        {
            return new FloatVector[] {new FloatVector(new float[] { 1, 0, 0 }), new FloatVector(new float[] { 0, 1, 0 }), new FloatVector(new float[] { 0, 0, 1 })};
        }
        public Projector(FloatVector[] baseOriginal, FloatVector originalOrigin=null)
        {
            this.originalBase = baseOriginal;
            if (originalOrigin == null) this.originalOrigin = baseOriginal[0].vectorWhithAllCoordinatesEquals(0);
            else this.originalOrigin = originalOrigin;
        }
        public bool setFinalBase(FloatVector[] finalBase)
        {
            FloatVector nullVector = new FloatVector(new float[] { 0, 0, 0 });
            for (int i=0;i<finalBase.Length;i++)
            {
                if (finalBase[i].isEquals(nullVector)) return false;
                for (int j = i+1;j < finalBase.Length; j++)
                {
                    if (finalBase[i].scalarProduct(finalBase[j]) != 0) return false;
                }
            }
            this.finalBase = finalBase;
            return true;
        }
        public bool constructFinalBase(FloatVector axeX,FloatVector origin)
        {
            if (axeX.Equals(axeX.vectorWhithAllCoordinatesEquals(0))&&axeX.length!=origin.length) return false;
            this.finalOrigin = origin;
            List<FloatVector> newBase = new List<FloatVector>();
            int indCordinateVectorNotNull = 0;
            while (axeX.coordinates[indCordinateVectorNotNull] == 0)
            {
                indCordinateVectorNotNull++;
            }
            newBase = getNextPartialBaseVector(newBase, axeX);
            for(int indBaseVector=0; indBaseVector<this.originalBase.Length; indBaseVector++)
            {
                if (indBaseVector!=indCordinateVectorNotNull)
                    newBase = getNextPartialBaseVector(newBase, this.originalBase[indBaseVector]);
            }
            for(int i = 0; i < newBase.Count; i++)
            {
                newBase[i] = newBase[i].normalize();
            }
            this.finalBase = newBase.ToArray();
            return true;
        }
        // B.(A + lambda * B)=0
        private float lambdaForCscalaireAisNull(FloatVector A, FloatVector B)
        {
            A = A.multiply(B);
            B = B.multiply(B);
            float lambda = -A.coordinates.Sum() / B.coordinates.Sum();
            return lambda;
        }
        private List<FloatVector> getNextPartialBaseVector(List<FloatVector> partialBase,FloatVector vector)
        {
            int lenVector = vector.coordinates.Length;
            int i = partialBase.Count;
            FloatVector nextPartialBaseVector = (FloatVector)vector.Clone();
            while (i < 0)
            {
                float lambda = this.lambdaForCscalaireAisNull(nextPartialBaseVector, partialBase[i - 1]);
                nextPartialBaseVector = nextPartialBaseVector.add(partialBase[i - 1].multiplyByScalar(lambda));
                i--;
            }
            partialBase.Add(nextPartialBaseVector);
            return partialBase;
        }
        public FloatVector project(FloatVector vector,bool toFinalBase = true)
        {
            return toFinalBase ? this.projectToFinalBase(vector) : this.projectToOriginalBase(vector);
        }
        public FloatVector projectToOriginalBase(FloatVector vector)
        {
            if (this.finalBase == null) return null;
            FloatVector result = vector.vectorWhithAllCoordinatesEquals(0);
            result.add(this.finalOrigin);
            for(int coordinate = 0; coordinate < vector.coordinates.Length; coordinate++)
            {
                for(int i=0; i < this.finalBase.Length; i++)
                {
                    result.add(this.originalBase[i].multiplyByScalar(
                        vector.coordinates[coordinate] * this.finalBase[coordinate].scalarProduct(this.originalBase[i]))
                    );
                }
                
            }
            result.substract(this.originalOrigin);
            return result;

        }
        public FloatVector projectToFinalBase(FloatVector vector)
        {
            if (this.finalBase == null) return null;
            FloatVector result = vector.vectorWhithAllCoordinatesEquals(0);
            result.add(this.originalOrigin);
            for (int coordinate = 0; coordinate < vector.coordinates.Length; coordinate++)
            {
                for (int i = 0; i < this.finalBase.Length; i++)
                {
                    result.add(this.finalBase[i].multiplyByScalar(
                        vector.coordinates[coordinate] * this.originalBase[coordinate].scalarProduct(this.finalBase[i]))
                    );
                }

            }
            result.substract(this.finalOrigin);
            return result;

        }
    }
}
