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
            this.Dgv_Sansiones = new System.Windows.Forms.DataGridView();
            this.Gpb_Busqueda = new System.Windows.Forms.GroupBox();
            this.Lbl_EspecificoPor = new System.Windows.Forms.Label();
            this.Txt_EspecificoPor = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Cbo_BuscarSansion = new System.Windows.Forms.ComboBox();
            this.Lbl_BuscarSansionPor = new System.Windows.Forms.Label();
            this.Pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.Pic_Minimizar = new System.Windows.Forms.PictureBox();
            this.Pic_Pregunta = new System.Windows.Forms.PictureBox();
            this.Pic_Barra = new System.Windows.Forms.PictureBox();
            this.Lbl_SansionesPersonal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Sansiones)).BeginInit();
            this.Gpb_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Pregunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Sansiones
            // 
            this.Dgv_Sansiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Sansiones.Location = new System.Drawing.Point(66, 179);
            this.Dgv_Sansiones.Name = "Dgv_Sansiones";
            this.Dgv_Sansiones.RowHeadersWidth = 51;
            this.Dgv_Sansiones.Size = new System.Drawing.Size(798, 375);
            this.Dgv_Sansiones.TabIndex = 14;
            // 
            // Gpb_Busqueda
            // 
            this.Gpb_Busqueda.Controls.Add(this.Lbl_EspecificoPor);
            this.Gpb_Busqueda.Controls.Add(this.Txt_EspecificoPor);
            this.Gpb_Busqueda.Controls.Add(this.Btn_Buscar);
            this.Gpb_Busqueda.Controls.Add(this.Cbo_BuscarSansion);
            this.Gpb_Busqueda.Controls.Add(this.Lbl_BuscarSansionPor);
            this.Gpb_Busqueda.Location = new System.Drawing.Point(62, 78);
            this.Gpb_Busqueda.Name = "Gpb_Busqueda";
            this.Gpb_Busqueda.Size = new System.Drawing.Size(803, 83);
            this.Gpb_Busqueda.TabIndex = 13;
            this.Gpb_Busqueda.TabStop = false;
            this.Gpb_Busqueda.Text = "Busqueda";
            // 
            // Lbl_EspecificoPor
            // 
            this.Lbl_EspecificoPor.AutoSize = true;
            this.Lbl_EspecificoPor.Location = new System.Drawing.Point(343, 37);
            this.Lbl_EspecificoPor.Name = "Lbl_EspecificoPor";
            this.Lbl_EspecificoPor.Size = new System.Drawing.Size(119, 17);
            this.Lbl_EspecificoPor.TabIndex = 5;
            this.Lbl_EspecificoPor.Text = "En Especifico Por";
            // 
            // Txt_EspecificoPor
            // 
            this.Txt_EspecificoPor.Location = new System.Drawing.Point(478, 36);
            this.Txt_EspecificoPor.Name = "Txt_EspecificoPor";
            this.Txt_EspecificoPor.Size = new System.Drawing.Size(194, 22);
            this.Txt_EspecificoPor.TabIndex = 4;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(692, 34);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Cbo_BuscarSansion
            // 
            this.Cbo_BuscarSansion.FormattingEnabled = true;
            this.Cbo_BuscarSansion.Location = new System.Drawing.Point(205, 34);
            this.Cbo_BuscarSansion.Name = "Cbo_BuscarSansion";
            this.Cbo_BuscarSansion.Size = new System.Drawing.Size(121, 24);
            this.Cbo_BuscarSansion.TabIndex = 2;
            // 
            // Lbl_BuscarSansionPor
            // 
            this.Lbl_BuscarSansionPor.AutoSize = true;
            this.Lbl_BuscarSansionPor.Location = new System.Drawing.Point(51, 37);
            this.Lbl_BuscarSansionPor.Name = "Lbl_BuscarSansionPor";
            this.Lbl_BuscarSansionPor.Size = new System.Drawing.Size(148, 17);
            this.Lbl_BuscarSansionPor.TabIndex = 1;
            this.Lbl_BuscarSansionPor.Text = "Buscar Sansiones Por";
            // 
            // Pic_Cerrar
            // 
            this.Pic_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Cerrar.Image")));
            this.Pic_Cerrar.Location = new System.Drawing.Point(890, 10);
            this.Pic_Cerrar.Name = "Pic_Cerrar";
            this.Pic_Cerrar.Size = new System.Drawing.Size(24, 23);
            this.Pic_Cerrar.TabIndex = 28;
            this.Pic_Cerrar.TabStop = false;
            // 
            // Pic_Minimizar
            // 
            this.Pic_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Minimizar.Image")));
            this.Pic_Minimizar.Location = new System.Drawing.Point(820, 8);
            this.Pic_Minimizar.Name = "Pic_Minimizar";
            this.Pic_Minimizar.Size = new System.Drawing.Size(26, 26);
            this.Pic_Minimizar.TabIndex = 27;
            this.Pic_Minimizar.TabStop = false;
            // 
            // Pic_Pregunta
            // 
            this.Pic_Pregunta.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Pregunta.Image")));
            this.Pic_Pregunta.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pic_Pregunta.InitialImage")));
            this.Pic_Pregunta.Location = new System.Drawing.Point(855, 8);
            this.Pic_Pregunta.Name = "Pic_Pregunta";
            this.Pic_Pregunta.Size = new System.Drawing.Size(23, 26);
            this.Pic_Pregunta.TabIndex = 26;
            this.Pic_Pregunta.TabStop = false;
            // 
            // Pic_Barra
            // 
            this.Pic_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pic_Barra.Location = new System.Drawing.Point(-3, -2);
            this.Pic_Barra.Name = "Pic_Barra";
            this.Pic_Barra.Size = new System.Drawing.Size(931, 51);
            this.Pic_Barra.TabIndex = 25;
            this.Pic_Barra.TabStop = false;
            // 
            // Lbl_SansionesPersonal
            // 
            this.Lbl_SansionesPersonal.AutoSize = true;
            this.Lbl_SansionesPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Lbl_SansionesPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SansionesPersonal.ForeColor = System.Drawing.Color.White;
            this.Lbl_SansionesPersonal.Location = new System.Drawing.Point(22, 8);
            this.Lbl_SansionesPersonal.Name = "Lbl_SansionesPersonal";
            this.Lbl_SansionesPersonal.Size = new System.Drawing.Size(320, 31);
            this.Lbl_SansionesPersonal.TabIndex = 29;
            this.Lbl_SansionesPersonal.Text = "Sansiones del Personal";
            this.Lbl_SansionesPersonal.UseMnemonic = false;
            // 
            // Frm_SansionesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 591);
            this.Controls.Add(this.Lbl_SansionesPersonal);
            this.Controls.Add(this.Pic_Cerrar);
            this.Controls.Add(this.Pic_Minimizar);
            this.Controls.Add(this.Pic_Pregunta);
            this.Controls.Add(this.Pic_Barra);
            this.Controls.Add(this.Dgv_Sansiones);
            this.Controls.Add(this.Gpb_Busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SansionesEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SansionesEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Sansiones)).EndInit();
            this.Gpb_Busqueda.ResumeLayout(false);
            this.Gpb_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Pregunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Barra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Sansiones;
        private System.Windows.Forms.GroupBox Gpb_Busqueda;
        private System.Windows.Forms.Label Lbl_EspecificoPor;
        private System.Windows.Forms.TextBox Txt_EspecificoPor;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox Cbo_BuscarSansion;
        private System.Windows.Forms.Label Lbl_BuscarSansionPor;
        private System.Windows.Forms.PictureBox Pic_Cerrar;
        private System.Windows.Forms.PictureBox Pic_Minimizar;
        private System.Windows.Forms.PictureBox Pic_Pregunta;
        private System.Windows.Forms.PictureBox Pic_Barra;
        private System.Windows.Forms.Label Lbl_SansionesPersonal;
    }
}