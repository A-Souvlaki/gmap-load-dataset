using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Load_DataSet.GUI
{
    public partial class AddCategoriesComboBox : UserControl
    {

        public event EventHandler SelectedIndexChanged;

        string[] _categories = { "DEPARTAMENTO", "MUNICIPIO","CODIGO POSTAL" };


        public AddCategoriesComboBox()
        {
            InitializeComponent();

           
        }
       
        public ComboBox GetPossibleFiles { get { return PossibleValuesCB; } }
        
        public ComboBox GetCategories { get { return CategoriesCB; } }

        public TextBox GetTextTown { get { return textTown; } }

        public Label GetLabCat { get { return labCat; } }

        public Label GetLabDep { get { return labDep; } }

        public Label GetLabMin { get { return labMin; } }

        public Label GetLabMax { get { return labMax; } }

        public TextBox GetTextMin { get { return textMin; } }

        public TextBox GetTextMax { get { return textMax; } }



        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedIndexChanged != null)
            {
                SelectedIndexChanged(this, e);
            }
        }

        private void AddCategoriesComboBox_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _categories.Length; i++)
            {
                CategoriesCB.Items.Add(_categories[i]);
            }
        }
    }
}
