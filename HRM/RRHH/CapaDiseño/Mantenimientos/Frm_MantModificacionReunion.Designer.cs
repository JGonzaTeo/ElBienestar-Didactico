namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantModificacionReunion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantModificacionReunion));
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_ModificacionReunion = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Gpb_DatosReunion = new System.Windows.Forms.GroupBox();
            this.Lbl_HoraSalida = new System.Windows.Forms.Label();
            this.Lbl_FechaSalida = new System.Windows.Forms.Label();
            this.Dtp_HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_HoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.Lbl_HoraIngreso = new System.Windows.Forms.Label();
            this.Lbl_FechaIngreso = new System.Windows.Forms.Label();
            this.Txt_CantidadEmpleado = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_CantidadEmpleados = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Gpb_Reunion = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_NombreReunion = new System.Windows.Forms.TextBox();
            this.Lbl_NombreReunion = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.Gpb_DatosReunion.SuspendLayout();
            this.Gpb_Reunion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-3, -1);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(635, 54);
            this.Pic_Barra.TabIndex = 60;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_ModificacionReunion
            // 
            this.Lbl_ModificacionReunion.AutoSize = true;
            this.Lbl_ModificacionReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_ModificacionReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ModificacionReunion.ForeColor = System.Drawing.Color.White;
            this.Lbl_ModificacionReunion.Location = new System.Drawing.Point(8, 11);
            this.Lbl_ModificacionReunion.Name = "Lbl_ModificacionReunion";
            this.Lbl_ModificacionReunion.Size = new System.Drawing.Size(364, 31);
            this.Lbl_ModificacionReunion.TabIndex = 64;
            this.Lbl_ModificacionReunion.Text = "Modificaciones en Reunión";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(252, 507);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(120, 39);
            this.Btn_Guardar.TabIndex = 65;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Gpb_DatosReunion
            // 
            this.Gpb_DatosReunion.Controls.Add(this.Lbl_HoraSalida);
            this.Gpb_DatosReunion.Controls.Add(this.Lbl_FechaSalida);
            this.Gpb_DatosReunion.Controls.Add(this.Dtp_HoraSalida);
            this.Gpb_DatosReunion.Controls.Add(this.Dtp_FechaSalida);
            this.Gpb_DatosReunion.Controls.Add(this.Dtp_HoraIngreso);
            this.Gpb_DatosReunion.Controls.Add(this.Dtp_FechaIngreso);
            this.Gpb_DatosReunion.Controls.Add(this.Lbl_HoraIngreso);
            this.Gpb_DatosReunion.Controls.Add(this.Lbl_FechaIngreso);
            this.Gpb_DatosReunion.Controls.Add(this.Txt_CantidadEmpleado);
            this.Gpb_DatosReunion.Controls.Add(this.Txt_Descripcion);
            this.Gpb_DatosReunion.Controls.Add(this.Lbl_CantidadEmpleados);
            this.Gpb_DatosReunion.Controls.Add(this.Lbl_Descripcion);
            this.Gpb_DatosReunion.Location = new System.Drawing.Point(15, 176);
            this.Gpb_DatosReunion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_DatosReunion.Name = "Gpb_DatosReunion";
            this.Gpb_DatosReunion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_DatosReunion.Size = new System.Drawing.Size(592, 301);
            this.Gpb_DatosReunion.TabIndex = 67;
            this.Gpb_DatosReunion.TabStop = false;
            this.Gpb_DatosReunion.Text = "Datos de la Reunión";
            // 
            // Lbl_HoraSalida
            // 
            this.Lbl_HoraSalida.AutoSize = true;
            this.Lbl_HoraSalida.Location = new System.Drawing.Point(35, 195);
            this.Lbl_HoraSalida.Name = "Lbl_HoraSalida";
            this.Lbl_HoraSalida.Size = new System.Drawing.Size(117, 17);
            this.Lbl_HoraSalida.TabIndex = 51;
            this.Lbl_HoraSalida.Text = "Hora Finalización";
            // 
            // Lbl_FechaSalida
            // 
            this.Lbl_FechaSalida.AutoSize = true;
            this.Lbl_FechaSalida.Location = new System.Drawing.Point(35, 160);
            this.Lbl_FechaSalida.Name = "Lbl_FechaSalida";
            this.Lbl_FechaSalida.Size = new System.Drawing.Size(125, 17);
            this.Lbl_FechaSalida.TabIndex = 50;
            this.Lbl_FechaSalida.Text = "Fecha Finalización";
            // 
            // Dtp_HoraSalida
            // 
            this.Dtp_HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_HoraSalida.Location = new System.Drawing.Point(160, 195);
            this.Dtp_HoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_HoraSalida.Name = "Dtp_HoraSalida";
            this.Dtp_HoraSalida.ShowUpDown = true;
            this.Dtp_HoraSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_HoraSalida.TabIndex = 49;
            // 
            // Dtp_FechaSalida
            // 
            this.Dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaSalida.Location = new System.Drawing.Point(160, 155);
            this.Dtp_FechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaSalida.Name = "Dtp_FechaSalida";
            this.Dtp_FechaSalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaSalida.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaSalida.TabIndex = 48;
            // 
            // Dtp_HoraIngreso
            // 
            this.Dtp_HoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_HoraIngreso.Location = new System.Drawing.Point(160, 116);
            this.Dtp_HoraIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_HoraIngreso.Name = "Dtp_HoraIngreso";
            this.Dtp_HoraIngreso.ShowUpDown = true;
            this.Dtp_HoraIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_HoraIngreso.TabIndex = 47;
            // 
            // Dtp_FechaIngreso
            // 
            this.Dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaIngreso.Location = new System.Drawing.Point(160, 76);
            this.Dtp_FechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaIngreso.Name = "Dtp_FechaIngreso";
            this.Dtp_FechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaIngreso.TabIndex = 46;
            // 
            // Lbl_HoraIngreso
            // 
            this.Lbl_HoraIngreso.AutoSize = true;
            this.Lbl_HoraIngreso.Location = new System.Drawing.Point(35, 121);
            this.Lbl_HoraIngreso.Name = "Lbl_HoraIngreso";
            this.Lbl_HoraIngreso.Size = new System.Drawing.Size(110, 17);
            this.Lbl_HoraIngreso.TabIndex = 45;
            this.Lbl_HoraIngreso.Text = "Hora de Ingreso";
            // 
            // Lbl_FechaIngreso
            // 
            this.Lbl_FechaIngreso.AutoSize = true;
            this.Lbl_FechaIngreso.Location = new System.Drawing.Point(35, 81);
            this.Lbl_FechaIngreso.Name = "Lbl_FechaIngreso";
            this.Lbl_FechaIngreso.Size = new System.Drawing.Size(118, 17);
            this.Lbl_FechaIngreso.TabIndex = 44;
            this.Lbl_FechaIngreso.Text = "Fecha de Ingreso";
            // 
            // Txt_CantidadEmpleado
            // 
            this.Txt_CantidadEmpleado.Location = new System.Drawing.Point(177, 238);
            this.Txt_CantidadEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CantidadEmpleado.Name = "Txt_CantidadEmpleado";
            this.Txt_CantidadEmpleado.Size = new System.Drawing.Size(139, 22);
            this.Txt_CantidadEmpleado.TabIndex = 43;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(139, 36);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(420, 22);
            this.Txt_Descripcion.TabIndex = 40;
            // 
            // Lbl_CantidadEmpleados
            // 
            this.Lbl_CantidadEmpleados.AutoSize = true;
            this.Lbl_CantidadEmpleados.Location = new System.Drawing.Point(30, 241);
            this.Lbl_CantidadEmpleados.Name = "Lbl_CantidadEmpleados";
            this.Lbl_CantidadEmpleados.Size = new System.Drawing.Size(138, 17);
            this.Lbl_CantidadEmpleados.TabIndex = 38;
            this.Lbl_CantidadEmpleados.Text = "Cantidad Empleados";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(33, 38);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Descripcion.TabIndex = 33;
            this.Lbl_Descripcion.Text = "Descripción";
            // 
            // Gpb_Reunion
            // 
            this.Gpb_Reunion.Controls.Add(this.Btn_Buscar);
            this.Gpb_Reunion.Controls.Add(this.Txt_NombreReunion);
            this.Gpb_Reunion.Controls.Add(this.Lbl_NombreReunion);
            this.Gpb_Reunion.Location = new System.Drawing.Point(15, 84);
            this.Gpb_Reunion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Reunion.Name = "Gpb_Reunion";
            this.Gpb_Reunion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Reunion.Size = new System.Drawing.Size(592, 73);
            this.Gpb_Reunion.TabIndex = 66;
            this.Gpb_Reunion.TabStop = false;
            this.Gpb_Reunion.Text = "Reunión";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(464, 21);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(96, 36);
            this.Btn_Buscar.TabIndex = 47;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_NombreReunion
            // 
            this.Txt_NombreReunion.Location = new System.Drawing.Point(177, 31);
            this.Txt_NombreReunion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NombreReunion.Name = "Txt_NombreReunion";
            this.Txt_NombreReunion.Size = new System.Drawing.Size(263, 22);
            this.Txt_NombreReunion.TabIndex = 39;
            // 
            // Lbl_NombreReunion
            // 
            this.Lbl_NombreReunion.AutoSize = true;
            this.Lbl_NombreReunion.Location = new System.Drawing.Point(21, 34);
            this.Lbl_NombreReunion.Name = "Lbl_NombreReunion";
            this.Lbl_NombreReunion.Size = new System.Drawing.Size(150, 17);
            this.Lbl_NombreReunion.TabIndex = 32;
            this.Lbl_NombreReunion.Text = "Nombre de la Reunión";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(521, 5);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 70;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(472, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 69;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(571, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 68;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Frm_MantModificacionReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 575);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gpb_DatosReunion);
            this.Controls.Add(this.Gpb_Reunion);
            this.Controls.Add(this.Lbl_ModificacionReunion);
            this.Controls.Add(this.Pic_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_MantModificacionReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantModificacionReunion";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.Gpb_DatosReunion.ResumeLayout(false);
            this.Gpb_DatosReunion.PerformLayout();
            this.Gpb_Reunion.ResumeLayout(false);
            this.Gpb_Reunion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_ModificacionReunion;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.GroupBox Gpb_DatosReunion;
        private System.Windows.Forms.TextBox Txt_CantidadEmpleado;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_CantidadEmpleados;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.GroupBox Gpb_Reunion;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_NombreReunion;
        private System.Windows.Forms.Label Lbl_NombreReunion;
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
    }
}