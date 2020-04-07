using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cLogica;
using System.Data.Odbc;

namespace mvc
{
    public partial class interfazgrafica : UserControl
    {
        logica Logic = new logica();
        string codibodega;
        public interfazgrafica()
        {
            InitializeComponent();
            Mostrarbodegas();
          
        }

        private void interfazgrafica_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            modificar_bodega modificarbodega = new modificar_bodega();
            modificarbodega.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modificar_producto modificarproducto = new modificar_producto();
            modificarproducto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdbcDataReader bodega = Logic.ingresoproducto(textBox7.Text, textBox8.Text, textBox9.Text);
            MessageBox.Show("bodega ingresada");

            //LimpiarCampos
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            Mostrarbodegas();
        }

        public void codigobodega()
        {

            OdbcDataReader almacenar = Logic.consultaproducto(textBox5.Text);
            try
            {
                while (almacenar.Read())
                {
                    codibodega = almacenar.GetString(0);
                   
                   
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void ubicacion()
        {
            codigobodega();

            OdbcDataReader ubicacion = Logic.consultaubicaciones(codibodega);
            try
            {
                while (ubicacion.Read())
                {
                    textBox6.Text  = ubicacion.GetString(0);


                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void deleteproducto()
        {


            OdbcDataReader ubicacion = Logic.deleteproducto(textBox5.Text);
            try
            {
                while (ubicacion.Read())
                {



                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void deletebodega()
        {
           

            OdbcDataReader ubicacion = Logic.deletebodega(textBox10.Text );
            try
            {
                while (ubicacion.Read())
                {
                   


                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void Mostrarbodegas()
        {
            dataGridView1.Rows.Clear();
            OdbcDataReader mostrarbodega = Logic.Rellenobodega();
            try
            {
                while (mostrarbodega.Read())
                {
                    dataGridView1.Rows.Add(mostrarbodega.GetString(0), mostrarbodega.GetString(1),
                       mostrarbodega.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader bodega = Logic.ingresoproducto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show("producto ingresado");

            //LimpiarCampos
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ubicacion();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deletebodega();
            textBox10.Clear();
            Mostrarbodegas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deleteproducto();
            textBox5.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mostrarbodegas();
        }
    }
}
