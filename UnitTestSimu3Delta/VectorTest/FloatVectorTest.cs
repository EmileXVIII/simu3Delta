using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.Objects;
namespace UnitTestSimu3Delta.VectorTest
{
    [TestClass]
    public class FloatVectorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            FloatVector vect1 = new FloatVector(new float[] { 1, 2, 3 });
            FloatVector vect2 = new FloatVector(new float[] { 3, 2, 1 });
            Assert.IsTrue(vect1.vectorWhithAllCoordinatesEquals(4).isEquals(vect1.add(vect2)));
        }
        [TestMethod]
        public void TestScalarProduct()
        {
            FloatVector vect1 = new FloatVector(new float[] { 1, 0, 3 });
            FloatVector vect2 = new FloatVector(new float[] { 1, 2, 3 });
            FloatVector vect3 = new FloatVector(new float[] { 1, 0, 0 });
            Assert.AreEqual(10, vect1.scalarProduct(vect2));
            Assert.AreEqual(1, vect3.scalarProduct(vect3));
        }
        [TestMethod]
        public void TestEquals()
        {
            FloatVector vect1 = new FloatVector(new float[] { 1, 0, 3 });
            FloatVector vect2 = new FloatVector(new float[] { 1, 2, 3 });
            FloatVector vect3 = new FloatVector(new float[] { 1, 2, 3 });
            Assert.IsTrue(vect1.isEquals(vect1));
            Assert.IsFalse(vect1.isEquals(vect2));
            Assert.IsTrue(vect2.isEquals(vect3));
        }
    }
}
