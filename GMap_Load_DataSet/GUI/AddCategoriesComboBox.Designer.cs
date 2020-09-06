namespace GMap_Load_DataSet.GUI
{
    partial class AddCategoriesComboBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.PossibleValuesCB = new System.Windows.Forms.ComboBox();
            this.labCat = new System.Windows.Forms.Label();
            this.labDep = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.labMin = new System.Windows.Forms.Label();
            this.labMax = new System.Windows.Forms.Label();
            this.textTown = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(26, 41);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(232, 21);
            this.CategoriesCB.TabIndex = 0;
            this.CategoriesCB.Visible = false;
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // PossibleValuesCB
            // 
            this.PossibleValuesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PossibleValuesCB.FormattingEnabled = true;
            this.PossibleValuesCB.Location = new System.Drawing.Point(26, 94);
            this.PossibleValuesCB.Name = "PossibleValuesCB";
            this.PossibleValuesCB.Size = new System.Drawing.Size(232, 21);
            this.PossibleValuesCB.TabIndex = 1;
            this.PossibleValuesCB.Visible = false;
            // 
            // labCat
            // 
            this.labCat.AutoSize = true;
            this.labCat.Location = new System.Drawing.Point(23, 16);
            this.labCat.Name = "labCat";
            this.labCat.Size = new System.Drawing.Size(57, 13);
            this.labCat.TabIndex = 2;
            this.labCat.Text = "Categories";
            this.labCat.Visible = false;
            // 
            // labDep
            // 
            this.labDep.AutoSize = true;
            this.labDep.Location = new System.Drawing.Point(23, 78);
            this.labDep.Name = "labDep";
            this.labDep.Size = new System.Drawing.Size(73, 13);
            this.labDep.TabIndex = 3;
            this.labDep.Text = "Departaments";
            this.labDep.Visible = false;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(53, 94);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(83, 20);
            this.textMin.TabIndex = 5;
            this.textMin.Visible = false;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(185, 94);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(73, 20);
            this.textMax.TabIndex = 6;
            this.textMax.Visible = false;
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(23, 97);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(24, 13);
            this.labMin.TabIndex = 7;
            this.labMin.Text = "Min";
            this.labMin.Visible = false;
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Location = new System.Drawing.Point(142, 97);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(27, 13);
            this.labMax.TabIndex = 8;
            this.labMax.Text = "Max";
            this.labMax.Visible = false;
            // 
            // textTown
            // 
            this.textTown.Location = new System.Drawing.Point(26, 94);
            this.textTown.Name = "textTown";
            this.textTown.Size = new System.Drawing.Size(232, 20);
            this.textTown.TabIndex = 9;
            this.textTown.Visible = false;
            // 
            // AddCategoriesComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textTown);
            this.Controls.Add(this.labMax);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.labDep);
            this.Controls.Add(this.labCat);
            this.Controls.Add(this.PossibleValuesCB);
            this.Controls.Add(this.CategoriesCB);
            this.Name = "AddCategoriesComboBox";
            this.Size = new System.Drawing.Size(421, 136);
            this.Load += new System.EventHandler(this.AddCategoriesComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.ComboBox PossibleValuesCB;
        private System.Windows.Forms.Label labCat;
        private System.Windows.Forms.Label labDep;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labMax;
        private System.Windows.Forms.TextBox textTown;
    }
}
