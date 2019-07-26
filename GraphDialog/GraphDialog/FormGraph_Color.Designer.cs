namespace GraphDialog
{
    partial class FormGraph_Color
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_100m = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chart_Full = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_100m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Full)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_100m
            // 
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.LabelStyle.Format = "{0:0.0}";
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "[ m ]";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.LabelStyle.Format = "{0:0.0}";
            chartArea1.AxisY.LabelStyle.Interval = 0D;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.AxisY.Maximum = 200D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.ScaleView.Zoomable = false;
            chartArea1.AxisY.ScrollBar.Enabled = false;
            chartArea1.AxisY.Title = "Brightness";
            chartArea1.Name = "ChartArea1";
            this.chart_100m.ChartAreas.Add(chartArea1);
            this.chart_100m.Location = new System.Drawing.Point(8, 8);
            this.chart_100m.Margin = new System.Windows.Forms.Padding(0);
            this.chart_100m.Name = "chart_100m";
            series1.BorderColor = System.Drawing.Color.CornflowerBlue;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.MarkerBorderColor = System.Drawing.Color.Blue;
            series1.Name = "graphdata";
            this.chart_100m.Series.Add(series1);
            this.chart_100m.Size = new System.Drawing.Size(638, 221);
            this.chart_100m.TabIndex = 5;
            this.chart_100m.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart_Full
            // 
            chartArea2.AxisX.Interval = 1000D;
            chartArea2.AxisX.LabelStyle.Format = "{0:0.0}";
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 100000D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "[ m ]";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.LabelStyle.Format = "{0:0.0}";
            chartArea2.AxisY.LabelStyle.Interval = 0D;
            chartArea2.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisY.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.AxisY.Maximum = 200D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.ScaleView.Zoomable = false;
            chartArea2.AxisY.ScrollBar.Enabled = false;
            chartArea2.AxisY.Title = "Brightness";
            chartArea2.Name = "ChartArea1";
            this.chart_Full.ChartAreas.Add(chartArea2);
            this.chart_Full.Location = new System.Drawing.Point(8, 247);
            this.chart_Full.Margin = new System.Windows.Forms.Padding(0);
            this.chart_Full.Name = "chart_Full";
            series2.BorderColor = System.Drawing.Color.CornflowerBlue;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.Name = "graphdata";
            this.chart_Full.Series.Add(series2);
            this.chart_Full.Size = new System.Drawing.Size(638, 309);
            this.chart_Full.TabIndex = 5;
            this.chart_Full.Text = "chart1";
            // 
            // FormGraph_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 565);
            this.Controls.Add(this.chart_Full);
            this.Controls.Add(this.chart_100m);
            this.Name = "FormGraph_Color";
            this.Text = "FormGraph_Color";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGraph_Color_FormClosing);
            this.Load += new System.EventHandler(this.FormGraph_Color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_100m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Full)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_100m;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Full;
    }
}