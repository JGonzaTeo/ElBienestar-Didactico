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
using System.Data.Odbc;
using static Recursos_Humanos.Form1;

namespace CapaDiseño.Procesos
{
    public partial class Frm_busquedaInterna : Form
    {
        Logica logic = new Logica();
        ToolTip ayuda_tp = new ToolTip();
        public Frm_busquedaInterna()
        {
            InitializeComponent();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Dgv_consultaPre.Rows.Clear();
            Dgv_consultaPre.Refresh();
            OdbcDataReader mostrar = logic.ConsultaLogicaSolicitudE(txt_id.Text);
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaPre.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            if (Dgv_consultaPre.Rows.Count > 0)
                btn_selec.Enabled = true;
            else
                btn_selec.Enabled = false;
        }

        private void Frm_busquedaInterna_Load(object sender, EventArgs e)
        {
            btn_selec.Enabled = false;
            txt_id.Focus();
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.ValidarCampoEntero((TextBox)sender);
        }

        private void btn_selec_Click(object sender, EventArgs e)
        {
            Frm_filtroInterno consultaReporte = new Frm_filtroInterno(txt_id.Text);
            consultaReporte.ShowDialog();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("17");
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
