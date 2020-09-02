using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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


namespace GMap_Load_DataSet.GUI
{
    public partial class MapWindow : Form
    {
        private ListOffices _ListOffices;
        private List<PointLatLng> puntos;
        GMapOverlay markers;

        public MapWindow()
        {
            InitializeComponent();
            puntos = new List<PointLatLng>();
            _ListOffices = new ListOffices();
        }


        DataView ImportData(String fileName)
        {

            _ListOffices.clearList();
            string title = "472-Colombian Oficces";

            DataSet ds = new DataSet();


            ds.Tables.Add(title);
            ds.Tables[title].Columns.Add("UBICACIÓN");
            ds.Tables[title].Columns.Add("TELEFONO");
            ds.Tables[title].Columns.Add("EMAIL");
            ds.Tables[title].Columns.Add("DIRECCIÓN");
            ds.Tables[title].Columns.Add("MUNICIPIO");
            ds.Tables[title].Columns.Add("HORARIO");
            ds.Tables[title].Columns.Add("DEPARTAMENTO");
            ds.Tables[title].Columns.Add("CODIGO POSTAL");
            ds.Tables[title].Columns.Add("LATITUD");
            ds.Tables[title].Columns.Add("LONGITUD");


            string[] lineas = File.ReadAllLines(fileName);



            for (int i = 1; i < lineas.Length; i++)
            {
                string[] celdas = Regex.Split(lineas[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                int value = celdas.Length;

                _ListOffices.Add_List_Map(celdas[0], celdas[1], celdas[2], celdas[3], celdas[3], celdas[4], celdas[5], celdas[6], celdas[7], celdas[8], celdas[9]);
                ds.Tables[title].Rows.Add(celdas);


            }



            return ds.Tables[0].DefaultView;
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
                listMap.GetDataGrid.DataSource = ImportData(openFileDialog.FileName);
            }
            addCategoriesComboBox.GetDepartments.Visible = true;
            BtnSearch.Visible = true;

            for (int i = 0; i < _ListOffices.listOffices.Count; i++)
            {
                double lat = double.Parse(_ListOffices.listOffices[i].Lat);
                double lon = double.Parse(_ListOffices.listOffices[i].lont);

                PointLatLng poin = new PointLatLng(lon, lat);

                puntos.Add(poin);
            }

            gMap_LoadTotal();

        }


        private void setMarkers()
        {
            for (int i = 0; i < puntos.Count; i++) //P es un punto creado con latitud y longitud
            {

                double lat1 = puntos[i].Lat;
                double lon1 = puntos[i].Lng;

                PointLatLng poin = new PointLatLng(lat1, lon1);
                GMarkerGoogle marker = new GMarkerGoogle(poin, GMarkerGoogleType.green_dot);
                markers.Markers.Add(marker); //Aqui se agrega el marcador a la capa

            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (addCategoriesComboBox.GetDepartments.Text.Length > 0)
            {
                addCategoriesComboBox.GetPossibleFiles.Visible = true;
            }
        }

        public void gMap_LoadTotal()
        {
            markers = new GMapOverlay("markers");
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GoogleMapProvider.Instance;  //Proveedor del servicio
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.MinZoom = 0;
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            gMap.AutoScroll = true;
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(20.9688132813906, -89.6250915527344), GMarkerGoogleType.green_dot);
            markers.Markers.Add(marker);
            setMarkers();
            gMap.Overlays.Add(markers);
        }

        private void listMap_Load(object sender, EventArgs e)
        {

        }
    }
}
