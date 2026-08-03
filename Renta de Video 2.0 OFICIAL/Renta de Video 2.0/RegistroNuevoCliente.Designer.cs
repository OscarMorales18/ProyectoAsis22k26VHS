namespace Renta_de_Video_2._0.Resources
{
    partial class RegistroNuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroNuevoCliente));
            DPI = new TextBox();
            Telefono = new TextBox();
            Direccion = new TextBox();
            Correo = new TextBox();
            Codigo_de_membresia = new TextBox();
            Guardar_registro_cliente = new Button();
            pictureBox2 = new PictureBox();
            NombreCompleto = new TextBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // DPI
            // 
            DPI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DPI.BackColor = Color.FromArgb(70, 0, 0);
            DPI.ForeColor = Color.Transparent;
            DPI.Location = new Point(36, 215);
            DPI.Name = "DPI";
            DPI.Size = new Size(534, 23);
            DPI.TabIndex = 18;
            DPI.TextChanged += DPI_TextChanged;
            // 
            // Telefono
            // 
            Telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Telefono.BackColor = Color.FromArgb(70, 0, 0);
            Telefono.ForeColor = Color.Transparent;
            Telefono.Location = new Point(36, 280);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(534, 23);
            Telefono.TabIndex = 19;
            Telefono.TextChanged += Telefono_TextChanged;
            // 
            // Direccion
            // 
            Direccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Direccion.BackColor = Color.FromArgb(70, 0, 0);
            Direccion.ForeColor = Color.Transparent;
            Direccion.Location = new Point(36, 351);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(534, 23);
            Direccion.TabIndex = 20;
            Direccion.TextChanged += Direccion_TextChanged;
            // 
            // Correo
            // 
            Correo.BackColor = Color.FromArgb(70, 0, 0);
            Correo.ForeColor = Color.Transparent;
            Correo.Location = new Point(36, 418);
            Correo.Name = "Correo";
            Correo.Size = new Size(534, 23);
            Correo.TabIndex = 21;
            Correo.TextChanged += Correo_TextChanged;
            // 
            // Codigo_de_membresia
            // 
            Codigo_de_membresia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Codigo_de_membresia.BackColor = Color.FromArgb(70, 0, 0);
            Codigo_de_membresia.ForeColor = Color.Transparent;
            Codigo_de_membresia.Location = new Point(36, 487);
            Codigo_de_membresia.Name = "Codigo_de_membresia";
            Codigo_de_membresia.Size = new Size(534, 23);
            Codigo_de_membresia.TabIndex = 22;
            Codigo_de_membresia.TextChanged += Codigo_de_membresia_TextChanged;
            // 
            // Guardar_registro_cliente
            // 
            Guardar_registro_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Guardar_registro_cliente.BackColor = Color.DarkOrange;
            Guardar_registro_cliente.Cursor = Cursors.Hand;
            Guardar_registro_cliente.FlatStyle = FlatStyle.Popup;
            Guardar_registro_cliente.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guardar_registro_cliente.Location = new Point(664, 487);
            Guardar_registro_cliente.Name = "Guardar_registro_cliente";
            Guardar_registro_cliente.Size = new Size(387, 53);
            Guardar_registro_cliente.TabIndex = 23;
            Guardar_registro_cliente.Text = "Guardar";
            Guardar_registro_cliente.UseVisualStyleBackColor = false;
            Guardar_registro_cliente.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(761, 153);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // NombreCompleto
            // 
            NombreCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NombreCompleto.BackColor = Color.FromArgb(70, 0, 0);
            NombreCompleto.ForeColor = Color.Transparent;
            NombreCompleto.Location = new Point(36, 153);
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Size = new Size(534, 23);
            NombreCompleto.TabIndex = 25;
            NombreCompleto.TextChanged += NombreCompleto_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1080, 562);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(997, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(35, 27);
            button2.TabIndex = 26;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RegistroNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 562);
            Controls.Add(button2);
            Controls.Add(NombreCompleto);
            Controls.Add(pictureBox2);
            Controls.Add(Guardar_registro_cliente);
            Controls.Add(Codigo_de_membresia);
            Controls.Add(Correo);
            Controls.Add(Direccion);
            Controls.Add(Telefono);
            Controls.Add(DPI);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroNuevoCliente";
            Text = "Registro de Nuevo Cliente";
            Load += RegistroNuevoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox DPI;
        private TextBox Telefono;
        private TextBox Direccion;
        private TextBox Correo;
        private TextBox Codigo_de_membresia;
        private Button Guardar_registro_cliente;
        private PictureBox pictureBox2;
        private TextBox NombreCompleto;
        private PictureBox pictureBox3;
        private Button button2;
    }
}