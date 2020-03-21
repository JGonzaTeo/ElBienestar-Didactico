using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseño.Consulta;
using CapaLogica;
using System.Data.Odbc;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantJornada : Form
    {
        Logica logic = new Logica();
        public Frm_MantJornada()
        {
            InitializeComponent();
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

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_codigoJornada.Enabled = true;
            Txt_nombreJornada.Enabled = true;
            Txt_horasJornada.Enabled = true;
            Cbo_estadoJornada.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader jornada = logic.modificarJornada(Txt_codigoJornada.Text, Txt_nombreJornada.Text, Txt_horasJornada.Text, Cbo_estadoJornada.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader jornada = logic.insertarJornada(Txt_codigoJornada.Text, Txt_nombreJornada.Text, Txt_horasJornada.Text, Cbo_estadoJornada.Text);
            MessageBox.Show("Datos registrados.");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader jornada = logic.eliminarJornada(Txt_codigoJornada.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaJornada concep = new Frm_consultaJornada();
            concep.ShowDialog();
            
            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigoJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombreJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_horasJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Cbo_estadoJornada.Text = concep.Dgv_consultaJornada.Rows[concep.Dgv_consultaJornada.CurrentRow.Index].
                     Cells[3].Value.ToString();
            }
        }
    }
}
