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
    public partial class Frm_MantIngresocuentascontables : Form
    {
        Logica Logic = new Logica();
        public Frm_MantIngresocuentascontables()
        {
            InitializeComponent();
        }

        private void Btn_RealizarSansion_Click(object sender, EventArgs e)
        {
            {
                if (Txt_Codigocuenta.Text == "" | Txt_Cuenta.Text== "" | Txt_Monto.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los Campos Solicitados");
                }
                else
                {
                   

                    OdbcDataReader cuenta = Logic.Insertarcuenta(Txt_Codigocuenta.Text, Txt_Cuenta.Text, Txt_Monto.Text);
                    MessageBox.Show("cuenta ingresada");
                    
                    //LimpiarCampos
                    Txt_Codigocuenta.Clear();
                    Txt_Cuenta.Clear();
                    Txt_Monto.Clear();
                   

                }
            }
        }

        private void Txt_Monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
