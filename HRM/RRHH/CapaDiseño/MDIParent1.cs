
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseño.Mantenimientos;
using CapaDiseño.Procesos;
using CapaLogica;
using Recursos_Humanos;

namespace CapaDiseño
{
   
    public partial class MDIParent1 : Form
    {
        Logica logic = new Logica();

        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        bool ventanaConceptos = false;
        Frm_MantPercepciones conceptos = new Frm_MantPercepciones();
        private void ConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPercepciones);
            if (ventanaConceptos == false || frmC == null)
            {
                if (frmC == null)
                {
                    conceptos = new Frm_MantPercepciones();
                }

                conceptos.MdiParent = this;
                conceptos.Show();
                Application.DoEvents();
                ventanaConceptos = true;
            }
            else
            {
                conceptos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ventananomina = false;
        Frm_Nomina nomina = new Frm_Nomina();

        private void NominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Nomina);
            if (ventananomina == false || frmC == null)
            {
                if (frmC == null)
                {
                    nomina = new Frm_Nomina();
                }

                nomina.MdiParent = this;
                nomina.Show();
                Application.DoEvents();
                ventananomina = true;
            }
            else
            {
                nomina.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaasignacionconcepto = false;
        Frm_Asignaciondeconcepto asignacionconcepto = new Frm_Asignaciondeconcepto();
        private void AsignacionDeConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Asignaciondeconcepto);
            if (ventanaasignacionconcepto == false || frmC == null)
            {
                if (frmC == null)
                {
                    asignacionconcepto = new Frm_Asignaciondeconcepto();
                }

                asignacionconcepto.MdiParent = this;
                asignacionconcepto.Show();
                Application.DoEvents();
                ventanaasignacionconcepto = true;
            }
            else
            {
                asignacionconcepto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaSolicitudEmpleadoN = false;
        Frm_SolicitudEmpleadoN solicitudEmpleado = new Frm_SolicitudEmpleadoN();
        private void solicitudEmpleadoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_SolicitudEmpleadoN);
            if (ventanaSolicitudEmpleadoN == false || frmC == null)
            {
                if (frmC == null)
                {
                    solicitudEmpleado = new Frm_SolicitudEmpleadoN();
                }

                solicitudEmpleado.MdiParent = this;
                solicitudEmpleado.Show();
                Application.DoEvents();
                ventanaSolicitudEmpleadoN = true;
            }
            else
            {
                solicitudEmpleado.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMantPerfil = false;
        Frm_MantPerfiles perfiles = new Frm_MantPerfiles();
        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPerfiles);
            if (ventanaMantPerfil == false || frmC == null)
            {
                if (frmC == null)
                {
                    perfiles = new Frm_MantPerfiles();
                }

                perfiles.MdiParent = this;
                perfiles.Show();
                Application.DoEvents();
                ventanaMantPerfil = true;
            }
            else
            {
                perfiles.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaPreseleccion = false;
        Frm_preSeleccion preseleccion = new Frm_preSeleccion();
        private void PreseleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPerfiles);
            if (ventanaPreseleccion == false || frmC == null)
            {
                if (frmC == null)
                {
                    preseleccion = new Frm_preSeleccion();
                }

                preseleccion.MdiParent = this;
                preseleccion.Show();
                Application.DoEvents();
                ventanaPreseleccion = true;
            }
            else
            {
                preseleccion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
    }

