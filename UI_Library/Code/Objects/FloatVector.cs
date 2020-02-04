﻿using System;
using UI_Library.Code.Operations;

namespace UI_Library.Code.CrashObject.Properties
{
    class FloatVector : Vector<float>
    {
        public FloatVector(float[] coordinates) : base(coordinates) { }

        public FloatVector add(Vector<float> vector)
        {
            Vector<float> newVector = base.Clone();
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] += vector[i];
            }
            return (FloatVector) newVector;
        }

        public FloatVector substract(Vector<float> vector)
        {
            Vector<float> newVector = base.Clone();
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] -= vector[i];
            }
            return (FloatVector) newVector;
        }

        public FloatVector scalarProduct(Vector<float> vector)
        {
            Vector<float> newVector = this.Clone();
            for (int i = 0; i < newVector.length; i++)
            {
                newVector[i] *= vector[i];
            }
            return (FloatVector) newVector;
        }

        public FloatVector vectorialProduct(Vector<float> vector)
        {
            {
                Vector<float> newVector = this.Clone();
                for (int i = 0; i < this.length; i++)
                {
                    newVector[i] *= newVector[Modulo.posModulo(i + 1, this.length)] * vector[Modulo.posModulo(i + 2, this.length)]
                                    - newVector[Modulo.posModulo(i + 2, this.length)] * vector[Modulo.posModulo(i + 1, this.length)];
                }
                return (FloatVector) newVector;
            }
        }
    }
}