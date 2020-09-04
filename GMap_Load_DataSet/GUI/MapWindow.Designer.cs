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
            this.buttImport = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.addCategoriesComboBox = new GMap_Load_DataSet.GUI.AddCategoriesComboBox();
            this.listMap = new GMap_Load_DataSet.GUI.ListMapInformation();
            this.SuspendLayout();
            // 
            // buttImport
            // 
            this.buttImport.Location = new System.Drawing.Point(883, 51);
            this.buttImport.Name = "buttImport";
            this.buttImport.Size = new System.Drawing.Size(100, 48);
            this.buttImport.TabIndex = 1;
            this.buttImport.Text = "Import";
            this.buttImport.UseVisualStyleBackColor = true;
            this.buttImport.Click += new System.EventHandler(this.buttImport_Click_1);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(229, 92);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(110, 23);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Visible = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(229, 51);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(110, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Visible = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.Enabled = false;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(651, 136);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 100;
            this.gMap.MinZoom = 0;
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
            this.gMap.Size = new System.Drawing.Size(585, 533);
            this.gMap.TabIndex = 9;
            this.gMap.Zoom = 10D;
            // 
            // addCategoriesComboBox
            // 
            this.addCategoriesComboBox.Location = new System.Drawing.Point(45, 12);
            this.addCategoriesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.addCategoriesComboBox.Name = "addCategoriesComboBox";
            this.addCategoriesComboBox.Size = new System.Drawing.Size(178, 103);
            this.addCategoriesComboBox.TabIndex = 3;
            // 
            // listMap
            // 
            this.listMap.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.listMap.Location = new System.Drawing.Point(25, 136);
            this.listMap.Margin = new System.Windows.Forms.Padding(4);
            this.listMap.Name = "listMap";
            this.listMap.Size = new System.Drawing.Size(597, 533);
            this.listMap.TabIndex = 2;
            this.listMap.Load += new System.EventHandler(this.listMap_Load);
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.addCategoriesComboBox);
            this.Controls.Add(this.listMap);
            this.Controls.Add(this.buttImport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttImport;
        private ListMapInformation listMap;
        private AddCategoriesComboBox addCategoriesComboBox;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnSearch;
        private GMap.NET.WindowsForms.GMapControl gMap;
    }
}