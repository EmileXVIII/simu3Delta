using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.GestionImage;
using UI_Library.Code.Objects;
using UI_Library.Code.RDMengine;

namespace UI_Library.Code.Tests
{
    class Test
    {
        public void test1()
        {
            Figure figureTest = new Figure();
            figureTest.readFile();
            Screw screwTest = new Screw(new float[] { 500, 500, 0, 0, 0, 0 }, figureTest[0].toVector());
            RDMengine engineTest = new RDMengine(figureTest,500,500);
            engineTest.applyScrew(screwTest);
            Figure figureResult = engineTest.figure;
        }
    }
}
