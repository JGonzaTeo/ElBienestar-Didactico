namespace CapaDiseño.Procesos
{
    partial class Frm_ControlAsistenciaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ControlAsistenciaPersonal));
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_ControlAsistenciaPersonal = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgv_AsistenciaPersonal = new System.Windows.Forms.DataGridView();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AsistenciaPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-5, -1);
            this.Pic_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(856, 62);
            this.Pic_Barra.TabIndex = 25;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_ControlAsistenciaPersonal
            // 
            this.Lbl_ControlAsistenciaPersonal.AutoSize = true;
            this.Lbl_ControlAsistenciaPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_ControlAsistenciaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ControlAsistenciaPersonal.ForeColor = System.Drawing.Color.White;
            this.Lbl_ControlAsistenciaPersonal.Location = new System.Drawing.Point(15, 14);
            this.Lbl_ControlAsistenciaPersonal.Name = "Lbl_ControlAsistenciaPersonal";
            this.Lbl_ControlAsistenciaPersonal.Size = new System.Drawing.Size(462, 31);
            this.Lbl_ControlAsistenciaPersonal.TabIndex = 29;
            this.Lbl_ControlAsistenciaPersonal.Text = "Control de Asistencia del Personal";
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(621, 409);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(164, 41);
            this.Btn_actualizar.TabIndex = 83;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Dgv_AsistenciaPersonal
            // 
            this.Dgv_AsistenciaPersonal.AllowUserToAddRows = false;
            this.Dgv_AsistenciaPersonal.AllowUserToDeleteRows = false;
            this.Dgv_AsistenciaPersonal.AllowUserToResizeColumns = false;
            this.Dgv_AsistenciaPersonal.AllowUserToResizeRows = false;
            this.Dgv_AsistenciaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AsistenciaPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.CODP,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Dgv_AsistenciaPersonal.Location = new System.Drawing.Point(48, 84);
            this.Dgv_AsistenciaPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_AsistenciaPersonal.Name = "Dgv_AsistenciaPersonal";
            this.Dgv_AsistenciaPersonal.RowHeadersVisible = false;
            this.Dgv_AsistenciaPersonal.RowHeadersWidth = 51;
            this.Dgv_AsistenciaPersonal.RowTemplate.Height = 24;
            this.Dgv_AsistenciaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_AsistenciaPersonal.Size = new System.Drawing.Size(754, 297);
            this.Dgv_AsistenciaPersonal.TabIndex = 81;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(709, 11);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 86;
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(659, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 85;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(758, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 84;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo Asistencia";
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
            // Column1
            // 
            this.Column1.HeaderText = "Fecha Ingreso";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha Salida";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora Ingreso";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora Salida";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Frm_ControlAsistenciaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 476);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgv_AsistenciaPersonal);
            this.Controls.Add(this.Lbl_ControlAsistenciaPersonal);
            this.Controls.Add(this.Pic_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ControlAsistenciaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ControlAsistenciaPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AsistenciaPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_ControlAsistenciaPersonal;
        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.DataGridView Dgv_AsistenciaPersonal;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}