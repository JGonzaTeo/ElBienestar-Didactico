using CapaDiseño.Consulta;
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
using System.Net;
using System.Net.NetworkInformation;


namespace CapaDiseño.Procesos
{
    public partial class Frm_Nomina : Form
    {

       Logica logic = new Logica();

        string slocalIP;
        string smacAddresses;
        string suser;
       
        
        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }
        public Frm_Nomina(String susuario)
        {
            InitializeComponent();
            MostrarEmpleados();
            obtenerip();
            suser = susuario;
        }
        public void MostrarEmpleados()
        {
            Dgv_empleadoscontables.Rows.Clear();
            OdbcDataReader mostrarEmpleado = logic.consultarnomina();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    Dgv_empleadoscontables.Rows.Add(mostrarEmpleado.GetString(0), mostrarEmpleado.GetString(1), mostrarEmpleado.GetString(2), mostrarEmpleado.GetString(3),
                        mostrarEmpleado.GetString(4), mostrarEmpleado.GetString(5), mostrarEmpleado.GetString(6));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado concep = new Frm_consultaEmpleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codempleado.Text = concep.Dgv_consultaEmpleado.Rows[concep.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[0].Value.ToString();


            }
        }

        private void Btn_generarnomina_Click(object sender, EventArgs e)
        {

            double deducciones = Convert.ToDouble(Txt_SubtotalDeducciones.Text);
            double percepciones =Convert.ToDouble(Txt_SubtotalPercepciones.Text);
            double total = (deducciones - percepciones);
            Txt_saldonominal.Text = Convert.ToString(total);
            OdbcDataReader cita = logic.Insertarnomina(Txt_CodEncabezado.Text,Txt_tiponomina.Text, Dtp_fechainicio.Text, Dtp_fechafin.Text, Txt_codempleado.Text, Txt_Observaciones.Text, Txt_saldonominal.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);



        }
    }
}
