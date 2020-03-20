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
    public partial class Frm_MantPercepciones : Form
    {
        Logica logic = new Logica();
        public Frm_MantPercepciones()
        {
            InitializeComponent();
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Saldo.Enabled = false;
            Cbo_estado.Enabled = false;
            Cbo_tipo.Enabled = false;
            Cbo_tipooperacion.Enabled = false;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarconcepto(Txt_Cod.Text,Txt_nombre.Text,Cbo_tipo.Text,Txt_Saldo.Text,Cbo_tipooperacion.Text,Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_Saldo.Enabled = true;
            Cbo_estado.Enabled = true;
            Cbo_tipo.Enabled = true;
            Cbo_tipooperacion.Enabled = true;
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarConcepto(Txt_Cod.Text, Txt_nombre.Text, Cbo_tipo.Text, Txt_Saldo.Text, Cbo_tipooperacion.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarconcepto(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConceptos concep = new Frm_consultaConceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Cbo_tipo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Saldo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_tipooperacion.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                     Cells[5].Value.ToString();






            }
        }
    }
}
