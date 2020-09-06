namespace GMap_Load_DataSet.GUI
{
    partial class MapWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttImport = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnCal = new System.Windows.Forms.Button();
            this.labRange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioBar = new System.Windows.Forms.RadioButton();
            this.radioPie = new System.Windows.Forms.RadioButton();
            this.radioPoints = new System.Windows.Forms.RadioButton();
            this.BtnSee = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.radioMar = new System.Windows.Forms.RadioButton();
            this.radioPol = new System.Windows.Forms.RadioButton();
            this.BtnChan = new System.Windows.Forms.Button();
            this.addCategoriesComboBox = new GMap_Load_DataSet.GUI.AddCategoriesComboBox();
            this.listMap = new GMap_Load_DataSet.GUI.ListMapInformation();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pie)).BeginInit();
            this.SuspendLayout();
            // 
            // buttImport
            // 
            this.buttImport.Location = new System.Drawing.Point(40, 631);
            this.buttImport.Name = "buttImport";
            this.buttImport.Size = new System.Drawing.Size(81, 23);
            this.buttImport.TabIndex = 1;
            this.buttImport.Text = "Import";
            this.buttImport.UseVisualStyleBackColor = true;
            this.buttImport.Click += new System.EventHandler(this.buttImport_Click_1);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(291, 559);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(90, 23);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Visible = false;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(291, 559);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(90, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Visible = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Location = new System.Drawing.Point(128, 631);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(75, 23);
            this.BtnAll.TabIndex = 6;
            this.BtnAll.Text = "All Data";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Visible = false;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnCal
            // 
            this.BtnCal.Location = new System.Drawing.Point(291, 559);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(90, 23);
            this.BtnCal.TabIndex = 7;
            this.BtnCal.Text = "Calculate";
            this.BtnCal.UseVisualStyleBackColor = true;
            this.BtnCal.Visible = false;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // labRange
            // 
            this.labRange.AutoSize = true;
            this.labRange.Location = new System.Drawing.Point(38, 597);
            this.labRange.Name = "labRange";
            this.labRange.Size = new System.Drawing.Size(205, 13);
            this.labRange.TabIndex = 8;
            this.labRange.Text = "Valores permitidos entre 50015 y 9040001";
            this.labRange.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido";
            // 
            // Diagram
            // 
            chartArea1.Name = "ChartArea1";
            this.Diagram.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 5;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.MaximumAutoSize = 80F;
            legend1.Name = "Legend1";
            this.Diagram.Legends.Add(legend1);
            this.Diagram.Location = new System.Drawing.Point(749, 417);
            this.Diagram.Name = "Diagram";
            this.Diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.LabelAngle = 90;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Diagram.Series.Add(series1);
            this.Diagram.Size = new System.Drawing.Size(499, 262);
            this.Diagram.TabIndex = 10;
            this.Diagram.Text = "chart1";
            this.Diagram.Visible = false;
            // 
            // radioBar
            // 
            this.radioBar.AutoSize = true;
            this.radioBar.Location = new System.Drawing.Point(689, 417);
            this.radioBar.Name = "radioBar";
            this.radioBar.Size = new System.Drawing.Size(41, 17);
            this.radioBar.TabIndex = 11;
            this.radioBar.TabStop = true;
            this.radioBar.Text = "Bar";
            this.radioBar.UseVisualStyleBackColor = true;
            this.radioBar.Visible = false;
            // 
            // radioPie
            // 
            this.radioPie.AutoSize = true;
            this.radioPie.Location = new System.Drawing.Point(690, 465);
            this.radioPie.Name = "radioPie";
            this.radioPie.Size = new System.Drawing.Size(40, 17);
            this.radioPie.TabIndex = 12;
            this.radioPie.TabStop = true;
            this.radioPie.Text = "Pie";
            this.radioPie.UseVisualStyleBackColor = true;
            this.radioPie.Visible = false;
            // 
            // radioPoints
            // 
            this.radioPoints.AutoSize = true;
            this.radioPoints.Location = new System.Drawing.Point(689, 440);
            this.radioPoints.Name = "radioPoints";
            this.radioPoints.Size = new System.Drawing.Size(54, 17);
            this.radioPoints.TabIndex = 13;
            this.radioPoints.TabStop = true;
            this.radioPoints.Text = "Points";
            this.radioPoints.UseVisualStyleBackColor = true;
            this.radioPoints.Visible = false;
            // 
            // BtnSee
            // 
            this.BtnSee.Location = new System.Drawing.Point(689, 488);
            this.BtnSee.Name = "BtnSee";
            this.BtnSee.Size = new System.Drawing.Size(44, 23);
            this.BtnSee.TabIndex = 14;
            this.BtnSee.Text = "See";
            this.BtnSee.UseVisualStyleBackColor = true;
            this.BtnSee.Visible = false;
            this.BtnSee.Click += new System.EventHandler(this.BtnSee_Click);
            // 
            // Points
            // 
            chartArea2.Name = "ChartArea1";
            this.Points.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Points.Legends.Add(legend2);
            this.Points.Location = new System.Drawing.Point(749, 417);
            this.Points.Name = "Points";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Points.Series.Add(series2);
            this.Points.Size = new System.Drawing.Size(499, 262);
            this.Points.TabIndex = 15;
            this.Points.Text = "chart1";
            this.Points.Visible = false;
            // 
            // Pie
            // 
            chartArea3.Name = "ChartArea1";
            this.Pie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Pie.Legends.Add(legend3);
            this.Pie.Location = new System.Drawing.Point(749, 417);
            this.Pie.Name = "Pie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Pie.Series.Add(series3);
            this.Pie.Size = new System.Drawing.Size(499, 262);
            this.Pie.TabIndex = 16;
            this.Pie.Text = "chart1";
            this.Pie.Visible = false;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(634, 74);
            this.gMap.Margin = new System.Windows.Forms.Padding(2);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(614, 308);
            this.gMap.TabIndex = 17;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // radioMar
            // 
            this.radioMar.AutoSize = true;
            this.radioMar.Location = new System.Drawing.Point(634, 52);
            this.radioMar.Name = "radioMar";
            this.radioMar.Size = new System.Drawing.Size(58, 17);
            this.radioMar.TabIndex = 18;
            this.radioMar.TabStop = true;
            this.radioMar.Text = "Marker";
            this.radioMar.UseVisualStyleBackColor = true;
            this.radioMar.Visible = false;
            // 
            // radioPol
            // 
            this.radioPol.AutoSize = true;
            this.radioPol.Location = new System.Drawing.Point(698, 52);
            this.radioPol.Name = "radioPol";
            this.radioPol.Size = new System.Drawing.Size(63, 17);
            this.radioPol.TabIndex = 19;
            this.radioPol.TabStop = true;
            this.radioPol.Text = "Polygon";
            this.radioPol.UseVisualStyleBackColor = true;
            this.radioPol.Visible = false;
            // 
            // BtnChan
            // 
            this.BtnChan.Location = new System.Drawing.Point(767, 49);
            this.BtnChan.Name = "BtnChan";
            this.BtnChan.Size = new System.Drawing.Size(57, 23);
            this.BtnChan.TabIndex = 20;
            this.BtnChan.Text = "Change";
            this.BtnChan.UseVisualStyleBackColor = true;
            this.BtnChan.Visible = false;
            this.BtnChan.Click += new System.EventHandler(this.BtnChan_Click);
            // 
            // addCategoriesComboBox
            // 
            this.addCategoriesComboBox.Location = new System.Drawing.Point(10, 465);
            this.addCategoriesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.addCategoriesComboBox.Name = "addCategoriesComboBox";
            this.addCategoriesComboBox.Size = new System.Drawing.Size(307, 127);
            this.addCategoriesComboBox.TabIndex = 3;
            // 
            // listMap
            // 
            this.listMap.Location = new System.Drawing.Point(16, 52);
            this.listMap.Margin = new System.Windows.Forms.Padding(4);
            this.listMap.Name = "listMap";
            this.listMap.Size = new System.Drawing.Size(599, 399);
            this.listMap.TabIndex = 2;
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1304, 681);
            this.Controls.Add(this.BtnChan);
            this.Controls.Add(this.radioPol);
            this.Controls.Add(this.radioMar);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.Pie);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.BtnSee);
            this.Controls.Add(this.radioPoints);
            this.Controls.Add(this.radioPie);
            this.Controls.Add(this.radioBar);
            this.Controls.Add(this.Diagram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labRange);
            this.Controls.Add(this.BtnCal);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.addCategoriesComboBox);
            this.Controls.Add(this.listMap);
            this.Controls.Add(this.buttImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapWindow";
            this.Load += new System.EventHandler(this.MapWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttImport;
        private ListMapInformation listMap;
        private AddCategoriesComboBox addCategoriesComboBox;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnCal;
        private System.Windows.Forms.Label labRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Diagram;
        private System.Windows.Forms.RadioButton radioBar;
        private System.Windows.Forms.RadioButton radioPie;
        private System.Windows.Forms.RadioButton radioPoints;
        private System.Windows.Forms.Button BtnSee;
        private System.Windows.Forms.DataVisualization.Charting.Chart Points;
        private System.Windows.Forms.DataVisualization.Charting.Chart Pie;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.RadioButton radioMar;
        private System.Windows.Forms.RadioButton radioPol;
        private System.Windows.Forms.Button BtnChan;
    }
}