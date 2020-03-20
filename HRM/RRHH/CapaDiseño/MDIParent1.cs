
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
using Desempeño;
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
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_preSeleccion);
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
        bool ventanaingresodespido = false;
        Frm_MantDespidoEmpleado despido = new Frm_MantDespidoEmpleado();
        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantDespidoEmpleado);
            if (ventanaingresodespido == false || frmC == null)
            {
                if (frmC == null)
                {
                    despido = new Frm_MantDespidoEmpleado();
                }

                despido.MdiParent = this;
                despido.Show();
                Application.DoEvents();
                ventanaingresodespido = true;
            }
            else
            {
                despido.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanacrearreunion = false;
        Frm_MantIngresoReunion ingresoreunion = new Frm_MantIngresoReunion();
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantIngresoReunion);
            if (ventanacrearreunion == false || frmC == null)
            {
                if (frmC == null)
                {
                    ingresoreunion = new Frm_MantIngresoReunion();
                }

                ingresoreunion.MdiParent = this;
                ingresoreunion.Show();
                Application.DoEvents();
                ventanacrearreunion = true;
            }
            else
            {
                ingresoreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ventanamodreunion = false;
        Frm_MantModificacionReunion modreunion = new Frm_MantModificacionReunion();
        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantModificacionReunion);
            if (ventanamodreunion == false || frmC == null)
            {
                if (frmC == null)
                {
                    modreunion = new Frm_MantModificacionReunion();
                }

                modreunion.MdiParent = this;
                modreunion.Show();
                Application.DoEvents();
                ventanamodreunion = true;
            }
            else
            {
                modreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaelimreunion = false;
        Frm_MantEliminacionReunion elimreunion = new Frm_MantEliminacionReunion();
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantEliminacionReunion);
            if (ventanaelimreunion == false || frmC == null)
            {
                if (frmC == null)
                {
                    elimreunion = new Frm_MantEliminacionReunion();
                }

                elimreunion.MdiParent = this;
                elimreunion.Show();
                Application.DoEvents();
                ventanaelimreunion = true;
            }
            else
            {
                elimreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanacrearasistencia = false;
        Frm_MantIngresoControlAsistencia crearasistencia = new Frm_MantIngresoControlAsistencia();
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantIngresoControlAsistencia);
            if (ventanacrearasistencia == false || frmC == null)
            {
                if (frmC == null)
                {
                    crearasistencia = new Frm_MantIngresoControlAsistencia();
                }

                crearasistencia.MdiParent = this;
                crearasistencia.Show();
                Application.DoEvents();
                ventanacrearasistencia = true;
            }
            else
            {
                crearasistencia.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ventanacrearsancion = false;
        Frm_MantIngresoSansion crearsancion = new Frm_MantIngresoSansion();
        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantIngresoSansion);
            if (ventanacrearsancion == false || frmC == null)
            {
                if (frmC == null)
                {
                    crearsancion = new Frm_MantIngresoSansion();
                }

                crearsancion.MdiParent = this;
                crearsancion.Show();
                Application.DoEvents();
                ventanacrearsancion = true;
            }
            else
            {
                crearsancion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaelimsancion = false;
        Frm_MantEliminacionSansion elimsancion = new Frm_MantEliminacionSansion();
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantEliminacionSansion);
            if (ventanaelimsancion == false || frmC == null)
            {
                if (frmC == null)
                {
                    elimsancion = new Frm_MantEliminacionSansion();
                }

                elimsancion.MdiParent = this;
                elimsancion.Show();
                Application.DoEvents();
                ventanaelimsancion = true;
            }
            else
            {
                elimsancion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanacontrolasistencia = false;
        Frm_ControlAsistenciaPersonal controlasistencia = new Frm_ControlAsistenciaPersonal();
        private void controlDeAsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ControlAsistenciaPersonal);
            if (ventanacontrolasistencia == false || frmC == null)
            {
                if (frmC == null)
                {
                    controlasistencia = new Frm_ControlAsistenciaPersonal();
                }

                controlasistencia.MdiParent = this;
                controlasistencia.Show();
                Application.DoEvents();
                ventanacontrolasistencia = true;
            }
            else
            {
                controlasistencia.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanasancion = false;
        Frm_SansionesEmpleados sancion = new Frm_SansionesEmpleados();
        private void sancionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_SansionesEmpleados);
            if (ventanasancion == false || frmC == null)
            {
                if (frmC == null)
                {
                    sancion = new Frm_SansionesEmpleados();
                }

                sancion.MdiParent = this;
                sancion.Show();
                Application.DoEvents();
                ventanasancion = true;
            }
            else
            {
                sancion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanaempleado = false;
        Frm_MantEmpleado empleado = new Frm_MantEmpleado();
        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantEmpleado);
            if (ventanaempleado == false || frmC == null)
            {
                if (frmC == null)
                {
                    empleado = new Frm_MantEmpleado();
                }

                empleado.MdiParent = this;
                empleado.Show();
                Application.DoEvents();
                ventanaempleado = true;
            }
            else
            {
                ingresoreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanaMC = false;
        Frm_MediodeComunicacion MC = new Frm_MediodeComunicacion();
        private void MedioDeComunicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantEmpleado);
            if (ventanaMC == false || frmC == null)
            {
                if (frmC == null)
                {
                    MC = new Frm_MediodeComunicacion();
                }

                MC.MdiParent = this;
                MC.Show();
                Application.DoEvents();
                ventanaMC = true;
            }
            else
            {
                ingresoreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanacontrato = false;
        Frm_MantTipoContratacion contrato = new Frm_MantTipoContratacion();
        private void TipoDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantEmpleado);
            if (ventanacontrato == false || frmC == null)
            {
                if (frmC == null)
                {
                    contrato = new Frm_MantTipoContratacion();
                }

                contrato.MdiParent = this;
                contrato.Show();
                Application.DoEvents();
                ventanacontrato = true;
            }
            else
            {
                ingresoreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void DespidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ControlDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        bool ventanaconvocatoria = false;
        Frm_Convocatoria convocatoria = new Frm_Convocatoria();
        private void ConvocatoriaYSeleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Convocatoria);
            if (ventanaconvocatoria == false || frmC == null)
            {
                if (frmC == null)
                {
                    convocatoria= new Frm_Convocatoria();
                }

                convocatoria.MdiParent = this;
                convocatoria.Show();
                Application.DoEvents();
                ventanaconvocatoria = true;
            }
            else
            {
                ingresoreunion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanadesempenio = false;
        Frm_DesempenioEmpleados desempenio = new Frm_DesempenioEmpleados();
        private void desempeñoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_DesempenioEmpleados);
            if (ventanadesempenio == false || frmC == null)
            {
                if (frmC == null)
                {
                    MC = new Frm_MediodeComunicacion();
                }

                desempenio.MdiParent = this;
                desempenio.Show();
                Application.DoEvents();
                ventanadesempenio = true;
            }
            else
            {
                desempenio.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanabusquedaInterna = false;
        Frm_busquedaInterna interna = new Frm_busquedaInterna();
        private void busquedaInternaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_busquedaInterna);
            if (ventanadesempenio == false || frmC == null)
            {
                if (frmC == null)
                {
                    interna = new Frm_busquedaInterna();
                }

                interna.MdiParent = this;
                interna.Show();
                Application.DoEvents();
                ventanabusquedaInterna = true;
            }
            else
            {
                interna.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCurriculum = false;
        Frm_MantCurriculum curriculum = new Frm_MantCurriculum();
        private void CurriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantCurriculum);
            if (ventanaCurriculum == false || frmC == null)
            {
                if (frmC == null)
                {
                    curriculum = new Frm_MantCurriculum();
                }

                curriculum.MdiParent = this;
                curriculum.Show();
                Application.DoEvents();
                ventanaCurriculum = true;
            }
            else
            {
                curriculum.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
    }

