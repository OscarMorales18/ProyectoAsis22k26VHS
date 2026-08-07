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
            pictureBox1 = new PictureBox();
            txt_idempleado = new TextBox();
            txt_contrasena = new TextBox();
            txt_usuario = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblNombreUsuario = new Label();
            lblRol = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmb_rol
            // 
            cmb_rol.BackColor = Color.FromArgb(42, 18, 11);
            cmb_rol.ForeColor = SystemColors.Info;
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Items.AddRange(new object[] { "Empleado", "Administrador", "Auditor" });
            cmb_rol.Location = new Point(61, 367);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(106, 23);
            cmb_rol.TabIndex = 29;
            // 
            // cmb_estado
            // 
            cmb_estado.BackColor = Color.FromArgb(42, 18, 11);
            cmb_estado.ForeColor = SystemColors.Info;
            cmb_estado.FormattingEnabled = true;
            cmb_estado.Items.AddRange(new object[] { "1", "0" });
            cmb_estado.Location = new Point(61, 432);
            cmb_estado.Name = "cmb_estado";
            cmb_estado.Size = new Size(106, 23);
            cmb_estado.TabIndex = 31;
            // 
            // dgv_usuarios
            // 
            dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuarios.Columns.AddRange(new DataGridViewColumn[] { Usuario, Contraseña, CodigoEmpleado, Rol, Estado });
            dgv_usuarios.Location = new Point(432, 168);
            dgv_usuarios.Name = "dgv_usuarios";
            dgv_usuarios.RowHeadersWidth = 51;
            dgv_usuarios.RowTemplate.Height = 24;
            dgv_usuarios.Size = new Size(670, 254);
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
            Contraseña.Name = "Contraseña";
            // 
            // CodigoEmpleado
            // 
            CodigoEmpleado.HeaderText = "CodigoEmpleado";
            CodigoEmpleado.Name = "CodigoEmpleado";
            CodigoEmpleado.Width = 140;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(247, 170, 28);
            btn_eliminar.FlatStyle = FlatStyle.Popup;
            btn_eliminar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(61, 541);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(163, 41);
            btn_eliminar.TabIndex = 33;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += eliminar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(247, 170, 28);
            btn_guardar.FlatStyle = FlatStyle.Popup;
            btn_guardar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(230, 541);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(161, 41);
            btn_guardar.TabIndex = 34;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += guardar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(247, 170, 28);
            btn_agregar.FlatStyle = FlatStyle.Popup;
            btn_agregar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(61, 494);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(163, 41);
            btn_agregar.TabIndex = 35;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += agregar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(247, 170, 28);
            btn_editar.FlatStyle = FlatStyle.Popup;
            btn_editar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.Location = new Point(230, 494);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(161, 41);
            btn_editar.TabIndex = 36;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += editar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1067, 628);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txt_idempleado
            // 
            txt_idempleado.BackColor = Color.FromArgb(42, 18, 11);
            txt_idempleado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_idempleado.ForeColor = SystemColors.Info;
            txt_idempleado.Location = new Point(61, 309);
            txt_idempleado.Name = "txt_idempleado";
            txt_idempleado.Size = new Size(317, 27);
            txt_idempleado.TabIndex = 40;
            // 
            // txt_contrasena
            // 
            txt_contrasena.BackColor = Color.FromArgb(42, 18, 11);
            txt_contrasena.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contrasena.ForeColor = SystemColors.Info;
            txt_contrasena.Location = new Point(61, 260);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(317, 27);
            txt_contrasena.TabIndex = 41;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.FromArgb(42, 18, 11);
            txt_usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.ForeColor = SystemColors.Info;
            txt_usuario.Location = new Point(61, 201);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(317, 27);
            txt_usuario.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(875, 441);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 9, 7);
            label1.ForeColor = Color.FromArgb(247, 170, 28);
            label1.Location = new Point(192, 432);
            label1.Name = "label1";
            label1.Size = new Size(81, 33);
            label1.TabIndex = 46;
            label1.Text = "1 = Activo\r\n0 = No Activo";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold);
            lblNombreUsuario.ForeColor = Color.FromArgb(246, 170, 28);
            lblNombreUsuario.Location = new Point(809, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(134, 17);
            lblNombreUsuario.TabIndex = 47;
            lblNombreUsuario.Text = "Nombre Usuario";
            lblNombreUsuario.Visible = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold);
            lblRol.ForeColor = Color.FromArgb(246, 170, 28);
            lblRol.Location = new Point(809, 26);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(33, 17);
            lblRol.TabIndex = 48;
            lblRol.Text = "Rol";
            lblRol.Visible = false;
            // 
            // Gestion_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 628);
            Controls.Add(lblRol);
            Controls.Add(lblNombreUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txt_usuario);
            Controls.Add(txt_contrasena);
            Controls.Add(txt_idempleado);
            Controls.Add(btn_editar);
            Controls.Add(btn_agregar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_eliminar);
            Controls.Add(dgv_usuarios);
            Controls.Add(cmb_estado);
            Controls.Add(cmb_rol);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Gestion_Empleados";
            Text = "Gestion_Empleados";
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private TextBox txt_idempleado;
        private TextBox txt_contrasena;
        private TextBox txt_usuario;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn CodigoEmpleado;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private Label lblNombreUsuario;
        private Label lblRol;
    }
}