namespace CapaDiseño.Procesos
{
    partial class Frm_polizaNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_polizaNomina));
            this.Gpb_Detallenominal = new System.Windows.Forms.GroupBox();
            this.Dgv_poliza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_numeronomina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_tipo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Txt_numeropoliza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lbl_procesonominal = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LBLTOTAL = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Gpb_Detallenominal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Detallenominal
            // 
            this.Gpb_Detallenominal.Controls.Add(this.Dgv_poliza);
            this.Gpb_Detallenominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detallenominal.Location = new System.Drawing.Point(21, 272);
            this.Gpb_Detallenominal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Detallenominal.Name = "Gpb_Detallenominal";
            this.Gpb_Detallenominal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gpb_Detallenominal.Size = new System.Drawing.Size(845, 273);
            this.Gpb_Detallenominal.TabIndex = 49;
            this.Gpb_Detallenominal.TabStop = false;
            this.Gpb_Detallenominal.Text = "Detalle";
            this.Gpb_Detallenominal.Enter += new System.EventHandler(this.Gpb_Detallenominal_Enter);
            // 
            // Dgv_poliza
            // 
            this.Dgv_poliza.AllowUserToAddRows = false;
            this.Dgv_poliza.AllowUserToDeleteRows = false;
            this.Dgv_poliza.AllowUserToOrderColumns = true;
            this.Dgv_poliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_poliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dgv_poliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_poliza.Location = new System.Drawing.Point(3, 22);
            this.Dgv_poliza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_poliza.Name = "Dgv_poliza";
            this.Dgv_poliza.RowHeadersWidth = 51;
            this.Dgv_poliza.RowTemplate.Height = 24;
            this.Dgv_poliza.Size = new System.Drawing.Size(839, 249);
            this.Dgv_poliza.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "CUENTAS CONTABLES";
            this.Column1.MaxInputLength = 327674;
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DEBE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "HABER";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(588, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(468, 97);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FECHA DE POLIZA";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(140, 65);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker3.TabIndex = 3;
            this.dateTimePicker3.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(140, 23);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "FINAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "INICIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_numeronomina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_tipo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Txt_numeropoliza);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(560, 161);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE POLIZA";
            this.groupBox1.UseWaitCursor = true;
            // 
            // Txt_numeronomina
            // 
            this.Txt_numeronomina.Location = new System.Drawing.Point(140, 126);
            this.Txt_numeronomina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_numeronomina.Name = "Txt_numeronomina";
            this.Txt_numeronomina.Size = new System.Drawing.Size(132, 22);
            this.Txt_numeronomina.TabIndex = 40;
            this.Txt_numeronomina.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "NO. NOMINA";
            this.label4.UseWaitCursor = true;
            // 
            // Txt_tipo
            // 
            this.Txt_tipo.Location = new System.Drawing.Point(140, 94);
            this.Txt_tipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_tipo.Name = "Txt_tipo";
            this.Txt_tipo.Size = new System.Drawing.Size(265, 22);
            this.Txt_tipo.TabIndex = 39;
            this.Txt_tipo.Text = "NOMINA";
            this.Txt_tipo.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // Txt_numeropoliza
            // 
            this.Txt_numeropoliza.Location = new System.Drawing.Point(140, 31);
            this.Txt_numeropoliza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_numeropoliza.Name = "Txt_numeropoliza";
            this.Txt_numeropoliza.Size = new System.Drawing.Size(132, 22);
            this.Txt_numeropoliza.TabIndex = 4;
            this.Txt_numeropoliza.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO POLIZA";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREACION";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO. POLIZA";
            this.label1.UseWaitCursor = true;
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lbl_procesonominal);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1072, 71);
            this.Pnl_nombreForm.TabIndex = 46;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(937, 15);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(888, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // lbl_procesonominal
            // 
            this.lbl_procesonominal.AutoSize = true;
            this.lbl_procesonominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procesonominal.ForeColor = System.Drawing.Color.White;
            this.lbl_procesonominal.Location = new System.Drawing.Point(27, 15);
            this.lbl_procesonominal.Name = "lbl_procesonominal";
            this.lbl_procesonominal.Size = new System.Drawing.Size(216, 25);
            this.lbl_procesonominal.TabIndex = 0;
            this.lbl_procesonominal.Text = "POLIZA DE NOMINA";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(987, 15);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 58);
            this.button1.TabIndex = 53;
            this.button1.Text = "INGRESAR CUENTA CONTABLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLTOTAL
            // 
            this.LBLTOTAL.AutoSize = true;
            this.LBLTOTAL.Location = new System.Drawing.Point(147, 549);
            this.LBLTOTAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTOTAL.Name = "LBLTOTAL";
            this.LBLTOTAL.Size = new System.Drawing.Size(119, 17);
            this.LBLTOTAL.TabIndex = 60;
            this.LBLTOTAL.Text = "SUMAS IGUALES";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(295, 545);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(132, 22);
            this.textBox10.TabIndex = 62;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(468, 545);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(132, 22);
            this.textBox11.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(888, 420);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 64;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Frm_polizaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.LBLTOTAL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gpb_Detallenominal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_polizaNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_polizaNomina";
            this.Load += new System.EventHandler(this.Frm_polizaNomina_Load);
            this.Gpb_Detallenominal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_poliza)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_Detallenominal;
        private System.Windows.Forms.DataGridView Dgv_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_numeronomina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_tipo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Txt_numeropoliza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lbl_procesonominal;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBLTOTAL;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
    }
}