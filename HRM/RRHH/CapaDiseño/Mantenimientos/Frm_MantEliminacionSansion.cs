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
namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantEliminacionSansion : Form
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
        public Frm_MantEliminacionSansion(String susuario)
        {
            InitializeComponent();
            obtenerip();
            suser = susuario;
            Gpb_IngresoDatos.Enabled = false;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click_1(object sender, EventArgs e)
        {
            if (Txt_RazonSansion.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Nombre de la Sansion");
            }
            else
            {
                OdbcDataReader Reunion = Logic.BuscarSansion(Txt_RazonSansion.Text);

                try
                {
                    while (Reunion.Read())
                    {

                        Txt_CodigoEmpleado.Text = Reunion.GetString(0);
                        Txt_Descripcion.Text = Reunion.GetString(1);
                        Dtp_FechaIngreso.Text = Reunion.GetString(2);
                        Dtp_FechaSalida.Text = Reunion.GetString(3);


                    }
                    if(Txt_CodigoEmpleado.Text == "")
                    {
                        MessageBox.Show("Ingrese correctamente el nombre de la sancion");
                    }

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_EliminarSansion_Click(object sender, EventArgs e)
        {
            if (Txt_RazonSansion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {

                //FORMATO DE FECHAS Y HORAS
                string sFechaIngreso, sFechaSalida;
                sFechaIngreso = Dtp_FechaIngreso.Value.ToString("yyyy-MM-dd");
                sFechaSalida = Dtp_FechaSalida.Value.ToString("yyyy-MM-dd");

                OdbcDataReader Sansion = Logic.DeleteSansion(Txt_RazonSansion.Text);
                MessageBox.Show("Sanción Eliminada");
                Logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);

                //LimpiarCampos
                Txt_RazonSansion.Clear();
                Txt_RazonSansion.Focus();
                Txt_Descripcion.Clear();
                Txt_CodigoEmpleado.Clear();
                Dtp_FechaIngreso.ResetText();
                Dtp_FechaSalida.ResetText();
                
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

            OdbcDataReader mostrarEmpleado = Logic.consultaayuda("6");
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
    }
}
