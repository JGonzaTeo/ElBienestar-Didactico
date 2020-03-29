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
    public partial class Frm_MantEliminacionReunion : Form
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
        public Frm_MantEliminacionReunion(String susuario)
        {
            InitializeComponent();
            obtenerip();
            suser = susuario;
            Gpb_DatosReunion.Enabled = false;
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
                        Dtp_FechaIngreso.Text = Reunion.GetString(1);
                        Dtp_FechaSalida.Text = Reunion.GetString(2);
                        Dtp_HoraIngreso.Text = Reunion.GetString(3);
                        Dtp_HoraSalida.Text = Reunion.GetString(4);
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
                Logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);

                //LimpiarCampos
                Txt_NombreReunion.Clear();
                Txt_NombreReunion.Focus();
                Txt_Descripcion.Clear();
                Txt_CantidadEmpleado.Clear();
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

            OdbcDataReader mostrarEmpleado = Logic.consultaayuda("5");
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
