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



namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantEmpleado : Form
    {
        Logica logic = new Logica();
        public Frm_MantEmpleado()
        {
            InitializeComponent();
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
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
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

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarEmpleado(Txt_Cod.Text,Txt_PrimerApellido.Text,Txt_SegundoNombre.Text,Txt_PrimerApellido.Text,TxtSegundoApellido.Text,Txt_Telefono.Text,Txt_Celular.Text,Txt_email.Text,Txt_Direccion.Text,Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarempleado(Txt_PrimerApellido.Text, Txt_SegundoNombre.Text, Txt_PrimerApellido.Text, TxtSegundoApellido.Text, Txt_Telefono.Text, Txt_Celular.Text, Txt_email.Text, Txt_Direccion.Text, Cbo_estado.Text);
            MessageBox.Show("Datos Insertados");
        }

        private void Pic_Borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamente.");
        }

        private void Pic_Consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            
        }
    }
}
