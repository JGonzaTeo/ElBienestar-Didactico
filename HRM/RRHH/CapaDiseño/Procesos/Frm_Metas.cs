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
using CapaDiseño.Procesos;

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

            //GRÁFICA
            Ct_graficaMeta.Series["Series1"].LegendText = "Metas";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("19-FEB-2017", 576);
            dic.Add("20-FEB-2017", 1087);
            dic.Add("21-FEB-2017", 1061);
            dic.Add("22-FEB-2017", 660);
            dic.Add("23-FEB-2017", 774);

            foreach (KeyValuePair<string, int> d in dic)
            {
                Ct_graficaMeta.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }
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
                      Cells[2].Value.ToString();
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                //OdbcDataReader meta = logic.InsertarMeta(Txt_empleadosDesempeño.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SUMA PARA EL DATAGRIDVIEW
        /*
        const int columna = 5;

        int suma = 0;
        foreach (DataGridViewRow row in _grid.Rows)
        {
            suma += (int)row.Cells[columna].Value;
        }
        */

        //SELECT
        /*
         Select metas, puntaje where fkempleado=txtcod_emp.text;
        */

        //TOTAL KPI
        /*
        public decimal totalkpi;

        public void totalKpi()
        {
            //Total
            Totalkpi = totalEmpleado+suma;
            Txt_totalMeta.Text = Totalkpi.ToString();
        }
         */
    }
}
