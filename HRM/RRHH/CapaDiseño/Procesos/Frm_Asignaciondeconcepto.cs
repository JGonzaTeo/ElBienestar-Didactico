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
    public partial class Frm_Asignaciondeconcepto : Form
    {
        Logica logic = new Logica();

        string slocalIP;
        string smacAddresses;
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
        public Frm_Asignaciondeconcepto()
        {
            InitializeComponent();
            MostrarEmpleados();
            Txt_codemp.Visible = false;
            obtenerip();
        }

        public void MostrarEmpleados()
        {
            Dgv_consultaempleado.Rows.Clear();
            OdbcDataReader mostrarEmpleado = logic.buscarempleadocontable();
            try
            {
                while (mostrarEmpleado.Read())
                {
                    Dgv_consultaempleado.Rows.Add(mostrarEmpleado.GetString(0), mostrarEmpleado.GetString(1));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void Chk_Selecciontodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Selecciontodos.Checked == true)
            {
                foreach (DataGridViewRow row in Dgv_consultaempleado.Rows)
                {

                    row.Cells["Column3"].Value = true;
                   

                }
            }
            else
            {

                foreach (DataGridViewRow row in Dgv_consultaempleado.Rows)
                {

                    row.Cells["Column3"].Value = false;

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int indice = 0;

            foreach (DataGridViewRow row in Dgv_consultaempleado.Rows)
            {

                int siguiente = indice + 1;

                if (indice != Dgv_consultaempleado.Rows.Count - 1)
                {
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Column3"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value) == true)
                    {

                        Txt_codemp.Text = Dgv_consultaempleado.CurrentRow.Cells[0].Value.ToString();
                      
                        Dgv_consultaempleado.CurrentCell = Dgv_consultaempleado.Rows[siguiente].Cells[Dgv_consultaempleado.CurrentCell.ColumnIndex];
                        logic.insertarempleadocont(Txt_codemp.Text, Txt_codigoconcepto.Text);
                        //MessageBox.Show(consultaempconta);

                    }
                    else
                    {
                        //MessageBox.Show("No esta agregando a ningun empleado");
                        Dgv_consultaempleado.CurrentCell = Dgv_consultaempleado.Rows[siguiente].Cells[Dgv_consultaempleado.CurrentCell.ColumnIndex];



                    }

                    indice++;

                }

            }
            MessageBox.Show("Concepto asignados");

            Txt_nombreconcepto.Text = "";
            Txt_codigoconcepto.Text = "";
            chk_Selecciontodos.Checked = false;
            logic.bitacora("0", slocalIP, smacAddresses, "Usuario", "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_consultaConceptos concep = new Frm_consultaConceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_codigoconcepto.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombreconcepto.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[1].Value.ToString();

            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
