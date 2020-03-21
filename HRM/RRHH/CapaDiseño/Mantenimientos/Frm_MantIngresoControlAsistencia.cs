﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantIngresoControlAsistencia : Form
    {
        Logica Logic = new Logica();
        public Frm_MantIngresoControlAsistencia()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoEmpleado.Text == "")
            {
                MessageBox.Show("Debe Ingresar su Codigo de Empleado");
            }
            else
            {

                OdbcDataReader ControlAsistencia = Logic.BuscarEmpleado(Txt_CodigoEmpleado.Text);
                try
                {
                    while (ControlAsistencia.Read())
                    {

                        Txt_Nombre.Text = ControlAsistencia.GetString(0);
                        Txt_Apellido.Text = ControlAsistencia.GetString(1);
                        
                    }
                    if(Txt_Nombre.Text == "")
                    {
                        MessageBox.Show("Ingrese un codito existente");
                    }
                    else
                    {
                        Txt_HoraIngreso.Text = DateTime.Now.ToLongTimeString();
                        Txt_FechaIngreso.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                    
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento se encuentra en desarollo");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_RegistrarAsistencia_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoEmpleado.Text == "" | Txt_Nombre.Text == "" | Txt_Apellido.Text == "" | Txt_FechaIngreso.Text == "" | Txt_HoraIngreso.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos Solicitados");
            }
            else
            {

                OdbcDataReader ControlAsistencia = Logic.InsertaControlAsistencia(Txt_CodigoEmpleado.Text, Txt_Nombre.Text, Txt_Apellido.Text, Txt_FechaIngreso.Text, Txt_HoraIngreso.Text);
                MessageBox.Show("Asistencia Ingresada");
                //limpiar Campos
                Txt_CodigoEmpleado.Clear();
                Txt_CodigoEmpleado.Focus();
                Txt_Nombre.Clear();
                Txt_Apellido.Clear();
                Txt_FechaIngreso.Clear();
                Txt_HoraIngreso.Clear();

            }
        }
    }
}
