namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantIngresoReunion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantIngresoReunion));
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_CreacionReunion = new System.Windows.Forms.Label();
            this.Gpb_Ingreso = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_CodigoEmpleado = new System.Windows.Forms.Label();
            this.Gpb_Reunion = new System.Windows.Forms.GroupBox();
            this.Lbl_HoraSalida = new System.Windows.Forms.Label();
            this.Lbl_FechaSalida = new System.Windows.Forms.Label();
            this.Dtp_HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_HoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.Lbl_HoraIngreso = new System.Windows.Forms.Label();
            this.Lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_CantidadEmpleados = new System.Windows.Forms.TextBox();
            this.Txt_DescripcionReunion = new System.Windows.Forms.TextBox();
            this.Txt_NombreReunion = new System.Windows.Forms.TextBox();
            this.Lbl_CantidadEmpleados = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.Lbl_NombreReunion = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ConsultarEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.Gpb_Ingreso.SuspendLayout();
            this.Gpb_Reunion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-8, -1);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(765, 50);
            this.Pic_Barra.TabIndex = 61;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_CreacionReunion
            // 
            this.Lbl_CreacionReunion.AutoSize = true;
            this.Lbl_CreacionReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_CreacionReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CreacionReunion.ForeColor = System.Drawing.Color.White;
            this.Lbl_CreacionReunion.Location = new System.Drawing.Point(12, 7);
            this.Lbl_CreacionReunion.Name = "Lbl_CreacionReunion";
            this.Lbl_CreacionReunion.Size = new System.Drawing.Size(287, 31);
            this.Lbl_CreacionReunion.TabIndex = 65;
            this.Lbl_CreacionReunion.Text = "Creación de Reunión";
            // 
            // Gpb_Ingreso
            // 
            this.Gpb_Ingreso.Controls.Add(this.Btn_Buscar);
            this.Gpb_Ingreso.Controls.Add(this.Txt_CodigoEmpleado);
            this.Gpb_Ingreso.Controls.Add(this.Lbl_CodigoEmpleado);
            this.Gpb_Ingreso.Location = new System.Drawing.Point(258, 74);
            this.Gpb_Ingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Ingreso.Name = "Gpb_Ingreso";
            this.Gpb_Ingreso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Ingreso.Size = new System.Drawing.Size(437, 92);
            this.Gpb_Ingreso.TabIndex = 74;
            this.Gpb_Ingreso.TabStop = false;
            this.Gpb_Ingreso.Text = "Busqueda de Empleado";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(312, 33);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(108, 38);
            this.Btn_Buscar.TabIndex = 12;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_CodigoEmpleado
            // 
            this.Txt_CodigoEmpleado.Location = new System.Drawing.Point(141, 41);
            this.Txt_CodigoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CodigoEmpleado.Name = "Txt_CodigoEmpleado";
            this.Txt_CodigoEmpleado.Size = new System.Drawing.Size(157, 22);
            this.Txt_CodigoEmpleado.TabIndex = 5;
            // 
            // Lbl_CodigoEmpleado
            // 
            this.Lbl_CodigoEmpleado.AutoSize = true;
            this.Lbl_CodigoEmpleado.Location = new System.Drawing.Point(16, 44);
            this.Lbl_CodigoEmpleado.Name = "Lbl_CodigoEmpleado";
            this.Lbl_CodigoEmpleado.Size = new System.Drawing.Size(119, 17);
            this.Lbl_CodigoEmpleado.TabIndex = 0;
            this.Lbl_CodigoEmpleado.Text = "Codigo Empleado";
            // 
            // Gpb_Reunion
            // 
            this.Gpb_Reunion.Controls.Add(this.Lbl_HoraSalida);
            this.Gpb_Reunion.Controls.Add(this.Lbl_FechaSalida);
            this.Gpb_Reunion.Controls.Add(this.Dtp_HoraSalida);
            this.Gpb_Reunion.Controls.Add(this.Dtp_FechaSalida);
            this.Gpb_Reunion.Controls.Add(this.Dtp_HoraIngreso);
            this.Gpb_Reunion.Controls.Add(this.Dtp_FechaIngreso);
            this.Gpb_Reunion.Controls.Add(this.Lbl_HoraIngreso);
            this.Gpb_Reunion.Controls.Add(this.Lbl_FechaIngreso);
            this.Gpb_Reunion.Controls.Add(this.Txt_Nombre);
            this.Gpb_Reunion.Controls.Add(this.Lbl_Nombre);
            this.Gpb_Reunion.Controls.Add(this.Txt_CantidadEmpleados);
            this.Gpb_Reunion.Controls.Add(this.Txt_DescripcionReunion);
            this.Gpb_Reunion.Controls.Add(this.Txt_NombreReunion);
            this.Gpb_Reunion.Controls.Add(this.Lbl_CantidadEmpleados);
            this.Gpb_Reunion.Controls.Add(this.LblDescripcion);
            this.Gpb_Reunion.Controls.Add(this.Lbl_NombreReunion);
            this.Gpb_Reunion.Location = new System.Drawing.Point(43, 183);
            this.Gpb_Reunion.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_Reunion.Name = "Gpb_Reunion";
            this.Gpb_Reunion.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_Reunion.Size = new System.Drawing.Size(652, 363);
            this.Gpb_Reunion.TabIndex = 73;
            this.Gpb_Reunion.TabStop = false;
            this.Gpb_Reunion.Text = "Datos para Reunión";
            // 
            // Lbl_HoraSalida
            // 
            this.Lbl_HoraSalida.AutoSize = true;
            this.Lbl_HoraSalida.Location = new System.Drawing.Point(70, 275);
            this.Lbl_HoraSalida.Name = "Lbl_HoraSalida";
            this.Lbl_HoraSalida.Size = new System.Drawing.Size(117, 17);
            this.Lbl_HoraSalida.TabIndex = 79;
            this.Lbl_HoraSalida.Text = "Hora Finalización";
            // 
            // Lbl_FechaSalida
            // 
            this.Lbl_FechaSalida.AutoSize = true;
            this.Lbl_FechaSalida.Location = new System.Drawing.Point(70, 240);
            this.Lbl_FechaSalida.Name = "Lbl_FechaSalida";
            this.Lbl_FechaSalida.Size = new System.Drawing.Size(125, 17);
            this.Lbl_FechaSalida.TabIndex = 78;
            this.Lbl_FechaSalida.Text = "Fecha Finalización";
            // 
            // Dtp_HoraSalida
            // 
            this.Dtp_HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_HoraSalida.Location = new System.Drawing.Point(195, 275);
            this.Dtp_HoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_HoraSalida.Name = "Dtp_HoraSalida";
            this.Dtp_HoraSalida.ShowUpDown = true;
            this.Dtp_HoraSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_HoraSalida.TabIndex = 77;
            // 
            // Dtp_FechaSalida
            // 
            this.Dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaSalida.Location = new System.Drawing.Point(195, 235);
            this.Dtp_FechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaSalida.Name = "Dtp_FechaSalida";
            this.Dtp_FechaSalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaSalida.TabIndex = 76;
            // 
            // Dtp_HoraIngreso
            // 
            this.Dtp_HoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_HoraIngreso.Location = new System.Drawing.Point(195, 196);
            this.Dtp_HoraIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_HoraIngreso.Name = "Dtp_HoraIngreso";
            this.Dtp_HoraIngreso.ShowUpDown = true;
            this.Dtp_HoraIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_HoraIngreso.TabIndex = 75;
            // 
            // Dtp_FechaIngreso
            // 
            this.Dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaIngreso.Location = new System.Drawing.Point(195, 156);
            this.Dtp_FechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaIngreso.Name = "Dtp_FechaIngreso";
            this.Dtp_FechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaIngreso.TabIndex = 74;
            // 
            // Lbl_HoraIngreso
            // 
            this.Lbl_HoraIngreso.AutoSize = true;
            this.Lbl_HoraIngreso.Location = new System.Drawing.Point(70, 201);
            this.Lbl_HoraIngreso.Name = "Lbl_HoraIngreso";
            this.Lbl_HoraIngreso.Size = new System.Drawing.Size(95, 17);
            this.Lbl_HoraIngreso.TabIndex = 73;
            this.Lbl_HoraIngreso.Text = "Hora de Inicio";
            // 
            // Lbl_FechaIngreso
            // 
            this.Lbl_FechaIngreso.AutoSize = true;
            this.Lbl_FechaIngreso.Location = new System.Drawing.Point(70, 161);
            this.Lbl_FechaIngreso.Name = "Lbl_FechaIngreso";
            this.Lbl_FechaIngreso.Size = new System.Drawing.Size(103, 17);
            this.Lbl_FechaIngreso.TabIndex = 72;
            this.Lbl_FechaIngreso.Text = "Fecha de Inicio";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(215, 32);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(369, 22);
            this.Txt_Nombre.TabIndex = 71;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(70, 36);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(125, 17);
            this.Lbl_Nombre.TabIndex = 70;
            this.Lbl_Nombre.Text = "Nombre Empleado";
            // 
            // Txt_CantidadEmpleados
            // 
            this.Txt_CantidadEmpleados.Location = new System.Drawing.Point(215, 319);
            this.Txt_CantidadEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CantidadEmpleados.Name = "Txt_CantidadEmpleados";
            this.Txt_CantidadEmpleados.Size = new System.Drawing.Size(139, 22);
            this.Txt_CantidadEmpleados.TabIndex = 58;
            // 
            // Txt_DescripcionReunion
            // 
            this.Txt_DescripcionReunion.Location = new System.Drawing.Point(181, 119);
            this.Txt_DescripcionReunion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_DescripcionReunion.Name = "Txt_DescripcionReunion";
            this.Txt_DescripcionReunion.Size = new System.Drawing.Size(420, 22);
            this.Txt_DescripcionReunion.TabIndex = 55;
            // 
            // Txt_NombreReunion
            // 
            this.Txt_NombreReunion.Location = new System.Drawing.Point(226, 81);
            this.Txt_NombreReunion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NombreReunion.Name = "Txt_NombreReunion";
            this.Txt_NombreReunion.Size = new System.Drawing.Size(369, 22);
            this.Txt_NombreReunion.TabIndex = 54;
            // 
            // Lbl_CantidadEmpleados
            // 
            this.Lbl_CantidadEmpleados.AutoSize = true;
            this.Lbl_CantidadEmpleados.Location = new System.Drawing.Point(69, 319);
            this.Lbl_CantidadEmpleados.Name = "Lbl_CantidadEmpleados";
            this.Lbl_CantidadEmpleados.Size = new System.Drawing.Size(138, 17);
            this.Lbl_CantidadEmpleados.TabIndex = 53;
            this.Lbl_CantidadEmpleados.Text = "Cantidad Empleados";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(70, 119);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LblDescripcion.TabIndex = 48;
            this.LblDescripcion.Text = "Descripción";
            // 
            // Lbl_NombreReunion
            // 
            this.Lbl_NombreReunion.AutoSize = true;
            this.Lbl_NombreReunion.Location = new System.Drawing.Point(70, 81);
            this.Lbl_NombreReunion.Name = "Lbl_NombreReunion";
            this.Lbl_NombreReunion.Size = new System.Drawing.Size(150, 17);
            this.Lbl_NombreReunion.TabIndex = 47;
            this.Lbl_NombreReunion.Text = "Nombre de la Reunión";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(329, 575);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(148, 48);
            this.Btn_Guardar.TabIndex = 72;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(651, 7);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 77;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(601, 7);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 76;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(700, 7);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 75;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_ConsultarEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(43, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 86);
            this.groupBox1.TabIndex = 78;
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
            // Frm_MantIngresoReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Gpb_Ingreso);
            this.Controls.Add(this.Gpb_Reunion);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Lbl_CreacionReunion);
            this.Controls.Add(this.Pic_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_MantIngresoReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantIngresoReunion";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.Gpb_Ingreso.ResumeLayout(false);
            this.Gpb_Ingreso.PerformLayout();
            this.Gpb_Reunion.ResumeLayout(false);
            this.Gpb_Reunion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_CreacionReunion;
        private System.Windows.Forms.GroupBox Gpb_Ingreso;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_CodigoEmpleado;
        private System.Windows.Forms.Label Lbl_CodigoEmpleado;
        private System.Windows.Forms.GroupBox Gpb_Reunion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_CantidadEmpleados;
        private System.Windows.Forms.TextBox Txt_DescripcionReunion;
        private System.Windows.Forms.TextBox Txt_NombreReunion;
        private System.Windows.Forms.Label Lbl_CantidadEmpleados;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label Lbl_NombreReunion;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_HoraSalida;
        private System.Windows.Forms.Label Lbl_FechaSalida;
        private System.Windows.Forms.DateTimePicker Dtp_HoraSalida;
        private System.Windows.Forms.DateTimePicker Dtp_FechaSalida;
        private System.Windows.Forms.DateTimePicker Dtp_HoraIngreso;
        private System.Windows.Forms.DateTimePicker Dtp_FechaIngreso;
        private System.Windows.Forms.Label Lbl_HoraIngreso;
        private System.Windows.Forms.Label Lbl_FechaIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_ConsultarEmpleados;
    }
}