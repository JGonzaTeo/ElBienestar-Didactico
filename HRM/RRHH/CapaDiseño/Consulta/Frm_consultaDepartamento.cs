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

namespace CapaDiseño.Consulta
{
    public partial class Frm_consultaDepartamento : Form
    {
        public Frm_consultaDepartamento()
        {
            InitializeComponent();
            MostrarConsulta();
        }
        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM departamentos WHERE Estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaDepartamento.Refresh();
                    Dgv_consultaDepartamento.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2));
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_consultaDepartamento_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaDepartamento.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaDepartamento.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
