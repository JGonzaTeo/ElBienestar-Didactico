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
    public partial class modificar_bodega : Form
    {
        logica Logic = new logica();
        public modificar_bodega()
        {
            InitializeComponent();
        }

        public void buscarbodega()
        {

            OdbcDataReader almacenar = Logic.modificarbodega(textBox7.Text);
            try
            {
                while (almacenar.Read())
                {
                    textBox8.Text = almacenar.GetString(1);
                    textBox9.Text = almacenar.GetString(2);


                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void modificarbodega()
        {

            OdbcDataReader almacenar = Logic.cambiobodega(textBox7.Text, textBox8.Text, textBox9.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buscarbodega();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            modificarbodega();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
