using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.RDMengine;
namespace UnitTestSimu3Delta.DeformationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Figure figure = new Figure();
            figure.Add(new Point2(0, 0));
            figure.Add(new Point2(2000, 0));
            RDMengine engine = new RDMengine(figure,1,1);
            Figure results = engine.calculateDeformation(figure[0], figure[1], null, new Screw(new float[] { 0, -500, 0, 0, 0, 0 },figure[0].toVector()), false);
        }
    }
}
