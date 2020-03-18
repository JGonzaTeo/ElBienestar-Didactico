namespace Recursos_Humanos
{
    partial class Frm_filtroPreSeleccion
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_consultaAceptados = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_aptos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_consultaRecha = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaAceptados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaRecha)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(13, 20);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(264, 23);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Preseleccion de Candidato";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(173)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_salir);
            this.panel1.Controls.Add(this.Lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 52);
            this.panel1.TabIndex = 15;
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
            this.nom,
            this.ape,
            this.pri,
            this.sec,
            this.ba,
            this.eU,
            this.gU,
            this.curE,
            this.sueldo});
            this.Dgv_consultaAceptados.Location = new System.Drawing.Point(15, 98);
            this.Dgv_consultaAceptados.Name = "Dgv_consultaAceptados";
            this.Dgv_consultaAceptados.ReadOnly = true;
            this.Dgv_consultaAceptados.RowHeadersVisible = false;
            this.Dgv_consultaAceptados.RowHeadersWidth = 51;
            this.Dgv_consultaAceptados.RowTemplate.Height = 24;
            this.Dgv_consultaAceptados.Size = new System.Drawing.Size(1002, 184);
            this.Dgv_consultaAceptados.TabIndex = 34;
            this.Dgv_consultaAceptados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consultaAceptados_CellClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "ID";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // ape
            // 
            this.ape.HeaderText = "Apellido";
            this.ape.Name = "ape";
            this.ape.ReadOnly = true;
            // 
            // pri
            // 
            this.pri.HeaderText = "Primaria";
            this.pri.Name = "pri";
            this.pri.ReadOnly = true;
            // 
            // sec
            // 
            this.sec.HeaderText = "Secundaria";
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            // 
            // ba
            // 
            this.ba.HeaderText = "Bachillerato";
            this.ba.Name = "ba";
            this.ba.ReadOnly = true;
            // 
            // eU
            // 
            this.eU.HeaderText = "Estudiante Universitario";
            this.eU.Name = "eU";
            this.eU.ReadOnly = true;
            // 
            // gU
            // 
            this.gU.HeaderText = "Graduado Universitario";
            this.gU.Name = "gU";
            this.gU.ReadOnly = true;
            // 
            // curE
            // 
            this.curE.HeaderText = "Curso Extra";
            this.curE.Name = "curE";
            this.curE.ReadOnly = true;
            // 
            // sueldo
            // 
            this.sueldo.HeaderText = "Sueldo Esperado";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            // 
            // lbl_aptos
            // 
            this.lbl_aptos.AutoSize = true;
            this.lbl_aptos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aptos.Location = new System.Drawing.Point(14, 68);
            this.lbl_aptos.Name = "lbl_aptos";
            this.lbl_aptos.Size = new System.Drawing.Size(143, 17);
            this.lbl_aptos.TabIndex = 35;
            this.lbl_aptos.Text = "Aptos para el puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "No aptos para el puesto";
            // 
            // Dgv_consultaRecha
            // 
            this.Dgv_consultaRecha.AllowUserToAddRows = false;
            this.Dgv_consultaRecha.AllowUserToDeleteRows = false;
            this.Dgv_consultaRecha.AllowUserToResizeColumns = false;
            this.Dgv_consultaRecha.AllowUserToResizeRows = false;
            this.Dgv_consultaRecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaRecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaRecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.Dgv_consultaRecha.Location = new System.Drawing.Point(15, 324);
            this.Dgv_consultaRecha.Name = "Dgv_consultaRecha";
            this.Dgv_consultaRecha.ReadOnly = true;
            this.Dgv_consultaRecha.RowHeadersVisible = false;
            this.Dgv_consultaRecha.RowHeadersWidth = 51;
            this.Dgv_consultaRecha.RowTemplate.Height = 24;
            this.Dgv_consultaRecha.Size = new System.Drawing.Size(1002, 184);
            this.Dgv_consultaRecha.TabIndex = 40;
            this.Dgv_consultaRecha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_consultaRecha_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Primaria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Secundaria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Bachillerato";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Estudiante Universitario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Graduado Universitario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Curso Extra";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Sueldo Esperado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::Recursos_Humanos.Properties.Resources.icons8_guardar_50;
            this.btn_buscar.Location = new System.Drawing.Point(1023, 98);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(55, 184);
            this.btn_buscar.TabIndex = 38;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = global::Recursos_Humanos.Properties.Resources.icons8_minimizar_la_ventana_35;
            this.Btn_minimizar.Location = new System.Drawing.Point(937, 9);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.Btn_minimizar.TabIndex = 1;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Recursos_Humanos.Properties.Resources.icons8_cerrar_ventana_35;
            this.Btn_salir.Location = new System.Drawing.Point(1026, 9);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(40, 40);
            this.Btn_salir.TabIndex = 2;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_filtroPreSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 520);
            this.Controls.Add(this.Dgv_consultaRecha);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_aptos);
            this.Controls.Add(this.Dgv_consultaAceptados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_filtroPreSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_filtroPreSeleccion";
            this.Load += new System.EventHandler(this.Frm_filtroPreSeleccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaAceptados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaRecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_salir;
        public System.Windows.Forms.DataGridView Dgv_consultaAceptados;
        private System.Windows.Forms.Label lbl_aptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ba;
        private System.Windows.Forms.DataGridViewTextBoxColumn eU;
        private System.Windows.Forms.DataGridViewTextBoxColumn gU;
        private System.Windows.Forms.DataGridViewTextBoxColumn curE;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        public System.Windows.Forms.DataGridView Dgv_consultaRecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}