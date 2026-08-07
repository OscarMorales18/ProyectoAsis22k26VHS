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
            pictureBox3 = new PictureBox();
            txt_dpi = new TextBox();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            txt_correo = new TextBox();
            txt_codigoMembresia = new TextBox();
            btn_guardarRegistro = new Button();
            pic_mascota = new PictureBox();
            txt_nombreCompleto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1216, 829);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txt_dpi
            // 
            txt_dpi.BackColor = Color.FromArgb(70, 0, 0);
            txt_dpi.ForeColor = Color.Transparent;
            txt_dpi.Location = new Point(41, 317);
            txt_dpi.Margin = new Padding(3, 4, 3, 4);
            txt_dpi.Name = "txt_dpi";
            txt_dpi.Size = new Size(610, 27);
            txt_dpi.TabIndex = 18;
            txt_dpi.TextChanged += DPI_TextChanged;
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.FromArgb(70, 0, 0);
            txt_telefono.ForeColor = Color.Transparent;
            txt_telefono.Location = new Point(41, 407);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(610, 27);
            txt_telefono.TabIndex = 19;
            txt_telefono.TextChanged += Telefono_TextChanged;
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.FromArgb(70, 0, 0);
            txt_direccion.ForeColor = Color.Transparent;
            txt_direccion.Location = new Point(41, 509);
            txt_direccion.Margin = new Padding(3, 4, 3, 4);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(610, 27);
            txt_direccion.TabIndex = 20;
            txt_direccion.TextChanged += Direccion_TextChanged;
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.FromArgb(70, 0, 0);
            txt_correo.ForeColor = Color.Transparent;
            txt_correo.Location = new Point(41, 618);
            txt_correo.Margin = new Padding(3, 4, 3, 4);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(610, 27);
            txt_correo.TabIndex = 21;
            txt_correo.TextChanged += Correo_TextChanged;
            // 
            // txt_codigoMembresia
            // 
            txt_codigoMembresia.BackColor = Color.FromArgb(70, 0, 0);
            txt_codigoMembresia.ForeColor = Color.Transparent;
            txt_codigoMembresia.Location = new Point(41, 725);
            txt_codigoMembresia.Margin = new Padding(3, 4, 3, 4);
            txt_codigoMembresia.Name = "txt_codigoMembresia";
            txt_codigoMembresia.Size = new Size(610, 27);
            txt_codigoMembresia.TabIndex = 22;
            txt_codigoMembresia.TextChanged += Codigo_de_membresia_TextChanged;
            // 
            // btn_guardarRegistro
            // 
            btn_guardarRegistro.BackColor = Color.DarkOrange;
            btn_guardarRegistro.Cursor = Cursors.Hand;
            btn_guardarRegistro.FlatStyle = FlatStyle.Popup;
            btn_guardarRegistro.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardarRegistro.Location = new Point(725, 712);
            btn_guardarRegistro.Margin = new Padding(3, 4, 3, 4);
            btn_guardarRegistro.Name = "btn_guardarRegistro";
            btn_guardarRegistro.Size = new Size(479, 85);
            btn_guardarRegistro.TabIndex = 23;
            btn_guardarRegistro.Text = "Guardar";
            btn_guardarRegistro.UseVisualStyleBackColor = false;
            btn_guardarRegistro.Click += OnGuardar_Click;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(42, 0, 0);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(837, 219);
            pic_mascota.Margin = new Padding(5, 4, 5, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(261, 281);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 24;
            pic_mascota.TabStop = false;
            // 
            // txt_nombreCompleto
            // 
            txt_nombreCompleto.BackColor = Color.FromArgb(70, 0, 0);
            txt_nombreCompleto.ForeColor = Color.Transparent;
            txt_nombreCompleto.Location = new Point(41, 203);
            txt_nombreCompleto.Margin = new Padding(3, 4, 3, 4);
            txt_nombreCompleto.Name = "txt_nombreCompleto";
            txt_nombreCompleto.Size = new Size(610, 27);
            txt_nombreCompleto.TabIndex = 25;
            txt_nombreCompleto.TextChanged += NombreCompleto_TextChanged;
            // 
            // RegistroNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1216, 829);
            Controls.Add(txt_nombreCompleto);
            Controls.Add(pic_mascota);
            Controls.Add(btn_guardarRegistro);
            Controls.Add(txt_codigoMembresia);
            Controls.Add(txt_correo);
            Controls.Add(txt_direccion);
            Controls.Add(txt_telefono);
            Controls.Add(txt_dpi);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroNuevoCliente";
            Text = "Registro de Nuevo Cliente";
            Load += RegistroNuevoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PictureBox pictureBox3;
        private TextBox txt_dpi;
        private TextBox txt_telefono;
        private TextBox txt_direccion;
        private TextBox txt_correo;
        private TextBox txt_codigoMembresia;
        private Button btn_guardarRegistro;
        private PictureBox pic_mascota;
        private TextBox txt_nombreCompleto;
    }
}