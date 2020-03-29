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
    public partial class Frm_MantModificacionReunion : Form
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
        public Frm_MantModificacionReunion(String susuario)
        {
            InitializeComponent();
            obtenerip();

            suser = susuario;
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
                        MessageBox.Show("Ingrese un Nombre existente");
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
            if (Txt_NombreReunion.Text == ""  | Txt_CantidadEmpleado.Text == "")
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

                OdbcDataReader Reunion = Logic.UpdateReunion(Txt_NombreReunion.Text, Txt_Descripcion.Text, sFechaIngreso,sFechaSalida, sHoraIngreso, sHoraSalida, Txt_CantidadEmpleado.Text);
                MessageBox.Show("Reunión Modificada");
                Logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);

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

            OdbcDataReader mostrarEmpleado = Logic.consultaayuda("13");
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
