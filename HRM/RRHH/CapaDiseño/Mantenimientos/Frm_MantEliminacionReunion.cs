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
using CapaLogica;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantEliminacionReunion : Form
    {
        Logica Logic = new Logica();
        public Frm_MantEliminacionReunion()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_NombreReunion.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Nombre de la Reunión");
            }
            else
            {
                OdbcDataReader Reunion = Logic.BuscarReunion(Txt_NombreReunion.Text);

                try
                {
                    while (Reunion.Read())
                    {

                        Txt_Descripcion.Text = Reunion.GetString(0);
                        Txt_FechaInicio.Text = Reunion.GetString(1);
                        Txt_FechaFinal.Text = Reunion.GetString(2);
                        Txt_HoraInicio.Text = Reunion.GetString(3);
                        Txt_HoraFinal.Text = Reunion.GetString(4);
                        Txt_CantidadEmpleado.Text = Reunion.GetString(5);


                    }
                    if(Txt_Descripcion.Text == "")
                    {
                        MessageBox.Show("Ingrese un nombre existente");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Txt_NombreReunion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {
                OdbcDataReader Reunion = Logic.DeleteReunion(Txt_NombreReunion.Text);
                MessageBox.Show("Reunión Eliminada");
                //LimpiarCampos
                Txt_NombreReunion.Clear();
                Txt_NombreReunion.Focus();
                Txt_Descripcion.Clear();
                Txt_FechaInicio.Clear();
                Txt_FechaFinal.Clear();
                Txt_HoraInicio.Clear();
                Txt_HoraFinal.Clear();
                Txt_CantidadEmpleado.Clear();
            }
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
