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

namespace UI_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            new PictureFromScatterPlot().Convert(5000,5000);
            createObject createObject = new createObject();
            createObject.Show();
        }

        private void subfileSubnewObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createObject createObject = new createObject();
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
    }
}
