using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_registro
{
    public partial class Form1 : Form
    {
        List<Riesgo> Riesgos = new List<Riesgo>();

        
        public Form1()
        {
            InitializeComponent();

            ///desaparecer textbox pagina 1

            DateLabel.Text = DateTime.Today.ToString();
            Analista_textbox.Visible = false;
            ID_textbox.Visible = false;
            Activo_textbox.Visible = false;
            IDlabel_page1.Visible = false;
            Analistalabel_page1.Visible = false;
            Activolabel_page1.Visible = false;
            Riesgo_label.Visible = false;
            Daño_label.Visible = false;
            Riesgo_textbox.Visible = false;
            Daño_textbox.Visible = false;

            ///desaparecer textbox pagina 2
            Funcion_label.Visible = false;
            Funcion_textbox.Visible = false;
            Sustitucion_label.Visible = false;
            Sustitucion_textbox.Visible = false;
            Profundidad_label.Visible = false;
            Profundidad_textbox.Visible = false;
            Extension_label.Visible = false;
            Extension_textbox.Visible = false;
            Agresion_label.Visible = false;
            Agresion_textbox.Visible = false;
            Vulnerabilidad_label.Visible = false;
            Vulnerabilidad_textbox.Visible = false;


            //Page1_grid.RowEnter += Page1_grid_RowEnter;
            Page1_grid.CellEnter += Page1_grid_RowEnter;

        }

        private void Page1_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //guardar rn base de datos
            using (var db = new LiteDatabase(@"\Local\Temp"))//instancia de base de datos
            { 
                //aqui se crea la coleccion para guardar 
                var col = db.GetCollection<Riesgo>("riesgos");

                //creacion de objeto tipo riesgo
                var r1 = new Riesgo
                {
                   
                    Nombre_riesgo = Riesgo_textbox.Text,
                    Activo = Activo_textbox.Text,
                    Daño=Daño_textbox.Text,
                    Analista=Analista_textbox.Text
                };

                //insertar objeto creado a la base de datos
                col.Insert(r1);
            }
        }

        public void data_assign()
        {


            int  r = 0;

            Page1_grid.Rows[r].Cells[0].Value = ID_textbox.Text;
            Page1_grid.Rows[r].Cells[2].Value = Analista_textbox.Text;
            Page1_grid.Rows[r].Cells[1].Value = Activo_textbox.Text;
            Page1_grid.Rows[r].Cells[3].Value = Riesgo_textbox.Text;
            Page1_grid.Rows[r].Cells[4].Value = Daño_textbox.Text;
            Page2_Grid.Rows[r].Cells[0].Value = ID_textbox.Text;
            Page2_Grid.Rows[r].Cells[2].Value = Analista_textbox.Text;
            Page2_Grid.Rows[r].Cells[1].Value = Activo_textbox.Text;
            Page2_Grid.Rows[r].Cells[3].Value = Riesgo_textbox.Text;
            Page2_Grid.Rows[r].Cells[4].Value = Daño_textbox.Text;


        }


        private void Agregar_bt_Click(object sender, EventArgs e)
        {
            Analista_textbox.Visible = true;
            ID_textbox.Visible = true;
            Activo_textbox.Visible = true;
            IDlabel_page1.Visible = true;
            Analistalabel_page1.Visible = true;
            Activolabel_page1.Visible = true;
            Riesgo_label.Visible = true;
            Daño_label.Visible = true;
            Riesgo_textbox.Visible = true;
            Daño_textbox.Visible = true;

            Page1_grid.Rows.Add();

        }

        private void Guardar_bt_Click(object sender, EventArgs e)
        {


            /// esconder los labels y los textbox
            Analista_textbox.Visible = false;
            ID_textbox.Visible = false;
            Activo_textbox.Visible = false;
            IDlabel_page1.Visible = false;
            Analistalabel_page1.Visible = false;
            Activolabel_page1.Visible = false;
            Riesgo_label.Visible = false;
            Daño_label.Visible = false;
            Riesgo_textbox.Visible = false;
            Daño_textbox.Visible = false;


            Analista_textbox.Clear();
            ID_textbox.Clear();
            Activo_textbox.Clear();
            Riesgo_textbox.Clear();
            Daño_textbox.Clear();
        }

        private void Page2_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Agregar2_bt_Click(object sender, EventArgs e)
        {
           
            Funcion_label.Visible = true;
            Funcion_textbox.Visible = true;
            Sustitucion_label.Visible = true;
            Sustitucion_textbox.Visible = true;
            Profundidad_label.Visible = true;
            Profundidad_textbox.Visible = true;
            Extension_label.Visible = true;
            Extension_textbox.Visible = true;
            Agresion_label.Visible = true;
            Agresion_textbox.Visible = true;
            Vulnerabilidad_label.Visible = true;
            Vulnerabilidad_textbox.Visible = true;


            //Limpiar los textbox
            Funcion_textbox.Clear();
            Sustitucion_textbox.Clear();
            Profundidad_textbox.Clear();
            Extension_textbox.Clear();
            Agresion_textbox.Clear();
            Vulnerabilidad_textbox.Clear();


        }

        private void ID_textbox_TextChanged(object sender, EventArgs e)
        {


        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void Guardar2_bt_Click(object sender, EventArgs e)
        {
            //Page2_grid.

            //guardar rn base de datos
            using (var db = new LiteDatabase(@"c:\Temp\mydata.db"))//instancia de base de datos
            {
                //aqui se crea la coleccion para guardar 
                var col = db.GetCollection<num_riesgo>("num_riesgos");

                //creacion de objeto tipo riesgo
                var r2 = new num_riesgo
                {
                    funcion = Convert.ToInt32(Funcion_textbox.Text),
                    sustitucion = Convert.ToInt32(Sustitucion_textbox.Text),
                    profundidad = Convert.ToInt32(Profundidad_textbox.Text),
                    extension = Convert.ToInt32(Extension_textbox.Text),
                    agresion = Convert.ToInt32(Agresion_textbox.Text),
                    vulnerabilidad = Convert.ToInt32(Vulnerabilidad_textbox.Text)
                };

                //insertar objeto creado a la base de datos
                col.Insert(r2);
            }

        }
    }

    public class Riesgo

    {
        public int ID { get; set; }
        public string Activo { get; set; }
        public string Nombre_riesgo { get; set; }
       // public string Tipo { get; set; }
        public string Daño { get; set; }
        public string Analista { get; set; }
        public string Fecha { get; set; }


    }

    public class num_riesgo
    {
        public int funcion { get; set; }
        public int sustitucion { get; set; }
        public int profundidad { get; set; }
        public int extension { get; set; }
        public int agresion { get; set; }
        public int vulnerabilidad { get; set; }
    }
}
