using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Procesos
{
    public partial class N : Form
    {
        public N()
        {
            InitializeComponent();
        }

        private void poliza_Load(object sender, EventArgs e)
        {

        }

        private void Pnl_nombreForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                e.Graphics.DrawImage(pictureBox1.Image, 0, 50, 900, 800);
                e.Graphics.DrawString("POLIZA DEL EMPLEADO:    " + textBox2.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(0, 0));
                e.Graphics.DrawString("SALARIOS", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 105));
                if (checkBox1.Checked == true)
                {
                    e.Graphics.DrawString("CAJA", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 129));
                }
                if (checkBox2.Checked == true)
                {
                    e.Graphics.DrawString("BANCOS", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 129));
                }
                if (checkBox3.Checked == true)
                {
                    e.Graphics.DrawString("CHEQUE", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 129));
                }


                e.Graphics.DrawString(textBox3.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(650, 105));
                e.Graphics.DrawString(textBox3.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(780, 129));
                e.Graphics.DrawString(textBox3.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(659, 820));
                e.Graphics.DrawString(textBox3.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(780, 820));
            }
        }
    }
}
