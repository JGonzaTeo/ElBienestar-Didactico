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
using System.Net;
using System.Net.NetworkInformation;
using CapaDiseño.Consulta;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantIngresoReunion : Form
    {
        Logica Logic = new Logica();

        string slocalIP;
        string smacAddresses;
        string suser;
        
          
        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }

        public Frm_MantIngresoReunion(String susuario)
        {
            InitializeComponent();
            obtenerip();
            suser = susuario;
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
                    
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txt_NombreReunion.Text == "" |  Txt_CantidadEmpleados.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {
                //FORMATO DE FECHAS Y HORAS
                string sFechaIngreso, sFechaSalida, sHoraIngreso, sHoraSalida;
                sFechaIngreso = Dtp_FechaIngreso.Value.ToString("yyyy-MM-dd");
                sFechaSalida = Dtp_FechaSalida.Value.ToString("yyyy-MM-dd");
                sHoraIngreso = Dtp_HoraIngreso.Value.ToLongTimeString();
                sHoraSalida = Dtp_HoraSalida.Value.ToLongTimeString();

                OdbcDataReader Reunion = Logic.InsertaReunion(Txt_CodigoEmpleado.Text, Txt_NombreReunion.Text, Txt_DescripcionReunion.Text, sFechaIngreso, sFechaSalida, sHoraIngreso, sHoraSalida, Txt_CantidadEmpleados.Text);
                MessageBox.Show("Reunión Ingresada");
                Logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
                //LimpiarCampos
                Txt_CodigoEmpleado.Clear();
                Txt_CodigoEmpleado.Focus();
                Txt_Nombre.Clear();
                Txt_NombreReunion.Clear();
                Txt_DescripcionReunion.Clear();
                Txt_CantidadEmpleados.Clear();
                Dtp_FechaIngreso.ResetText();
                Dtp_FechaSalida.ResetText();
                Dtp_HoraIngreso.ResetText();
                Dtp_HoraSalida.ResetText();
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = Logic.consultaayuda("9");
            try
            {
                while (mostrarEmpleado.Read())
                {
                    ruta = mostrarEmpleado.GetString(1);
                    indice = mostrarEmpleado.GetString(2);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Help.ShowHelp(this, ruta, indice);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ConsultarEmpleados_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado consultaempleado = new Frm_consultaEmpleado();
            consultaempleado.ShowDialog();

            if (consultaempleado.DialogResult == DialogResult.OK)
            {
                Txt_CodigoEmpleado.Text = consultaempleado.Dgv_consultaEmpleado.Rows[consultaempleado.Dgv_consultaEmpleado.CurrentRow.Index].Cells[0].Value.ToString();

            }
        }
    }
}
