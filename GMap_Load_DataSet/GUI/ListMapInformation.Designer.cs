namespace GMap_Load_DataSet.GUI
{
    partial class ListMapInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridMap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMap
            // 
            this.dataGridMap.AllowUserToAddRows = false;
            this.dataGridMap.AllowUserToDeleteRows = false;
            this.dataGridMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMap.Location = new System.Drawing.Point(0, 0);
            this.dataGridMap.Name = "dataGridMap";
            this.dataGridMap.ReadOnly = true;
            this.dataGridMap.Size = new System.Drawing.Size(564, 321);
            this.dataGridMap.TabIndex = 0;
            this.dataGridMap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMap_CellContentClick);
            // 
            // ListMapInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridMap);
            this.Name = "ListMapInformation";
            this.Size = new System.Drawing.Size(564, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMap;
    }
}
