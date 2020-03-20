using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recursos_Humanos.Consultas;
using CapaLogica_RRHH;
using System.Data.Odbc;
using System.Runtime.InteropServices;
using static Recursos_Humanos.Form1;

namespace Recursos_Humanos
{
    public partial class Frm_SolicitudEmpleado : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_SolicitudEmpleado(string use)
        {
            InitializeComponent();
            txt_idCreador.Enabled = false;
            txt_idPerfil.Enabled = false;
            txt_medio.Enabled = false;
            dtp_fechaS.Format = DateTimePickerFormat.Custom;
            dtp_fechaS.CustomFormat = "yyyy/MM/dd";
            chc_primaria.Enabled = false;
            chc_secundaria.Enabled = false;
            chc_bachillerato.Enabled = false;
            chc_Estudiante.Enabled = false;
            chc_Graduado.Enabled = false;
            chc_Cursos.Enabled = false;
            scampo = logic.siguiente("tbl_encabezadoreportevacante", "KidReporteVacante");
            lbl_siguiente.Text = "Numero de reporte: " + scampo;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_buscarEmpleado_Click(object sender, EventArgs e)
        {
            Frm_consultaCreador consultaCreador = new Frm_consultaCreador();
            consultaCreador.ShowDialog();

            if (consultaCreador.DialogResult == DialogResult.OK)
            {
                txt_idCreador.Text = consultaCreador.Dgv_consultaCreador.Rows[consultaCreador.Dgv_consultaCreador.CurrentRow.Index].Cells[0].Value.ToString();
                dtp_fechaS.Enabled = true;
            }
        }

        private void Btn_buscarPerfil_Click(object sender, EventArgs e)
        {
            Frm_consultaPerfil consultaPerfil = new Frm_consultaPerfil();
            consultaPerfil.ShowDialog();

            if (consultaPerfil.DialogResult == DialogResult.OK)
            {
                txt_idPerfil.Text = consultaPerfil.Dgv_consultaPerfil.Rows[consultaPerfil.Dgv_consultaPerfil.CurrentRow.Index].Cells[0].Value.ToString();
                cmb_TipoContratacion.Enabled = true;
            }
        }

        private void Btn_buscarMedio_Click(object sender, EventArgs e)
        {
            Frm_consultaMedio consultaMedio = new Frm_consultaMedio();
            consultaMedio.ShowDialog();

            if (consultaMedio.DialogResult == DialogResult.OK)
            {
                txt_medio.Text = consultaMedio.Dgv_consultaMedios.Rows[consultaMedio.Dgv_consultaMedios.CurrentRow.Index].Cells[0].Value.ToString();
                chc_primaria.Enabled = true;
                chc_Cursos.Enabled = true;
                txt_sueldo.Enabled = true;
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idCreador.Text) || string.IsNullOrEmpty(txt_idPerfil.Text)  || string.IsNullOrEmpty(txt_medio.Text) || string.IsNullOrEmpty(cmb_TipoContratacion.Text) ||  string.IsNullOrEmpty(txt_sueldo.Text)) //chc_Cursos.Checked == false ||
                MessageBox.Show("Un campo esta vacio, por favor llenelo para poder continuar.");
            else
            {
                string fec = dtp_fechaS.Value.ToString("yyyy/MM/dd");
               
                Console.WriteLine(fec);
                //aqui pondrias el codigo de guardar
                //OdbcDataReader encabezado = logic.InsertarReporte(txt_idCreador.Text, txt_idPerfil.Text, fec, cmb_TipoContratacion.SelectedItem.ToString(), txt_medio.Text, txt_extras.Text, txt_extras.Text);
                OdbcDataReader encabezado = logic.InsertarReporteEnca(scampo, txt_idCreador.Text, txt_idPerfil.Text, fec, cmb_TipoContratacion.SelectedItem.ToString(), txt_medio.Text);
                //(string reporte, string idEmpleado, string idPuesto, string fecha, string tipo, string medio)
                //Conversion a numeros
                bool p, s, b, es, g, c;
                p = chc_primaria.Checked;
                s= chc_secundaria.Checked;
                b= chc_bachillerato.Checked;
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

                OdbcDataReader detalle = logic.InsertarReporteDeta(scampo,p2,s2,b2,es2,g2,c2, txt_extras.Text,txt_sueldo.Text);
                //(string cod, string primaria, string secundaria, string bachi, string eU, string gU, string cE, string dC, string sueldo)

                MessageBox.Show("Se ha guardado el reporte.");
                txt_idCreador.Text ="";
                txt_idPerfil.Text = "";
                txt_medio.Text = "";
                txt_extras.Text = "";
                txt_sueldo.Text = "";
                dtp_fechaS.Format = DateTimePickerFormat.Custom;
                dtp_fechaS.CustomFormat = "yyyy/MM/dd";
                chc_primaria.Checked = false;
                chc_secundaria.Checked = false;
                chc_secundaria.Enabled = false;
                chc_Cursos.Enabled = false;
                chc_bachillerato.Checked = false;
                chc_Estudiante.Checked = false;
                chc_Graduado.Checked = false;
                chc_Cursos.Checked = false;
                dtp_fechaS.Enabled = false;
                txt_idPerfil.Enabled = false;
                txt_medio.Enabled = false;
                cmb_TipoContratacion.Enabled = false;
                txt_extras.Enabled = false;
                txt_extras.Enabled = false;
                txt_sueldo.Enabled = false;
                btn_guardar.Enabled = false;
                btn_buscarMedio.Enabled = false;
                btn_buscarPerfil.Enabled = false;
                scampo = logic.siguiente("tbl_encabezadoreportevacante", "KidReporteVacante");
                lbl_siguiente.Text = "Numero de reporte: " + scampo;
                Console.WriteLine(logic.siguiente("tbl_encabezadoreportevacante", "KidReporteVacante"));

            }
        }
    

        private void Frm_SolicitudEmpleado_Load(object sender, EventArgs e)
        {
            dtp_fechaS.Enabled = false;
            txt_idPerfil.Enabled = false;
            txt_medio.Enabled = false;
            cmb_TipoContratacion.Enabled = false;
            txt_extras.Enabled = false;
            txt_extras.Enabled = false;
            txt_sueldo.Enabled = false;
            btn_guardar.Enabled = false;
            btn_buscarMedio.Enabled = false;
            btn_buscarPerfil.Enabled = false;
            scampo = logic.siguiente("tbl_encabezadoreportevacante", "KidReporteVacante");
            lbl_siguiente.Text = "Numero de reporte: "+scampo;
            Console.WriteLine(logic.siguiente("tbl_encabezadoreportevacante", "KidReporteVacante"));
        }

        private void Dtp_fechaS_ValueChanged(object sender, EventArgs e)
        {
            
            btn_buscarPerfil.Enabled = true;
        }

        private void Cmb_TipoContratacion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btn_buscarMedio.Enabled = true;
            Console.WriteLine(cmb_TipoContratacion.SelectedItem.ToString());
        }

        private void Txt_razon_TextChanged(object sender, EventArgs e)
        {
            txt_extras.Enabled = true;
        }

        private void Txt_cualidades_TextChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
        }

        private void Chc_primaria_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(chc_primaria.Checked.ToString());
            Console.WriteLine(chc_primaria.Checked == true);
            bool p, s, b, es, g, c;
            p = chc_primaria.Checked;
            int ase = Convert.ToInt32(p);
            string ase2 = ase.ToString();
            Console.WriteLine(ase2);
            chc_primaria.Enabled = false;
            chc_secundaria.Enabled = true;
            btn_guardar.Enabled = true;
            if (chc_primaria.Checked == false)
                btn_guardar.Enabled = false;
        }

        private void Chc_secundaria_CheckedChanged(object sender, EventArgs e)
        {
            chc_secundaria.Enabled = false;
            chc_bachillerato.Enabled = true;
        }

        private void Chc_bachillerato_CheckedChanged(object sender, EventArgs e)
        {
            chc_bachillerato.Enabled = false;
            chc_Estudiante.Enabled = true;
        }

        private void Chc_Estudiante_CheckedChanged(object sender, EventArgs e)
        {
                chc_Estudiante.Enabled = false;
                chc_Graduado.Enabled = true;
           
        }

        private void Chc_Graduado_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_Graduado.Checked)
                chc_Estudiante.Enabled = false;
            else
            {
                chc_Estudiante.Checked = false;
                chc_bachillerato.Checked = false;
                chc_secundaria.Checked = false;
                chc_primaria.Checked = false;

                chc_Graduado.Enabled = false;
                chc_Estudiante.Enabled = false;
                chc_bachillerato.Enabled = false;
                chc_secundaria.Enabled = false;

                chc_primaria.Enabled = true;
            }
        }
  
        private void Chc_Cursos_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_Cursos.Checked)
                txt_extras.Enabled = true;
            else
            {
                txt_extras.Enabled = false;
                txt_extras.Text = "";
                btn_guardar.Enabled = false;
            }
        }

        private void Txt_extras_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Txt_sueldo_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.ValidarCampoDecimal((TextBox)sender);
        }

        private void Btn_consulta_Click(object sender, EventArgs e)
        {
            Frm_consultaReporteVacante consultaReporte = new Frm_consultaReporteVacante();
            consultaReporte.ShowDialog();
        }
    }
}
