namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantTipoContratacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantTipoContratacion));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.Label_MantEmpleados = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Label_Estado = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            this.Cbo_Contrato = new System.Windows.Forms.ComboBox();
            this.Cbo_Proyecto = new System.Windows.Forms.Label();
            this.Label_xMes = new System.Windows.Forms.Label();
            this.Label_xContrato = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.Label_MantEmpleados);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(970, 51);
            this.Pnl_nombreForm.TabIndex = 3;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(862, 11);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Label_MantEmpleados
            // 
            this.Label_MantEmpleados.AutoSize = true;
            this.Label_MantEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MantEmpleados.ForeColor = System.Drawing.Color.White;
            this.Label_MantEmpleados.Location = new System.Drawing.Point(19, 15);
            this.Label_MantEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_MantEmpleados.Name = "Label_MantEmpleados";
            this.Label_MantEmpleados.Size = new System.Drawing.Size(371, 20);
            this.Label_MantEmpleados.TabIndex = 0;
            this.Label_MantEmpleados.Text = "MANTENIMIENTO DE TIPO CONTRATACION";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(825, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(899, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_Estado);
            this.groupBox1.Controls.Add(this.Label_Estado);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.Cbo_Mes);
            this.groupBox1.Controls.Add(this.Cbo_Contrato);
            this.groupBox1.Controls.Add(this.Cbo_Proyecto);
            this.groupBox1.Controls.Add(this.Label_xMes);
            this.groupBox1.Controls.Add(this.Label_xContrato);
            this.groupBox1.Controls.Add(this.Txt_Codigo);
            this.groupBox1.Controls.Add(this.Label_Codigo);
            this.groupBox1.Location = new System.Drawing.Point(72, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 152);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(515, 24);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(167, 21);
            this.Cbo_Estado.TabIndex = 18;
            // 
            // Label_Estado
            // 
            this.Label_Estado.AutoSize = true;
            this.Label_Estado.Location = new System.Drawing.Point(460, 27);
            this.Label_Estado.Name = "Label_Estado";
            this.Label_Estado.Size = new System.Drawing.Size(40, 13);
            this.Label_Estado.TabIndex = 17;
            this.Label_Estado.Text = "Estado";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(654, 97);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Location = new System.Drawing.Point(365, 96);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(167, 21);
            this.Cbo_Mes.TabIndex = 15;
            // 
            // Cbo_Contrato
            // 
            this.Cbo_Contrato.FormattingEnabled = true;
            this.Cbo_Contrato.Location = new System.Drawing.Point(100, 96);
            this.Cbo_Contrato.Name = "Cbo_Contrato";
            this.Cbo_Contrato.Size = new System.Drawing.Size(178, 21);
            this.Cbo_Contrato.TabIndex = 14;
            // 
            // Cbo_Proyecto
            // 
            this.Cbo_Proyecto.AutoSize = true;
            this.Cbo_Proyecto.Location = new System.Drawing.Point(580, 100);
            this.Cbo_Proyecto.Name = "Cbo_Proyecto";
            this.Cbo_Proyecto.Size = new System.Drawing.Size(68, 13);
            this.Cbo_Proyecto.TabIndex = 12;
            this.Cbo_Proyecto.Text = "Por Proyecto";
            // 
            // Label_xMes
            // 
            this.Label_xMes.AutoSize = true;
            this.Label_xMes.Location = new System.Drawing.Point(313, 100);
            this.Label_xMes.Name = "Label_xMes";
            this.Label_xMes.Size = new System.Drawing.Size(46, 13);
            this.Label_xMes.TabIndex = 10;
            this.Label_xMes.Text = "Por Mes";
            // 
            // Label_xContrato
            // 
            this.Label_xContrato.AutoSize = true;
            this.Label_xContrato.Location = new System.Drawing.Point(17, 100);
            this.Label_xContrato.Name = "Label_xContrato";
            this.Label_xContrato.Size = new System.Drawing.Size(66, 13);
            this.Label_xContrato.TabIndex = 8;
            this.Label_xContrato.Text = "Por Contrato";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(231, 28);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(182, 20);
            this.Txt_Codigo.TabIndex = 7;
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.AutoSize = true;
            this.Label_Codigo.Location = new System.Drawing.Point(168, 31);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.Size = new System.Drawing.Size(40, 13);
            this.Label_Codigo.TabIndex = 6;
            this.Label_Codigo.Text = "Codigo";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(597, 64);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(110, 89);
            this.Btn_consultar.TabIndex = 91;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(513, 64);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(86, 89);
            this.Btn_borrar.TabIndex = 90;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(429, 64);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(86, 89);
            this.Btn_guardar.TabIndex = 89;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(345, 64);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(86, 89);
            this.Btn_editar.TabIndex = 88;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(261, 64);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(86, 89);
            this.Btn_ingresar.TabIndex = 87;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Frm_MantTipoContratacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 340);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MantTipoContratacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantTipoContratacion";
            this.Load += new System.EventHandler(this.Frm_MantTipoContratacion_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Label Label_MantEmpleados;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_xMes;
        private System.Windows.Forms.Label Label_xContrato;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Label_Codigo;
        private System.Windows.Forms.Label Cbo_Proyecto;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox Cbo_Mes;
        private System.Windows.Forms.ComboBox Cbo_Contrato;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label Label_Estado;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
    }
}