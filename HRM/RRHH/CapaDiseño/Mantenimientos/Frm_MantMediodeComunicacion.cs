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
        string scampo;


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

            Txt_ID.Enabled = false;
            Txt_Nombre.Enabled = false;
            Txt_Direccion.Enabled = false;
            Txt_Telefono.Enabled = false;
            Cbo_Estado.Enabled = false;

            scampo = logic.siguiente("mediodecomunicacion", "pkmediodecomunicacion");
            Txt_ID.Text = scampo;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("12");
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

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pic_Consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaMediodeComunicacion concep = new Frm_consultaMediodeComunicacion();
            concep.ShowDialog();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_ID.Enabled = true;
            Txt_Nombre.Enabled = true;
            Txt_Direccion.Enabled = true;
            Txt_Telefono.Enabled = true;
            Cbo_Estado.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarMC(Txt_ID.Text, Txt_Nombre.Text, Txt_Direccion.Text, Txt_Telefono.Text, Cbo_Estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarMC(Txt_Nombre.Text, Txt_Direccion.Text, Txt_Telefono.Text, Cbo_Estado.Text);
            MessageBox.Show("Datos insertar correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_ID.Text);
            MessageBox.Show("Eliminado Correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaMediodeComunicacion concep = new Frm_consultaMediodeComunicacion();
            concep.ShowDialog();
            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_ID.Text = concep.Dgv_consultaMedios.Rows[concep.Dgv_consultaMedios.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_Nombre.Text = concep.Dgv_consultaMedios.Rows[concep.Dgv_consultaMedios.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_Direccion.Text = concep.Dgv_consultaMedios.Rows[concep.Dgv_consultaMedios.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Telefono.Text = concep.Dgv_consultaMedios.Rows[concep.Dgv_consultaMedios.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_Estado.Text = concep.Dgv_consultaMedios.Rows[concep.Dgv_consultaMedios.CurrentRow.Index].
                      Cells[4].Value.ToString();
      
            }
        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Cbo_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_Estado.Items.Add("1");
            Cbo_Estado.Items.Add("0");
        }
    }
}
