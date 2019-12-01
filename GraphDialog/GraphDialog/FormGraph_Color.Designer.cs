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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_100m = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chart_Full = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Multi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_Pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_100m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pie)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_100m
            // 
            this.chart_100m.BackColor = System.Drawing.Color.Silver;
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
            this.chart_100m.Location = new System.Drawing.Point(0, 0);
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
            this.chart_100m.Size = new System.Drawing.Size(296, 221);
            this.chart_100m.TabIndex = 5;
            this.chart_100m.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart_Full
            // 
            this.chart_Full.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart_Full.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.Interval = 123D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = 30;
            chartArea2.AxisX.LabelStyle.Format = "{0:0.0}";
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 1234D;
            chartArea2.AxisX.Minimum = -123D;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX.Title = "ChartAreas>Axis> titel [ m ]";
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
            this.chart_Full.Location = new System.Drawing.Point(296, 1);
            this.chart_Full.Margin = new System.Windows.Forms.Padding(9);
            this.chart_Full.Name = "chart_Full";
            this.chart_Full.Padding = new System.Windows.Forms.Padding(5, 5, 10, 10);
            series2.BorderColor = System.Drawing.Color.CornflowerBlue;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.Name = "graphdata";
            this.chart_Full.Series.Add(series2);
            this.chart_Full.Size = new System.Drawing.Size(331, 220);
            this.chart_Full.TabIndex = 5;
            this.chart_Full.Text = "chart1";
            // 
            // chart_Multi
            // 
            this.chart_Multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea3.AlignWithChartArea = "ChartArea2";
            chartArea3.AxisX.Interval = 10D;
            chartArea3.AxisX.LabelStyle.Format = "{0:0.0}";
            chartArea3.AxisX.LabelStyle.Interval = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "[ m ]";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea3.AxisY.LabelStyle.Format = "{0:0.0}";
            chartArea3.AxisY.LabelStyle.Interval = 0D;
            chartArea3.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisY.LineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.AxisY.Maximum = 200D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.ScaleView.Zoomable = false;
            chartArea3.AxisY.ScrollBar.Enabled = false;
            chartArea3.AxisY.Title = "Brightness";
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea3.BorderColor = System.Drawing.Color.Red;
            chartArea3.Name = "ChartArea1";
            chartArea4.AlignWithChartArea = "ChartArea1";
            chartArea4.AxisX.Interval = 1.7D;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.Title = "거리(Area>Axis)";
            chartArea4.AxisY.Title = "Y(um)";
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea4.BorderColor = System.Drawing.Color.Red;
            chartArea4.BorderWidth = 2;
            chartArea4.Name = "ChartArea2";
            this.chart_Multi.ChartAreas.Add(chartArea3);
            this.chart_Multi.ChartAreas.Add(chartArea4);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.Title = "범례제목";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend2";
            legend2.Title = "ㅁㄴㅇㄹ";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DashLine;
            this.chart_Multi.Legends.Add(legend1);
            this.chart_Multi.Legends.Add(legend2);
            this.chart_Multi.Location = new System.Drawing.Point(0, 254);
            this.chart_Multi.Margin = new System.Windows.Forms.Padding(0);
            this.chart_Multi.Name = "chart_Multi";
            series3.BorderColor = System.Drawing.Color.CornflowerBlue;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend2";
            series3.LegendText = "범례Legend 테스트 이건 시리즈편집기에서";
            series3.MarkerBorderColor = System.Drawing.Color.Blue;
            series3.Name = "graphdata";
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Series3";
            series5.YValuesPerPoint = 4;
            this.chart_Multi.Series.Add(series3);
            this.chart_Multi.Series.Add(series4);
            this.chart_Multi.Series.Add(series5);
            this.chart_Multi.Size = new System.Drawing.Size(627, 408);
            this.chart_Multi.TabIndex = 5;
            this.chart_Multi.Text = "chart1";
            title1.DockedToChartArea = "ChartArea1";
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "모양텍스트1(요건Titles 컬렉션에서)";
            title1.ToolTip = "tooltip1";
            title2.DockedToChartArea = "ChartArea2";
            title2.ForeColor = System.Drawing.Color.Lime;
            title2.Name = "Title2";
            title2.Text = "모양텍스트2";
            title2.ToolTip = "tooltip1";
            this.chart_Multi.Titles.Add(title1);
            this.chart_Multi.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(17, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ChartAreas>Axis>LabelStyle>Format={0:0.0}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(305, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ChartAreas>Axis>간격>Interval =1.7";
            // 
            // chart_Pie
            // 
            chartArea5.Area3DStyle.Enable3D = true;
            chartArea5.Area3DStyle.Inclination = 60;
            chartArea5.Area3DStyle.IsRightAngleAxes = false;
            chartArea5.Area3DStyle.WallWidth = 20;
            chartArea5.Name = "ChartArea1";
            this.chart_Pie.ChartAreas.Add(chartArea5);
            legend3.Name = "Legend1";
            this.chart_Pie.Legends.Add(legend3);
            this.chart_Pie.Location = new System.Drawing.Point(658, 46);
            this.chart_Pie.Name = "chart_Pie";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_Pie.Series.Add(series6);
            this.chart_Pie.Size = new System.Drawing.Size(550, 562);
            this.chart_Pie.TabIndex = 7;
            this.chart_Pie.Text = "chart1";
            // 
            // FormGraph_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1228, 662);
            this.Controls.Add(this.chart_Pie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Full);
            this.Controls.Add(this.chart_Multi);
            this.Controls.Add(this.chart_100m);
            this.Name = "FormGraph_Color";
            this.Text = "FormGraph_Color";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGraph_Color_FormClosing);
            this.Load += new System.EventHandler(this.FormGraph_Color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_100m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_100m;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Full;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Multi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Pie;
    }
}