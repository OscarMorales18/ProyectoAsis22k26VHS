namespace Renta_de_Video_2._0
{
    partial class Gestion_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Empleados));
            cmb_rol = new ComboBox();
            cmb_estado = new ComboBox();
            dgv_usuarios = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            CodigoEmpleado = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btn_eliminar = new Button();
            btn_guardar = new Button();
            btn_agregar = new Button();
            btn_editar = new Button();
            pic_imagen1 = new PictureBox();
            txt_idEmpleado = new TextBox();
            txt_contrasena = new TextBox();
            txt_usuario = new TextBox();
            pic_mascota = new PictureBox();
            label1 = new Label();
            lbl_nombreUsuario = new Label();
            lbl_rol = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            SuspendLayout();
            // 
            // cmb_rol
            // 
            cmb_rol.BackColor = Color.FromArgb(42, 18, 11);
            cmb_rol.ForeColor = SystemColors.Info;
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Items.AddRange(new object[] { "Empleado", "Administrador", "Auditor" });
            cmb_rol.Location = new Point(70, 489);
            cmb_rol.Margin = new Padding(3, 4, 3, 4);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(121, 28);
            cmb_rol.TabIndex = 29;
            // 
            // cmb_estado
            // 
            cmb_estado.BackColor = Color.FromArgb(42, 18, 11);
            cmb_estado.ForeColor = SystemColors.Info;
            cmb_estado.FormattingEnabled = true;
            cmb_estado.Items.AddRange(new object[] { "1", "0" });
            cmb_estado.Location = new Point(70, 576);
            cmb_estado.Margin = new Padding(3, 4, 3, 4);
            cmb_estado.Name = "cmb_estado";
            cmb_estado.Size = new Size(121, 28);
            cmb_estado.TabIndex = 31;
            // 
            // dgv_usuarios
            // 
            dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuarios.Columns.AddRange(new DataGridViewColumn[] { Usuario, Contraseña, CodigoEmpleado, Rol, Estado });
            dgv_usuarios.Location = new Point(494, 224);
            dgv_usuarios.Margin = new Padding(3, 4, 3, 4);
            dgv_usuarios.Name = "dgv_usuarios";
            dgv_usuarios.RowHeadersWidth = 51;
            dgv_usuarios.RowTemplate.Height = 24;
            dgv_usuarios.Size = new Size(766, 339);
            dgv_usuarios.TabIndex = 32;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 115;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 6;
            Contraseña.Name = "Contraseña";
            Contraseña.Width = 125;
            // 
            // CodigoEmpleado
            // 
            CodigoEmpleado.HeaderText = "CodigoEmpleado";
            CodigoEmpleado.MinimumWidth = 6;
            CodigoEmpleado.Name = "CodigoEmpleado";
            CodigoEmpleado.Width = 140;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(247, 170, 28);
            btn_eliminar.FlatStyle = FlatStyle.Popup;
            btn_eliminar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(70, 721);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(186, 55);
            btn_eliminar.TabIndex = 33;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += OnEliminar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(247, 170, 28);
            btn_guardar.FlatStyle = FlatStyle.Popup;
            btn_guardar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(263, 721);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(184, 55);
            btn_guardar.TabIndex = 34;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += OnGuardar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(247, 170, 28);
            btn_agregar.FlatStyle = FlatStyle.Popup;
            btn_agregar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(70, 659);
            btn_agregar.Margin = new Padding(3, 4, 3, 4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(186, 55);
            btn_agregar.TabIndex = 35;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += OnAgregar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(247, 170, 28);
            btn_editar.FlatStyle = FlatStyle.Popup;
            btn_editar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.Location = new Point(263, 659);
            btn_editar.Margin = new Padding(3, 4, 3, 4);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(184, 55);
            btn_editar.TabIndex = 36;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += OnEditar_Click;
            // 
            // pic_imagen1
            // 
            pic_imagen1.BackColor = Color.Transparent;
            pic_imagen1.Dock = DockStyle.Fill;
            pic_imagen1.Image = (Image)resources.GetObject("pic_imagen1.Image");
            pic_imagen1.Location = new Point(0, 0);
            pic_imagen1.Margin = new Padding(3, 4, 3, 4);
            pic_imagen1.Name = "pic_imagen1";
            pic_imagen1.Size = new Size(1219, 837);
            pic_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imagen1.TabIndex = 38;
            pic_imagen1.TabStop = false;
            pic_imagen1.Click += pictureBox1_Click;
            // 
            // txt_idEmpleado
            // 
            txt_idEmpleado.BackColor = Color.FromArgb(42, 18, 11);
            txt_idEmpleado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_idEmpleado.ForeColor = SystemColors.Info;
            txt_idEmpleado.Location = new Point(70, 412);
            txt_idEmpleado.Margin = new Padding(3, 4, 3, 4);
            txt_idEmpleado.Name = "txt_idEmpleado";
            txt_idEmpleado.Size = new Size(362, 32);
            txt_idEmpleado.TabIndex = 40;
            // 
            // txt_contrasena
            // 
            txt_contrasena.BackColor = Color.FromArgb(42, 18, 11);
            txt_contrasena.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contrasena.ForeColor = SystemColors.Info;
            txt_contrasena.Location = new Point(70, 347);
            txt_contrasena.Margin = new Padding(3, 4, 3, 4);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(362, 32);
            txt_contrasena.TabIndex = 41;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.FromArgb(42, 18, 11);
            txt_usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.ForeColor = SystemColors.Info;
            txt_usuario.Location = new Point(70, 268);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(362, 32);
            txt_usuario.TabIndex = 42;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(42, 0, 0);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(1000, 588);
            pic_mascota.Margin = new Padding(5, 4, 5, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(219, 249);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 45;
            pic_mascota.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 9, 7);
            label1.ForeColor = Color.FromArgb(247, 170, 28);
            label1.Location = new Point(219, 576);
            label1.Name = "label1";
            label1.Size = new Size(93, 44);
            label1.TabIndex = 46;
            label1.Text = "1 = Activo\r\n0 = No Activo";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_nombreUsuario
            // 
            lbl_nombreUsuario.AutoSize = true;
            lbl_nombreUsuario.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold);
            lbl_nombreUsuario.ForeColor = Color.FromArgb(246, 170, 28);
            lbl_nombreUsuario.Location = new Point(925, 12);
            lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            lbl_nombreUsuario.Size = new Size(168, 22);
            lbl_nombreUsuario.TabIndex = 47;
            lbl_nombreUsuario.Text = "Nombre Usuario";
            lbl_nombreUsuario.Visible = false;
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold);
            lbl_rol.ForeColor = Color.FromArgb(246, 170, 28);
            lbl_rol.Location = new Point(925, 35);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(43, 22);
            lbl_rol.TabIndex = 48;
            lbl_rol.Text = "Rol";
            lbl_rol.Visible = false;
            // 
            // Gestion_Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 837);
            Controls.Add(lbl_rol);
            Controls.Add(lbl_nombreUsuario);
            Controls.Add(label1);
            Controls.Add(pic_mascota);
            Controls.Add(txt_usuario);
            Controls.Add(txt_contrasena);
            Controls.Add(txt_idEmpleado);
            Controls.Add(btn_editar);
            Controls.Add(btn_agregar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_eliminar);
            Controls.Add(dgv_usuarios);
            Controls.Add(cmb_estado);
            Controls.Add(cmb_rol);
            Controls.Add(pic_imagen1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gestion_Empleados";
            Text = "Gestion_Empleados";
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private PictureBox pic_imagen1;
        private TextBox txt_idEmpleado;
        private TextBox txt_contrasena;
        private TextBox txt_usuario;
        private PictureBox pic_mascota;
        private Label label1;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn CodigoEmpleado;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private Label lbl_nombreUsuario;
        private Label lbl_rol;
    }
}