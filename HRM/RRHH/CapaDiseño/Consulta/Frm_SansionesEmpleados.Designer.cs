namespace CapaDiseño.Procesos
{
    partial class Frm_SansionesEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SansionesEmpleados));
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_SansionesPersonal = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgv_SancionEmpleado = new System.Windows.Forms.DataGridView();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secundaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bachillerato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SancionEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-3, -2);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(1159, 50);
            this.Pic_Barra.TabIndex = 25;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_SansionesPersonal
            // 
            this.Lbl_SansionesPersonal.AutoSize = true;
            this.Lbl_SansionesPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_SansionesPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SansionesPersonal.ForeColor = System.Drawing.Color.White;
            this.Lbl_SansionesPersonal.Location = new System.Drawing.Point(21, 7);
            this.Lbl_SansionesPersonal.Name = "Lbl_SansionesPersonal";
            this.Lbl_SansionesPersonal.Size = new System.Drawing.Size(320, 31);
            this.Lbl_SansionesPersonal.TabIndex = 29;
            this.Lbl_SansionesPersonal.Text = "Sanciones del Personal";
            this.Lbl_SansionesPersonal.UseMnemonic = false;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(844, 422);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 85;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Dgv_SancionEmpleado
            // 
            this.Dgv_SancionEmpleado.AllowUserToAddRows = false;
            this.Dgv_SancionEmpleado.AllowUserToDeleteRows = false;
            this.Dgv_SancionEmpleado.AllowUserToResizeColumns = false;
            this.Dgv_SancionEmpleado.AllowUserToResizeRows = false;
            this.Dgv_SancionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SancionEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.CODP,
            this.primaria,
            this.secundaria,
            this.bachillerato,
            this.eU,
            this.Estado});
            this.Dgv_SancionEmpleado.Location = new System.Drawing.Point(28, 86);
            this.Dgv_SancionEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_SancionEmpleado.Name = "Dgv_SancionEmpleado";
            this.Dgv_SancionEmpleado.RowHeadersVisible = false;
            this.Dgv_SancionEmpleado.RowHeadersWidth = 51;
            this.Dgv_SancionEmpleado.RowTemplate.Height = 24;
            this.Dgv_SancionEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_SancionEmpleado.Size = new System.Drawing.Size(1007, 297);
            this.Dgv_SancionEmpleado.TabIndex = 84;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(964, 5);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 89;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(915, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 88;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1013, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 87;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo Sancion";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.Width = 125;
            // 
            // CODP
            // 
            this.CODP.HeaderText = "Codigo Empleado";
            this.CODP.MinimumWidth = 6;
            this.CODP.Name = "CODP";
            this.CODP.Width = 125;
            // 
            // primaria
            // 
            this.primaria.HeaderText = "Razon Sancion";
            this.primaria.MinimumWidth = 6;
            this.primaria.Name = "primaria";
            this.primaria.Width = 125;
            // 
            // secundaria
            // 
            this.secundaria.HeaderText = "Descripcion ";
            this.secundaria.MinimumWidth = 6;
            this.secundaria.Name = "secundaria";
            this.secundaria.Width = 125;
            // 
            // bachillerato
            // 
            this.bachillerato.HeaderText = "Fecha Inicio";
            this.bachillerato.MinimumWidth = 6;
            this.bachillerato.Name = "bachillerato";
            this.bachillerato.Width = 125;
            // 
            // eU
            // 
            this.eU.HeaderText = "Fecha Final";
            this.eU.MinimumWidth = 6;
            this.eU.Name = "eU";
            this.eU.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Frm_SansionesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 491);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgv_SancionEmpleado);
            this.Controls.Add(this.Lbl_SansionesPersonal);
            this.Controls.Add(this.Pic_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_SansionesEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SansionesEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SancionEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_SansionesPersonal;
        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.DataGridView Dgv_SancionEmpleado;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODP;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn secundaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn bachillerato;
        private System.Windows.Forms.DataGridViewTextBoxColumn eU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}