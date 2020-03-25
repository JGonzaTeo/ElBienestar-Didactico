using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Recursos_Humanos
{
    public partial class Form1 : Form
    {
        public class Funciones
        {
            public static bool ValidarCampoEntero(TextBox CajaDeTexto)
            {
                try
                {
                    int d = Convert.ToInt32(CajaDeTexto.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    CajaDeTexto.Text = "0";
                    CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                    return false;
                }
            }
            public static bool ValidarCampoDecimal(TextBox CajaDeTexto)
            {
                try
                {
                    decimal d = Convert.ToDecimal(CajaDeTexto.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    CajaDeTexto.Text = "0";
                    CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                    return false;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}
