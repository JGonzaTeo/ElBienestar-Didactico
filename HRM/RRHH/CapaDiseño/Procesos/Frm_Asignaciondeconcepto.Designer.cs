namespace CapaDiseño.Procesos
{
    partial class Frm_Asignaciondeconcepto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Asignaciondeconcepto));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lbl_asignacionconcepto = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_consultaempleado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_Selecciontodos = new System.Windows.Forms.CheckBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_codigoconcepto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_nombreconcepto = new System.Windows.Forms.TextBox();
            this.Txt_codemp = new System.Windows.Forms.TextBox();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lbl_asignacionconcepto);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, -1);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1310, 63);
            this.Pnl_nombreForm.TabIndex = 2;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(770, 15);
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
            this.btn_minimizar.Location = new System.Drawing.Point(723, 15);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // lbl_asignacionconcepto
            // 
            this.lbl_asignacionconcepto.AutoSize = true;
            this.lbl_asignacionconcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asignacionconcepto.ForeColor = System.Drawing.Color.White;
            this.lbl_asignacionconcepto.Location = new System.Drawing.Point(26, 15);
            this.lbl_asignacionconcepto.Name = "lbl_asignacionconcepto";
            this.lbl_asignacionconcepto.Size = new System.Drawing.Size(312, 25);
            this.lbl_asignacionconcepto.TabIndex = 0;
            this.lbl_asignacionconcepto.Text = "ASIGNACION DE CONCEPTO";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(820, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Dgv_consultaempleado
            // 
            this.Dgv_consultaempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dgv_consultaempleado.Location = new System.Drawing.Point(69, 219);
            this.Dgv_consultaempleado.Name = "Dgv_consultaempleado";
            this.Dgv_consultaempleado.RowHeadersWidth = 51;
            this.Dgv_consultaempleado.RowTemplate.Height = 24;
            this.Dgv_consultaempleado.Size = new System.Drawing.Size(576, 150);
            this.Dgv_consultaempleado.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Seleccionar";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // chk_Selecciontodos
            // 
            this.chk_Selecciontodos.AutoSize = true;
            this.chk_Selecciontodos.Location = new System.Drawing.Point(497, 192);
            this.chk_Selecciontodos.Name = "chk_Selecciontodos";
            this.chk_Selecciontodos.Size = new System.Drawing.Size(148, 21);
            this.chk_Selecciontodos.TabIndex = 4;
            this.chk_Selecciontodos.Text = "Seleccionar Todos";
            this.chk_Selecciontodos.UseVisualStyleBackColor = true;
            this.chk_Selecciontodos.CheckedChanged += new System.EventHandler(this.Chk_Selecciontodos_CheckedChanged);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(723, 400);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(118, 42);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Finalizar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo concepto:";
            // 
            // Txt_codigoconcepto
            // 
            this.Txt_codigoconcepto.Location = new System.Drawing.Point(214, 100);
            this.Txt_codigoconcepto.Name = "Txt_codigoconcepto";
            this.Txt_codigoconcepto.Size = new System.Drawing.Size(405, 22);
            this.Txt_codigoconcepto.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(625, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.Location = new System.Drawing.Point(550, 400);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(135, 42);
            this.Btn_siguiente.TabIndex = 9;
            this.Btn_siguiente.Text = "Siguiente";
            this.Btn_siguiente.UseVisualStyleBackColor = true;
            this.Btn_siguiente.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre del concepto:";
            // 
            // Txt_nombreconcepto
            // 
            this.Txt_nombreconcepto.Location = new System.Drawing.Point(234, 145);
            this.Txt_nombreconcepto.Name = "Txt_nombreconcepto";
            this.Txt_nombreconcepto.Size = new System.Drawing.Size(153, 22);
            this.Txt_nombreconcepto.TabIndex = 11;
            // 
            // Txt_codemp
            // 
            this.Txt_codemp.Location = new System.Drawing.Point(692, 107);
            this.Txt_codemp.Name = "Txt_codemp";
            this.Txt_codemp.Size = new System.Drawing.Size(100, 22);
            this.Txt_codemp.TabIndex = 12;
            // 
            // Frm_Asignaciondeconcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 476);
            this.Controls.Add(this.Txt_codemp);
            this.Controls.Add(this.Txt_nombreconcepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_siguiente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_codigoconcepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.chk_Selecciontodos);
            this.Controls.Add(this.Dgv_consultaempleado);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Asignaciondeconcepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACION DE CONCEPTO";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lbl_asignacionconcepto;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView Dgv_consultaempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox chk_Selecciontodos;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_codigoconcepto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Button Btn_siguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_nombreconcepto;
        private System.Windows.Forms.TextBox Txt_codemp;
    }
}