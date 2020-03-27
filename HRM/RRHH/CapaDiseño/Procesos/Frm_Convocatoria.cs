﻿
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


namespace CapaDiseño.Procesos
{

    public partial class Frm_Convocatoria : Form
    {

        public Frm_Convocatoria()
        {
            InitializeComponent();
           
        }

        public void MostrarConsulta()
        {
            try
            {
                Conexion conexion = new Conexion();
                string consultaMostrar = "SELECT * FROM tbl_solicitud_empleado_detalle WHERE estado='1';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    DGV_PERFIL.Refresh();
                    DGV_PERFIL.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7), mostrarDatos.GetString(8),
                         mostrarDatos.GetString(9));
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
            PdfWriter.GetInstance(doc, new FileStream("Convocatoria.pdf", FileMode.Create)); // asignamos el nombre de archivo
            // Importante Abrir el documento
            doc.Open();
            // Creamos un titulo personalizado con tamaño de fuente 18 y color Azul
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLUE);
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
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in DGV_PERFIL.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in DGV_PERFIL.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(table);
                pdfDoc.Close();
                stream.Close();
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
    }
}
