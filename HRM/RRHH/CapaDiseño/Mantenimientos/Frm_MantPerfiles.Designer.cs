namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantPerfiles));
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.btn_buscarCreador = new System.Windows.Forms.Button();
            this.lbl_desCursos = new System.Windows.Forms.Label();
            this.txt_extras = new System.Windows.Forms.TextBox();
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
            this.Txt_puesto = new System.Windows.Forms.TextBox();
            this.Lbl_nom = new System.Windows.Forms.Label();
            this.Lbl_codPercepcion = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE PERFILES";
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(1, 1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1293, 63);
            this.Pnl_nombreForm.TabIndex = 69;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1183, 15);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1136, 15);
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
            this.btn_cerrar.Location = new System.Drawing.Point(1233, 15);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.btn_buscarCreador);
            this.gpb_datos.Controls.Add(this.lbl_desCursos);
            this.gpb_datos.Controls.Add(this.txt_extras);
            this.gpb_datos.Controls.Add(this.chc_Cursos);
            this.gpb_datos.Controls.Add(this.chc_Graduado);
            this.gpb_datos.Controls.Add(this.chc_Estudiante);
            this.gpb_datos.Controls.Add(this.chc_bachillerato);
            this.gpb_datos.Controls.Add(this.chc_secundaria);
            this.gpb_datos.Controls.Add(this.chc_primaria);
            this.gpb_datos.Controls.Add(this.lbl_curso);
            this.gpb_datos.Controls.Add(this.lbl_gUniversidad);
            this.gpb_datos.Controls.Add(this.lbl_estuUni);
            this.gpb_datos.Controls.Add(this.lbl_bachillerato);
            this.gpb_datos.Controls.Add(this.lbl_secundaria);
            this.gpb_datos.Controls.Add(this.lbl_primaria);
            this.gpb_datos.Controls.Add(this.Txt_puesto);
            this.gpb_datos.Controls.Add(this.Lbl_nom);
            this.gpb_datos.Controls.Add(this.Lbl_codPercepcion);
            this.gpb_datos.Controls.Add(this.Txt_Cod);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(32, 235);
            this.gpb_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_datos.Size = new System.Drawing.Size(1221, 432);
            this.gpb_datos.TabIndex = 75;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Encabezado";
            // 
            // btn_buscarCreador
            // 
            this.btn_buscarCreador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_buscarCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarCreador.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_buscarCreador.Location = new System.Drawing.Point(548, 92);
            this.btn_buscarCreador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscarCreador.Name = "btn_buscarCreador";
            this.btn_buscarCreador.Size = new System.Drawing.Size(53, 42);
            this.btn_buscarCreador.TabIndex = 75;
            this.btn_buscarCreador.Text = "B";
            this.btn_buscarCreador.UseVisualStyleBackColor = false;
            this.btn_buscarCreador.Click += new System.EventHandler(this.btn_buscarCreador_Click);
            // 
            // lbl_desCursos
            // 
            this.lbl_desCursos.AutoSize = true;
            this.lbl_desCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desCursos.Location = new System.Drawing.Point(33, 252);
            this.lbl_desCursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desCursos.Name = "lbl_desCursos";
            this.lbl_desCursos.Size = new System.Drawing.Size(211, 20);
            this.lbl_desCursos.TabIndex = 74;
            this.lbl_desCursos.Text = "Descripcion cursos extras:";
            // 
            // txt_extras
            // 
            this.txt_extras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_extras.Location = new System.Drawing.Point(39, 281);
            this.txt_extras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_extras.Multiline = true;
            this.txt_extras.Name = "txt_extras";
            this.txt_extras.Size = new System.Drawing.Size(665, 111);
            this.txt_extras.TabIndex = 73;
            // 
            // chc_Cursos
            // 
            this.chc_Cursos.AutoSize = true;
            this.chc_Cursos.Location = new System.Drawing.Point(1033, 103);
            this.chc_Cursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_Cursos.Name = "chc_Cursos";
            this.chc_Cursos.Size = new System.Drawing.Size(18, 17);
            this.chc_Cursos.TabIndex = 72;
            this.chc_Cursos.UseVisualStyleBackColor = true;
            // 
            // chc_Graduado
            // 
            this.chc_Graduado.AutoSize = true;
            this.chc_Graduado.Location = new System.Drawing.Point(1035, 49);
            this.chc_Graduado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_Graduado.Name = "chc_Graduado";
            this.chc_Graduado.Size = new System.Drawing.Size(18, 17);
            this.chc_Graduado.TabIndex = 71;
            this.chc_Graduado.UseVisualStyleBackColor = true;
            // 
            // chc_Estudiante
            // 
            this.chc_Estudiante.AutoSize = true;
            this.chc_Estudiante.Location = new System.Drawing.Point(1033, 187);
            this.chc_Estudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_Estudiante.Name = "chc_Estudiante";
            this.chc_Estudiante.Size = new System.Drawing.Size(18, 17);
            this.chc_Estudiante.TabIndex = 70;
            this.chc_Estudiante.UseVisualStyleBackColor = true;
            // 
            // chc_bachillerato
            // 
            this.chc_bachillerato.AutoSize = true;
            this.chc_bachillerato.Location = new System.Drawing.Point(1033, 146);
            this.chc_bachillerato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_bachillerato.Name = "chc_bachillerato";
            this.chc_bachillerato.Size = new System.Drawing.Size(18, 17);
            this.chc_bachillerato.TabIndex = 69;
            this.chc_bachillerato.UseVisualStyleBackColor = true;
            // 
            // chc_secundaria
            // 
            this.chc_secundaria.AutoSize = true;
            this.chc_secundaria.Location = new System.Drawing.Point(372, 187);
            this.chc_secundaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_secundaria.Name = "chc_secundaria";
            this.chc_secundaria.Size = new System.Drawing.Size(18, 17);
            this.chc_secundaria.TabIndex = 68;
            this.chc_secundaria.UseVisualStyleBackColor = true;
            // 
            // chc_primaria
            // 
            this.chc_primaria.AutoSize = true;
            this.chc_primaria.Location = new System.Drawing.Point(372, 143);
            this.chc_primaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_primaria.Name = "chc_primaria";
            this.chc_primaria.Size = new System.Drawing.Size(18, 17);
            this.chc_primaria.TabIndex = 67;
            this.chc_primaria.UseVisualStyleBackColor = true;
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso.Location = new System.Drawing.Point(695, 105);
            this.lbl_curso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(121, 20);
            this.lbl_curso.TabIndex = 66;
            this.lbl_curso.Text = "Cursos Extras:";
            // 
            // lbl_gUniversidad
            // 
            this.lbl_gUniversidad.AutoSize = true;
            this.lbl_gUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gUniversidad.Location = new System.Drawing.Point(695, 49);
            this.lbl_gUniversidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gUniversidad.Name = "lbl_gUniversidad";
            this.lbl_gUniversidad.Size = new System.Drawing.Size(180, 20);
            this.lbl_gUniversidad.TabIndex = 65;
            this.lbl_gUniversidad.Text = "Graduado Universidad:";
            // 
            // lbl_estuUni
            // 
            this.lbl_estuUni.AutoSize = true;
            this.lbl_estuUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estuUni.Location = new System.Drawing.Point(695, 183);
            this.lbl_estuUni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estuUni.Name = "lbl_estuUni";
            this.lbl_estuUni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_estuUni.Size = new System.Drawing.Size(192, 20);
            this.lbl_estuUni.TabIndex = 64;
            this.lbl_estuUni.Text = "Estudiante Universitario:";
            // 
            // lbl_bachillerato
            // 
            this.lbl_bachillerato.AutoSize = true;
            this.lbl_bachillerato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bachillerato.Location = new System.Drawing.Point(695, 143);
            this.lbl_bachillerato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bachillerato.Name = "lbl_bachillerato";
            this.lbl_bachillerato.Size = new System.Drawing.Size(103, 20);
            this.lbl_bachillerato.TabIndex = 63;
            this.lbl_bachillerato.Text = "Bachillerato:";
            // 
            // lbl_secundaria
            // 
            this.lbl_secundaria.AutoSize = true;
            this.lbl_secundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secundaria.Location = new System.Drawing.Point(33, 183);
            this.lbl_secundaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_secundaria.Name = "lbl_secundaria";
            this.lbl_secundaria.Size = new System.Drawing.Size(98, 20);
            this.lbl_secundaria.TabIndex = 62;
            this.lbl_secundaria.Text = "Secundaria:";
            // 
            // lbl_primaria
            // 
            this.lbl_primaria.AutoSize = true;
            this.lbl_primaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primaria.Location = new System.Drawing.Point(33, 143);
            this.lbl_primaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_primaria.Name = "lbl_primaria";
            this.lbl_primaria.Size = new System.Drawing.Size(77, 20);
            this.lbl_primaria.TabIndex = 61;
            this.lbl_primaria.Text = "Primaria:";
            // 
            // Txt_puesto
            // 
            this.Txt_puesto.Location = new System.Drawing.Point(240, 96);
            this.Txt_puesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_puesto.Name = "Txt_puesto";
            this.Txt_puesto.Size = new System.Drawing.Size(281, 27);
            this.Txt_puesto.TabIndex = 3;
            // 
            // Lbl_nom
            // 
            this.Lbl_nom.AutoSize = true;
            this.Lbl_nom.Location = new System.Drawing.Point(33, 100);
            this.Lbl_nom.Name = "Lbl_nom";
            this.Lbl_nom.Size = new System.Drawing.Size(123, 20);
            this.Lbl_nom.TabIndex = 2;
            this.Lbl_nom.Text = "Codigo Puesto:";
            // 
            // Lbl_codPercepcion
            // 
            this.Lbl_codPercepcion.AutoSize = true;
            this.Lbl_codPercepcion.Location = new System.Drawing.Point(33, 50);
            this.Lbl_codPercepcion.Name = "Lbl_codPercepcion";
            this.Lbl_codPercepcion.Size = new System.Drawing.Size(133, 20);
            this.Lbl_codPercepcion.TabIndex = 1;
            this.Lbl_codPercepcion.Text = "Código de Perfil:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Enabled = false;
            this.Txt_Cod.Location = new System.Drawing.Point(240, 46);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(281, 27);
            this.Txt_Cod.TabIndex = 0;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(821, 95);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(187, 110);
            this.Btn_consultar.TabIndex = 74;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(708, 95);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(115, 110);
            this.Btn_borrar.TabIndex = 73;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(596, 95);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 110);
            this.Btn_guardar.TabIndex = 72;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(484, 95);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(115, 110);
            this.Btn_editar.TabIndex = 71;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(372, 95);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(115, 110);
            this.Btn_ingresar.TabIndex = 70;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Frm_MantPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 716);
            this.Controls.Add(this.Pnl_nombreForm);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_MantPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantPerfiles";
            this.Load += new System.EventHandler(this.Frm_MantPerfiles_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.TextBox Txt_puesto;
        private System.Windows.Forms.Label Lbl_nom;
        private System.Windows.Forms.Label Lbl_codPercepcion;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.CheckBox chc_Cursos;
        private System.Windows.Forms.CheckBox chc_Graduado;
        private System.Windows.Forms.CheckBox chc_Estudiante;
        private System.Windows.Forms.CheckBox chc_bachillerato;
        private System.Windows.Forms.CheckBox chc_secundaria;
        private System.Windows.Forms.CheckBox chc_primaria;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_gUniversidad;
        private System.Windows.Forms.Label lbl_estuUni;
        private System.Windows.Forms.Label lbl_bachillerato;
        private System.Windows.Forms.Label lbl_secundaria;
        private System.Windows.Forms.Label lbl_primaria;
        private System.Windows.Forms.Label lbl_desCursos;
        private System.Windows.Forms.TextBox txt_extras;
        private System.Windows.Forms.Button btn_buscarCreador;
    }
}