using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.CrashObject.Properties;

namespace UI_Library.Code.Objects
{
    class Projector
    {
        FloatVector[] originalBase;
        FloatVector[] finalBase;
        static public FloatVector[] getUsualBase()
        {
            return new FloatVector[] {new FloatVector(new float[] { 1, 0, 0 }), new FloatVector(new float[] { 0, 1, 0 }), new FloatVector(new float[] { 0, 0, 1 })};
        }
        public Projector(FloatVector[] baseOriginal)
        {
            this.originalBase = baseOriginal;
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
        public bool constructFinalBase(FloatVector vector)
        {
            if (vector.Equals(vector.vectorWhithAllCoordinatesEquals(0))) return false;
            List<FloatVector> newBase = new List<FloatVector>();
            int indCordinateVectorNotNull = 0;
            while (vector.coordinates[indCordinateVectorNotNull] == 0)
            {
                indCordinateVectorNotNull++;
            }
            for(int indBaseVector=0; indBaseVector<this.originalBase.Length; indBaseVector++)
            {
                newBase = getNextPartialBaseVector(newBase, this.originalBase[indBaseVector]);
            }
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
                nextPartialBaseVector = nextPartialBaseVector.add(partialBase[i - 1].multiply(vector.vectorWhithAllCoordinatesEquals(lambda)));
                i--;
            }
            partialBase.Add(nextPartialBaseVector);
            return partialBase;
        }
    }
}
