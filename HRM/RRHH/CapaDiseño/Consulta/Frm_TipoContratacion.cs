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
    public partial class Frm_TipoContratacion : Form
    {
        public Frm_TipoContratacion()
        {
            InitializeComponent();
            MostrarConsulta();
        }
        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM tipocontratacion WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaContratacion.Refresh();
                    Dgv_consultaContratacion.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        private void Btn_actualizarMedio_Click(object sender, EventArgs e)
        {
            Dgv_consultaContratacion.Rows.Clear();
            MostrarConsulta();
        }

        private void Frm_TipoContratacion_Load(object sender, EventArgs e)
        {

        }

        private void Btn_seleccionarMedio_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaContratacion.Rows.Count == 0)
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

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
