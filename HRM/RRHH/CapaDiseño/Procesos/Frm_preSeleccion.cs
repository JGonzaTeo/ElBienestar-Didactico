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

namespace Recursos_Humanos
{
    public partial class Frm_preSeleccion : Form
    {
        Logica logic = new Logica();
        ToolTip ayuda_tp = new ToolTip();
        public Frm_preSeleccion()
        {
            InitializeComponent();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Dgv_consultaPre.Rows.Clear();
            Dgv_consultaPre.Refresh();
            OdbcDataReader mostrar = logic.ConsultaLogicaPreseleccionFiltro(txt_id.Text);
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaPre.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
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

        private void Btn_selec_Click(object sender, EventArgs e)
        {
            Frm_filtroPreSeleccion consultaReporte = new Frm_filtroPreSeleccion(txt_id.Text);
            consultaReporte.ShowDialog();
        }

        private void Frm_preSeleccion_Load(object sender, EventArgs e)
        {
            btn_selec.Enabled = false;
            txt_id.Focus();
        }

        private void Txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.ValidarCampoEntero((TextBox)sender);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("24");
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
