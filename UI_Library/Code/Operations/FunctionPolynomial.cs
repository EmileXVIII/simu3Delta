using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Operations
{
    class FunctionPolynomial
    {
        float[] listFactors;
        public FunctionPolynomial(float[] listFactors)
        {
            this.listFactors = listFactors;
        }
        public float calcY(float X)
        {
            OperationFile<float> operationFile = OperationFile<float>.newOperationFileSum();
            for (int i = 0; i < this.listFactors.Length; i++)
            {
                operationFile.Add(this.listFactors[i] * (float)Math.Pow(X, i));
            }
            return operationFile.doOpp();
        }
    }
}
