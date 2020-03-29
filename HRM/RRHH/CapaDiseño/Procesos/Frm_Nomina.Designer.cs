namespace CapaDiseño.Procesos
{
    partial class Frm_Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Nomina));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lbl_procesonominal = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Gpb_nominaencabezado = new System.Windows.Forms.GroupBox();
            this.Txt_saldonominal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_codempleado = new System.Windows.Forms.TextBox();
            this.lblempleadorealizar = new System.Windows.Forms.Label();
            this.Dtp_fechafin = new System.Windows.Forms.DateTimePicker();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.Dtp_fechainicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_tiponomina = new System.Windows.Forms.TextBox();
            this.lbl_tiponomina = new System.Windows.Forms.Label();
            this.Txt_CodEncabezado = new System.Windows.Forms.TextBox();
            this.lbl_codnominaenca = new System.Windows.Forms.Label();
            this.Gpb_Detallenominal = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dgv_empleadoscontables = new System.Windows.Forms.DataGridView();
            this.lbl_subtotalpercepciones = new System.Windows.Forms.Label();
            this.Txt_SubtotalPercepciones = new System.Windows.Forms.TextBox();
            this.lbl_subtotaldeducciones = new System.Windows.Forms.Label();
            this.Txt_SubtotalDeducciones = new System.Windows.Forms.TextBox();
            this.btn_generarnomina = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_nombreForm.SuspendLayout();
            this.Gpb_nominaencabezado.SuspendLayout();
            this.Gpb_Detallenominal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_empleadoscontables)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lbl_procesonominal);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(-3, -1);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1310, 63);
            this.Pnl_nombreForm.TabIndex = 1;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1183, 15);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1136, 15);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // lbl_procesonominal
            // 
            this.lbl_procesonominal.AutoSize = true;
            this.lbl_procesonominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procesonominal.ForeColor = System.Drawing.Color.White;
            this.lbl_procesonominal.Location = new System.Drawing.Point(26, 15);
            this.lbl_procesonominal.Name = "lbl_procesonominal";
            this.lbl_procesonominal.Size = new System.Drawing.Size(175, 25);
            this.lbl_procesonominal.TabIndex = 0;
            this.lbl_procesonominal.Text = "Proceso Nominal";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1233, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Gpb_nominaencabezado
            // 
            this.Gpb_nominaencabezado.Controls.Add(this.Txt_saldonominal);
            this.Gpb_nominaencabezado.Controls.Add(this.label2);
            this.Gpb_nominaencabezado.Controls.Add(this.Txt_Observaciones);
            this.Gpb_nominaencabezado.Controls.Add(this.lbl_observaciones);
            this.Gpb_nominaencabezado.Controls.Add(this.button1);
            this.Gpb_nominaencabezado.Controls.Add(this.Txt_codempleado);
            this.Gpb_nominaencabezado.Controls.Add(this.lblempleadorealizar);
            this.Gpb_nominaencabezado.Controls.Add(this.Dtp_fechafin);
            this.Gpb_nominaencabezado.Controls.Add(this.lblfechafin);
            this.Gpb_nominaencabezado.Controls.Add(this.Dtp_fechainicio);
            this.Gpb_nominaencabezado.Controls.Add(this.label1);
            this.Gpb_nominaencabezado.Controls.Add(this.Txt_tiponomina);
            this.Gpb_nominaencabezado.Controls.Add(this.lbl_tiponomina);
            this.Gpb_nominaencabezado.Controls.Add(this.Txt_CodEncabezado);
            this.Gpb_nominaencabezado.Controls.Add(this.lbl_codnominaenca);
            this.Gpb_nominaencabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_nominaencabezado.Location = new System.Drawing.Point(28, 79);
            this.Gpb_nominaencabezado.Name = "Gpb_nominaencabezado";
            this.Gpb_nominaencabezado.Size = new System.Drawing.Size(1261, 175);
            this.Gpb_nominaencabezado.TabIndex = 2;
            this.Gpb_nominaencabezado.TabStop = false;
            this.Gpb_nominaencabezado.Text = "Encabezado Nomina";
            // 
            // Txt_saldonominal
            // 
            this.Txt_saldonominal.Location = new System.Drawing.Point(789, 134);
            this.Txt_saldonominal.Name = "Txt_saldonominal";
            this.Txt_saldonominal.Size = new System.Drawing.Size(132, 27);
            this.Txt_saldonominal.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Saldo Nominal:";
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(178, 141);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(320, 27);
            this.Txt_Observaciones.TabIndex = 12;
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Location = new System.Drawing.Point(22, 144);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(126, 20);
            this.lbl_observaciones.TabIndex = 11;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(456, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Txt_codempleado
            // 
            this.Txt_codempleado.Location = new System.Drawing.Point(298, 92);
            this.Txt_codempleado.Name = "Txt_codempleado";
            this.Txt_codempleado.Size = new System.Drawing.Size(132, 27);
            this.Txt_codempleado.TabIndex = 9;
            // 
            // lblempleadorealizar
            // 
            this.lblempleadorealizar.AutoSize = true;
            this.lblempleadorealizar.Location = new System.Drawing.Point(101, 92);
            this.lblempleadorealizar.Name = "lblempleadorealizar";
            this.lblempleadorealizar.Size = new System.Drawing.Size(171, 20);
            this.lblempleadorealizar.TabIndex = 8;
            this.lblempleadorealizar.Text = "Empleado encargado:";
            // 
            // Dtp_fechafin
            // 
            this.Dtp_fechafin.Location = new System.Drawing.Point(810, 74);
            this.Dtp_fechafin.Name = "Dtp_fechafin";
            this.Dtp_fechafin.Size = new System.Drawing.Size(365, 27);
            this.Dtp_fechafin.TabIndex = 7;
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.Location = new System.Drawing.Point(669, 79);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(83, 20);
            this.lblfechafin.TabIndex = 6;
            this.lblfechafin.Text = "Fecha fin:";
            // 
            // Dtp_fechainicio
            // 
            this.Dtp_fechainicio.Location = new System.Drawing.Point(810, 32);
            this.Dtp_fechainicio.Name = "Dtp_fechainicio";
            this.Dtp_fechainicio.Size = new System.Drawing.Size(365, 27);
            this.Dtp_fechainicio.TabIndex = 5;
            this.Dtp_fechainicio.Value = new System.DateTime(2020, 3, 24, 22, 55, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha inicio:";
            // 
            // Txt_tiponomina
            // 
            this.Txt_tiponomina.Location = new System.Drawing.Point(456, 32);
            this.Txt_tiponomina.Name = "Txt_tiponomina";
            this.Txt_tiponomina.Size = new System.Drawing.Size(130, 27);
            this.Txt_tiponomina.TabIndex = 3;
            // 
            // lbl_tiponomina
            // 
            this.lbl_tiponomina.AutoSize = true;
            this.lbl_tiponomina.Location = new System.Drawing.Point(333, 36);
            this.lbl_tiponomina.Name = "lbl_tiponomina";
            this.lbl_tiponomina.Size = new System.Drawing.Size(108, 20);
            this.lbl_tiponomina.TabIndex = 2;
            this.lbl_tiponomina.Text = "Tipo Nomina:";
            // 
            // Txt_CodEncabezado
            // 
            this.Txt_CodEncabezado.Location = new System.Drawing.Point(117, 36);
            this.Txt_CodEncabezado.Name = "Txt_CodEncabezado";
            this.Txt_CodEncabezado.Size = new System.Drawing.Size(130, 27);
            this.Txt_CodEncabezado.TabIndex = 1;
            // 
            // lbl_codnominaenca
            // 
            this.lbl_codnominaenca.AutoSize = true;
            this.lbl_codnominaenca.Location = new System.Drawing.Point(12, 39);
            this.lbl_codnominaenca.Name = "lbl_codnominaenca";
            this.lbl_codnominaenca.Size = new System.Drawing.Size(80, 20);
            this.lbl_codnominaenca.TabIndex = 0;
            this.lbl_codnominaenca.Text = "No. Folio:";
            // 
            // Gpb_Detallenominal
            // 
            this.Gpb_Detallenominal.Controls.Add(this.dataGridView1);
            this.Gpb_Detallenominal.Controls.Add(this.Dgv_empleadoscontables);
            this.Gpb_Detallenominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detallenominal.Location = new System.Drawing.Point(28, 278);
            this.Gpb_Detallenominal.Name = "Gpb_Detallenominal";
            this.Gpb_Detallenominal.Size = new System.Drawing.Size(1263, 303);
            this.Gpb_Detallenominal.TabIndex = 3;
            this.Gpb_Detallenominal.TabStop = false;
            this.Gpb_Detallenominal.Text = "Detalle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Dgv_empleadoscontables
            // 
            this.Dgv_empleadoscontables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_empleadoscontables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgv_empleadoscontables.Location = new System.Drawing.Point(37, 26);
            this.Dgv_empleadoscontables.Name = "Dgv_empleadoscontables";
            this.Dgv_empleadoscontables.RowHeadersWidth = 51;
            this.Dgv_empleadoscontables.RowTemplate.Height = 24;
            this.Dgv_empleadoscontables.Size = new System.Drawing.Size(1187, 101);
            this.Dgv_empleadoscontables.TabIndex = 0;
            // 
            // lbl_subtotalpercepciones
            // 
            this.lbl_subtotalpercepciones.AutoSize = true;
            this.lbl_subtotalpercepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotalpercepciones.Location = new System.Drawing.Point(85, 614);
            this.lbl_subtotalpercepciones.Name = "lbl_subtotalpercepciones";
            this.lbl_subtotalpercepciones.Size = new System.Drawing.Size(215, 20);
            this.lbl_subtotalpercepciones.TabIndex = 4;
            this.lbl_subtotalpercepciones.Text = "Sub Total Percepciones:";
            // 
            // Txt_SubtotalPercepciones
            // 
            this.Txt_SubtotalPercepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SubtotalPercepciones.Location = new System.Drawing.Point(365, 611);
            this.Txt_SubtotalPercepciones.Name = "Txt_SubtotalPercepciones";
            this.Txt_SubtotalPercepciones.Size = new System.Drawing.Size(148, 27);
            this.Txt_SubtotalPercepciones.TabIndex = 5;
            // 
            // lbl_subtotaldeducciones
            // 
            this.lbl_subtotaldeducciones.AutoSize = true;
            this.lbl_subtotaldeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotaldeducciones.Location = new System.Drawing.Point(648, 614);
            this.lbl_subtotaldeducciones.Name = "lbl_subtotaldeducciones";
            this.lbl_subtotaldeducciones.Size = new System.Drawing.Size(210, 20);
            this.lbl_subtotaldeducciones.TabIndex = 6;
            this.lbl_subtotaldeducciones.Text = "Sub Total Deducciones:";
            // 
            // Txt_SubtotalDeducciones
            // 
            this.Txt_SubtotalDeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SubtotalDeducciones.Location = new System.Drawing.Point(910, 611);
            this.Txt_SubtotalDeducciones.Name = "Txt_SubtotalDeducciones";
            this.Txt_SubtotalDeducciones.Size = new System.Drawing.Size(148, 27);
            this.Txt_SubtotalDeducciones.TabIndex = 7;
            // 
            // btn_generarnomina
            // 
            this.btn_generarnomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.btn_generarnomina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generarnomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarnomina.Location = new System.Drawing.Point(1080, 676);
            this.btn_generarnomina.Name = "btn_generarnomina";
            this.btn_generarnomina.Size = new System.Drawing.Size(194, 40);
            this.btn_generarnomina.TabIndex = 8;
            this.btn_generarnomina.Text = "Generar Nomina";
            this.btn_generarnomina.UseVisualStyleBackColor = false;
            this.btn_generarnomina.Click += new System.EventHandler(this.Btn_generarnomina_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sueldo Base";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Concepto";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Saldo";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Debe/Haber";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Operacion";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sueldo Liquido";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Frm_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 728);
            this.Controls.Add(this.btn_generarnomina);
            this.Controls.Add(this.Txt_SubtotalDeducciones);
            this.Controls.Add(this.lbl_subtotaldeducciones);
            this.Controls.Add(this.Txt_SubtotalPercepciones);
            this.Controls.Add(this.lbl_subtotalpercepciones);
            this.Controls.Add(this.Gpb_Detallenominal);
            this.Controls.Add(this.Gpb_nominaencabezado);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Nomina";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.Gpb_nominaencabezado.ResumeLayout(false);
            this.Gpb_nominaencabezado.PerformLayout();
            this.Gpb_Detallenominal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_empleadoscontables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lbl_procesonominal;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox Gpb_nominaencabezado;
        private System.Windows.Forms.TextBox Txt_saldonominal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_codempleado;
        private System.Windows.Forms.Label lblempleadorealizar;
        private System.Windows.Forms.DateTimePicker Dtp_fechafin;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.DateTimePicker Dtp_fechainicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_tiponomina;
        private System.Windows.Forms.Label lbl_tiponomina;
        private System.Windows.Forms.TextBox Txt_CodEncabezado;
        private System.Windows.Forms.Label lbl_codnominaenca;
        private System.Windows.Forms.GroupBox Gpb_Detallenominal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView Dgv_empleadoscontables;
        private System.Windows.Forms.Label lbl_subtotalpercepciones;
        private System.Windows.Forms.TextBox Txt_SubtotalPercepciones;
        private System.Windows.Forms.Label lbl_subtotaldeducciones;
        private System.Windows.Forms.TextBox Txt_SubtotalDeducciones;
        private System.Windows.Forms.Button btn_generarnomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}