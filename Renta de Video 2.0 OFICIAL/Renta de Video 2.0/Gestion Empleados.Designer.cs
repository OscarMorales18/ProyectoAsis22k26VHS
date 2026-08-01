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
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            eliminar = new Button();
            guardar = new Button();
            agregar = new Button();
            editar = new Button();
            pictureBox1 = new PictureBox();
            NombreCompleto = new TextBox();
            contra = new TextBox();
            usu = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.FromArgb(42, 18, 11);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(50, 342);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(106, 23);
            cmbRol.TabIndex = 29;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(42, 18, 11);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(50, 401);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(106, 23);
            cmbEstado.TabIndex = 31;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Usuario, Rol, Estado });
            dataGridView1.Location = new Point(437, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(593, 141);
            dataGridView1.TabIndex = 32;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
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
            // eliminar
            // 
            eliminar.BackColor = Color.IndianRed;
            eliminar.FlatStyle = FlatStyle.Popup;
            eliminar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminar.Location = new Point(50, 546);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(163, 41);
            eliminar.TabIndex = 33;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = false;
            eliminar.Click += eliminar_Click;
            // 
            // guardar
            // 
            guardar.BackColor = Color.DarkOrange;
            guardar.FlatStyle = FlatStyle.Popup;
            guardar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardar.Location = new Point(219, 546);
            guardar.Name = "guardar";
            guardar.Size = new Size(161, 41);
            guardar.TabIndex = 34;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = false;
            guardar.Click += guardar_Click;
            // 
            // agregar
            // 
            agregar.BackColor = Color.OliveDrab;
            agregar.FlatStyle = FlatStyle.Popup;
            agregar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregar.Location = new Point(50, 499);
            agregar.Name = "agregar";
            agregar.Size = new Size(163, 41);
            agregar.TabIndex = 35;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = false;
            agregar.Click += agregar_Click;
            // 
            // editar
            // 
            editar.BackColor = Color.LightSeaGreen;
            editar.FlatStyle = FlatStyle.Popup;
            editar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editar.Location = new Point(219, 499);
            editar.Name = "editar";
            editar.Size = new Size(161, 41);
            editar.TabIndex = 36;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = false;
            editar.Click += editar_Click;
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
            // 
            // NombreCompleto
            // 
            NombreCompleto.BackColor = Color.FromArgb(42, 18, 11);
            NombreCompleto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreCompleto.Location = new Point(50, 270);
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Size = new Size(317, 27);
            NombreCompleto.TabIndex = 40;
            NombreCompleto.TextChanged += NombreCompleto_TextChanged;
            // 
            // contra
            // 
            contra.BackColor = Color.FromArgb(42, 18, 11);
            contra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contra.Location = new Point(50, 215);
            contra.Name = "contra";
            contra.Size = new Size(317, 27);
            contra.TabIndex = 41;
            contra.TextChanged += contra_TextChanged;
            // 
            // usu
            // 
            usu.BackColor = Color.FromArgb(42, 18, 11);
            usu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usu.Location = new Point(50, 156);
            usu.Name = "usu";
            usu.Size = new Size(317, 27);
            usu.TabIndex = 42;
            usu.TextChanged += usu_TextChanged;
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
            // Gestion_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 628);
            Controls.Add(pictureBox2);
            Controls.Add(usu);
            Controls.Add(contra);
            Controls.Add(NombreCompleto);
            Controls.Add(editar);
            Controls.Add(agregar);
            Controls.Add(guardar);
            Controls.Add(eliminar);
            Controls.Add(dataGridView1);
            Controls.Add(cmbEstado);
            Controls.Add(cmbRol);
            Controls.Add(pictureBox1);
            Name = "Gestion_Empleados";
            Text = "Gestion_Empleados";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button editar;
        private PictureBox pictureBox1;
        private TextBox NombreCompleto;
        private TextBox contra;
        private TextBox usu;
        private PictureBox pictureBox2;
    }
}