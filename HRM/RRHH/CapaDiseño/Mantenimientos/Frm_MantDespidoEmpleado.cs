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
    public partial class Frm_MantDespidoEmpleado : Form
    {
        Logica Logic = new Logica();

        public Frm_MantDespidoEmpleado()
        {
            InitializeComponent();
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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoEmpleado.Text == "")
            {
                MessageBox.Show("Debe Ingresar su Codigo de Empleado");
            }
            else
            {
                OdbcDataReader Reunion = Logic.BuscarEmpleadoReunion(Txt_CodigoEmpleado.Text);
                try
                {
                    while (Reunion.Read())
                    {

                        Txt_NombreEmpleado.Text = Reunion.GetString(0);

                    }
                    if(Txt_NombreEmpleado.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un codigo existente");
                    }
                    else
                    {
                        Txt_Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }

            }
        }

        private void Btn_RealizarDespido_Click(object sender, EventArgs e)
        {

            if (Txt_NombreEmpleado.Text == "" | Txt_Fecha.Text == "" | Txt_RazonDespido.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {
                OdbcDataReader Despido = Logic.InsertaDespido(Txt_CodigoEmpleado.Text, Txt_RazonDespido.Text, Txt_Descripcion.Text, Txt_Fecha.Text);
                MessageBox.Show("Despido Ingresado");
                //LimpiarCampos
                Txt_CodigoEmpleado.Clear();
                Txt_CodigoEmpleado.Focus();
                Txt_NombreEmpleado.Clear();
                Txt_RazonDespido.Clear();
                Txt_Descripcion.Clear();
                Txt_Fecha.Clear();

            }
        }
    }
}
