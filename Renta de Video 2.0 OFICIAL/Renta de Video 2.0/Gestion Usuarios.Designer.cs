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
            cmbRol = new ComboBox();
            cmbEstado = new ComboBox();
            dvgUsuarios = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Id_Empleado = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btn_eliminar = new Button();
            btn_guardar = new Button();
            btn_agregar = new Button();
            btn_editar = new Button();
            pictureBox1 = new PictureBox();
            txt_idemple = new TextBox();
            txt_contra = new TextBox();
            txt_usu = new TextBox();
            pictureBox2 = new PictureBox();
            txt_busca = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.White;
            cmbRol.ForeColor = Color.FromArgb(53, 0, 1);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Empleado", "Administrador" });
            cmbRol.Location = new Point(54, 305);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(106, 23);
            cmbRol.TabIndex = 29;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.ForeColor = Color.FromArgb(53, 0, 1);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Retirado" });
            cmbEstado.Location = new Point(54, 371);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(106, 23);
            cmbEstado.TabIndex = 31;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // dvgUsuarios
            // 
            dvgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuarios.Columns.AddRange(new DataGridViewColumn[] { Codigo, Usuario, Contraseña, Id_Empleado, Rol, Estado });
            dvgUsuarios.Location = new Point(437, 156);
            dvgUsuarios.Name = "dvgUsuarios";
            dvgUsuarios.RowHeadersWidth = 51;
            dvgUsuarios.RowTemplate.Height = 24;
            dvgUsuarios.Size = new Size(739, 283);
            dvgUsuarios.TabIndex = 32;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 6;
            Contraseña.Name = "Contraseña";
            Contraseña.Width = 125;
            // 
            // Id_Empleado
            // 
            Id_Empleado.HeaderText = "ID_Empleado";
            Id_Empleado.MinimumWidth = 6;
            Id_Empleado.Name = "Id_Empleado";
            Id_Empleado.Width = 125;
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
            btn_eliminar.BackColor = Color.FromArgb(246, 170, 28);
            btn_eliminar.FlatStyle = FlatStyle.Popup;
            btn_eliminar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(87, 534);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(151, 38);
            btn_eliminar.TabIndex = 33;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += eliminar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(246, 170, 28);
            btn_guardar.FlatStyle = FlatStyle.Popup;
            btn_guardar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(271, 544);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(141, 35);
            btn_guardar.TabIndex = 34;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += guardar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(246, 170, 28);
            btn_agregar.FlatStyle = FlatStyle.Popup;
            btn_agregar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(87, 491);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(148, 39);
            btn_agregar.TabIndex = 35;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += agregar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(246, 170, 28);
            btn_editar.FlatStyle = FlatStyle.Popup;
            btn_editar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.Location = new Point(271, 493);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(141, 37);
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
            pictureBox1.Size = new Size(1213, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txt_idemple
            // 
            txt_idemple.BackColor = Color.FromArgb(42, 18, 11);
            txt_idemple.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_idemple.Location = new Point(54, 256);
            txt_idemple.Name = "txt_idemple";
            txt_idemple.Size = new Size(317, 27);
            txt_idemple.TabIndex = 40;
            txt_idemple.TextChanged += NombreCompleto_TextChanged;
            // 
            // txt_contra
            // 
            txt_contra.BackColor = Color.FromArgb(42, 18, 11);
            txt_contra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contra.Location = new Point(54, 192);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(317, 27);
            txt_contra.TabIndex = 41;
            txt_contra.TextChanged += contra_TextChanged;
            // 
            // txt_usu
            // 
            txt_usu.BackColor = Color.FromArgb(42, 18, 11);
            txt_usu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usu.Location = new Point(54, 132);
            txt_usu.Name = "txt_usu";
            txt_usu.Size = new Size(317, 27);
            txt_usu.TabIndex = 42;
            txt_usu.TextChanged += usu_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(982, 470);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // txt_busca
            // 
            txt_busca.BackColor = Color.FromArgb(42, 18, 11);
            txt_busca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_busca.ForeColor = SystemColors.Info;
            txt_busca.Location = new Point(571, 470);
            txt_busca.Name = "txt_busca";
            txt_busca.Size = new Size(317, 27);
            txt_busca.TabIndex = 46;
            txt_busca.TextChanged += txt_busca_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(982, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(35, 27);
            button2.TabIndex = 47;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Gestion_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(button2);
            Controls.Add(btn_eliminar);
            Controls.Add(txt_busca);
            Controls.Add(pictureBox2);
            Controls.Add(txt_usu);
            Controls.Add(txt_contra);
            Controls.Add(txt_idemple);
            Controls.Add(btn_editar);
            Controls.Add(btn_agregar);
            Controls.Add(btn_guardar);
            Controls.Add(dvgUsuarios);
            Controls.Add(cmbEstado);
            Controls.Add(cmbRol);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gestion_Empleados";
            Text = "Gestion_Empleados";
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private PictureBox pictureBox1;
        private TextBox txt_idemple;
        private TextBox txt_contra;
        private TextBox txt_usu;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Id_Empleado;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txt_busca;
        private Button button2;
    }
}