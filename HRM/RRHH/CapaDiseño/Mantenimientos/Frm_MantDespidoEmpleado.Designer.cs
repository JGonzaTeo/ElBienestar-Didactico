namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantDespidoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantDespidoEmpleado));
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_Despido = new System.Windows.Forms.Label();
            this.Btn_RealizarDespido = new System.Windows.Forms.Button();
            this.Gpb_DatosDespido = new System.Windows.Forms.GroupBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_RazonDespido = new System.Windows.Forms.TextBox();
            this.Txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_RazonDespido = new System.Windows.Forms.Label();
            this.Lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.Gpb_Busqueda = new System.Windows.Forms.GroupBox();
            this.Txt_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_CodigoEmpleado = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.Gpb_DatosDespido.SuspendLayout();
            this.Gpb_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-1, -2);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(615, 62);
            this.Pic_Barra.TabIndex = 21;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_Despido
            // 
            this.Lbl_Despido.AutoSize = true;
            this.Lbl_Despido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_Despido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Despido.ForeColor = System.Drawing.Color.White;
            this.Lbl_Despido.Location = new System.Drawing.Point(29, 11);
            this.Lbl_Despido.Name = "Lbl_Despido";
            this.Lbl_Despido.Size = new System.Drawing.Size(121, 31);
            this.Lbl_Despido.TabIndex = 25;
            this.Lbl_Despido.Text = "Despido";
            // 
            // Btn_RealizarDespido
            // 
            this.Btn_RealizarDespido.Location = new System.Drawing.Point(229, 421);
            this.Btn_RealizarDespido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_RealizarDespido.Name = "Btn_RealizarDespido";
            this.Btn_RealizarDespido.Size = new System.Drawing.Size(144, 38);
            this.Btn_RealizarDespido.TabIndex = 26;
            this.Btn_RealizarDespido.Text = "Realizar Despido";
            this.Btn_RealizarDespido.UseVisualStyleBackColor = true;
            this.Btn_RealizarDespido.Click += new System.EventHandler(this.Btn_RealizarDespido_Click);
            // 
            // Gpb_DatosDespido
            // 
            this.Gpb_DatosDespido.Controls.Add(this.Dtp_FechaIngreso);
            this.Gpb_DatosDespido.Controls.Add(this.Txt_Descripcion);
            this.Gpb_DatosDespido.Controls.Add(this.Txt_RazonDespido);
            this.Gpb_DatosDespido.Controls.Add(this.Txt_NombreEmpleado);
            this.Gpb_DatosDespido.Controls.Add(this.Lbl_Fecha);
            this.Gpb_DatosDespido.Controls.Add(this.Lbl_Descripcion);
            this.Gpb_DatosDespido.Controls.Add(this.Lbl_RazonDespido);
            this.Gpb_DatosDespido.Controls.Add(this.Lbl_NombreEmpleado);
            this.Gpb_DatosDespido.Location = new System.Drawing.Point(39, 190);
            this.Gpb_DatosDespido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_DatosDespido.Name = "Gpb_DatosDespido";
            this.Gpb_DatosDespido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_DatosDespido.Size = new System.Drawing.Size(540, 215);
            this.Gpb_DatosDespido.TabIndex = 28;
            this.Gpb_DatosDespido.TabStop = false;
            this.Gpb_DatosDespido.Text = "Datos para Despido";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(129, 121);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(279, 22);
            this.Txt_Descripcion.TabIndex = 9;
            // 
            // Txt_RazonDespido
            // 
            this.Txt_RazonDespido.Location = new System.Drawing.Point(164, 80);
            this.Txt_RazonDespido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_RazonDespido.Name = "Txt_RazonDespido";
            this.Txt_RazonDespido.Size = new System.Drawing.Size(243, 22);
            this.Txt_RazonDespido.TabIndex = 8;
            // 
            // Txt_NombreEmpleado
            // 
            this.Txt_NombreEmpleado.Location = new System.Drawing.Point(164, 42);
            this.Txt_NombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_NombreEmpleado.Name = "Txt_NombreEmpleado";
            this.Txt_NombreEmpleado.Size = new System.Drawing.Size(243, 22);
            this.Txt_NombreEmpleado.TabIndex = 5;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(35, 167);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(31, 121);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripción";
            // 
            // Lbl_RazonDespido
            // 
            this.Lbl_RazonDespido.AutoSize = true;
            this.Lbl_RazonDespido.Location = new System.Drawing.Point(31, 84);
            this.Lbl_RazonDespido.Name = "Lbl_RazonDespido";
            this.Lbl_RazonDespido.Size = new System.Drawing.Size(128, 17);
            this.Lbl_RazonDespido.TabIndex = 2;
            this.Lbl_RazonDespido.Text = "Razon del Despido";
            // 
            // Lbl_NombreEmpleado
            // 
            this.Lbl_NombreEmpleado.AutoSize = true;
            this.Lbl_NombreEmpleado.Location = new System.Drawing.Point(31, 42);
            this.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado";
            this.Lbl_NombreEmpleado.Size = new System.Drawing.Size(125, 17);
            this.Lbl_NombreEmpleado.TabIndex = 0;
            this.Lbl_NombreEmpleado.Text = "Nombre Empleado";
            // 
            // Gpb_Busqueda
            // 
            this.Gpb_Busqueda.Controls.Add(this.Txt_CodigoEmpleado);
            this.Gpb_Busqueda.Controls.Add(this.Btn_Buscar);
            this.Gpb_Busqueda.Controls.Add(this.Lbl_CodigoEmpleado);
            this.Gpb_Busqueda.Location = new System.Drawing.Point(36, 81);
            this.Gpb_Busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Busqueda.Name = "Gpb_Busqueda";
            this.Gpb_Busqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Busqueda.Size = new System.Drawing.Size(543, 89);
            this.Gpb_Busqueda.TabIndex = 27;
            this.Gpb_Busqueda.TabStop = false;
            this.Gpb_Busqueda.Text = "Busqueda";
            // 
            // Txt_CodigoEmpleado
            // 
            this.Txt_CodigoEmpleado.Location = new System.Drawing.Point(163, 33);
            this.Txt_CodigoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CodigoEmpleado.Name = "Txt_CodigoEmpleado";
            this.Txt_CodigoEmpleado.Size = new System.Drawing.Size(247, 22);
            this.Txt_CodigoEmpleado.TabIndex = 7;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(429, 30);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 6;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_CodigoEmpleado
            // 
            this.Lbl_CodigoEmpleado.AutoSize = true;
            this.Lbl_CodigoEmpleado.Location = new System.Drawing.Point(37, 36);
            this.Lbl_CodigoEmpleado.Name = "Lbl_CodigoEmpleado";
            this.Lbl_CodigoEmpleado.Size = new System.Drawing.Size(119, 17);
            this.Lbl_CodigoEmpleado.TabIndex = 1;
            this.Lbl_CodigoEmpleado.Text = "Codigo Empleado";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(505, 11);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 10;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(456, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 9;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(555, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Dtp_FechaIngreso
            // 
            this.Dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaIngreso.Location = new System.Drawing.Point(129, 162);
            this.Dtp_FechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_FechaIngreso.Name = "Dtp_FechaIngreso";
            this.Dtp_FechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtp_FechaIngreso.Size = new System.Drawing.Size(265, 22);
            this.Dtp_FechaIngreso.TabIndex = 10;
            // 
            // Frm_MantDespidoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 480);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.Btn_RealizarDespido);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.Gpb_DatosDespido);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Gpb_Busqueda);
            this.Controls.Add(this.Lbl_Despido);
            this.Controls.Add(this.Pic_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_MantDespidoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantDespidoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.Gpb_DatosDespido.ResumeLayout(false);
            this.Gpb_DatosDespido.PerformLayout();
            this.Gpb_Busqueda.ResumeLayout(false);
            this.Gpb_Busqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_Despido;
        private System.Windows.Forms.Button Btn_RealizarDespido;
        private System.Windows.Forms.GroupBox Gpb_DatosDespido;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_RazonDespido;
        private System.Windows.Forms.TextBox Txt_NombreEmpleado;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_RazonDespido;
        private System.Windows.Forms.Label Lbl_NombreEmpleado;
        private System.Windows.Forms.GroupBox Gpb_Busqueda;
        private System.Windows.Forms.TextBox Txt_CodigoEmpleado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_CodigoEmpleado;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DateTimePicker Dtp_FechaIngreso;
    }
}