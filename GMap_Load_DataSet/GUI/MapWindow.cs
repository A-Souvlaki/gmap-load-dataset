using GMap_Load_DataSet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.DataVisualization.Charting;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GMap_Load_DataSet.GUI
{
    public partial class MapWindow : Form
    {


        List<PointLatLng> points;

        ListOffices lo;

        DataSet ds;

        GMapOverlay markers;

        GMapOverlay polygons;

        public MapWindow()
        {
            InitializeComponent();

            points = new List<PointLatLng>();

            lo = new ListOffices();

            markers = new GMapOverlay("markers");

            polygons = new GMapOverlay("polygons");
        }

        private void MapWindow_Load(object sender, EventArgs e)
        {
            addCategoriesComboBox.SelectedIndexChanged += new EventHandler(AddCategoriesComboBox_SelectedIndexChanged);
            Create_Chart();

            radioBar.Checked = true;
            radioMar.Checked = true;


        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMap.Position = new PointLatLng(4.6097100, -74.0817500);

            gMap.Overlays.Add(markers);
            gMap.Overlays.Add(polygons);
        }

        public void gMap_LoadTotal()
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MinZoom = 0;
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            gMap.AutoScroll = true;

        }

        private void Create_Chart()
        {
            string[] regions = { "CUNDINAMARCA", "BOYACA", "TOLIMA", "BOLIVAR", "SUCRE", "CESAR" };
            string[] towns = { "BOGOTA D.C.", "CALDAS", "VALLE DEL CAUCA", "ANTIOQUIA", "SANTANDER" };
            string[] schedule = { "NO TRABAJA EN JORNADA CONTINUA", "TRABAJA EN JORNADA CONTINUA" };

            int[] q_municipalitiesA = { 7, 6, 5, 9, 7, 5 };
            int[] q_municipalitiesB = { 28, 11, 16, 16, 10 };
            string[] q_municipalitiesC = { "0.18", "0.82" };


            Diagram.Series["Series1"].LegendText = "Departament with a Offices number between 5 and 10";
            Points.Series["Series1"].LegendText = "Departament with more than 10 Offices";


            Dictionary<string, int> dicA = new Dictionary<string, int>();
            Dictionary<string, int> dicB = new Dictionary<string, int>();
            Dictionary<string, string> dicC = new Dictionary<string, string>();

            for (int i = 0; i < 6; i++)
            {
                dicA.Add(regions[i], q_municipalitiesA[i]);

            }
            for (int i = 0; i < 5; i++)
            {

                dicB.Add(towns[i], q_municipalitiesB[i]);
            }
            for (int i = 0; i < 2; i++)
            {

                dicC.Add(schedule[i], q_municipalitiesC[i]);
            }

            foreach (KeyValuePair<string, int> d in dicA)
            {
                Diagram.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, int> d in dicB)
            {
                Points.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
            foreach (KeyValuePair<string, string> d in dicC)
            {
                Pie.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
        }

        DataView ImportData(String fileName)
        {
            string title = "472-Colombian Oficces";

            ds = new DataSet();

            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("UBICACIÓN");
            ds.Tables[title].Columns.Add("TELEFONO");
            ds.Tables[title].Columns.Add("EMAIL");
            ds.Tables[title].Columns.Add("DIRECCIÓN");
            ds.Tables[title].Columns.Add("DEPARTAMENTO");
            ds.Tables[title].Columns.Add("HORARIO");
            ds.Tables[title].Columns.Add("CODIGO POSTAL");


            string[] lineas = File.ReadAllLines(fileName);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] celdas = Regex.Split(lineas[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                string location = celdas[0];
                string _phone = celdas[1];
                string _mail = celdas[2];
                string _dir = celdas[3];
                string _dept = celdas[4];
                string _schedule = celdas[5];
                string zipCode = celdas[6];
                string lat = celdas[7];
                string lon = celdas[8];

                ds.Tables[title].Rows.Add(location, _phone, _mail, _dir, _dept, _schedule, zipCode);
                lo.Add_List_Map(location, _phone, _mail, _dir, _dept, _schedule, zipCode, lat, lon);

            }


            return ds.Tables[0].DefaultView;
        }

        private void Fill_Table(List<Office> list)
        {
            string title = "472-Colombian Oficces";

            ds = new DataSet();

            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("UBICACIÓN");
            ds.Tables[title].Columns.Add("TELEFONO");
            ds.Tables[title].Columns.Add("EMAIL");
            ds.Tables[title].Columns.Add("DIRECCIÓN");
            ds.Tables[title].Columns.Add("DEPARTAMENTO");
            ds.Tables[title].Columns.Add("HORARIO");
            ds.Tables[title].Columns.Add("CODIGO POSTAL");

            for (int i = 0; i < list.Count; i++)
            {
                ds.Tables[title].Rows.Add(list[i].Ubication, list[i].Phone, list[i].Email, list[i].Address, list[i].Departament, list[i].Schedule, list[i].Zip_Code);

            }

            listMap.GetDataGrid.DataSource = ds.Tables[0].DefaultView; ;
        }

        private void buttImport_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //Used like a filter: csv;

                Title = "Seleccionar Archivo"
            };

            //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ds != null) {
                    ds.Clear();
                    listMap.GetDataGrid.DataSource = ImportData(openFileDialog.FileName);
                }
                else
                {
                    listMap.GetDataGrid.DataSource = ImportData(openFileDialog.FileName);
                }
            }
            BtnAll.Visible = true;
            BtnSee.Visible = true;
            BtnChan.Visible = true;
            radioBar.Visible = true;
            radioPie.Visible = true;
            radioPoints.Visible = true;
            radioPol.Visible = true;
            radioMar.Visible = true;
            Diagram.Visible = true;
            addCategoriesComboBox.GetLabCat.Visible = true;
            addCategoriesComboBox.GetCategories.Visible = true;
            
            gMap_LoadTotal();
            setMarkers();
            setPolygons();

            polygons.IsVisibile = false;
            

        }

        private void setMarkers() 
        {
            for (int i = 0; i < lo.Offices.Count; i++)
            {
                double lat = double.Parse(lo.Offices[i].Lat, System.Globalization.CultureInfo.InvariantCulture);
                double lon = double.Parse(lo.Offices[i].lont, System.Globalization.CultureInfo.InvariantCulture);

                PointLatLng poin = new PointLatLng(lon, lat);
                GMapMarker marker = new GMarkerGoogle(poin, GMarkerGoogleType.green_dot);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("Información: \n Ubicacion:{0} \n Latitud:{1} \n Longitud:{2}", lo.Offices[i].Name, lo.Offices[i].lont, lo.Offices[i].Lat);
                markers.Markers.Add(marker);

                points.Add(poin);

            }
        }

        private void setPolygons()
        {
            GMapPolygon pl = new GMapPolygon(points, "Polygons");
            pl.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));
            pl.Stroke = new Pen(Color.Blue, 1);

            polygons.Polygons.Add(pl);
        }

        private void AddCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addCategoriesComboBox.GetCategories.Text.Equals("DEPARTAMENTO"))
            {
                Default_Settings();
                addCategoriesComboBox.GetLabDep.Visible = true;
                addCategoriesComboBox.GetPossibleFiles.Items.Clear();
                List<String> dept = lo.Get_Departaments();

                for (int i = 0; i < dept.Count; i++)
                {
                    addCategoriesComboBox.GetPossibleFiles.Items.Add(dept[i]);
                }
                addCategoriesComboBox.GetPossibleFiles.Visible = true;
                BtnFilter.Visible = true;
            }
            else if(addCategoriesComboBox.GetCategories.Text.Equals("MUNICIPIO"))
            {
                Default_Settings();
                addCategoriesComboBox.GetLabDep.Text = "Towns";
                addCategoriesComboBox.GetTextTown.Visible = true;
                addCategoriesComboBox.GetTextTown.Focus();
                addCategoriesComboBox.GetTextTown.Select(0, 0);
                BtnSearch.Visible = true;
               
            }
            else if(addCategoriesComboBox.GetCategories.Text.Equals("CODIGO POSTAL"))
            {
                Default_Settings();
                addCategoriesComboBox.GetLabDep.Text = "Range";
                addCategoriesComboBox.GetTextMin.Visible = true;
                addCategoriesComboBox.GetTextMax.Visible = true;
                addCategoriesComboBox.GetLabMin.Visible = true;
                addCategoriesComboBox.GetLabMax.Visible = true;
                BtnCal.Visible = true;
                labRange.Visible = true;
                
            }
        }

        private void Default_Settings() {

            addCategoriesComboBox.GetLabDep.Text = "Departament";
            addCategoriesComboBox.GetPossibleFiles.Visible = false;
            addCategoriesComboBox.GetTextTown.Visible = false;
            addCategoriesComboBox.GetTextMin.Visible = false;
            addCategoriesComboBox.GetTextMax.Visible = false;
            addCategoriesComboBox.GetLabMin.Visible = false;
            addCategoriesComboBox.GetLabMax.Visible = false;
            BtnFilter.Visible = false;
            BtnSearch.Visible = false;
            BtnCal.Visible = false;
            labRange.Visible = false;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataView)listMap.GetDataGrid.DataSource).Table;
            dt.DefaultView.RowFilter = string.Format("DEPARTAMENTO = '{0}'", addCategoriesComboBox.GetPossibleFiles.Text);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Office> o = lo.Get_SubString_For_A_Search(addCategoriesComboBox.GetTextTown.Text);

            Fill_Table(o);

            addCategoriesComboBox.GetTextTown.Focus();
            addCategoriesComboBox.GetTextTown.Select(0, 0);

        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            string min = addCategoriesComboBox.GetTextMin.Text.Trim();
            string max = addCategoriesComboBox.GetTextMax.Text.Trim();
            

            if ((min.All(Char.IsDigit) && min.Length > 0) && (max.All(Char.IsDigit) && max.Length > 0))
            {
                int minimun = Int32.Parse(min);
                int maximun = Int32.Parse(max);
               
                if ((minimun >= 50015 && minimun <= 9040001) && maximun <= 9040001)
                {
                    List<Office> o = lo.Get_Range_From_Values(minimun, maximun);
                    Fill_Table(o);
                }
                else 
                {
                    MessageBox.Show("Rango invalido");
                }
            }
            else 
            {
                MessageBox.Show("Los caracteres ingresados deben ser numeros");
            }
        }

        private void BtnSee_Click(object sender, EventArgs e)
        {
            if(radioBar.Checked)
            {
                Diagram.Visible = true;
                Points.Visible = false;
                Pie.Visible = false;
            }
            else if (radioPoints.Checked) 
            {
                Points.Visible = true;
                Diagram.Visible = false;
                Pie.Visible = false;
            }
            else if(radioPie.Checked)
            {
                Points.Visible = false;
                Diagram.Visible = false;
                Pie.Visible = true;
            }
        }

   

        private void BtnAll_Click(object sender, EventArgs e)
        {
            Fill_Table(lo.Offices);
        }

        private void BtnChan_Click(object sender, EventArgs e)
        {
            if (radioMar.Checked)
            {
                markers.IsVisibile = true;
                polygons.IsVisibile = false;
            }
            else if (radioPol.Checked)
            {
                markers.IsVisibile = false;
                polygons.IsVisibile = true;
            }
        }

       

      
    }
}
