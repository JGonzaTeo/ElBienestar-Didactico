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
using CapaDiseño.Consulta;
using CapaLogica;
using System.Net;
using System.Net.NetworkInformation;


namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_ManteDepartamento : Form
    {
        Logica logic = new Logica();
        string scampo;
        string suser;

        string slocalIP;
        string smacAddresses;
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


        public Frm_ManteDepartamento(String susuario)
        {
            InitializeComponent();
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            txt_descripcion.Enabled = false;
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;

            obtenerip();
            suser = susuario;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            txt_descripcion.Enabled = true;
            Txt_nombre.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader departamentos = logic.modificarDepartamento(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text);
            MessageBox.Show("Datos modificados correctamente.");
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader departamentos = logic.InsertarDepartamento(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text);
            MessageBox.Show("Departamento Insertado correctamente.");
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader perfil = logic.eliminarDepartamento(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            scampo = logic.siguiente("departamentos", "pkcodigodepto");
            Txt_Cod.Text = scampo;
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);

        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaDepartamento perfil = new Frm_consultaDepartamento();
            perfil.ShowDialog();

            if (perfil.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = perfil.Dgv_consultaDepartamento.Rows[perfil.Dgv_consultaDepartamento.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Frm_ManteDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("4");
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
    }
}
