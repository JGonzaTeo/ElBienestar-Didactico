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

namespace CapaDiseño.Procesos
{
    public partial class Frm_filtroInterno : Form
    {
        string IDReporte;
        string[] valores = new string[8];
        string[] cambio = new string[12];
        string IDPerfil;
        Logica logic = new Logica();
        ToolTip ayuda_tp = new ToolTip();
        public Frm_filtroInterno(string COD)
        {
            InitializeComponent();
            IDReporte = COD;
        }

        private void Frm_filtroInterno_Load(object sender, EventArgs e)
        {
            //Tomando los datos del detalle de la solicitud
            OdbcDataReader mostrar = logic.ConsultaLogicaBusquedaInterna(IDReporte);
            try
            {
                while (mostrar.Read())
                {
                    //MessageBox.Show(mostrar.GetString(1)+ mostrar.GetString(2));
                    valores[0] = mostrar.GetString(1);
                    valores[1] = mostrar.GetString(2);
                    valores[2] = mostrar.GetString(3);
                    valores[3] = mostrar.GetString(4);
                    valores[4] = mostrar.GetString(5);
                    valores[5] = mostrar.GetString(6);
                    valores[6] = mostrar.GetString(7);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            //tomadno y clasificando a los perfiles aptos
            OdbcDataReader clasificar = logic.ConsultaPerfilDetalle();
            //Para buscar el empleado y puesto
            string IDPuesto;
            try
            {
                while (clasificar.Read())
                {
                    //MessageBox.Show(clasificar.GetString(0)+ clasificar.GetString(1)+ clasificar.GetString(2)+ clasificar.GetString(3)+ clasificar.GetString(4)+ clasificar.GetString(5)+ clasificar.GetString(6)+ clasificar.GetString(7)+ clasificar.GetString(8));
                   Console.WriteLine(clasificar.GetString(0) + clasificar.GetString(1) + clasificar.GetString(2) + clasificar.GetString(3) + clasificar.GetString(4) + clasificar.GetString(5) + clasificar.GetString(6) + clasificar.GetString(7) + clasificar.GetString(8));
                    if (valores[0] == clasificar.GetString(1) && valores[1] == clasificar.GetString(2) && valores[2] == clasificar.GetString(3) && valores[3] == clasificar.GetString(4) && valores[4] == clasificar.GetString(5) && valores[5] == clasificar.GetString(6) && valores[6] == clasificar.GetString(7))
                    {
                       
                        //Consulta para obtener empleado y puesto
                        IDPuesto = clasificar.GetString(0);
                        IDPerfil = IDPuesto;

                        OdbcDataReader empleadoPuesto = logic.ConsultaEmpleadoyPuesto(clasificar.GetString(0));
                        try
                        {
                            while (empleadoPuesto.Read())
                            {
                              //MessageBox.Show(empleadoPuesto.GetString(0) + empleadoPuesto.GetString(1) + empleadoPuesto.GetString(2) + empleadoPuesto.GetString(3) + empleadoPuesto.GetString(4));
                              Console.WriteLine(empleadoPuesto.GetString(0) + empleadoPuesto.GetString(1) + empleadoPuesto.GetString(2) + empleadoPuesto.GetString(3) + empleadoPuesto.GetString(4));
                                Dgv_consultaAceptados.Rows.Add(clasificar.GetString(0), empleadoPuesto.GetString(4));
                                dgv_empleados.Rows.Add(empleadoPuesto.GetString(0), empleadoPuesto.GetString(1), empleadoPuesto.GetString(2), empleadoPuesto.GetString(3));
                                
                                // Dgv_consultaAceptados.Rows.Add(empleadoPuesto.GetString(4));
                            }
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        
                    }
                }
               
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            /*VERIFICACION DE TABLA VACIA*/
            if (dgv_empleados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_empleados.Rows)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("No hay ningun empleado con los datos solicitados.");
                this.Close();
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            if (dgv_empleados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_empleados.Rows)
                {
                    try
                    {

                        OdbcDataReader aptos = logic.InsertarAptos(IDReporte, IDPerfil);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Se han guardado a los candidatos Internos Aptos.");
                this.Close();
            }
            else
                MessageBox.Show("No se han seleccionado candidatos, por favor seleccionelos.");
            
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("20");
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


