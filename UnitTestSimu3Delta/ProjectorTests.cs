using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.Objects;

namespace UnitTestSimu3Delta
{
    [TestClass]
    public class ProjectorTests
    {
        [TestMethod]
        public void testProjection()
        {
            FloatVector testVector = new FloatVector(new float[] { 1, 2, 3 });
            Projector projector = new Projector(Projector.getUsualBase());
            FloatVector newAxeX = new FloatVector(new float[] { 0, 0, 1 });
            projector.constructFinalBase(newAxeX, newAxeX.vectorWhithAllCoordinatesEquals(0));
            Assert.AreEqual(testVector[2] , projector.projectToFinalBase(testVector)[0]);
        }
    }
}
