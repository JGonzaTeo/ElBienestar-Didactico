namespace CapaDiseño.Procesos
{
    partial class Frm_filtroInterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_filtroInterno));
            this.lbl_procesonominal = new System.Windows.Forms.Label();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_aptos = new System.Windows.Forms.Label();
            this.Dgv_consultaAceptados = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.codE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaAceptados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_procesonominal
            // 
            this.lbl_procesonominal.AutoSize = true;
            this.lbl_procesonominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procesonominal.ForeColor = System.Drawing.Color.White;
            this.lbl_procesonominal.Location = new System.Drawing.Point(27, 15);
            this.lbl_procesonominal.Name = "lbl_procesonominal";
            this.lbl_procesonominal.Size = new System.Drawing.Size(182, 25);
            this.lbl_procesonominal.TabIndex = 0;
            this.lbl_procesonominal.Text = "Busqueda Interna";
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
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1425, 63);
            this.Pnl_nombreForm.TabIndex = 42;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1264, 11);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_minimizar.Location = new System.Drawing.Point(1217, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1315, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_aptos
            // 
            this.lbl_aptos.AutoSize = true;
            this.lbl_aptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aptos.Location = new System.Drawing.Point(29, 68);
            this.lbl_aptos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aptos.Name = "lbl_aptos";
            this.lbl_aptos.Size = new System.Drawing.Size(216, 20);
            this.lbl_aptos.TabIndex = 43;
            this.lbl_aptos.Text = "Perfiles Aptos Internamente";
            // 
            // Dgv_consultaAceptados
            // 
            this.Dgv_consultaAceptados.AllowUserToAddRows = false;
            this.Dgv_consultaAceptados.AllowUserToDeleteRows = false;
            this.Dgv_consultaAceptados.AllowUserToResizeColumns = false;
            this.Dgv_consultaAceptados.AllowUserToResizeRows = false;
            this.Dgv_consultaAceptados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaAceptados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaAceptados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.puesto});
            this.Dgv_consultaAceptados.Location = new System.Drawing.Point(24, 101);
            this.Dgv_consultaAceptados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_consultaAceptados.Name = "Dgv_consultaAceptados";
            this.Dgv_consultaAceptados.ReadOnly = true;
            this.Dgv_consultaAceptados.RowHeadersVisible = false;
            this.Dgv_consultaAceptados.RowHeadersWidth = 51;
            this.Dgv_consultaAceptados.RowTemplate.Height = 24;
            this.Dgv_consultaAceptados.Size = new System.Drawing.Size(1336, 133);
            this.Dgv_consultaAceptados.TabIndex = 44;
            // 
            // cod
            // 
            this.cod.HeaderText = "COD Perfil";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // puesto
            // 
            this.puesto.HeaderText = "COD Puesto";
            this.puesto.MinimumWidth = 6;
            this.puesto.Name = "puesto";
            this.puesto.ReadOnly = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(581, 457);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(307, 49);
            this.btn_buscar.TabIndex = 45;
            this.btn_buscar.Text = "Postular";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Empleados Internos Aptos";
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToAddRows = false;
            this.dgv_empleados.AllowUserToDeleteRows = false;
            this.dgv_empleados.AllowUserToResizeColumns = false;
            this.dgv_empleados.AllowUserToResizeRows = false;
            this.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codE,
            this.codJ,
            this.nombre,
            this.apellido});
            this.dgv_empleados.Location = new System.Drawing.Point(24, 298);
            this.dgv_empleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.RowHeadersVisible = false;
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.RowTemplate.Height = 24;
            this.dgv_empleados.Size = new System.Drawing.Size(1336, 138);
            this.dgv_empleados.TabIndex = 47;
            // 
            // codE
            // 
            this.codE.HeaderText = "COD Empleado";
            this.codE.MinimumWidth = 6;
            this.codE.Name = "codE";
            this.codE.ReadOnly = true;
            // 
            // codJ
            // 
            this.codJ.HeaderText = "COD Jornada";
            this.codJ.MinimumWidth = 6;
            this.codJ.Name = "codJ";
            this.codJ.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // Frm_filtroInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 519);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.Dgv_consultaAceptados);
            this.Controls.Add(this.lbl_aptos);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_filtroInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_filtroInterno";
            this.Load += new System.EventHandler(this.Frm_filtroInterno_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaAceptados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_procesonominal;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_aptos;
        public System.Windows.Forms.DataGridView Dgv_consultaAceptados;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codE;
        private System.Windows.Forms.DataGridViewTextBoxColumn codJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}