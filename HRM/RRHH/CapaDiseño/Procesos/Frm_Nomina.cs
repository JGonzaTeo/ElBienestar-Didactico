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
            Txt_SubtotalPercepciones.Enabled = false;
            Txt_SubtotalDeducciones.Enabled = false;
            Txt_saldonominal.Enabled = false;
        }

        public void MostrarEmpleados()
        {
            Dgv_empleadoscontables.Rows.Clear();
            OdbcDataReader mostrarEmpleado = logic.consultarnomina();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    Dgv_empleadoscontables.Rows.Add(mostrarEmpleado.GetString(0), mostrarEmpleado.GetString(1),
                        mostrarEmpleado.GetString(2), mostrarEmpleado.GetString(3),
                        mostrarEmpleado.GetString(4), mostrarEmpleado.GetString(5),
                        mostrarEmpleado.GetString(6));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            cambiodecampos();

        }

        public void cambiodecampos()
        {
            foreach (DataGridViewRow row in Dgv_empleadoscontables.Rows)
            {

                if (Convert.ToString(row.Cells["Column6"].Value) == "0")
                {
                    row.Cells["Column6"].Value = "Percepcion";
                }
                if (Convert.ToString(row.Cells["Column6"].Value) == "1")
                {
                    row.Cells["Column6"].Value = "Deduccion";
                }
                if (Convert.ToString(row.Cells["Column7"].Value) == "0")
                {
                    row.Cells["Column7"].Value = "Suma";
                }
                if (Convert.ToString(row.Cells["Column7"].Value) == "1")
                {
                    row.Cells["Column7"].Value = "Multiplicacion";
                }

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
            double prespuestaps = 0;
            double prespuestaps2 = 0;
            double prespuestapm2 = 0;
            double prespuestapm = 0;
            double ptotalpercepcion;

            double drespuestaps = 0;
            double drespuestaps2 = 0;
            double drespuestapm2 = 0;
            double drespuestapm = 0;
            double dtotaldeduccion;

            foreach (DataGridViewRow row in Dgv_empleadoscontables.Rows)
            {
                if (Convert.ToString(row.Cells["Column6"].Value) == "Percepcion")
                {
                    if (Convert.ToString(row.Cells["Column7"].Value) == "Suma")
                    {
                        prespuestaps = Convert.ToDouble(row.Cells["Column3"].Value) + Convert.ToDouble(row.Cells["Column5"].Value);
                        //  MessageBox.Show("encontro una suma");
                        // MessageBox.Show(Convert.ToString(prespuestaps));

                        prespuestaps2 = prespuestaps2 + prespuestaps;
                        //MessageBox.Show("sumando" + Convert.ToString(prespuestaps2));
                    }
                    if (Convert.ToString(row.Cells["Column7"].Value) == "Multiplicacion")
                    {
                        prespuestapm = Convert.ToDouble(row.Cells["Column3"].Value) * Convert.ToDouble(row.Cells["Column5"].Value);
                        //MessageBox.Show("encontro una multiplicacion");
                        prespuestapm2 = prespuestapm2 + prespuestapm;
                        //MessageBox.Show("multiplicando" + Convert.ToString(prespuestapm2));
                    }


                }
                else if (Convert.ToString(row.Cells["Column6"].Value) == "Deduccion")
                {
                    if (Convert.ToString(row.Cells["Column7"].Value) == "Suma")
                    {
                        drespuestaps = Convert.ToDouble(row.Cells["Column3"].Value) + Convert.ToDouble(row.Cells["Column5"].Value);
                        //MessageBox.Show("encontro una suma");
                        //MessageBox.Show(Convert.ToString(drespuestaps));

                        drespuestaps2 = drespuestaps2 + drespuestaps;
                        //MessageBox.Show("sumando" + Convert.ToString(drespuestaps2));
                    }
                    if (Convert.ToString(row.Cells["Column7"].Value) == "Multiplicacion")
                    {
                        drespuestapm = Convert.ToDouble(row.Cells["Column3"].Value) * Convert.ToDouble(row.Cells["Column5"].Value);
                        //MessageBox.Show("encontro una multiplicacion");
                        drespuestapm2 = drespuestapm2 + drespuestapm;
                        //MessageBox.Show("multiplicando" + Convert.ToString(drespuestapm2));
                    }
                }


            }

            //MessageBox.Show("sali");
            ptotalpercepcion = prespuestaps2 + prespuestapm2;
            //MessageBox.Show(Convert.ToString(ptotalpercepcion));
            Txt_SubtotalPercepciones.Text = Convert.ToString(ptotalpercepcion);

            dtotaldeduccion = drespuestaps2 + drespuestapm2;
            //MessageBox.Show(Convert.ToString(dtotaldeduccion));
            Txt_SubtotalDeducciones.Text = Convert.ToString(dtotaldeduccion);

            string sFechaIngreso = Dtp_fechainicio.Value.ToString("yyyy-MM-dd");
            string sFechaFin = Dtp_fechafin.Value.ToString("yyyy-MM-dd");

            double deducciones = Convert.ToDouble(Txt_SubtotalDeducciones.Text);
            double percepciones = Convert.ToDouble(Txt_SubtotalPercepciones.Text);
            double total = (percepciones - deducciones);
            Txt_saldonominal.Text = Convert.ToString(total);
            OdbcDataReader cita = logic.Insertarnomina(Txt_CodEncabezado.Text, Txt_tiponomina.Text, sFechaIngreso, sFechaFin, Txt_codempleado.Text, Txt_Observaciones.Text, Txt_saldonominal.Text);
            MessageBox.Show("Nomina Finalizada.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);




        }

    }
    }

