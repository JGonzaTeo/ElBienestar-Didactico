using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Procesos
{
    public partial class Frm_ControlAsistenciaPersonal : Form
    {
        public Frm_ControlAsistenciaPersonal()
        {
            InitializeComponent();
            MostrarAsistenciaPersonal();
        }

        public void MostrarAsistenciaPersonal()
        {
            try
            {
                Conexion conexion = new Conexion();
                //string consultaMostrar = "select * from asistencia;";
                string consultaMostrar = "Select * from asistencia ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_AsistenciaPersonal.Refresh();
                    Dgv_AsistenciaPersonal.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }


        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_AsistenciaPersonal.Rows.Clear();
            MostrarAsistenciaPersonal();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
