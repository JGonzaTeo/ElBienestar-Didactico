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


namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantEmpleado : Form
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
        public Frm_MantEmpleado(String susuario)
        {
            InitializeComponent();
            obtenerip();
            suser = susuario;
            Txt_Cod.Enabled = false;
            Txt_PrimerApellido.Enabled = false;
            Txt_SegundoNombre.Enabled = false;
            Txt_PrimerApellido.Enabled = false;
            Txt_SegundoNombre.Enabled = false;
            Txt_Telefono.Enabled = false;
            Txt_Celular.Enabled = false;
            Txt_email.Enabled = false;
            Txt_Nit.Enabled = false;
            Txt_Direccion.Enabled = false;
        }

        private void Pnl_nombreForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("7");
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Txt_Cod.Enabled = true;
            Txt_PrimerApellido.Enabled = true;
            Txt_SegundoNombre.Enabled = true;
            Txt_PrimerApellido.Enabled = true;
            Txt_SegundoNombre.Enabled = true;
            Txt_Telefono.Enabled = true;
            Txt_Celular.Enabled = true;
            Txt_email.Enabled = true;
            Txt_Nit.Enabled = true;
            Txt_Direccion.Enabled = true;
        }

        public void PicActualizar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarEmpleado(Txt_Cod.Text,Txt_PrimerApellido.Text,Txt_SegundoNombre.Text,Txt_PrimerApellido.Text,TxtSegundoApellido.Text,Txt_Telefono.Text,Txt_Celular.Text,Txt_email.Text,Txt_Direccion.Text,Txt_Nit.Text,Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);

        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarempleado(Txt_PrimerApellido.Text, Txt_SegundoNombre.Text, Txt_PrimerApellido.Text, TxtSegundoApellido.Text, Txt_Telefono.Text, Txt_Celular.Text, Txt_email.Text, Txt_Direccion.Text,Txt_Nit.Text ,Cbo_estado.Text);
            MessageBox.Show("Datos Insertados");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);

        }

        private void Pic_Borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);

        }

        private void Pic_Consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_PrimerApellido.Enabled = true;
            Txt_SegundoNombre.Enabled = true;
            Txt_PrimerApellido.Enabled = true;
            Txt_SegundoNombre.Enabled = true;
            Txt_Telefono.Enabled = true;
            Txt_Celular.Enabled = true;
            Txt_email.Enabled = true;
            Txt_Direccion.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarEmpleado(Txt_Cod.Text, Txt_PrimerApellido.Text, Txt_SegundoNombre.Text, Txt_PrimerApellido.Text, TxtSegundoApellido.Text, Txt_Telefono.Text, Txt_Celular.Text, Txt_email.Text, Txt_Direccion.Text,Txt_Nit.Text ,Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarempleado(Txt_PrimerApellido.Text, Txt_SegundoNombre.Text, Txt_PrimerApellido.Text, TxtSegundoApellido.Text, Txt_Telefono.Text, Txt_Celular.Text, Txt_email.Text, Txt_Direccion.Text, Txt_Nit.Text ,Cbo_estado.Text);
            MessageBox.Show("Datos Insertados");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();
            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_PrimerNombre.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_SegundoNombre.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_PrimerApellido.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[3].Value.ToString();
                TxtSegundoApellido.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_Telefono.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                     Cells[5].Value.ToString();
                Txt_Celular.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[6].Value.ToString();
                Txt_email.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[7].Value.ToString();
                Txt_Direccion.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[8].Value.ToString();
                string emp1 = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[9].Value.ToString();
                Txt_Nit.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                Cells[10].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[11].Value.ToString();

            }
        }

        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_estado.Items.Add("1");
            Cbo_estado.Items.Add("0");

        }
    }
}
