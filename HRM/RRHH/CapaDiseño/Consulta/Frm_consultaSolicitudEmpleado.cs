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

namespace CapaDiseño.Consulta
{
    public partial class Frm_consultaSolicitudEmpleado : Form
    {
        Logica logic = new Logica();
        public Frm_consultaSolicitudEmpleado()
        {
            InitializeComponent();
            Mostrar();
        }
        public void Mostrar()
        {
            Dgv_consultaSolicitud.Rows.Clear();
            Dgv_consultaSolicitud.Rows.Clear();
            //Cambiar variable
            string s="5";
            OdbcDataReader mostrarEncabezado = logic.ConsultaLogicaSolicitudE(s);
            try
            {
                while (mostrarEncabezado.Read())
                {
                    Dgv_consultaSolicitud.Rows.Add(mostrarEncabezado.GetString(0), mostrarEncabezado.GetString(1), mostrarEncabezado.GetString(2), mostrarEncabezado.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Frm_consultaSolicitudEmpleado_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaSolicitud.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
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
    }
}
