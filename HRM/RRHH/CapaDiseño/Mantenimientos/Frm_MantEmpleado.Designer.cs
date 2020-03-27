namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantEmpleado));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.Label_MantEmpleados = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_cod = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.Dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Label_Direccion = new System.Windows.Forms.Label();
            this.Label_email = new System.Windows.Forms.Label();
            this.Label_Celular = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Label_FechaNacimiento = new System.Windows.Forms.Label();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.Txt_PrimerApellido = new System.Windows.Forms.TextBox();
            this.Txt_SegundoNombre = new System.Windows.Forms.TextBox();
            this.Txt_PrimerNombre = new System.Windows.Forms.TextBox();
            this.Label_SegundoApellido = new System.Windows.Forms.Label();
            this.Lable_PrimerApellido = new System.Windows.Forms.Label();
            this.Label_SegundoNombre = new System.Windows.Forms.Label();
            this.Label_PrimerNombre = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.Label_MantEmpleados);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(970, 51);
            this.Pnl_nombreForm.TabIndex = 1;
            this.Pnl_nombreForm.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_nombreForm_Paint);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = global::CapaDiseño.Properties.Resources.question__1_;
            this.btn_Ayuda.Location = new System.Drawing.Point(862, 11);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Label_MantEmpleados
            // 
            this.Label_MantEmpleados.AutoSize = true;
            this.Label_MantEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MantEmpleados.ForeColor = System.Drawing.Color.White;
            this.Label_MantEmpleados.Location = new System.Drawing.Point(34, 15);
            this.Label_MantEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_MantEmpleados.Name = "Label_MantEmpleados";
            this.Label_MantEmpleados.Size = new System.Drawing.Size(298, 20);
            this.Label_MantEmpleados.TabIndex = 0;
            this.Label_MantEmpleados.Text = "MANTENIMIENTO DE EMPLEADOS";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(825, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(899, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_cod);
            this.groupBox1.Controls.Add(this.Txt_Cod);
            this.groupBox1.Controls.Add(this.Cbo_estado);
            this.groupBox1.Controls.Add(this.lbl_estado);
            this.groupBox1.Controls.Add(this.Dtp_FechaNacimiento);
            this.groupBox1.Controls.Add(this.Txt_Direccion);
            this.groupBox1.Controls.Add(this.Txt_email);
            this.groupBox1.Controls.Add(this.Txt_Celular);
            this.groupBox1.Controls.Add(this.Txt_Telefono);
            this.groupBox1.Controls.Add(this.Label_Direccion);
            this.groupBox1.Controls.Add(this.Label_email);
            this.groupBox1.Controls.Add(this.Label_Celular);
            this.groupBox1.Controls.Add(this.Label_Telefono);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.Label_FechaNacimiento);
            this.groupBox1.Controls.Add(this.TxtSegundoApellido);
            this.groupBox1.Controls.Add(this.Txt_PrimerApellido);
            this.groupBox1.Controls.Add(this.Txt_SegundoNombre);
            this.groupBox1.Controls.Add(this.Txt_PrimerNombre);
            this.groupBox1.Controls.Add(this.Label_SegundoApellido);
            this.groupBox1.Controls.Add(this.Lable_PrimerApellido);
            this.groupBox1.Controls.Add(this.Label_SegundoNombre);
            this.groupBox1.Controls.Add(this.Label_PrimerNombre);
            this.groupBox1.Location = new System.Drawing.Point(28, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 186);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // Lbl_cod
            // 
            this.Lbl_cod.AutoSize = true;
            this.Lbl_cod.Location = new System.Drawing.Point(28, 25);
            this.Lbl_cod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cod.Name = "Lbl_cod";
            this.Lbl_cod.Size = new System.Drawing.Size(58, 26);
            this.Lbl_cod.TabIndex = 31;
            this.Lbl_cod.Text = "Codigo de \r\nEmpleado";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Location = new System.Drawing.Point(121, 31);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(183, 20);
            this.Txt_Cod.TabIndex = 30;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_estado.Location = new System.Drawing.Point(673, 133);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(210, 21);
            this.Cbo_estado.TabIndex = 29;
            this.Cbo_estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_estado_SelectedIndexChanged);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(593, 145);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 28;
            this.lbl_estado.Text = "Estado";
            // 
            // Dtp_FechaNacimiento
            // 
            this.Dtp_FechaNacimiento.Location = new System.Drawing.Point(673, 97);
            this.Dtp_FechaNacimiento.Name = "Dtp_FechaNacimiento";
            this.Dtp_FechaNacimiento.Size = new System.Drawing.Size(210, 20);
            this.Dtp_FechaNacimiento.TabIndex = 27;
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(673, 44);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(210, 20);
            this.Txt_Direccion.TabIndex = 26;
            this.Txt_Direccion.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(381, 133);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(190, 20);
            this.Txt_email.TabIndex = 25;
            this.Txt_email.TextChanged += new System.EventHandler(this.TextBox13_TextChanged);
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Location = new System.Drawing.Point(381, 100);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(190, 20);
            this.Txt_Celular.TabIndex = 24;
            this.Txt_Celular.TextChanged += new System.EventHandler(this.TextBox14_TextChanged);
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(381, 64);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(190, 20);
            this.Txt_Telefono.TabIndex = 23;
            this.Txt_Telefono.TextChanged += new System.EventHandler(this.TextBox15_TextChanged);
            // 
            // Label_Direccion
            // 
            this.Label_Direccion.AutoSize = true;
            this.Label_Direccion.Location = new System.Drawing.Point(593, 47);
            this.Label_Direccion.Name = "Label_Direccion";
            this.Label_Direccion.Size = new System.Drawing.Size(52, 13);
            this.Label_Direccion.TabIndex = 22;
            this.Label_Direccion.Text = "Dirección";
            this.Label_Direccion.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label_email
            // 
            this.Label_email.AutoSize = true;
            this.Label_email.Location = new System.Drawing.Point(323, 140);
            this.Label_email.Name = "Label_email";
            this.Label_email.Size = new System.Drawing.Size(35, 13);
            this.Label_email.TabIndex = 21;
            this.Label_email.Text = "E-mail\r\n";
            this.Label_email.Click += new System.EventHandler(this.Label10_Click);
            // 
            // Label_Celular
            // 
            this.Label_Celular.AutoSize = true;
            this.Label_Celular.Location = new System.Drawing.Point(323, 103);
            this.Label_Celular.Name = "Label_Celular";
            this.Label_Celular.Size = new System.Drawing.Size(39, 13);
            this.Label_Celular.TabIndex = 20;
            this.Label_Celular.Text = "Celular";
            this.Label_Celular.Click += new System.EventHandler(this.Label11_Click);
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Location = new System.Drawing.Point(323, 67);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(49, 13);
            this.Label_Telefono.TabIndex = 19;
            this.Label_Telefono.Text = "Teléfono";
            this.Label_Telefono.Click += new System.EventHandler(this.Label12_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(673, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 20);
            this.textBox6.TabIndex = 14;
            // 
            // Label_FechaNacimiento
            // 
            this.Label_FechaNacimiento.AutoSize = true;
            this.Label_FechaNacimiento.Location = new System.Drawing.Point(593, 91);
            this.Label_FechaNacimiento.Name = "Label_FechaNacimiento";
            this.Label_FechaNacimiento.Size = new System.Drawing.Size(60, 26);
            this.Label_FechaNacimiento.TabIndex = 10;
            this.Label_FechaNacimiento.Text = "Fecha\r\nNacimiento";
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Location = new System.Drawing.Point(381, 31);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(183, 20);
            this.TxtSegundoApellido.TabIndex = 7;
            // 
            // Txt_PrimerApellido
            // 
            this.Txt_PrimerApellido.Location = new System.Drawing.Point(121, 133);
            this.Txt_PrimerApellido.Name = "Txt_PrimerApellido";
            this.Txt_PrimerApellido.Size = new System.Drawing.Size(183, 20);
            this.Txt_PrimerApellido.TabIndex = 6;
            // 
            // Txt_SegundoNombre
            // 
            this.Txt_SegundoNombre.Location = new System.Drawing.Point(121, 100);
            this.Txt_SegundoNombre.Name = "Txt_SegundoNombre";
            this.Txt_SegundoNombre.Size = new System.Drawing.Size(183, 20);
            this.Txt_SegundoNombre.TabIndex = 5;
            // 
            // Txt_PrimerNombre
            // 
            this.Txt_PrimerNombre.Location = new System.Drawing.Point(121, 60);
            this.Txt_PrimerNombre.Name = "Txt_PrimerNombre";
            this.Txt_PrimerNombre.Size = new System.Drawing.Size(183, 20);
            this.Txt_PrimerNombre.TabIndex = 4;
            // 
            // Label_SegundoApellido
            // 
            this.Label_SegundoApellido.AutoSize = true;
            this.Label_SegundoApellido.Location = new System.Drawing.Point(323, 25);
            this.Label_SegundoApellido.Name = "Label_SegundoApellido";
            this.Label_SegundoApellido.Size = new System.Drawing.Size(53, 26);
            this.Label_SegundoApellido.TabIndex = 3;
            this.Label_SegundoApellido.Text = "Segundo \r\nApellido";
            // 
            // Lable_PrimerApellido
            // 
            this.Lable_PrimerApellido.AutoSize = true;
            this.Lable_PrimerApellido.Location = new System.Drawing.Point(28, 140);
            this.Lable_PrimerApellido.Name = "Lable_PrimerApellido";
            this.Lable_PrimerApellido.Size = new System.Drawing.Size(76, 13);
            this.Lable_PrimerApellido.TabIndex = 2;
            this.Lable_PrimerApellido.Text = "Primer Apellido";
            // 
            // Label_SegundoNombre
            // 
            this.Label_SegundoNombre.AutoSize = true;
            this.Label_SegundoNombre.Location = new System.Drawing.Point(28, 103);
            this.Label_SegundoNombre.Name = "Label_SegundoNombre";
            this.Label_SegundoNombre.Size = new System.Drawing.Size(90, 13);
            this.Label_SegundoNombre.TabIndex = 1;
            this.Label_SegundoNombre.Text = "Segundo Nombre";
            // 
            // Label_PrimerNombre
            // 
            this.Label_PrimerNombre.AutoSize = true;
            this.Label_PrimerNombre.Location = new System.Drawing.Point(28, 67);
            this.Label_PrimerNombre.Name = "Label_PrimerNombre";
            this.Label_PrimerNombre.Size = new System.Drawing.Size(76, 13);
            this.Label_PrimerNombre.TabIndex = 0;
            this.Label_PrimerNombre.Text = "Primer Nombre";
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
            this.Btn_consultar.Location = new System.Drawing.Point(597, 65);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(110, 89);
            this.Btn_consultar.TabIndex = 86;
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
            this.Btn_borrar.Location = new System.Drawing.Point(513, 65);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(86, 89);
            this.Btn_borrar.TabIndex = 85;
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
            this.Btn_guardar.Location = new System.Drawing.Point(429, 65);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(86, 89);
            this.Btn_guardar.TabIndex = 84;
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
            this.Btn_editar.Location = new System.Drawing.Point(345, 65);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(86, 89);
            this.Btn_editar.TabIndex = 83;
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
            this.Btn_ingresar.Location = new System.Drawing.Point(261, 65);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(86, 89);
            this.Btn_ingresar.TabIndex = 82;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Frm_MantEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 375);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MantEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantEmpleado";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label Label_MantEmpleados;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Label_FechaNacimiento;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.TextBox Txt_PrimerApellido;
        private System.Windows.Forms.TextBox Txt_SegundoNombre;
        private System.Windows.Forms.TextBox Txt_PrimerNombre;
        private System.Windows.Forms.Label Label_SegundoApellido;
        private System.Windows.Forms.Label Lable_PrimerApellido;
        private System.Windows.Forms.Label Label_SegundoNombre;
        private System.Windows.Forms.Label Label_PrimerNombre;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Label Label_Direccion;
        private System.Windows.Forms.Label Label_email;
        private System.Windows.Forms.Label Label_Celular;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.DateTimePicker Dtp_FechaNacimiento;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label Lbl_cod;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
    }
}