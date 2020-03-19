namespace CapaDiseño
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reunionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeConceptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudEmpleadoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preseleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeAsistenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sancionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desempeñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(923, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolsMenu
            // 
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(90, 20);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMenu,
            this.cerrarToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(923, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceptosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.despidoToolStripMenuItem,
            this.reunionToolStripMenuItem,
            this.controlDeAsistenciaToolStripMenuItem,
            this.sancionToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // conceptosToolStripMenuItem
            // 
            this.conceptosToolStripMenuItem.Name = "conceptosToolStripMenuItem";
            this.conceptosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.conceptosToolStripMenuItem.Text = "Conceptos";
            this.conceptosToolStripMenuItem.Click += new System.EventHandler(this.ConceptosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // despidoToolStripMenuItem
            // 
            this.despidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem});
            this.despidoToolStripMenuItem.Name = "despidoToolStripMenuItem";
            this.despidoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.despidoToolStripMenuItem.Text = "Despido";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // reunionToolStripMenuItem
            // 
            this.reunionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificacionToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.reunionToolStripMenuItem.Name = "reunionToolStripMenuItem";
            this.reunionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.reunionToolStripMenuItem.Text = "Reunion";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificacionToolStripMenuItem.Text = "Modificar";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // controlDeAsistenciaToolStripMenuItem
            // 
            this.controlDeAsistenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem});
            this.controlDeAsistenciaToolStripMenuItem.Name = "controlDeAsistenciaToolStripMenuItem";
            this.controlDeAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.controlDeAsistenciaToolStripMenuItem.Text = "Control de Asistencia";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // sancionToolStripMenuItem
            // 
            this.sancionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.sancionToolStripMenuItem.Name = "sancionToolStripMenuItem";
            this.sancionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sancionToolStripMenuItem.Text = "Sancion";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominaToolStripMenuItem,
            this.asignacionDeConceptoToolStripMenuItem,
            this.solicitudEmpleadoNuevoToolStripMenuItem,
            this.preseleccionToolStripMenuItem,
            this.controlDeAsistenciaToolStripMenuItem1,
            this.sancionToolStripMenuItem1,
            this.desempeñoToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.nominaToolStripMenuItem.Text = "Nomina";
            this.nominaToolStripMenuItem.Click += new System.EventHandler(this.NominaToolStripMenuItem_Click);
            // 
            // asignacionDeConceptoToolStripMenuItem
            // 
            this.asignacionDeConceptoToolStripMenuItem.Name = "asignacionDeConceptoToolStripMenuItem";
            this.asignacionDeConceptoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.asignacionDeConceptoToolStripMenuItem.Text = "Asignacion de concepto";
            this.asignacionDeConceptoToolStripMenuItem.Click += new System.EventHandler(this.AsignacionDeConceptoToolStripMenuItem_Click);
            // 
            // solicitudEmpleadoNuevoToolStripMenuItem
            // 
            this.solicitudEmpleadoNuevoToolStripMenuItem.Name = "solicitudEmpleadoNuevoToolStripMenuItem";
            this.solicitudEmpleadoNuevoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.solicitudEmpleadoNuevoToolStripMenuItem.Text = "Solicitud Empleado Nuevo";
            this.solicitudEmpleadoNuevoToolStripMenuItem.Click += new System.EventHandler(this.solicitudEmpleadoNuevoToolStripMenuItem_Click);
            // 
            // preseleccionToolStripMenuItem
            // 
            this.preseleccionToolStripMenuItem.Name = "preseleccionToolStripMenuItem";
            this.preseleccionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.preseleccionToolStripMenuItem.Text = "Preseleccion";
            this.preseleccionToolStripMenuItem.Click += new System.EventHandler(this.PreseleccionToolStripMenuItem_Click);
            // 
            // controlDeAsistenciaToolStripMenuItem1
            // 
            this.controlDeAsistenciaToolStripMenuItem1.Name = "controlDeAsistenciaToolStripMenuItem1";
            this.controlDeAsistenciaToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.controlDeAsistenciaToolStripMenuItem1.Text = "Control de Asistencia";
            this.controlDeAsistenciaToolStripMenuItem1.Click += new System.EventHandler(this.controlDeAsistenciaToolStripMenuItem1_Click);
            // 
            // sancionToolStripMenuItem1
            // 
            this.sancionToolStripMenuItem1.Name = "sancionToolStripMenuItem1";
            this.sancionToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.sancionToolStripMenuItem1.Text = "Sancion";
            this.sancionToolStripMenuItem1.Click += new System.EventHandler(this.sancionToolStripMenuItem1_Click);
            // 
            // desempeñoToolStripMenuItem
            // 
            this.desempeñoToolStripMenuItem.Name = "desempeñoToolStripMenuItem";
            this.desempeñoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.desempeñoToolStripMenuItem.Text = "Desempeño";
            this.desempeñoToolStripMenuItem.Click += new System.EventHandler(this.desempeñoToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(923, 609);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeConceptoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudEmpleadoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preseleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reunionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controlDeAsistenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sancionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem desempeñoToolStripMenuItem;
    }
}



