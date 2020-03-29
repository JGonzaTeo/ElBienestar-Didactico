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

namespace Recursos_Humanos
{
    public partial class Frm_filtroPreSeleccion : Form
    {
        string IDReporte;
        string[] valores = new string[7];
        string[] cambio = new string[12];
        double sueldos;
        Logica logic = new Logica();
        ToolTip ayuda_tp = new ToolTip();
        public Frm_filtroPreSeleccion(string id)
        {
            InitializeComponent();
            IDReporte = id;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_filtroPreSeleccion_Load(object sender, EventArgs e)
        {
            OdbcDataReader mostrar = logic.ConsultaLogicaPreseleccionComparacion(IDReporte);
            try
            {
                while (mostrar.Read())
                {
                    valores[0] = mostrar.GetString(0);
                    valores[1] = mostrar.GetString(1);
                    valores[2] = mostrar.GetString(2);
                    valores[3] = mostrar.GetString(3);
                    valores[4] = mostrar.GetString(4);
                    valores[5] = mostrar.GetString(5);
                    sueldos = mostrar.GetDouble(6);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            //Clasificacion segun cualidades
            OdbcDataReader clasificar = logic.ConsultaSeleccionComparacionAceptados(IDReporte);
            try
            {
                while (clasificar.Read())
                {
                   if(valores[0]== clasificar.GetInt16(0).ToString() && valores[1] == clasificar.GetInt16(1).ToString() && valores[2] == clasificar.GetInt16(2).ToString() && valores[3] == clasificar.GetInt16(3).ToString() && valores[4] == clasificar.GetInt16(4).ToString() && valores[5] == clasificar.GetInt16(5).ToString() && sueldos == clasificar.GetDouble(6))
                       Dgv_consultaAceptados.Rows.Add(clasificar.GetString(7), clasificar.GetString(8), clasificar.GetString(9), clasificar.GetInt16(0).ToString(), clasificar.GetInt16(1).ToString(), clasificar.GetInt16(2).ToString(), clasificar.GetInt16(3).ToString(), clasificar.GetInt16(4).ToString(), clasificar.GetInt16(5).ToString(), clasificar.GetDouble(6).ToString());
                    else
                        Dgv_consultaRecha.Rows.Add(clasificar.GetString(7), clasificar.GetString(8), clasificar.GetString(9), clasificar.GetInt16(0).ToString(), clasificar.GetInt16(1).ToString(), clasificar.GetInt16(2).ToString(), clasificar.GetInt16(3).ToString(), clasificar.GetInt16(4).ToString(), clasificar.GetInt16(5).ToString(), clasificar.GetDouble(6).ToString());
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Dgv_consultaRecha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Dgv_consultaAceptados.Rows.Add(Dgv_consultaRecha.Rows[e.RowIndex].Cells[0].Value, Dgv_consultaRecha.Rows[e.RowIndex].Cells[1].Value,
                Dgv_consultaRecha.Rows[e.RowIndex].Cells[2].Value, Dgv_consultaRecha.Rows[e.RowIndex].Cells[3].Value,
                Dgv_consultaRecha.Rows[e.RowIndex].Cells[4].Value, Dgv_consultaRecha.Rows[e.RowIndex].Cells[5].Value,
                Dgv_consultaRecha.Rows[e.RowIndex].Cells[6].Value, Dgv_consultaRecha.Rows[e.RowIndex].Cells[7].Value,
                Dgv_consultaRecha.Rows[e.RowIndex].Cells[8].Value, Dgv_consultaRecha.Rows[e.RowIndex].Cells[9].Value,
                Dgv_consultaRecha.Rows[e.RowIndex].Cells[9].Value);
            
            Dgv_consultaRecha.Rows.RemoveAt(Dgv_consultaRecha.CurrentRow.Index);
            }
            else
                MessageBox.Show("Debe de seleccionar un registro valido");

        }

        private void Dgv_consultaAceptados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Dgv_consultaRecha.Rows.Add(Dgv_consultaAceptados.Rows[e.RowIndex].Cells[0].Value, Dgv_consultaAceptados.Rows[e.RowIndex].Cells[1].Value,
                   Dgv_consultaAceptados.Rows[e.RowIndex].Cells[2].Value, Dgv_consultaAceptados.Rows[e.RowIndex].Cells[3].Value,
                   Dgv_consultaAceptados.Rows[e.RowIndex].Cells[4].Value, Dgv_consultaAceptados.Rows[e.RowIndex].Cells[5].Value,
                   Dgv_consultaAceptados.Rows[e.RowIndex].Cells[6].Value, Dgv_consultaAceptados.Rows[e.RowIndex].Cells[7].Value,
                   Dgv_consultaAceptados.Rows[e.RowIndex].Cells[8].Value, Dgv_consultaAceptados.Rows[e.RowIndex].Cells[9].Value,
                   Dgv_consultaAceptados.Rows[e.RowIndex].Cells[9].Value);

                Dgv_consultaAceptados.Rows.RemoveAt(Dgv_consultaAceptados.CurrentRow.Index);
            }
            else
                MessageBox.Show("Debe de seleccionar un registro valido");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaAceptados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv_consultaAceptados.Rows){
                try
                {
                  
                        OdbcDataReader banco = logic.InsertarBanco(row.Cells[0].Value.ToString());


                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Se han guardado a los candidatos en el banco de talento.");
            this.Close();
        }else
                MessageBox.Show("No se han seleccionado candidatos, por favor seleccionelos.");
        }

        private void Btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("21");
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
