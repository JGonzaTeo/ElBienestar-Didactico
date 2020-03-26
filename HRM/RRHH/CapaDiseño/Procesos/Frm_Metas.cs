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
using CapaDiseño.Consulta;
using Desempeño;
using System.Collections;

namespace Metas
{
    public partial class Frm_Metas : Form
    {
        Logica logic = new Logica();
        
        public Frm_Metas()
        {
            InitializeComponent();

            //FECHA DEL DÍA
            DateTime fechaHoy = DateTime.Now;
            string fechaEvaluacion = fechaHoy.ToString("yyyy/MM/dd");
            Txt_fechaMeta.Text = fechaEvaluacion;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Frm_consultaEmpleado des = new Frm_consultaEmpleado();
            des.ShowDialog();

            if (des.DialogResult == DialogResult.OK)
            {
                Txt_empleadoMeta.Text = des.Dgv_consultaEmpleado.Rows[des.Dgv_consultaEmpleado.CurrentRow.Index].
                      Cells[1].Value.ToString();
            }
        }

        ArrayList Punto = new ArrayList();
        ArrayList Fecha = new ArrayList();
        private void Ct_graficaMeta_Click(object sender, EventArgs e)
        {
            Ct_graficaMeta.Series["Series1"].LegendText = "Metas";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(Txt_fechaMeta.Text, int.Parse(Txt_totalMeta.Text));
            
            foreach (KeyValuePair<string, int> d in dic)
            {
                Ct_graficaMeta.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
        }

        public int suma = 0;
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_Metas des = new Frm_Metas();
            //
            Txt_codigoMeta.Clear();
            Txt_nombreMeta.Clear();
            Cob_tipoMeta.Items.Clear();
            Txt_descripcion.Clear();
            Cob_completado.Items.Clear();
            //
            try
            {
                OdbcDataReader meta = logic.InsertarMeta(Txt_nombreMeta.ToString(),Cob_tipoMeta.ToString(), Txt_descripcion.ToString(),
                    Cob_completado.ToString(),Txt_fechaMeta.ToString(),Nud_puntajeMeta.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
            if (Dgv_vistaMeta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv_vistaMeta.Rows)
                {
                    try
                    {
                        OdbcDataReader aptos = logic.InsertarMeta(Txt_nombreMeta.ToString(), Cob_tipoMeta.ToString(), 
                            Txt_descripcion.ToString(), Cob_completado.ToString(), Txt_fechaMeta.ToString(), 
                            Nud_puntajeMeta.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Se han guardado.");
                
                Txt_empleadoMeta.Text = des.Dgv_vistaMeta.Rows[des.Dgv_vistaMeta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombreMeta.Text = des.Dgv_vistaMeta.Rows[des.Dgv_vistaMeta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Nud_puntajeMeta.Text = des.Dgv_vistaMeta.Rows[des.Dgv_vistaMeta.CurrentRow.Index].
                      Cells[2].Value.ToString();
            }
            else
                MessageBox.Show("No se han llenado los campos.");
            //SUMA DE LA COLUMNA DEL DATA GRID
            const int columna = 2;

            foreach (DataGridViewRow row in Dgv_vistaMeta.Rows)
            {
                suma += (int)row.Cells[columna].Value;
            }
        }

        public decimal Totalkpi;
        public string TKM;
        public void totalKpi()
        {
            //Total
            decimal totalMeta = Convert.ToDecimal(TKM);
            Txt_totalMeta.Text = TKM.ToString() + suma;

            //Totalkpi = TKM.ToString + suma;
            Txt_totalMeta.Text = Totalkpi.ToString();
        }

        private void cambioValor(object sender, EventArgs e)
        {
            totalKpi();
        }

        private void Txt_empleadoMeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_totalMeta_TextChanged(object sender, EventArgs e)
        {
            Txt_totalMeta.Enabled = false;
        }
    }
}