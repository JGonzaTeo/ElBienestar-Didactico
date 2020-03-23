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

namespace CapaDiseño.Procesos
{
    public partial class Frm_SolicitudEmpleadoN : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_SolicitudEmpleadoN()
        {
            InitializeComponent();

            scampo = logic.siguiente("tbl_solicitud_empleado_encabezado", "pksolicitudempleado");
            txt_solicitud.Text = scampo;

            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("yyyy/MM/dd");
            txt_fecha.Text = fecha;

            txt_creador.Enabled = false;
            txt_tipo.Enabled = false;
            //chc_primaria.Enabled = false;
            //chc_secundaria.Enabled = false;
            //chc_bachillerato.Enabled = false;
            //chc_Estudiante.Enabled = false;
            //chc_Graduado.Enabled = false;
            //chc_Cursos.Enabled = false;
            //txt_extras.Enabled = false;
            //btn_buscarContratacion.Enabled = false;
        }

        private void btn_buscarCreador_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                txt_creador.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
            if (string.IsNullOrEmpty(txt_creador.Text))
                MessageBox.Show("Debe de seleccionar un creador");
            else
                btn_buscarContratacion.Enabled = true;
        }

        private void btn_buscarContratacion_Click(object sender, EventArgs e)
        {
            
            Frm_TipoContratacion concep = new Frm_TipoContratacion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                txt_creador.Text = concep.Dgv_consultaContratacion.Rows[concep.Dgv_consultaContratacion.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
            if (string.IsNullOrEmpty(txt_creador.Text))
                MessageBox.Show("Debe de seleccionar un tipo de contratación");
            else {
                txt_extras.Enabled = true;
                chc_primaria.Enabled = true;
            }
            
        }

        private void btn_generar_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txt_creador.Text) || string.IsNullOrEmpty(txt_tipo.Text))
                MessageBox.Show("Algunos campos estan sin rellenar.");
            else
            {
                OdbcDataReader encabezado = logic.InsertarSolicitudEmpleado(scampo, txt_creador.Text, txt_tipo.Text, txt_fecha.Text, p2, s2, b2, es2, g2, c2, txt_extras.Text);
                MessageBox.Show("Solicitud creada exitosamente.");
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_SolicitudEmpleadoN_Load(object sender, EventArgs e)
        {

        }
    }
}
