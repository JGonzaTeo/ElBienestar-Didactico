namespace Metas
{
    partial class Frm_Metas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Metas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Pnl_Desempeño = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_metaTitulo = new System.Windows.Forms.Label();
            this.Gpb_meta = new System.Windows.Forms.GroupBox();
            this.Nud_puntajeMeta = new System.Windows.Forms.NumericUpDown();
            this.Txt_nombreMeta = new System.Windows.Forms.TextBox();
            this.Lbl_puntaje = new System.Windows.Forms.Label();
            this.Txt_totalMeta = new System.Windows.Forms.TextBox();
            this.Lbl_totalMeta = new System.Windows.Forms.Label();
            this.Cob_completado = new System.Windows.Forms.ComboBox();
            this.Cob_tipoMeta = new System.Windows.Forms.ComboBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.Txt_empleadoMeta = new System.Windows.Forms.TextBox();
            this.Txt_fechaMeta = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_fechaMeta = new System.Windows.Forms.Label();
            this.Lbl_completado = new System.Windows.Forms.Label();
            this.Lbl_plazoMeta = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Lbl_codigoMeta = new System.Windows.Forms.Label();
            this.Txt_codigoMeta = new System.Windows.Forms.TextBox();
            this.Lbl_nombreMeta = new System.Windows.Forms.Label();
            this.Gpb_vista = new System.Windows.Forms.GroupBox();
            this.Dgv_vistaMeta = new System.Windows.Forms.DataGridView();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_grafica = new System.Windows.Forms.GroupBox();
            this.Ct_graficaMeta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pnl_Desempeño.SuspendLayout();
            this.Gpb_meta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_puntajeMeta)).BeginInit();
            this.Gpb_vista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_vistaMeta)).BeginInit();
            this.Gpb_grafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ct_graficaMeta)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Desempeño
            // 
            this.Pnl_Desempeño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_Desempeño.Controls.Add(this.Btn_ayuda);
            this.Pnl_Desempeño.Controls.Add(this.Btn_minimizar);
            this.Pnl_Desempeño.Controls.Add(this.Btn_cerrar);
            this.Pnl_Desempeño.Controls.Add(this.Lbl_metaTitulo);
            this.Pnl_Desempeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Desempeño.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Desempeño.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Desempeño.Name = "Pnl_Desempeño";
            this.Pnl_Desempeño.Size = new System.Drawing.Size(831, 51);
            this.Pnl_Desempeño.TabIndex = 3;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(750, 12);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(33, 31);
            this.Btn_ayuda.TabIndex = 9;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(714, 12);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(787, 12);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_metaTitulo
            // 
            this.Lbl_metaTitulo.AutoSize = true;
            this.Lbl_metaTitulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_metaTitulo.Location = new System.Drawing.Point(11, 17);
            this.Lbl_metaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_metaTitulo.Name = "Lbl_metaTitulo";
            this.Lbl_metaTitulo.Size = new System.Drawing.Size(199, 20);
            this.Lbl_metaTitulo.TabIndex = 0;
            this.Lbl_metaTitulo.Text = "META DEL EMPLEADO";
            // 
            // Gpb_meta
            // 
            this.Gpb_meta.Controls.Add(this.Nud_puntajeMeta);
            this.Gpb_meta.Controls.Add(this.Txt_nombreMeta);
            this.Gpb_meta.Controls.Add(this.Lbl_puntaje);
            this.Gpb_meta.Controls.Add(this.Txt_totalMeta);
            this.Gpb_meta.Controls.Add(this.Lbl_totalMeta);
            this.Gpb_meta.Controls.Add(this.Cob_completado);
            this.Gpb_meta.Controls.Add(this.Cob_tipoMeta);
            this.Gpb_meta.Controls.Add(this.Btn_Agregar);
            this.Gpb_meta.Controls.Add(this.Lbl_nombreEmpleado);
            this.Gpb_meta.Controls.Add(this.Txt_empleadoMeta);
            this.Gpb_meta.Controls.Add(this.Txt_fechaMeta);
            this.Gpb_meta.Controls.Add(this.Btn_buscar);
            this.Gpb_meta.Controls.Add(this.Lbl_fechaMeta);
            this.Gpb_meta.Controls.Add(this.Lbl_completado);
            this.Gpb_meta.Controls.Add(this.Lbl_plazoMeta);
            this.Gpb_meta.Controls.Add(this.Txt_descripcion);
            this.Gpb_meta.Controls.Add(this.Lbl_descripcion);
            this.Gpb_meta.Controls.Add(this.Lbl_codigoMeta);
            this.Gpb_meta.Controls.Add(this.Txt_codigoMeta);
            this.Gpb_meta.Controls.Add(this.Lbl_nombreMeta);
            this.Gpb_meta.Location = new System.Drawing.Point(12, 56);
            this.Gpb_meta.Name = "Gpb_meta";
            this.Gpb_meta.Size = new System.Drawing.Size(371, 259);
            this.Gpb_meta.TabIndex = 4;
            this.Gpb_meta.TabStop = false;
            this.Gpb_meta.Text = "Meta";
            // 
            // Nud_puntajeMeta
            // 
            this.Nud_puntajeMeta.Location = new System.Drawing.Point(259, 191);
            this.Nud_puntajeMeta.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nud_puntajeMeta.Name = "Nud_puntajeMeta";
            this.Nud_puntajeMeta.Size = new System.Drawing.Size(101, 20);
            this.Nud_puntajeMeta.TabIndex = 16;
            this.Nud_puntajeMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_nombreMeta
            // 
            this.Txt_nombreMeta.Location = new System.Drawing.Point(119, 97);
            this.Txt_nombreMeta.Name = "Txt_nombreMeta";
            this.Txt_nombreMeta.Size = new System.Drawing.Size(134, 20);
            this.Txt_nombreMeta.TabIndex = 15;
            // 
            // Lbl_puntaje
            // 
            this.Lbl_puntaje.AutoSize = true;
            this.Lbl_puntaje.Location = new System.Drawing.Point(266, 172);
            this.Lbl_puntaje.Name = "Lbl_puntaje";
            this.Lbl_puntaje.Size = new System.Drawing.Size(43, 13);
            this.Lbl_puntaje.TabIndex = 13;
            this.Lbl_puntaje.Text = "Puntaje";
            // 
            // Txt_totalMeta
            // 
            this.Txt_totalMeta.Enabled = false;
            this.Txt_totalMeta.Location = new System.Drawing.Point(257, 225);
            this.Txt_totalMeta.Name = "Txt_totalMeta";
            this.Txt_totalMeta.Size = new System.Drawing.Size(100, 20);
            this.Txt_totalMeta.TabIndex = 10;
            this.Txt_totalMeta.TextChanged += new System.EventHandler(this.Txt_totalMeta_TextChanged);
            // 
            // Lbl_totalMeta
            // 
            this.Lbl_totalMeta.AutoSize = true;
            this.Lbl_totalMeta.Location = new System.Drawing.Point(193, 225);
            this.Lbl_totalMeta.Name = "Lbl_totalMeta";
            this.Lbl_totalMeta.Size = new System.Drawing.Size(58, 13);
            this.Lbl_totalMeta.TabIndex = 12;
            this.Lbl_totalMeta.Text = "Total Meta";
            // 
            // Cob_completado
            // 
            this.Cob_completado.FormattingEnabled = true;
            this.Cob_completado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Cob_completado.Location = new System.Drawing.Point(11, 188);
            this.Cob_completado.Name = "Cob_completado";
            this.Cob_completado.Size = new System.Drawing.Size(109, 21);
            this.Cob_completado.TabIndex = 7;
            // 
            // Cob_tipoMeta
            // 
            this.Cob_tipoMeta.FormattingEnabled = true;
            this.Cob_tipoMeta.Items.AddRange(new object[] {
            "Corto",
            "Mediano"});
            this.Cob_tipoMeta.Location = new System.Drawing.Point(259, 97);
            this.Cob_tipoMeta.Name = "Cob_tipoMeta";
            this.Cob_tipoMeta.Size = new System.Drawing.Size(101, 21);
            this.Cob_tipoMeta.TabIndex = 5;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(29, 225);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Agregar.TabIndex = 11;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Lbl_nombreEmpleado
            // 
            this.Lbl_nombreEmpleado.AutoSize = true;
            this.Lbl_nombreEmpleado.Location = new System.Drawing.Point(26, 26);
            this.Lbl_nombreEmpleado.Name = "Lbl_nombreEmpleado";
            this.Lbl_nombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.Lbl_nombreEmpleado.TabIndex = 6;
            this.Lbl_nombreEmpleado.Text = "Nombre Empleado";
            // 
            // Txt_empleadoMeta
            // 
            this.Txt_empleadoMeta.Location = new System.Drawing.Point(11, 42);
            this.Txt_empleadoMeta.Name = "Txt_empleadoMeta";
            this.Txt_empleadoMeta.Size = new System.Drawing.Size(262, 20);
            this.Txt_empleadoMeta.TabIndex = 1;
            this.Txt_empleadoMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_fechaMeta
            // 
            this.Txt_fechaMeta.Enabled = false;
            this.Txt_fechaMeta.Location = new System.Drawing.Point(143, 188);
            this.Txt_fechaMeta.Name = "Txt_fechaMeta";
            this.Txt_fechaMeta.Size = new System.Drawing.Size(98, 20);
            this.Txt_fechaMeta.TabIndex = 8;
            this.Txt_fechaMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(285, 39);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 2;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Lbl_fechaMeta
            // 
            this.Lbl_fechaMeta.AutoSize = true;
            this.Lbl_fechaMeta.Location = new System.Drawing.Point(152, 172);
            this.Lbl_fechaMeta.Name = "Lbl_fechaMeta";
            this.Lbl_fechaMeta.Size = new System.Drawing.Size(79, 13);
            this.Lbl_fechaMeta.TabIndex = 11;
            this.Lbl_fechaMeta.Text = "Fecha de Meta";
            // 
            // Lbl_completado
            // 
            this.Lbl_completado.AutoSize = true;
            this.Lbl_completado.Location = new System.Drawing.Point(26, 172);
            this.Lbl_completado.Name = "Lbl_completado";
            this.Lbl_completado.Size = new System.Drawing.Size(63, 13);
            this.Lbl_completado.TabIndex = 10;
            this.Lbl_completado.Text = "Completado";
            // 
            // Lbl_plazoMeta
            // 
            this.Lbl_plazoMeta.AutoSize = true;
            this.Lbl_plazoMeta.Location = new System.Drawing.Point(266, 81);
            this.Lbl_plazoMeta.Name = "Lbl_plazoMeta";
            this.Lbl_plazoMeta.Size = new System.Drawing.Size(60, 13);
            this.Lbl_plazoMeta.TabIndex = 9;
            this.Lbl_plazoMeta.Text = "Plazo Meta";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(11, 146);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(349, 20);
            this.Txt_descripcion.TabIndex = 6;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(26, 130);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(63, 13);
            this.Lbl_descripcion.TabIndex = 4;
            this.Lbl_descripcion.Text = "Descripción";
            // 
            // Lbl_codigoMeta
            // 
            this.Lbl_codigoMeta.AutoSize = true;
            this.Lbl_codigoMeta.Location = new System.Drawing.Point(26, 81);
            this.Lbl_codigoMeta.Name = "Lbl_codigoMeta";
            this.Lbl_codigoMeta.Size = new System.Drawing.Size(40, 13);
            this.Lbl_codigoMeta.TabIndex = 3;
            this.Lbl_codigoMeta.Text = "Código";
            // 
            // Txt_codigoMeta
            // 
            this.Txt_codigoMeta.Enabled = false;
            this.Txt_codigoMeta.Location = new System.Drawing.Point(11, 97);
            this.Txt_codigoMeta.Name = "Txt_codigoMeta";
            this.Txt_codigoMeta.Size = new System.Drawing.Size(100, 20);
            this.Txt_codigoMeta.TabIndex = 3;
            this.Txt_codigoMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_nombreMeta
            // 
            this.Lbl_nombreMeta.AutoSize = true;
            this.Lbl_nombreMeta.Location = new System.Drawing.Point(140, 81);
            this.Lbl_nombreMeta.Name = "Lbl_nombreMeta";
            this.Lbl_nombreMeta.Size = new System.Drawing.Size(71, 13);
            this.Lbl_nombreMeta.TabIndex = 0;
            this.Lbl_nombreMeta.Text = "Nombre Meta";
            // 
            // Gpb_vista
            // 
            this.Gpb_vista.Controls.Add(this.Dgv_vistaMeta);
            this.Gpb_vista.Location = new System.Drawing.Point(15, 321);
            this.Gpb_vista.Name = "Gpb_vista";
            this.Gpb_vista.Size = new System.Drawing.Size(368, 221);
            this.Gpb_vista.TabIndex = 5;
            this.Gpb_vista.TabStop = false;
            this.Gpb_vista.Text = "Vista";
            // 
            // Dgv_vistaMeta
            // 
            this.Dgv_vistaMeta.AllowUserToDeleteRows = false;
            this.Dgv_vistaMeta.AllowUserToOrderColumns = true;
            this.Dgv_vistaMeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_vistaMeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.Meta,
            this.Puntaje});
            this.Dgv_vistaMeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_vistaMeta.Location = new System.Drawing.Point(3, 16);
            this.Dgv_vistaMeta.Name = "Dgv_vistaMeta";
            this.Dgv_vistaMeta.RowHeadersVisible = false;
            this.Dgv_vistaMeta.Size = new System.Drawing.Size(362, 202);
            this.Dgv_vistaMeta.TabIndex = 0;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // Meta
            // 
            this.Meta.HeaderText = "Meta";
            this.Meta.Name = "Meta";
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            // 
            // Gpb_grafica
            // 
            this.Gpb_grafica.Controls.Add(this.Ct_graficaMeta);
            this.Gpb_grafica.Location = new System.Drawing.Point(389, 56);
            this.Gpb_grafica.Name = "Gpb_grafica";
            this.Gpb_grafica.Size = new System.Drawing.Size(431, 483);
            this.Gpb_grafica.TabIndex = 0;
            this.Gpb_grafica.TabStop = false;
            this.Gpb_grafica.Text = "Gráfica";
            // 
            // Ct_graficaMeta
            // 
            chartArea1.Name = "ChartArea1";
            this.Ct_graficaMeta.ChartAreas.Add(chartArea1);
            this.Ct_graficaMeta.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Ct_graficaMeta.Legends.Add(legend1);
            this.Ct_graficaMeta.Location = new System.Drawing.Point(3, 16);
            this.Ct_graficaMeta.Name = "Ct_graficaMeta";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.Ct_graficaMeta.Series.Add(series1);
            this.Ct_graficaMeta.Size = new System.Drawing.Size(425, 464);
            this.Ct_graficaMeta.TabIndex = 0;
            this.Ct_graficaMeta.Text = "chart1";
            this.Ct_graficaMeta.Click += new System.EventHandler(this.Ct_graficaMeta_Click);
            // 
            // Frm_Metas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 551);
            this.Controls.Add(this.Gpb_grafica);
            this.Controls.Add(this.Gpb_vista);
            this.Controls.Add(this.Gpb_meta);
            this.Controls.Add(this.Pnl_Desempeño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Metas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Pnl_Desempeño.ResumeLayout(false);
            this.Pnl_Desempeño.PerformLayout();
            this.Gpb_meta.ResumeLayout(false);
            this.Gpb_meta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_puntajeMeta)).EndInit();
            this.Gpb_vista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_vistaMeta)).EndInit();
            this.Gpb_grafica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ct_graficaMeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Desempeño;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_metaTitulo;
        private System.Windows.Forms.GroupBox Gpb_meta;
        private System.Windows.Forms.Label Lbl_fechaMeta;
        private System.Windows.Forms.Label Lbl_completado;
        private System.Windows.Forms.Label Lbl_plazoMeta;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_empleadoMeta;
        private System.Windows.Forms.Label Lbl_nombreEmpleado;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label Lbl_codigoMeta;
        private System.Windows.Forms.TextBox Txt_codigoMeta;
        private System.Windows.Forms.Label Lbl_nombreMeta;
        private System.Windows.Forms.GroupBox Gpb_vista;
        private System.Windows.Forms.GroupBox Gpb_grafica;
        private System.Windows.Forms.TextBox Txt_fechaMeta;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView Dgv_vistaMeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.ComboBox Cob_completado;
        private System.Windows.Forms.ComboBox Cob_tipoMeta;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ct_graficaMeta;
        private System.Windows.Forms.Label Lbl_totalMeta;
        private System.Windows.Forms.Label Lbl_puntaje;
        private System.Windows.Forms.TextBox Txt_nombreMeta;
        private System.Windows.Forms.NumericUpDown Nud_puntajeMeta;
        public System.Windows.Forms.TextBox Txt_totalMeta;
    }
}

