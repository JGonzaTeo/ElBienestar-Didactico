namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantIngresoControlAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantIngresoControlAsistencia));
            this.Btn_RegistrarAsistencia = new System.Windows.Forms.Button();
            this.Gpb_DatosEmpleado = new System.Windows.Forms.GroupBox();
            this.Lbl_HoraSalida = new System.Windows.Forms.Label();
            this.Lbl_FechaSalida = new System.Windows.Forms.Label();
            this.Dtp_HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_HoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_HoraIngreso = new System.Windows.Forms.Label();
            this.Lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Gpb_Ingreso = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_CodigoEmpleado = new System.Windows.Forms.Label();
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_IngresoAsistencia = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ConsultarEmpleados = new System.Windows.Forms.Button();
            this.Gpb_DatosEmpleado.SuspendLayout();
            this.Gpb_Ingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_RegistrarAsistencia
            // 
            this.Btn_RegistrarAsistencia.Location = new System.Drawing.Point(291, 485);
            this.Btn_RegistrarAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_RegistrarAsistencia.Name = "Btn_RegistrarAsistencia";
            this.Btn_RegistrarAsistencia.Size = new System.Drawing.Size(162, 54);
            this.Btn_RegistrarAsistencia.TabIndex = 21;
            this.Btn_RegistrarAsistencia.Text = "Registrar Asistencia";
            this.Btn_RegistrarAsistencia.UseVisualStyleBackColor = true;
            this.Btn_RegistrarAsistencia.Click += new System.EventHandler(this.Btn_RegistrarAsistencia_Click);
            // 
            // Gpb_DatosEmpleado
            // 
            this.Gpb_DatosEmpleado.Controls.Add(this.Lbl_HoraSalida);
            this.Gpb_DatosEmpleado.Controls.Add(this.Lbl_FechaSalida);
            this.Gpb_DatosEmpleado.Controls.Add(this.Dtp_HoraSalida);
            this.Gpb_DatosEmpleado.Controls.Add(this.Dtp_FechaSalida);
            this.Gpb_DatosEmpleado.Controls.Add(this.Dtp_HoraIngreso);
            this.Gpb_DatosEmpleado.Controls.Add(this.Dtp_FechaIngreso);
            this.Gpb_DatosEmpleado.Controls.Add(this.Txt_Apellido);
            this.Gpb_DatosEmpleado.Controls.Add(this.Txt_Nombre);
            this.Gpb_DatosEmpleado.Controls.Add(this.Lbl_HoraIngreso);
            this.Gpb_DatosEmpleado.Controls.Add(this.Lbl_FechaIngreso);
            this.Gpb_DatosEmpleado.Controls.Add(this.Lbl_Apellido);
            this.Gpb_DatosEmpleado.Controls.Add(this.Lbl_Nombre);
            this.Gpb_DatosEmpleado.Location = new System.Drawing.Point(39, 176);
            this.Gpb_DatosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_DatosEmpleado.Name = "Gpb_DatosEmpleado";
            this.Gpb_DatosEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_DatosEmpleado.Size = new System.Drawing.Size(652, 293);
            this.Gpb_DatosEmpleado.TabIndex = 23;
            this.Gpb_DatosEmpleado.TabStop = false;
            this.Gpb_DatosEmpleado.Text = "Datos Empleado";
            // 
            // Lbl_HoraSalida
            // 
            this.Lbl_HoraSalida.AutoSize = true;
            this.Lbl_HoraSalida.Location = new System.Drawing.Point(132, 245);
            this.Lbl_HoraSalida.Name = "Lbl_HoraSalida";
            this.Lbl_HoraSalida.Size = new System.Drawing.Size(102, 17);
            this.Lbl_HoraSalida.TabIndex = 13;
            this.Lbl_HoraSalida.Text = "Hora de Salida";
            // 
            // Lbl_FechaSalida
            // 
            this.Lbl_FechaSalida.AutoSize = true;
            this.Lbl_FechaSalida.Location = new System.Drawing.Point(132, 210);
            this.Lbl_FechaSalida.Name = "Lbl_FechaSalida";
            this.Lbl_FechaSalida.Size = new System.Drawing.Size(90, 17);
            this.Lbl_FechaSalida.TabIndex = 12;
            this.Lbl_FechaSalida.Text = "Fecha Salida";
            // 
            // Dtp_HoraSalida
            // 
            this.Dtp_HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_HoraSalida.Location = new System.Drawing.Point(257, 245);
            this.Dtp_HoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_HoraSalida.Name = "Dtp_HoraSalida";
            this.Dtp_HoraSalida.ShowUpDown = true;
            this.Dtp_HoraSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_HoraSalida.TabIndex = 11;
            // 
            // Dtp_FechaSalida
            // 
            this.Dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaSalida.Location = new System.Drawing.Point(257, 205);
            this.Dtp_FechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaSalida.Name = "Dtp_FechaSalida";
            this.Dtp_FechaSalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaSalida.TabIndex = 10;
            // 
            // Dtp_HoraIngreso
            // 
            this.Dtp_HoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_HoraIngreso.Location = new System.Drawing.Point(257, 166);
            this.Dtp_HoraIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_HoraIngreso.Name = "Dtp_HoraIngreso";
            this.Dtp_HoraIngreso.ShowUpDown = true;
            this.Dtp_HoraIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_HoraIngreso.TabIndex = 9;
            // 
            // Dtp_FechaIngreso
            // 
            this.Dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaIngreso.Location = new System.Drawing.Point(257, 126);
            this.Dtp_FechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaIngreso.Name = "Dtp_FechaIngreso";
            this.Dtp_FechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaIngreso.TabIndex = 8;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(210, 81);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(277, 22);
            this.Txt_Apellido.TabIndex = 7;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(210, 38);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(277, 22);
            this.Txt_Nombre.TabIndex = 6;
            // 
            // Lbl_HoraIngreso
            // 
            this.Lbl_HoraIngreso.AutoSize = true;
            this.Lbl_HoraIngreso.Location = new System.Drawing.Point(132, 171);
            this.Lbl_HoraIngreso.Name = "Lbl_HoraIngreso";
            this.Lbl_HoraIngreso.Size = new System.Drawing.Size(110, 17);
            this.Lbl_HoraIngreso.TabIndex = 4;
            this.Lbl_HoraIngreso.Text = "Hora de Ingreso";
            // 
            // Lbl_FechaIngreso
            // 
            this.Lbl_FechaIngreso.AutoSize = true;
            this.Lbl_FechaIngreso.Location = new System.Drawing.Point(132, 131);
            this.Lbl_FechaIngreso.Name = "Lbl_FechaIngreso";
            this.Lbl_FechaIngreso.Size = new System.Drawing.Size(118, 17);
            this.Lbl_FechaIngreso.TabIndex = 3;
            this.Lbl_FechaIngreso.Text = "Fecha de Ingreso";
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Location = new System.Drawing.Point(132, 81);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(58, 17);
            this.Lbl_Apellido.TabIndex = 2;
            this.Lbl_Apellido.Text = "Apellido";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(132, 38);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(58, 17);
            this.Lbl_Nombre.TabIndex = 1;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Gpb_Ingreso
            // 
            this.Gpb_Ingreso.Controls.Add(this.Btn_Buscar);
            this.Gpb_Ingreso.Controls.Add(this.Txt_CodigoEmpleado);
            this.Gpb_Ingreso.Controls.Add(this.Lbl_CodigoEmpleado);
            this.Gpb_Ingreso.Location = new System.Drawing.Point(266, 85);
            this.Gpb_Ingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Ingreso.Name = "Gpb_Ingreso";
            this.Gpb_Ingreso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Ingreso.Size = new System.Drawing.Size(425, 86);
            this.Gpb_Ingreso.TabIndex = 22;
            this.Gpb_Ingreso.TabStop = false;
            this.Gpb_Ingreso.Text = "Busqueda de Empleado";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(320, 27);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(83, 37);
            this.Btn_Buscar.TabIndex = 12;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_CodigoEmpleado
            // 
            this.Txt_CodigoEmpleado.Location = new System.Drawing.Point(141, 33);
            this.Txt_CodigoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CodigoEmpleado.Name = "Txt_CodigoEmpleado";
            this.Txt_CodigoEmpleado.Size = new System.Drawing.Size(157, 22);
            this.Txt_CodigoEmpleado.TabIndex = 5;
            // 
            // Lbl_CodigoEmpleado
            // 
            this.Lbl_CodigoEmpleado.AutoSize = true;
            this.Lbl_CodigoEmpleado.Location = new System.Drawing.Point(16, 35);
            this.Lbl_CodigoEmpleado.Name = "Lbl_CodigoEmpleado";
            this.Lbl_CodigoEmpleado.Size = new System.Drawing.Size(119, 17);
            this.Lbl_CodigoEmpleado.TabIndex = 0;
            this.Lbl_CodigoEmpleado.Text = "Codigo Empleado";
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-51, -4);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(798, 66);
            this.Pic_Barra.TabIndex = 25;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_IngresoAsistencia
            // 
            this.Lbl_IngresoAsistencia.AutoSize = true;
            this.Lbl_IngresoAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_IngresoAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngresoAsistencia.ForeColor = System.Drawing.Color.White;
            this.Lbl_IngresoAsistencia.Location = new System.Drawing.Point(11, 15);
            this.Lbl_IngresoAsistencia.Name = "Lbl_IngresoAsistencia";
            this.Lbl_IngresoAsistencia.Size = new System.Drawing.Size(295, 31);
            this.Lbl_IngresoAsistencia.TabIndex = 29;
            this.Lbl_IngresoAsistencia.Text = "Ingreso de Asistencia";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(627, 11);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 32;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(577, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 31;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(676, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 30;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_ConsultarEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(39, 85);
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
            // Frm_MantIngresoControlAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Lbl_IngresoAsistencia);
            this.Controls.Add(this.Pic_Barra);
            this.Controls.Add(this.Btn_RegistrarAsistencia);
            this.Controls.Add(this.Gpb_DatosEmpleado);
            this.Controls.Add(this.Gpb_Ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_MantIngresoControlAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantIngresoControlAsistencia";
            this.Gpb_DatosEmpleado.ResumeLayout(false);
            this.Gpb_DatosEmpleado.PerformLayout();
            this.Gpb_Ingreso.ResumeLayout(false);
            this.Gpb_Ingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_RegistrarAsistencia;
        private System.Windows.Forms.GroupBox Gpb_DatosEmpleado;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_HoraIngreso;
        private System.Windows.Forms.Label Lbl_FechaIngreso;
        private System.Windows.Forms.Label Lbl_Apellido;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.GroupBox Gpb_Ingreso;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_CodigoEmpleado;
        private System.Windows.Forms.Label Lbl_CodigoEmpleado;
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_IngresoAsistencia;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_HoraSalida;
        private System.Windows.Forms.Label Lbl_FechaSalida;
        private System.Windows.Forms.DateTimePicker Dtp_HoraSalida;
        private System.Windows.Forms.DateTimePicker Dtp_FechaSalida;
        private System.Windows.Forms.DateTimePicker Dtp_HoraIngreso;
        private System.Windows.Forms.DateTimePicker Dtp_FechaIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_ConsultarEmpleados;
    }
}