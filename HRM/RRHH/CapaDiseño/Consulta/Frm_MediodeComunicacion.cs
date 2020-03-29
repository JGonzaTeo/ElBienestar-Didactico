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
    public partial class Frm_MediodeComunicacion : Form
    {
        public Frm_MediodeComunicacion()
        {
            InitializeComponent();
        }
        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM mediodecomunicacion WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaMedios.Refresh();
                    Dgv_consultaMedios.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5));
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
            Dgv_consultaMedios.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionarMedio_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaMedios.Rows.Count == 0)
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
