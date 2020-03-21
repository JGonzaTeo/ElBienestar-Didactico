using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDiseño.Consulta;
using System.Data.Odbc;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantCurriculum : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_MantCurriculum()
        {

            InitializeComponent();
            scampo = logic.siguiente("tbl_curriculums", "pkidCurriculum");
        }

        private void Btn_buscarCreador_Click(object sender, EventArgs e)
        {

        }

        private void Txt_puesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            chc_primaria.Enabled = true;
            chc_secundaria.Enabled = true;
            chc_bachillerato.Enabled = true;
            chc_Estudiante.Enabled = true;
            chc_Graduado.Enabled = true;
            chc_Cursos.Enabled = true;
            Txt_Cod.Text = scampo;
            Txt_nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            txt_Direccion.Enabled = true;
            txt_Correo.Enabled = true;
            txt_Solicitud.Enabled = true;
            txt_Experiencia.Enabled = true;
            txt_Sueldo.Enabled = true;
            txt_extras.Enabled = true;

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Conversion a numeros
            bool p, s, b, es, g, c;
            p = chc_primaria.Checked;
            s = chc_secundaria.Checked;
            b = chc_bachillerato.Checked;
            es = chc_Estudiante.Checked;
            g = chc_Graduado.Checked;
            c = chc_Cursos.Checked;

            string p2, s2, b2, es2, g2, c2;
            int p1, s1, b1, es1, g1, c1;

            p1 = Convert.ToInt32(p);
            s1 = Convert.ToInt32(s);
            b1 = Convert.ToInt32(b);
            es1 = Convert.ToInt32(es);
            g1 = Convert.ToInt32(g);
            c1 = Convert.ToInt32(c);

            p2 = p1.ToString();
            s2 = s1.ToString();
            b2 = b1.ToString();
            es2 = es1.ToString();
            g2 = g1.ToString();
            c2 = c1.ToString();

            //MessageBox.Show(p2);
            OdbcDataReader curriculum = logic.InsertarCurriculum(Txt_Cod.Text, Txt_nombre.Text,txt_Apellido.Text,txt_Numero.Text,txt_Direccion.Text,txt_Correo.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text,txt_Experiencia.Text,txt_Sueldo.Text,txt_Solicitud.Text);
            MessageBox.Show("Curriculum Creado");
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //Conversion a numeros
            bool p, s, b, es, g, c;
            p = chc_primaria.Checked;
            s = chc_secundaria.Checked;
            b = chc_bachillerato.Checked;
            es = chc_Estudiante.Checked;
            g = chc_Graduado.Checked;
            c = chc_Cursos.Checked;

            string p2, s2, b2, es2, g2, c2;
            int p1, s1, b1, es1, g1, c1;

            p1 = Convert.ToInt32(p);
            s1 = Convert.ToInt32(s);
            b1 = Convert.ToInt32(b);
            es1 = Convert.ToInt32(es);
            g1 = Convert.ToInt32(g);
            c1 = Convert.ToInt32(c);

            p2 = p1.ToString();
            s2 = s1.ToString();
            b2 = b1.ToString();
            es2 = es1.ToString();
            g2 = g1.ToString();
            c2 = c1.ToString();
            OdbcDataReader curriculum = logic.modificarCurriculum(Txt_Cod.Text, Txt_nombre.Text,txt_Apellido.Text,txt_Numero.Text,txt_Direccion.Text,txt_Correo.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text,txt_Experiencia.Text,txt_Sueldo.Text,txt_Solicitud.Text);
            MessageBox.Show("Datos modificados correctamente");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader perfil = logic.eliminarCurriculum(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaCurriculum curriculum = new Frm_consultaCurriculum();
            curriculum.ShowDialog();

            if (curriculum.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = curriculum.Dgv_consultaCurriculum.Rows[curriculum.Dgv_consultaCurriculum.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }
    }
}
