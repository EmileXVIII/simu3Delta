using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.RDMengine;
using System.Windows.Forms;

namespace UnitTestSimu3Delta.DeformationTests
{
    [TestClass]
    public class DeformationTest1
    {
        public async void show(Figure figure)
        {
            DataPoint[] dataset = new DataPoint[figure.Count];
            for (int indPoint = 0; indPoint < figure.Count; indPoint++)
            {
                Point3 point = figure[indPoint];
                dataset[indPoint] = new DataPoint(point.X, point.Y);
            }
            Application.Run(new graph(dataset));
        }
        [TestMethod]
        public void TestMethod1()
        {
            Figure figure = new Figure();
            figure.Add(new Point2(0, 0));
            figure.Add(new Point2(2000, 0));
            RDMengine engine = new RDMengine(figure,1,1);
            Figure results = engine.calculateDeformation(figure[0], figure[1], null, new Screw(new float[] { 0, (float)(-5.0*Math.Pow(10,-8)), 0, 0, 0, 0 },figure[0].toVector()), false);
            Assert.AreEqual(0, results[results.Count - 1].Y);
            show(results);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Figure figure = new Figure();
            figure.Add(new Point2(0, 0));
            figure.Add(new Point2(2000, 0));
            figure.Add(new Point2(2000, 2000));
            figure.Add(new Point2(0, 2000));
            RDMengine engine = new RDMengine(figure, 1, 1);
            Screw screw = new Screw(new float[] { 0, (float)(-5.0 * Math.Pow(10, -8)), 0, 0, 0, 0 }, new Point2(0, 1000).toVector());
            Figure results1 = engine.calculateDeformation(figure[0], figure[1], screw ,null , true);
            show(results1);
            screw = screw.changeApplicationPoint(figure[1].toVector());
            Figure results2 = engine.calculateDeformation(figure[0], figure[1], null, screw, true);
        }
    }
}
