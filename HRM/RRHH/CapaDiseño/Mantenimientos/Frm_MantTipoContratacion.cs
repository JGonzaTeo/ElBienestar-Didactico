﻿using CapaDiseño.Consulta;
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

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantTipoContratacion : Form
    {
        Logica logic = new Logica();
        public Frm_MantTipoContratacion()
        {
            InitializeComponent();
        }

        private void Frm_MantTipoContratacion_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pic_Insertar_Click(object sender, EventArgs e)
        {
            Txt_Codigo.Enabled = true;
            Cbo_Contrato.Enabled = true;
            Cbo_Estado.Enabled = true;
            Cbo_Mes.Enabled = true;
            Cbo_Proyecto.Enabled = true;
        }

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarTC(Txt_Codigo.Text,Cbo_Contrato.Text,Cbo_Mes.Text,Cbo_Proyecto.Text, Cbo_Estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Pic_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarMC(Cbo_Contrato.Text, Cbo_Mes.Text, Cbo_Proyecto.Text, Cbo_Estado.Text);
            MessageBox.Show("Datos insertar correctamente.");
        }

        private void Pic_Borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarEmpleado(Txt_Codigo.Text);
            MessageBox.Show("Eliminado Correctamente.");
        }
    }
}
