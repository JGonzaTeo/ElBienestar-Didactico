using CapaDatos;
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

namespace CapaDiseño.Procesos
{
    
    public partial class Frm_polizaNomina : Form
    {

        public Frm_polizaNomina()
        {
          
            InitializeComponent();
        }
        Logica logic = new Logica();

        string sueldo;
        string conceptos;
        string resultados;
        public void Guardar()

        {
        
               string fechainicial = dateTimePicker2.Value.ToString("yyyy-MM-dd");
               string fechafinal = dateTimePicker3.Value.ToString("yyyy-MM-dd");
               string codigopoliza = Convert.ToString(Txt_numeropoliza.Text);
               string codigonomina = Convert.ToString(Txt_numeronomina.Text);

       OdbcDataReader cita = logic.Guardarpoliza(codigopoliza, codigonomina, fechainicial, fechafinal);
       
          

        }
        public void Mostrarcuentasporpagar()
        {

            OdbcDataReader mostrarEmpleado = logic.rellenocuentascontables();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    
                    Dgv_poliza.Rows.Add(mostrarEmpleado.GetString(0)+" por pagar","", mostrarEmpleado.GetString(1));

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }
        public void Mostrarcuentas()
        {

            OdbcDataReader mostrarEmpleado = logic.rellenocuentascontables();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    Dgv_poliza.Rows.Add(mostrarEmpleado.GetString(0), mostrarEmpleado.GetString(1));
                    

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }
        public void MostrarEmpleados()
        {
          
            OdbcDataReader mostrarEmpleado = logic.rellenoconceptos();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    Dgv_poliza.Rows.Add(mostrarEmpleado.GetString(0), mostrarEmpleado.GetString(1));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
          

        }
        public void sueldos()
        {
            


            Dgv_poliza.Rows.Add("SUELDOS", sueldo);
        }
        public void sueldocalculo()
        {
            int resta;
            int suma;
            resta = int.Parse(conceptos) - int.Parse(resultados) ;
            sueldo = resta.ToString();
            suma = int.Parse(sueldo) + int.Parse(resultados);
           
            Dgv_poliza.Rows.Add("BANCOS", "", suma.ToString());

        }

    public void sumaconcepto()
        {

            OdbcDataReader mostrarEmpleado = logic.comparacionconcepto();
            try
            {
                while (mostrarEmpleado.Read())
                {

                    resultados = mostrarEmpleado.GetString(0);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }
        public void datosnomina()
        {

            OdbcDataReader mostrarEmpleado = logic.consultanomas();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    Txt_numeropoliza.Text = mostrarEmpleado.GetString(0);
                    Txt_numeronomina.Text = mostrarEmpleado.GetString(0);
                    conceptos = mostrarEmpleado.GetString(1);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        public void compasuma()
            {

                OdbcDataReader mostrarEmpleado = logic.comparacion();
                try
                {
                    while (mostrarEmpleado.Read())
                    {
                        textBox10.Text = mostrarEmpleado.GetString(0);
                        textBox11.Text = mostrarEmpleado.GetString(0);
                        
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }


           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sumasiguales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimientos.Frm_MantIngresocuentascontables concep = new Mantenimientos.Frm_MantIngresocuentascontables();
            concep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Asignaciondeconcepto concep = new Frm_Asignaciondeconcepto();
            concep.ShowDialog();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


   



        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("26");
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void actualizar()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consulta = "TRUNCATE mydb.poliza_detalle;";
                OdbcCommand comm = new OdbcCommand(consulta, conexion.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();

         
               
            }
            catch (Exception error)
            {
                Console.Write("Error: " + error.Message);
            }
        }

        private void Frm_polizaNomina_Load(object sender, EventArgs e)
        {
            Dgv_poliza.Rows.Clear();
            actualizar();
            sumaconcepto();
            MostrarEmpleados();
            datosnomina();
            System.Threading.Thread.Sleep(10);
            sueldocalculo();
            sueldos();
            Mostrarcuentas();
            Mostrarcuentasporpagar();
           

            System.Threading.Thread.Sleep(30);
            MessageBox.Show("POLIZA GUARDADA");
            sumasiguales();
            System.Threading.Thread.Sleep(40);
            compasuma();
            Guardar();
        }
        private void sumasiguales()
        {

           
             foreach (DataGridViewRow row in Dgv_poliza.Rows)
            {
                string scuentas = Convert.ToString(row.Cells["Column1"].Value);
                string sdebe = Convert.ToString(row.Cells["Column2"].Value);
                string shaber = Convert.ToString(row.Cells["Column3"].Value);
                OdbcDataReader cita = logic.detallepolizass(scuentas,sdebe, shaber);



            }



        }

        private void Gpb_Detallenominal_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dgv_poliza.Rows.Clear();
            actualizar();
            sumaconcepto();
            MostrarEmpleados();
            datosnomina();
            System.Threading.Thread.Sleep(10);
            sueldocalculo();
            sueldos();
            Mostrarcuentas();
            Mostrarcuentasporpagar();
          

            System.Threading.Thread.Sleep(30);
          
            sumasiguales();
            System.Threading.Thread.Sleep(40);
            compasuma();
            Guardar();
        }
    }
}