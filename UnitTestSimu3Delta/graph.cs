using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestSimu3Delta
{
    public partial class graph : Form
    {
        public graph(System.Windows.Forms.DataVisualization.Charting.DataPoint[] dataset)
        {
            InitializeComponent(dataset);
        }
    }
}
