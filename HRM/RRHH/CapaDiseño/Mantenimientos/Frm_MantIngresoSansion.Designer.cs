namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantIngresoSansion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantIngresoSansion));
            this.Lbl_IngresoSansion = new System.Windows.Forms.Label();
            this.Btn_RealizarSansion = new System.Windows.Forms.Button();
            this.Gpb_IngresoDatos = new System.Windows.Forms.GroupBox();
            this.Dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FechaFinalizacion = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_RazonSansion = new System.Windows.Forms.TextBox();
            this.Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_RazonSansion = new System.Windows.Forms.Label();
            this.Lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.Gpb_Busqueda = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_CodigoEmpleado = new System.Windows.Forms.Label();
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ConsultarEmpleados = new System.Windows.Forms.Button();
            this.Gpb_IngresoDatos.SuspendLayout();
            this.Gpb_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_IngresoSansion
            // 
            this.Lbl_IngresoSansion.AutoSize = true;
            this.Lbl_IngresoSansion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_IngresoSansion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngresoSansion.ForeColor = System.Drawing.Color.White;
            this.Lbl_IngresoSansion.Location = new System.Drawing.Point(15, 11);
            this.Lbl_IngresoSansion.Name = "Lbl_IngresoSansion";
            this.Lbl_IngresoSansion.Size = new System.Drawing.Size(265, 31);
            this.Lbl_IngresoSansion.TabIndex = 32;
            this.Lbl_IngresoSansion.Text = "Ingreso de Sanción";
            // 
            // Btn_RealizarSansion
            // 
            this.Btn_RealizarSansion.Location = new System.Drawing.Point(282, 444);
            this.Btn_RealizarSansion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_RealizarSansion.Name = "Btn_RealizarSansion";
            this.Btn_RealizarSansion.Size = new System.Drawing.Size(141, 37);
            this.Btn_RealizarSansion.TabIndex = 33;
            this.Btn_RealizarSansion.Text = "Realizar Sansión";
            this.Btn_RealizarSansion.UseVisualStyleBackColor = true;
            this.Btn_RealizarSansion.Click += new System.EventHandler(this.Btn_RealizarSansion_Click);
            // 
            // Gpb_IngresoDatos
            // 
            this.Gpb_IngresoDatos.Controls.Add(this.Dtp_FechaSalida);
            this.Gpb_IngresoDatos.Controls.Add(this.Dtp_FechaIngreso);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_FechaFinalizacion);
            this.Gpb_IngresoDatos.Controls.Add(this.Txt_Descripcion);
            this.Gpb_IngresoDatos.Controls.Add(this.Txt_RazonSansion);
            this.Gpb_IngresoDatos.Controls.Add(this.Txt_NombreEmpleado);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_FechaInicio);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_Descripcion);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_RazonSansion);
            this.Gpb_IngresoDatos.Controls.Add(this.Lbl_NombreEmpleado);
            this.Gpb_IngresoDatos.Location = new System.Drawing.Point(31, 190);
            this.Gpb_IngresoDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_IngresoDatos.Name = "Gpb_IngresoDatos";
            this.Gpb_IngresoDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_IngresoDatos.Size = new System.Drawing.Size(585, 236);
            this.Gpb_IngresoDatos.TabIndex = 35;
            this.Gpb_IngresoDatos.TabStop = false;
            this.Gpb_IngresoDatos.Text = "Ingreso de Datos";
            // 
            // Dtp_FechaSalida
            // 
            this.Dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaSalida.Location = new System.Drawing.Point(251, 194);
            this.Dtp_FechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaSalida.Name = "Dtp_FechaSalida";
            this.Dtp_FechaSalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaSalida.TabIndex = 25;
            // 
            // Dtp_FechaIngreso
            // 
            this.Dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaIngreso.Location = new System.Drawing.Point(230, 153);
            this.Dtp_FechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaIngreso.Name = "Dtp_FechaIngreso";
            this.Dtp_FechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaIngreso.TabIndex = 24;
            // 
            // Lbl_FechaFinalizacion
            // 
            this.Lbl_FechaFinalizacion.AutoSize = true;
            this.Lbl_FechaFinalizacion.Location = new System.Drawing.Point(113, 199);
            this.Lbl_FechaFinalizacion.Name = "Lbl_FechaFinalizacion";
            this.Lbl_FechaFinalizacion.Size = new System.Drawing.Size(125, 17);
            this.Lbl_FechaFinalizacion.TabIndex = 23;
            this.Lbl_FechaFinalizacion.Text = "Fecha Finalización";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(216, 111);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(279, 22);
            this.Txt_Descripcion.TabIndex = 19;
            // 
            // Txt_RazonSansion
            // 
            this.Txt_RazonSansion.Location = new System.Drawing.Point(251, 71);
            this.Txt_RazonSansion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_RazonSansion.Name = "Txt_RazonSansion";
            this.Txt_RazonSansion.Size = new System.Drawing.Size(244, 22);
            this.Txt_RazonSansion.TabIndex = 18;
            // 
            // Txt_NombreEmpleado
            // 
            this.Txt_NombreEmpleado.Location = new System.Drawing.Point(244, 33);
            this.Txt_NombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NombreEmpleado.Name = "Txt_NombreEmpleado";
            this.Txt_NombreEmpleado.Size = new System.Drawing.Size(251, 22);
            this.Txt_NombreEmpleado.TabIndex = 17;
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(113, 158);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(83, 17);
            this.Lbl_FechaInicio.TabIndex = 16;
            this.Lbl_FechaInicio.Text = "Fecha Inicio";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(113, 111);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Descripcion.TabIndex = 15;
            this.Lbl_Descripcion.Text = "Descripción";
            // 
            // Lbl_RazonSansion
            // 
            this.Lbl_RazonSansion.AutoSize = true;
            this.Lbl_RazonSansion.Location = new System.Drawing.Point(113, 74);
            this.Lbl_RazonSansion.Name = "Lbl_RazonSansion";
            this.Lbl_RazonSansion.Size = new System.Drawing.Size(139, 17);
            this.Lbl_RazonSansion.TabIndex = 14;
            this.Lbl_RazonSansion.Text = "Razon de la Sanción";
            // 
            // Lbl_NombreEmpleado
            // 
            this.Lbl_NombreEmpleado.AutoSize = true;
            this.Lbl_NombreEmpleado.Location = new System.Drawing.Point(113, 33);
            this.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado";
            this.Lbl_NombreEmpleado.Size = new System.Drawing.Size(125, 17);
            this.Lbl_NombreEmpleado.TabIndex = 13;
            this.Lbl_NombreEmpleado.Text = "Nombre Empleado";
            // 
            // Gpb_Busqueda
            // 
            this.Gpb_Busqueda.Controls.Add(this.Btn_Buscar);
            this.Gpb_Busqueda.Controls.Add(this.Txt_CodigoEmpleado);
            this.Gpb_Busqueda.Controls.Add(this.Lbl_CodigoEmpleado);
            this.Gpb_Busqueda.Location = new System.Drawing.Point(244, 85);
            this.Gpb_Busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Busqueda.Name = "Gpb_Busqueda";
            this.Gpb_Busqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Busqueda.Size = new System.Drawing.Size(372, 86);
            this.Gpb_Busqueda.TabIndex = 34;
            this.Gpb_Busqueda.TabStop = false;
            this.Gpb_Busqueda.Text = "Busqueda";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(268, 43);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(85, 27);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_CodigoEmpleado
            // 
            this.Txt_CodigoEmpleado.Location = new System.Drawing.Point(130, 45);
            this.Txt_CodigoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CodigoEmpleado.Name = "Txt_CodigoEmpleado";
            this.Txt_CodigoEmpleado.Size = new System.Drawing.Size(132, 22);
            this.Txt_CodigoEmpleado.TabIndex = 1;
            // 
            // Lbl_CodigoEmpleado
            // 
            this.Lbl_CodigoEmpleado.AutoSize = true;
            this.Lbl_CodigoEmpleado.Location = new System.Drawing.Point(5, 43);
            this.Lbl_CodigoEmpleado.Name = "Lbl_CodigoEmpleado";
            this.Lbl_CodigoEmpleado.Size = new System.Drawing.Size(119, 17);
            this.Lbl_CodigoEmpleado.TabIndex = 0;
            this.Lbl_CodigoEmpleado.Text = "Codigo Empleado";
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-55, -4);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(756, 55);
            this.Pic_Barra.TabIndex = 28;
            this.Pic_Barra.TabStop = false;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(557, 5);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 38;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(508, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 37;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(607, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 36;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_ConsultarEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(31, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 86);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // Btn_ConsultarEmpleados
            // 
            this.Btn_ConsultarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultarEmpleados.Location = new System.Drawing.Point(19, 28);
            this.Btn_ConsultarEmpleados.Name = "Btn_ConsultarEmpleados";
            this.Btn_ConsultarEmpleados.Size = new System.Drawing.Size(167, 36);
            this.Btn_ConsultarEmpleados.TabIndex = 34;
            this.Btn_ConsultarEmpleados.Text = "Consultar Empleados";
            this.Btn_ConsultarEmpleados.UseVisualStyleBackColor = true;
            this.Btn_ConsultarEmpleados.Click += new System.EventHandler(this.Btn_ConsultarEmpleados_Click);
            // 
            // Frm_MantIngresoSansion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Btn_RealizarSansion);
            this.Controls.Add(this.Gpb_IngresoDatos);
            this.Controls.Add(this.Gpb_Busqueda);
            this.Controls.Add(this.Lbl_IngresoSansion);
            this.Controls.Add(this.Pic_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_MantIngresoSansion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantIngresoSansion";
            this.Gpb_IngresoDatos.ResumeLayout(false);
            this.Gpb_IngresoDatos.PerformLayout();
            this.Gpb_Busqueda.ResumeLayout(false);
            this.Gpb_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_IngresoSansion;
        private System.Windows.Forms.Button Btn_RealizarSansion;
        private System.Windows.Forms.GroupBox Gpb_IngresoDatos;
        private System.Windows.Forms.Label Lbl_FechaFinalizacion;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_RazonSansion;
        private System.Windows.Forms.TextBox Txt_NombreEmpleado;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_RazonSansion;
        private System.Windows.Forms.Label Lbl_NombreEmpleado;
        private System.Windows.Forms.GroupBox Gpb_Busqueda;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_CodigoEmpleado;
        private System.Windows.Forms.Label Lbl_CodigoEmpleado;
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DateTimePicker Dtp_FechaSalida;
        private System.Windows.Forms.DateTimePicker Dtp_FechaIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_ConsultarEmpleados;
    }
}