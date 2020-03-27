namespace UnitTestSimu3Delta
{
    partial class graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeGaph(System.Windows.Forms.DataVisualization.Charting.DataPoint[] dataset)
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea504 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend504 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series504 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart504 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart504)).BeginInit();
            this.SuspendLayout();
            // 
            // chart504
            // 
            chartArea504.Name = "ChartArea504";
            this.chart504.ChartAreas.Add(chartArea504);
            legend504.Name = "Legend504";
            this.chart504.Legends.Add(legend504);
            this.chart504.Location = new System.Drawing.Point(0, 0);
            this.chart504.Name = "chart504";
            series504.ChartArea = "ChartArea504";
            series504.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series504.Legend = "Legend504";
            series504.Name = "Courbe de déformation";
            for(int i = 0; i < dataset.Length; i++)
            {
                series504.Points.Add(dataset[i]);
            }
            this.chart504.Series.Add(series504);
            this.chart504.Size = new System.Drawing.Size(1281, 649);
            this.chart504.TabIndex = 0;
            this.chart504.Text = "chart504";
            // 
            // graph
            // 
            this.Controls.Add(this.chart504);
            this.Name = "graph";
            ((System.ComponentModel.ISupportInitialize)(this.chart504)).EndInit();
            this.ResumeLayout(false);

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()//
        {
            this.SuspendLayout();
            // 
            // graph
            // 
            this.ClientSize = new System.Drawing.Size(1293, 684);
            this.Name = "graph";
            this.ResumeLayout(false);

        }

        #endregion
    }
}