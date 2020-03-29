using CapaDatos;
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

namespace CapaDiseño.Consulta
{
    public partial class Frm_consultaCurriculum : Form
    {
        public Frm_consultaCurriculum()
        {
            InitializeComponent();
            MostrarConsulta();
        }

        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM tbl_curriculums WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                
                while (mostrarDatos.Read())
                {
                    Dgv_consultaCurriculum.Refresh();
                    Dgv_consultaCurriculum.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7), mostrarDatos.GetString(8), mostrarDatos.GetString(9), mostrarDatos.GetString(10), mostrarDatos.GetString(11), mostrarDatos.GetString(12));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void Dgv_consultaPerfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaCurriculum.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaCurriculum.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_consultaCurriculum_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }
    }
}
