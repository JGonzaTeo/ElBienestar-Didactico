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
    public partial class Frm_MantIngresoReunion : Form
    {
        Logica Logic = new Logica();
        public Frm_MantIngresoReunion()
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

                        Txt_Nombre.Text = Reunion.GetString(0);

                    }
                    if(Txt_Nombre.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un codigo existente");

                    }
                    else
                    {
                        Txt_HoraInicio.Text = DateTime.Now.ToLongTimeString();
                        Txt_FechaInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        Txt_HoraFinal.Text = DateTime.Now.ToLongTimeString();
                        Txt_FechaFinal.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                    
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txt_NombreReunion.Text == "" | Txt_FechaInicio.Text == "" | Txt_HoraInicio.Text == "" | Txt_FechaFinal.Text == "" | Txt_HoraFinal.Text == "" | Txt_CantidadEmpleados.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {
                OdbcDataReader Reunion = Logic.InsertaReunion(Txt_CodigoEmpleado.Text, Txt_NombreReunion.Text, Txt_DescripcionReunion.Text, Txt_FechaInicio.Text, Txt_FechaFinal.Text, Txt_HoraInicio.Text, Txt_HoraFinal.Text, Txt_CantidadEmpleados.Text);
                MessageBox.Show("Reunión Ingresada");
                //LimpiarCampos
                Txt_CodigoEmpleado.Clear();
                Txt_CodigoEmpleado.Focus();
                Txt_Nombre.Clear();
                Txt_NombreReunion.Clear();
                Txt_DescripcionReunion.Clear();
                Txt_FechaInicio.Clear();
                Txt_FechaFinal.Clear();
                Txt_HoraInicio.Clear();
                Txt_HoraFinal.Clear();
                Txt_CantidadEmpleados.Clear();
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
