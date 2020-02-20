using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UI_Library.Code.Operations
{
    class OperationFile<T>
    {
        public List<T> operationFile;

        OppFunction oppFunction;
        public static OperationFile<float> newOperationFileSum()
        {
            OperationFile<float> operationFile = new OperationFile<float>();
            operationFile.changeOppFunction((ref List<float> aOperationFile) => OperationFile<float>.oppFloat(ref aOperationFile, '+'));
            return operationFile;
        }
        public void Add(T val) { this.operationFile.Add(val); }
        public void Clear() { this.operationFile.Clear(); }
        public void Pop() { this.operationFile.RemoveAt(this.operationFile.Count - 1); }
        public OperationFile()
        {
            this.operationFile = new List<T>();
        }
        public void changeOppFunction(OppFunction oppFunction)
        {
            this.oppFunction = oppFunction;
        }
        public delegate T OppFunction(ref List<T> operationFile);
        public T doOpp()
        {
            return this.oppFunction(ref this.operationFile);
        }
        public delegate float Operation(float X,float Y);
        private static float oppFloat(ref List<float> list,char opp)
        {
            Operation opperator;
            switch (opp)
            {
                case '+':
                    opperator = new Operation((X, Y) => X + Y);
                    break;
                case '*':
                    opperator = new Operation((X, Y) => X + Y);
                    break;
                default:
                    throw new Exception("Operator " + opp + " Not Implemented");
            }
            float result = 0;
            float[] listSorted = OperationFile<T>.sortedByAbsolutes(list);
            foreach(float element in listSorted)
            {
                result = opperator(result, element);
            }
            return result;
        }
        private static float[] sortedByAbsolutes(List<float> list)
        {
            float[] result= new float[list.Count];
            List<float> listAbsolute1 = new List<float>();
            List<float> listAbsolute2 = new List<float>();
            List<int> listInds = new List<int>();
            foreach(float element in list){
                float absoluteElement = Math.Abs(element);
                listAbsolute1.Add(absoluteElement);
                listAbsolute2.Add(absoluteElement);

            }
            listAbsolute2.Sort();
            foreach (float element in listAbsolute2)
            {
                listInds.Add(listAbsolute1.IndexOf(element));
            }
            for(int i = 0; i < list.Count; i++)
            {
                int indList = listInds[i];
                result[i] = list[indList];
            }
            return result;
        }
    }
}

