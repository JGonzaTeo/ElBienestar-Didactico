//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDiseño.Procesos;
using CapaDatos;
using System.IO;


namespace CapaDiseño.Procesos
{

    public partial class Frm_Convocatoria : Form
    {

        public Frm_Convocatoria()
        {
            InitializeComponent();
        }

        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM tbl_solicitud_empleado_detalle WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    DGV_PERFIL.Refresh();
                    DGV_PERFIL.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7), mostrarDatos.GetString(8),
                         mostrarDatos.GetString(9));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Frm_Convocatoria_Load(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cbo_TipoC.Text = "Contratacion";
                Cbo_TipoC.Items.Clear();

                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM tipocontratacion WHERE estado='1' ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cbo_TipoC.Refresh();
                    Cbo_TipoC.Items.Add(mostrarDatos.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Cbo_MC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cbo_MC.Text = "Contratacion";
                Cbo_MC.Items.Clear();

                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM mediodecomunicacion WHERE estado='1' ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cbo_MC.Refresh();
                    Cbo_MC.Items.Add(mostrarDatos.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CREACION DE PDF PENDIENTE CASI TERMINADA");
            
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
