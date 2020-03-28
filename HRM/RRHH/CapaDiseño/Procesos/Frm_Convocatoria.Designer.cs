namespace CapaDiseño.Procesos
{
    partial class Frm_Convocatoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Convocatoria));
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTP_fEHCA = new System.Windows.Forms.DateTimePicker();
            this.Cbo_MC = new System.Windows.Forms.ComboBox();
            this.Cbo_TipoC = new System.Windows.Forms.ComboBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Label_Fecha = new System.Windows.Forms.Label();
            this.Label_Medio = new System.Windows.Forms.Label();
            this.Label_TipoContratacion = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_PERFIL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Desempeño = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_desempeñoTitulo = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PERFIL)).BeginInit();
            this.Pnl_Desempeño.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Location = new System.Drawing.Point(778, 134);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(104, 30);
            this.Btn_Imprimir.TabIndex = 26;
            this.Btn_Imprimir.Text = "ACEPTAR";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTP_fEHCA);
            this.panel1.Controls.Add(this.Btn_Imprimir);
            this.panel1.Controls.Add(this.Cbo_MC);
            this.panel1.Controls.Add(this.Cbo_TipoC);
            this.panel1.Controls.Add(this.Txt_Id);
            this.panel1.Controls.Add(this.Label_Fecha);
            this.panel1.Controls.Add(this.Label_Medio);
            this.panel1.Controls.Add(this.Label_TipoContratacion);
            this.panel1.Controls.Add(this.Label_ID);
            this.panel1.Location = new System.Drawing.Point(17, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 177);
            this.panel1.TabIndex = 25;
            // 
            // DTP_fEHCA
            // 
            this.DTP_fEHCA.Location = new System.Drawing.Point(602, 26);
            this.DTP_fEHCA.Name = "DTP_fEHCA";
            this.DTP_fEHCA.Size = new System.Drawing.Size(213, 20);
            this.DTP_fEHCA.TabIndex = 18;
            // 
            // Cbo_MC
            // 
            this.Cbo_MC.FormattingEnabled = true;
            this.Cbo_MC.Location = new System.Drawing.Point(602, 90);
            this.Cbo_MC.Name = "Cbo_MC";
            this.Cbo_MC.Size = new System.Drawing.Size(213, 21);
            this.Cbo_MC.TabIndex = 17;
            this.Cbo_MC.SelectedIndexChanged += new System.EventHandler(this.Cbo_MC_SelectedIndexChanged);
            // 
            // Cbo_TipoC
            // 
            this.Cbo_TipoC.FormattingEnabled = true;
            this.Cbo_TipoC.Location = new System.Drawing.Point(221, 87);
            this.Cbo_TipoC.Name = "Cbo_TipoC";
            this.Cbo_TipoC.Size = new System.Drawing.Size(173, 21);
            this.Cbo_TipoC.TabIndex = 16;
            this.Cbo_TipoC.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoC_SelectedIndexChanged);
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(221, 22);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(173, 20);
            this.Txt_Id.TabIndex = 8;
            // 
            // Label_Fecha
            // 
            this.Label_Fecha.AutoSize = true;
            this.Label_Fecha.Location = new System.Drawing.Point(478, 25);
            this.Label_Fecha.Name = "Label_Fecha";
            this.Label_Fecha.Size = new System.Drawing.Size(42, 13);
            this.Label_Fecha.TabIndex = 6;
            this.Label_Fecha.Text = "FECHA";
            // 
            // Label_Medio
            // 
            this.Label_Medio.AutoSize = true;
            this.Label_Medio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Medio.Location = new System.Drawing.Point(464, 88);
            this.Label_Medio.Name = "Label_Medio";
            this.Label_Medio.Size = new System.Drawing.Size(117, 34);
            this.Label_Medio.TabIndex = 5;
            this.Label_Medio.Text = "MEDIO DE \r\nCOMUNICACION";
            // 
            // Label_TipoContratacion
            // 
            this.Label_TipoContratacion.AutoSize = true;
            this.Label_TipoContratacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TipoContratacion.Location = new System.Drawing.Point(31, 90);
            this.Label_TipoContratacion.Name = "Label_TipoContratacion";
            this.Label_TipoContratacion.Size = new System.Drawing.Size(142, 17);
            this.Label_TipoContratacion.TabIndex = 4;
            this.Label_TipoContratacion.Text = "TIPO CONTRATACION";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ID.Location = new System.Drawing.Point(31, 25);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(94, 17);
            this.Label_ID.TabIndex = 3;
            this.Label_ID.Text = "ID EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "INFORMACION DE PERFIL";
            // 
            // DGV_PERFIL
            // 
            this.DGV_PERFIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PERFIL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DGV_PERFIL.Location = new System.Drawing.Point(17, 325);
            this.DGV_PERFIL.Name = "DGV_PERFIL";
            this.DGV_PERFIL.RowHeadersVisible = false;
            this.DGV_PERFIL.Size = new System.Drawing.Size(898, 166);
            this.DGV_PERFIL.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Primaria";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Secundaria";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bachillerato";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estudiante_U";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grado_U";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Curso_Extra";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Descripcion_curso";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estado";
            this.Column9.Name = "Column9";
            // 
            // Pnl_Desempeño
            // 
            this.Pnl_Desempeño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_Desempeño.Controls.Add(this.Btn_ayuda);
            this.Pnl_Desempeño.Controls.Add(this.Btn_minimizar);
            this.Pnl_Desempeño.Controls.Add(this.Btn_cerrar);
            this.Pnl_Desempeño.Controls.Add(this.Lbl_desempeñoTitulo);
            this.Pnl_Desempeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Desempeño.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Desempeño.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Desempeño.Name = "Pnl_Desempeño";
            this.Pnl_Desempeño.Size = new System.Drawing.Size(949, 51);
            this.Pnl_Desempeño.TabIndex = 28;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(866, 12);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(33, 31);
            this.Btn_ayuda.TabIndex = 9;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(829, 12);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.Btn_minimizar.TabIndex = 8;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(903, 12);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_desempeñoTitulo
            // 
            this.Lbl_desempeñoTitulo.AutoSize = true;
            this.Lbl_desempeñoTitulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_desempeñoTitulo.Location = new System.Drawing.Point(11, 17);
            this.Lbl_desempeñoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_desempeñoTitulo.Name = "Lbl_desempeñoTitulo";
            this.Lbl_desempeñoTitulo.Size = new System.Drawing.Size(149, 20);
            this.Lbl_desempeñoTitulo.TabIndex = 0;
            this.Lbl_desempeñoTitulo.Text = "CONVOCATORIA";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(795, 274);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(104, 30);
            this.Btn_Buscar.TabIndex = 29;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Frm_Convocatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 503);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Pnl_Desempeño);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_PERFIL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Convocatoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Convocatoria";
            this.Load += new System.EventHandler(this.Frm_Convocatoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PERFIL)).EndInit();
            this.Pnl_Desempeño.ResumeLayout(false);
            this.Pnl_Desempeño.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTP_fEHCA;
        private System.Windows.Forms.ComboBox Cbo_MC;
        private System.Windows.Forms.ComboBox Cbo_TipoC;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Label_Fecha;
        private System.Windows.Forms.Label Label_Medio;
        private System.Windows.Forms.Label Label_TipoContratacion;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_PERFIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel Pnl_Desempeño;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_desempeñoTitulo;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}