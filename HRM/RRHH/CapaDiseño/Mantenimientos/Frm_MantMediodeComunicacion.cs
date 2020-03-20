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


namespace CapaDiseño.Procesos
{
    public partial class Frm_MediodeComunicacion : Form
    {
        Logica logic = new Logica();
        public Frm_MediodeComunicacion()
        {
            InitializeComponent();
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
        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarMC( Txt_Nombre.Text, Txt_Direccion.Text, Txt_Telefono.Text, Cbo_Estado.Text);
            MessageBox.Show("Datos insertar correctamente.");
        }

        private void Pic_Borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_ID.Text);
            MessageBox.Show("Eliminado Correctamente.");
        }

    }
}
