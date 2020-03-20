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
    public partial class Frm_MantIngresoSansion : Form
    {
        Logica Logic = new Logica();
        public Frm_MantIngresoSansion()
        {
            InitializeComponent();
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
                        MessageBox.Show("Ingrese un codigo existente");
                    }
                    else
                    {
                        Txt_FechaInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        Txt_FechaFinal.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    }

                   
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_RealizarSansion_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoEmpleado.Text == "" | Txt_NombreEmpleado.Text == "" | Txt_FechaInicio.Text == "" | Txt_RazonSansion.Text == "" | Txt_FechaFinal.Text == "" | Txt_Descripcion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {
                OdbcDataReader Sansion = Logic.InsertarSansion(Txt_CodigoEmpleado.Text, Txt_RazonSansion.Text, Txt_Descripcion.Text, Txt_FechaInicio.Text, Txt_FechaFinal.Text);
                MessageBox.Show("Sansión Ingresada");
                //LimpiarCampos
                Txt_CodigoEmpleado.Clear();
                Txt_CodigoEmpleado.Focus();
                Txt_RazonSansion.Clear();
                Txt_NombreEmpleado.Clear();
                Txt_Descripcion.Clear();
                Txt_FechaInicio.Clear();
                Txt_FechaFinal.Clear();

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
