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
    public partial class Frm_consltaPerfiles : Form
    {
        string[] valores = new string[7];
        public Frm_consltaPerfiles()
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
                string consultaMostrar = "SELECT * FROM perfil_encabezado WHERE Estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                string consultaMostrar2 = "SELECT * FROM perfil_detalle WHERE Estado='1';";
                OdbcCommand comm2 = new OdbcCommand(consultaMostrar2, conexion.conexionbd());
                OdbcDataReader mostrarDatos2 = comm2.ExecuteReader();
                int contador = 0;
                while (mostrarDatos.Read() && mostrarDatos2.Read())
                {
                    contador= 0;
                    Dgv_consultaPerfil.Refresh();
                    for(int n=1; n < 7; n++)
                    {
                        if(mostrarDatos2.GetString(n) == "1")
                            valores[contador] = "Si";
                        else
                            valores[contador] = "No";

                        contador++;
                    }
                    Dgv_consultaPerfil.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), valores[0], valores[1], valores[2], valores[3], valores[4], valores[5], mostrarDatos2.GetString(7));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
                comm2.Connection.Close();
                mostrarDatos2.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaPerfil.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaPerfil.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Frm_consltaPerfiles_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
        }
    }
}
