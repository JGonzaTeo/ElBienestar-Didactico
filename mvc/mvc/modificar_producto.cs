using cLogica;
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

namespace mvc
{
    public partial class modificar_producto : Form
    {
        logica Logic = new logica();
        public modificar_producto()
        {
            InitializeComponent();
        }
        public void buscarbodega()
        {

            OdbcDataReader almacenar = Logic.modificarproducto(textBox1.Text);
            try
            {
                while (almacenar.Read())
                {
                    textBox2.Text = almacenar.GetString(1);
                    textBox3.Text = almacenar.GetString(2);
                    textBox4.Text = almacenar.GetString(3);


                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void modificarbodega()
        {

            OdbcDataReader almacenar = Logic.cambioproducto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarbodega();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modificarbodega();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
