using CapaDiseño.Consulta;
using CapaLogica;
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
using System.Net;
using System.Net.NetworkInformation;


namespace CapaDiseño.Procesos
{
    public partial class Frm_MediodeComunicacion : Form
    {
        Logica logic = new Logica();
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
        public Frm_MediodeComunicacion(String susuario)
        {

            InitializeComponent();
            obtenerip();
            suser = susuario;
        }

        private void Pic_Insertar_Click(object sender, EventArgs e)
        {
            Txt_ID.Enabled = true;
            Txt_Nombre.Enabled = true;
            Txt_Direccion.Enabled = true;
            Txt_Telefono.Enabled = true;
            Cbo_Estado.Enabled = true;
        }

        public void PicActualizar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarMC(Txt_ID.Text,Txt_Nombre.Text,Txt_Direccion.Text,Txt_Telefono.Text,Cbo_Estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);

        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarMC( Txt_Nombre.Text, Txt_Direccion.Text, Txt_Telefono.Text, Cbo_Estado.Text);
            MessageBox.Show("Datos insertar correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);

        }

        private void Pic_Borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_ID.Text);
            MessageBox.Show("Eliminado Correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
