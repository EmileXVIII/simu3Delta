using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library.Code.GestionImage;
using UI_Library.Code.OpenGl.GestionImage;
using System.Drawing.Printing;
using UI_Library.Code.RDMengine;
using System.Windows.Forms.DataVisualization.Charting;
using UI_Library.Code.Objects;
using UI_Library.Code.Inputs;
using UI_Library.Code.Adaptator;

namespace UI_Library
{
    public partial class Form1 : Form
    {

        public async void show(Figure figure)
        {
            DataPoint[] dataset = new DataPoint[figure.Count];
            for (int indPoint = 0; indPoint < figure.Count; indPoint++)
            {
                Point3 point = figure[indPoint];
                dataset[indPoint] = new DataPoint(point.X, point.Y);
            }
            new graph(dataset).Show();
        }
            private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"C:\emile.dir\perso\Ynov\projets\Simu3DeltaC#\myImg.png");
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            string nameFile = textBoxFileName.Text;
            Bitmap myImg = new PictureFromScatterPlot().Convert(5000,5000);
            try
            {
                myImg.Save(Application.StartupPath + @"\" + nameFile);
            }
            catch
            {
                throw new Exception("Can't save , try to rename the file");
            }
            Form frm = new Form();
            frm.Show();
            PictureBox PictureBox2 = new PictureBox();
            PictureBox2.Image = Image.FromFile(Application.StartupPath+@"\"+nameFile);
            PictureBox2.Show();
            frm.Controls.Add(PictureBox2);
            PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            /*
            Form3 form3 = new Form3();
            form3.Show();
            */
            /*
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();
            */
        }

        private void subfileSubnewObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createObject createObject = new createObject(textBoxFileName.Text);
            createObject.Show();
        }

        private void subfileSubopenObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlertOpen alertOpen = new AlertOpen();
            alertOpen.Show();
        }

        private void subfileSubopenSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlertOpen alertOpen = new AlertOpen();
            alertOpen.Show();
        }

        private void subrunSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chargement chargement = new Chargement();
            chargement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FloatInput imput = new FloatInput((TextBoxImputable)this.textBoxTest1);
            float strenght = imput.getValue();
            if(imput.getConvertionStatus())
            {
                Figure figure = new Figure();
                figure.Add(new Point2(0, 0));
                figure.Add(new Point2(2000, 0));
                RDMengine engine = new RDMengine(figure, 1, 1);
                Figure results = engine.calculateDeformation(figure[0], figure[1], null, new Screw(new float[] { 0, strenght, 0, 0, 0, 0 }, figure[0].toVector()), false);
                show(results);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FloatInput imput = new FloatInput((TextBoxImputable)this.textBoxTest2);
            float strenght = imput.getValue();
            if (imput.getConvertionStatus())
            {
                Figure figure = new Figure();
                figure.Add(new Point2(0, 0));
                figure.Add(new Point2(2000, 0));
                figure.Add(new Point2(2000, 2000));
                figure.Add(new Point2(0, 2000));
                RDMengine engine = new RDMengine(figure, 1, 1);
                Screw screw = new Screw(new float[] { 0, strenght, 0, 0, 0, 0 }, new Point2(0, 1000).toVector());
                /*Assert.AreEqual(
                     engine.getDeformationFunctionY(2000, 1000, 0, (float)(-5.0 * Math.Pow(10, -8)), true, 2).calcY(1000),
                     engine.getDeformationFunctionY(2000, 1000, 0, (float)(-5.0 * Math.Pow(10, -8)), false, 2).calcY(1000)
                     );*/
                Figure results1 = engine.calculateDeformation(figure[0], figure[1], screw, null, true);
                show(results1);
            }
        }
    }
}
