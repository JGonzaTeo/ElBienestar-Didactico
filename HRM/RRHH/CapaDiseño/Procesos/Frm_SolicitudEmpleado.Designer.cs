namespace Recursos_Humanos
{
    partial class Frm_SolicitudEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_idCreador = new System.Windows.Forms.TextBox();
            this.btn_buscarEmpleado = new System.Windows.Forms.Button();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.txt_idPerfil = new System.Windows.Forms.TextBox();
            this.btn_buscarPerfil = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fechaS = new System.Windows.Forms.DateTimePicker();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cmb_TipoContratacion = new System.Windows.Forms.ComboBox();
            this.lbl_estudios = new System.Windows.Forms.Label();
            this.lbl_desCursos = new System.Windows.Forms.Label();
            this.txt_extras = new System.Windows.Forms.TextBox();
            this.lbl_medio = new System.Windows.Forms.Label();
            this.txt_medio = new System.Windows.Forms.TextBox();
            this.btn_buscarMedio = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.chc_Cursos = new System.Windows.Forms.CheckBox();
            this.chc_Graduado = new System.Windows.Forms.CheckBox();
            this.chc_Estudiante = new System.Windows.Forms.CheckBox();
            this.chc_bachillerato = new System.Windows.Forms.CheckBox();
            this.chc_secundaria = new System.Windows.Forms.CheckBox();
            this.chc_primaria = new System.Windows.Forms.CheckBox();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_gUniversidad = new System.Windows.Forms.Label();
            this.lbl_estuUni = new System.Windows.Forms.Label();
            this.lbl_bachillerato = new System.Windows.Forms.Label();
            this.lbl_secundaria = new System.Windows.Forms.Label();
            this.lbl_primaria = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_siguiente = new System.Windows.Forms.Label();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(972, 52);
            this.panel1.TabIndex = 9;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(13, 20);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(254, 23);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Solicitud nuevo empleado";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(4, 17);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(137, 17);
            this.lbl_nom.TabIndex = 19;
            this.lbl_nom.Text = "ID creador solicitud:";
            // 
            // txt_idCreador
            // 
            this.txt_idCreador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idCreador.Location = new System.Drawing.Point(169, 17);
            this.txt_idCreador.Name = "txt_idCreador";
            this.txt_idCreador.Size = new System.Drawing.Size(170, 23);
            this.txt_idCreador.TabIndex = 18;
            // 
            // btn_buscarEmpleado
            // 
            this.btn_buscarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarEmpleado.Location = new System.Drawing.Point(345, 17);
            this.btn_buscarEmpleado.Name = "btn_buscarEmpleado";
            this.btn_buscarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarEmpleado.TabIndex = 17;
            this.btn_buscarEmpleado.Text = "Buscar";
            this.btn_buscarEmpleado.UseVisualStyleBackColor = true;
            this.btn_buscarEmpleado.Click += new System.EventHandler(this.Btn_buscarEmpleado_Click);
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfil.Location = new System.Drawing.Point(4, 85);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(60, 17);
            this.lbl_perfil.TabIndex = 22;
            this.lbl_perfil.Text = "ID perfil:";
            // 
            // txt_idPerfil
            // 
            this.txt_idPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idPerfil.Location = new System.Drawing.Point(169, 85);
            this.txt_idPerfil.Name = "txt_idPerfil";
            this.txt_idPerfil.Size = new System.Drawing.Size(170, 23);
            this.txt_idPerfil.TabIndex = 21;
            // 
            // btn_buscarPerfil
            // 
            this.btn_buscarPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarPerfil.Location = new System.Drawing.Point(345, 85);
            this.btn_buscarPerfil.Name = "btn_buscarPerfil";
            this.btn_buscarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarPerfil.TabIndex = 20;
            this.btn_buscarPerfil.Text = "Buscar";
            this.btn_buscarPerfil.UseVisualStyleBackColor = true;
            this.btn_buscarPerfil.Click += new System.EventHandler(this.Btn_buscarPerfil_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(4, 53);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(129, 17);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha de solicitud:";
            // 
            // dtp_fechaS
            // 
            this.dtp_fechaS.Location = new System.Drawing.Point(169, 56);
            this.dtp_fechaS.Name = "dtp_fechaS";
            this.dtp_fechaS.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaS.TabIndex = 24;
            this.dtp_fechaS.ValueChanged += new System.EventHandler(this.Dtp_fechaS_ValueChanged);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(471, 20);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(148, 17);
            this.lbl_tipo.TabIndex = 25;
            this.lbl_tipo.Text = "Tipo de contratacion:";
            // 
            // cmb_TipoContratacion
            // 
            this.cmb_TipoContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoContratacion.FormattingEnabled = true;
            this.cmb_TipoContratacion.Items.AddRange(new object[] {
            "Contrato Temporal",
            "Contrato Indefinido",
            "Planilla"});
            this.cmb_TipoContratacion.Location = new System.Drawing.Point(671, 20);
            this.cmb_TipoContratacion.Name = "cmb_TipoContratacion";
            this.cmb_TipoContratacion.Size = new System.Drawing.Size(170, 21);
            this.cmb_TipoContratacion.TabIndex = 26;
            this.cmb_TipoContratacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_TipoContratacion_SelectedIndexChanged);
            // 
            // lbl_estudios
            // 
            this.lbl_estudios.AutoSize = true;
            this.lbl_estudios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estudios.Location = new System.Drawing.Point(4, 9);
            this.lbl_estudios.Name = "lbl_estudios";
            this.lbl_estudios.Size = new System.Drawing.Size(134, 17);
            this.lbl_estudios.TabIndex = 28;
            this.lbl_estudios.Text = "Estudios necesarios:";
            // 
            // lbl_desCursos
            // 
            this.lbl_desCursos.AutoSize = true;
            this.lbl_desCursos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desCursos.Location = new System.Drawing.Point(464, 9);
            this.lbl_desCursos.Name = "lbl_desCursos";
            this.lbl_desCursos.Size = new System.Drawing.Size(171, 17);
            this.lbl_desCursos.TabIndex = 30;
            this.lbl_desCursos.Text = "Descripcion cursos extras:";
            // 
            // txt_extras
            // 
            this.txt_extras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_extras.Location = new System.Drawing.Point(467, 29);
            this.txt_extras.Multiline = true;
            this.txt_extras.Name = "txt_extras";
            this.txt_extras.Size = new System.Drawing.Size(413, 181);
            this.txt_extras.TabIndex = 29;
            this.txt_extras.TextChanged += new System.EventHandler(this.Txt_cualidades_TextChanged);
            this.txt_extras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_extras_KeyUp);
            // 
            // lbl_medio
            // 
            this.lbl_medio.AutoSize = true;
            this.lbl_medio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medio.Location = new System.Drawing.Point(471, 59);
            this.lbl_medio.Name = "lbl_medio";
            this.lbl_medio.Size = new System.Drawing.Size(193, 17);
            this.lbl_medio.TabIndex = 33;
            this.lbl_medio.Text = "ID medio de Comunicacion:";
            // 
            // txt_medio
            // 
            this.txt_medio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medio.Location = new System.Drawing.Point(671, 53);
            this.txt_medio.Name = "txt_medio";
            this.txt_medio.Size = new System.Drawing.Size(170, 23);
            this.txt_medio.TabIndex = 32;
            // 
            // btn_buscarMedio
            // 
            this.btn_buscarMedio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarMedio.Location = new System.Drawing.Point(847, 53);
            this.btn_buscarMedio.Name = "btn_buscarMedio";
            this.btn_buscarMedio.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarMedio.TabIndex = 31;
            this.btn_buscarMedio.Text = "Buscar";
            this.btn_buscarMedio.UseVisualStyleBackColor = true;
            this.btn_buscarMedio.Click += new System.EventHandler(this.Btn_buscarMedio_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(411, 472);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(169, 40);
            this.btn_guardar.TabIndex = 34;
            this.btn_guardar.Text = "Generar solicitud";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.txt_sueldo);
            this.panel2.Controls.Add(this.lbl_sueldo);
            this.panel2.Controls.Add(this.chc_Cursos);
            this.panel2.Controls.Add(this.chc_Graduado);
            this.panel2.Controls.Add(this.chc_Estudiante);
            this.panel2.Controls.Add(this.chc_bachillerato);
            this.panel2.Controls.Add(this.chc_secundaria);
            this.panel2.Controls.Add(this.chc_primaria);
            this.panel2.Controls.Add(this.lbl_curso);
            this.panel2.Controls.Add(this.lbl_gUniversidad);
            this.panel2.Controls.Add(this.lbl_estuUni);
            this.panel2.Controls.Add(this.lbl_bachillerato);
            this.panel2.Controls.Add(this.lbl_secundaria);
            this.panel2.Controls.Add(this.lbl_primaria);
            this.panel2.Controls.Add(this.lbl_estudios);
            this.panel2.Controls.Add(this.lbl_desCursos);
            this.panel2.Controls.Add(this.txt_extras);
            this.panel2.Location = new System.Drawing.Point(37, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 220);
            this.panel2.TabIndex = 35;
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldo.Location = new System.Drawing.Point(163, 187);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(170, 23);
            this.txt_sueldo.TabIndex = 34;
            this.txt_sueldo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_sueldo_KeyUp);
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldo.Location = new System.Drawing.Point(34, 193);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(88, 17);
            this.lbl_sueldo.TabIndex = 43;
            this.lbl_sueldo.Text = "Sueldo Base:";
            // 
            // chc_Cursos
            // 
            this.chc_Cursos.AutoSize = true;
            this.chc_Cursos.Location = new System.Drawing.Point(288, 170);
            this.chc_Cursos.Name = "chc_Cursos";
            this.chc_Cursos.Size = new System.Drawing.Size(15, 14);
            this.chc_Cursos.TabIndex = 42;
            this.chc_Cursos.UseVisualStyleBackColor = true;
            this.chc_Cursos.CheckedChanged += new System.EventHandler(this.Chc_Cursos_CheckedChanged);
            // 
            // chc_Graduado
            // 
            this.chc_Graduado.AutoSize = true;
            this.chc_Graduado.Location = new System.Drawing.Point(288, 144);
            this.chc_Graduado.Name = "chc_Graduado";
            this.chc_Graduado.Size = new System.Drawing.Size(15, 14);
            this.chc_Graduado.TabIndex = 41;
            this.chc_Graduado.UseVisualStyleBackColor = true;
            this.chc_Graduado.CheckedChanged += new System.EventHandler(this.Chc_Graduado_CheckedChanged);
            // 
            // chc_Estudiante
            // 
            this.chc_Estudiante.AutoSize = true;
            this.chc_Estudiante.Location = new System.Drawing.Point(288, 118);
            this.chc_Estudiante.Name = "chc_Estudiante";
            this.chc_Estudiante.Size = new System.Drawing.Size(15, 14);
            this.chc_Estudiante.TabIndex = 40;
            this.chc_Estudiante.UseVisualStyleBackColor = true;
            this.chc_Estudiante.CheckedChanged += new System.EventHandler(this.Chc_Estudiante_CheckedChanged);
            // 
            // chc_bachillerato
            // 
            this.chc_bachillerato.AutoSize = true;
            this.chc_bachillerato.Location = new System.Drawing.Point(288, 92);
            this.chc_bachillerato.Name = "chc_bachillerato";
            this.chc_bachillerato.Size = new System.Drawing.Size(15, 14);
            this.chc_bachillerato.TabIndex = 39;
            this.chc_bachillerato.UseVisualStyleBackColor = true;
            this.chc_bachillerato.CheckedChanged += new System.EventHandler(this.Chc_bachillerato_CheckedChanged);
            // 
            // chc_secundaria
            // 
            this.chc_secundaria.AutoSize = true;
            this.chc_secundaria.Location = new System.Drawing.Point(288, 65);
            this.chc_secundaria.Name = "chc_secundaria";
            this.chc_secundaria.Size = new System.Drawing.Size(15, 14);
            this.chc_secundaria.TabIndex = 38;
            this.chc_secundaria.UseVisualStyleBackColor = true;
            this.chc_secundaria.CheckedChanged += new System.EventHandler(this.Chc_secundaria_CheckedChanged);
            // 
            // chc_primaria
            // 
            this.chc_primaria.AutoSize = true;
            this.chc_primaria.Location = new System.Drawing.Point(288, 39);
            this.chc_primaria.Name = "chc_primaria";
            this.chc_primaria.Size = new System.Drawing.Size(15, 14);
            this.chc_primaria.TabIndex = 37;
            this.chc_primaria.UseVisualStyleBackColor = true;
            this.chc_primaria.CheckedChanged += new System.EventHandler(this.Chc_primaria_CheckedChanged);
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso.Location = new System.Drawing.Point(34, 170);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(94, 17);
            this.lbl_curso.TabIndex = 36;
            this.lbl_curso.Text = "Cursos Extras:";
            // 
            // lbl_gUniversidad
            // 
            this.lbl_gUniversidad.AutoSize = true;
            this.lbl_gUniversidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gUniversidad.Location = new System.Drawing.Point(34, 144);
            this.lbl_gUniversidad.Name = "lbl_gUniversidad";
            this.lbl_gUniversidad.Size = new System.Drawing.Size(158, 17);
            this.lbl_gUniversidad.TabIndex = 35;
            this.lbl_gUniversidad.Text = "Graduado Universidad:";
            // 
            // lbl_estuUni
            // 
            this.lbl_estuUni.AutoSize = true;
            this.lbl_estuUni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estuUni.Location = new System.Drawing.Point(34, 118);
            this.lbl_estuUni.Name = "lbl_estuUni";
            this.lbl_estuUni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_estuUni.Size = new System.Drawing.Size(160, 17);
            this.lbl_estuUni.TabIndex = 34;
            this.lbl_estuUni.Text = "Estudiante Universitario:";
            // 
            // lbl_bachillerato
            // 
            this.lbl_bachillerato.AutoSize = true;
            this.lbl_bachillerato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bachillerato.Location = new System.Drawing.Point(34, 92);
            this.lbl_bachillerato.Name = "lbl_bachillerato";
            this.lbl_bachillerato.Size = new System.Drawing.Size(88, 17);
            this.lbl_bachillerato.TabIndex = 33;
            this.lbl_bachillerato.Text = "Bachillerato:";
            // 
            // lbl_secundaria
            // 
            this.lbl_secundaria.AutoSize = true;
            this.lbl_secundaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secundaria.Location = new System.Drawing.Point(34, 65);
            this.lbl_secundaria.Name = "lbl_secundaria";
            this.lbl_secundaria.Size = new System.Drawing.Size(84, 17);
            this.lbl_secundaria.TabIndex = 32;
            this.lbl_secundaria.Text = "Secundaria:";
            // 
            // lbl_primaria
            // 
            this.lbl_primaria.AutoSize = true;
            this.lbl_primaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primaria.Location = new System.Drawing.Point(34, 39);
            this.lbl_primaria.Name = "lbl_primaria";
            this.lbl_primaria.Size = new System.Drawing.Size(65, 17);
            this.lbl_primaria.TabIndex = 31;
            this.lbl_primaria.Text = "Primaria:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.lbl_nom);
            this.panel3.Controls.Add(this.btn_buscarEmpleado);
            this.panel3.Controls.Add(this.lbl_medio);
            this.panel3.Controls.Add(this.txt_idCreador);
            this.panel3.Controls.Add(this.txt_medio);
            this.panel3.Controls.Add(this.btn_buscarPerfil);
            this.panel3.Controls.Add(this.btn_buscarMedio);
            this.panel3.Controls.Add(this.txt_idPerfil);
            this.panel3.Controls.Add(this.cmb_TipoContratacion);
            this.panel3.Controls.Add(this.lbl_perfil);
            this.panel3.Controls.Add(this.lbl_tipo);
            this.panel3.Controls.Add(this.lbl_fecha);
            this.panel3.Controls.Add(this.dtp_fechaS);
            this.panel3.Location = new System.Drawing.Point(31, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 132);
            this.panel3.TabIndex = 31;
            // 
            // lbl_siguiente
            // 
            this.lbl_siguiente.AutoSize = true;
            this.lbl_siguiente.BackColor = System.Drawing.Color.White;
            this.lbl_siguiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_siguiente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_siguiente.Location = new System.Drawing.Point(30, 67);
            this.lbl_siguiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_siguiente.Name = "lbl_siguiente";
            this.lbl_siguiente.Size = new System.Drawing.Size(140, 22);
            this.lbl_siguiente.TabIndex = 36;
            this.lbl_siguiente.Text = "Siguiente Codigo:";
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.BorderSize = 0;
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btn_consulta.Location = new System.Drawing.Point(878, 55);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(40, 40);
            this.btn_consulta.TabIndex = 3;
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.Btn_minimizar.Location = new System.Drawing.Point(831, 9);
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
 
            this.Btn_salir.Location = new System.Drawing.Point(920, 9);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(40, 40);
            this.Btn_salir.TabIndex = 2;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_SolicitudEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 524);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.lbl_siguiente);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SolicitudEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SolicitudEmpleado";
            this.Load += new System.EventHandler(this.Frm_SolicitudEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_idCreador;
        private System.Windows.Forms.Button btn_buscarEmpleado;
        private System.Windows.Forms.Label lbl_perfil;
        private System.Windows.Forms.TextBox txt_idPerfil;
        private System.Windows.Forms.Button btn_buscarPerfil;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fechaS;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmb_TipoContratacion;
        private System.Windows.Forms.Label lbl_estudios;
        private System.Windows.Forms.Label lbl_desCursos;
        private System.Windows.Forms.TextBox txt_extras;
        private System.Windows.Forms.Label lbl_medio;
        private System.Windows.Forms.TextBox txt_medio;
        private System.Windows.Forms.Button btn_buscarMedio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_gUniversidad;
        private System.Windows.Forms.Label lbl_estuUni;
        private System.Windows.Forms.Label lbl_bachillerato;
        private System.Windows.Forms.Label lbl_secundaria;
        private System.Windows.Forms.Label lbl_primaria;
        private System.Windows.Forms.CheckBox chc_Cursos;
        private System.Windows.Forms.CheckBox chc_Graduado;
        private System.Windows.Forms.CheckBox chc_Estudiante;
        private System.Windows.Forms.CheckBox chc_bachillerato;
        private System.Windows.Forms.CheckBox chc_secundaria;
        private System.Windows.Forms.CheckBox chc_primaria;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.Label lbl_siguiente;
        private System.Windows.Forms.Button btn_consulta;
    }
}