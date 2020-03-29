
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDiseño.Procesos;
using CapaDatos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CapaLogica;

namespace CapaDiseño.Procesos
{

    public partial class Frm_Convocatoria : Form
    {
        Logica logic = new Logica();
        public Frm_Convocatoria()
        {
            InitializeComponent();
           
        }

        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM perfil_detalle WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    DGV_PERFIL.Refresh();
                    DGV_PERFIL.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7), mostrarDatos.GetString(8));
                }
                comm.Connection.Close();
                mostrarDatos.Close();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Frm_Convocatoria_Load(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cbo_TipoC.Text = "Contratacion";
                Cbo_TipoC.Items.Clear();

                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM tipocontratacion WHERE estado='1' ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cbo_TipoC.Refresh();
                    Cbo_TipoC.Items.Add(mostrarDatos.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Cbo_MC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cbo_MC.Text = "Contratacion";
                Cbo_MC.Items.Clear();

                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM mediodecomunicacion WHERE estado='1' ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cbo_MC.Refresh();
                    Cbo_MC.Items.Add(mostrarDatos.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Convo.pdf", FileMode.Create)); // asignamos el nombre de archivo
            // Importante Abrir el documento
            doc.Open();
            // Creamos un titulo personalizado con tamaño de fuente 18 y color Azul
            Paragraph title = new Paragraph();
  
            title.Add("CONVOCATORIA DE TRABAJO ");
            doc.Add(title);
            // Agregamos un parrafo vacio como separacion.
            doc.Add(new Paragraph(" "));

            // Empezamos a crear la tabla, definimos una tabla de 6 columnas
            PdfPTable table = new PdfPTable(4);
            // Esta es la primera fila
            table.AddCell("ID Empleado Creador");
            table.AddCell("Fecha");
            table.AddCell("Tipo de Contratacion");
            table.AddCell("Medio de Comunicacion");

            // Segunda fila
            table.AddCell(Txt_Id.Text);
            table.AddCell(DTP_fEHCA.Text);
            table.AddCell(Cbo_TipoC.Text);
            table.AddCell(Cbo_MC.Text);

            // DOS LINEAS DE SEPARACION
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            title.Add("REQUISITOS");
            doc.Add(title);
            doc.Add(new Paragraph(" "));

            // Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(DGV_PERFIL.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 85;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;


            //Adding Header row
            foreach (DataGridViewColumn column in DGV_PERFIL.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in DGV_PERFIL.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }


            //Exporting to PDF
            string folderPath = "C:\\PDF\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + Txt_NombrePDF.Text + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(table);
                pdfDoc.Close();
                stream.Close();

                MessageBox.Show("El documneto ha sido creado, dirijase a la carpeta PDF en su Disco C");
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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            MostrarConsulta();  
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarEmpleado = logic.consultaayuda("18");
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
