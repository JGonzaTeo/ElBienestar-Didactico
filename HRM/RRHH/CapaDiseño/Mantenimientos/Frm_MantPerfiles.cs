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

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantPerfiles : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_MantPerfiles()
        {
            InitializeComponent();
            scampo = logic.siguiente("perfil_encabezado", "pkcodperfil");
            Txt_Cod.Text = scampo;
            chc_primaria.Enabled = false;
            chc_secundaria.Enabled = false;
            chc_bachillerato.Enabled = false;
            chc_Estudiante.Enabled = false;
            chc_Graduado.Enabled = false;
            chc_Cursos.Enabled = false;
            txt_extras.Enabled = false;
            Txt_Cod.Enabled = false;
            Txt_puesto.Enabled = false;
        }

        private void btn_buscarCreador_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_puesto.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
            if (string.IsNullOrEmpty(Txt_puesto.Text))
                MessageBox.Show("Debe de seleccionar un puesto");
            
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            chc_primaria.Enabled = true;
            chc_secundaria.Enabled = true;
            chc_bachillerato.Enabled = true;
            chc_Estudiante.Enabled = true;
            chc_Graduado.Enabled = true;
            chc_Cursos.Enabled = true;
            txt_extras.Enabled = true;
            Txt_Cod.Enabled = true;
            Txt_puesto.Enabled = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConceptos concep = new Frm_consultaConceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
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
            OdbcDataReader perfil = logic.InsertarPerfil(Txt_Cod.Text, Txt_puesto.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text);
            MessageBox.Show("Perfil Creado.");
        }

        private void Frm_MantPerfiles_Load(object sender, EventArgs e)
        {

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
            OdbcDataReader perfil = logic.modificarPerfil(Txt_Cod.Text, Txt_puesto.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader perfil = logic.eliminarPerfil(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }
    }
}
