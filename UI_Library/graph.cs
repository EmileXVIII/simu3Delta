﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Library
{
    public partial class graph : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart504;
        public graph(System.Windows.Forms.DataVisualization.Charting.DataPoint[] dataset)
        {
            InitializeComponent();//dataset);
            InitializeGaph(dataset);
        }
    }
}