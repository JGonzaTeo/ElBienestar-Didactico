﻿namespace CapaDiseño.Consulta
{
    partial class Frm_TipoContratacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TipoContratacion));
            this.Btn_actualizarMedio = new System.Windows.Forms.Button();
            this.Btn_seleccionarMedio = new System.Windows.Forms.Button();
            this.Dgv_consultaContratacion = new System.Windows.Forms.DataGridView();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.Label_Contratar = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaContratacion)).BeginInit();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_actualizarMedio
            // 
            this.Btn_actualizarMedio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizarMedio.FlatAppearance.BorderSize = 3;
            this.Btn_actualizarMedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizarMedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizarMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizarMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizarMedio.Location = new System.Drawing.Point(701, 153);
            this.Btn_actualizarMedio.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizarMedio.Name = "Btn_actualizarMedio";
            this.Btn_actualizarMedio.Size = new System.Drawing.Size(123, 33);
            this.Btn_actualizarMedio.TabIndex = 82;
            this.Btn_actualizarMedio.Text = "Actualizar";
            this.Btn_actualizarMedio.UseVisualStyleBackColor = true;
            this.Btn_actualizarMedio.Click += new System.EventHandler(this.Btn_actualizarMedio_Click);
            // 
            // Btn_seleccionarMedio
            // 
            this.Btn_seleccionarMedio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_seleccionarMedio.FlatAppearance.BorderSize = 3;
            this.Btn_seleccionarMedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_seleccionarMedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_seleccionarMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_seleccionarMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionarMedio.Location = new System.Drawing.Point(828, 153);
            this.Btn_seleccionarMedio.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_seleccionarMedio.Name = "Btn_seleccionarMedio";
            this.Btn_seleccionarMedio.Size = new System.Drawing.Size(123, 33);
            this.Btn_seleccionarMedio.TabIndex = 81;
            this.Btn_seleccionarMedio.Text = "Seleccionar";
            this.Btn_seleccionarMedio.UseVisualStyleBackColor = true;
            this.Btn_seleccionarMedio.Click += new System.EventHandler(this.Btn_seleccionarMedio_Click);
            // 
            // Dgv_consultaContratacion
            // 
            this.Dgv_consultaContratacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaContratacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgv_consultaContratacion.Location = new System.Drawing.Point(1, 72);
            this.Dgv_consultaContratacion.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_consultaContratacion.Name = "Dgv_consultaContratacion";
            this.Dgv_consultaContratacion.RowHeadersWidth = 51;
            this.Dgv_consultaContratacion.RowTemplate.Height = 24;
            this.Dgv_consultaContratacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaContratacion.Size = new System.Drawing.Size(696, 169);
            this.Dgv_consultaContratacion.TabIndex = 80;
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.Label_Contratar);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(-10, 2);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(978, 51);
            this.Pnl_nombreForm.TabIndex = 79;
            // 
            // Label_Contratar
            // 
            this.Label_Contratar.AutoSize = true;
            this.Label_Contratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Contratar.ForeColor = System.Drawing.Color.White;
            this.Label_Contratar.Location = new System.Drawing.Point(20, 12);
            this.Label_Contratar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Contratar.Name = "Label_Contratar";
            this.Label_Contratar.Size = new System.Drawing.Size(277, 20);
            this.Label_Contratar.TabIndex = 0;
            this.Label_Contratar.Text = "Consulta de Tipo de Contratacion";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(852, 12);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(925, 12);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PorContrato";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PorMeses";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PorProyecto";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            // 
            // Frm_TipoContratacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 243);
            this.Controls.Add(this.Btn_actualizarMedio);
            this.Controls.Add(this.Btn_seleccionarMedio);
            this.Controls.Add(this.Dgv_consultaContratacion);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TipoContratacion";
            this.Text = "Frm_TipoContratacion";
            this.Load += new System.EventHandler(this.Frm_TipoContratacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaContratacion)).EndInit();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizarMedio;
        private System.Windows.Forms.Button Btn_seleccionarMedio;
        public System.Windows.Forms.DataGridView Dgv_consultaContratacion;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label Label_Contratar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}