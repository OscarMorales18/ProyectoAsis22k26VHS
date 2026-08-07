namespace Renta_de_Video_2._0
{
    partial class DetalleCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCliente));
            btn_guardar = new Button();
            contadordeRenta = new NumericUpDown();
            label8 = new Label();
            chk_si = new CheckBox();
            chk_no = new CheckBox();
            pic_imagen1 = new PictureBox();
            txt_dpi = new TextBox();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            txt_correo = new TextBox();
            txt_codigoMembresia = new TextBox();
            pic_mascota = new PictureBox();
            txt_nombreCompleto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)contadordeRenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DarkOrange;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatStyle = FlatStyle.Popup;
            btn_guardar.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(697, 635);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(411, 75);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += OnGuardar_Click;
            // 
            // contadordeRenta
            // 
            contadordeRenta.BackColor = Color.FromArgb(64, 0, 0);
            contadordeRenta.Cursor = Cursors.Hand;
            contadordeRenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contadordeRenta.ForeColor = SystemColors.ButtonFace;
            contadordeRenta.Location = new Point(850, 64);
            contadordeRenta.Margin = new Padding(3, 4, 3, 4);
            contadordeRenta.Name = "contadordeRenta";
            contadordeRenta.Size = new Size(105, 34);
            contadordeRenta.TabIndex = 28;
            contadordeRenta.ValueChanged += ContadordeRenta_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1011, 411);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 30;
            // 
            // chk_si
            // 
            chk_si.AutoSize = true;
            chk_si.BackColor = Color.OliveDrab;
            chk_si.CheckAlign = ContentAlignment.MiddleRight;
            chk_si.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_si.Location = new Point(779, 197);
            chk_si.Margin = new Padding(3, 4, 3, 4);
            chk_si.Name = "chk_si";
            chk_si.Size = new Size(73, 54);
            chk_si.TabIndex = 31;
            chk_si.Text = "Si";
            chk_si.UseVisualStyleBackColor = false;
            chk_si.CheckedChanged += si_CheckedChanged;
            // 
            // chk_no
            // 
            chk_no.AutoSize = true;
            chk_no.BackColor = Color.Brown;
            chk_no.CheckAlign = ContentAlignment.MiddleRight;
            chk_no.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_no.Location = new Point(939, 203);
            chk_no.Margin = new Padding(3, 4, 3, 4);
            chk_no.Name = "chk_no";
            chk_no.Size = new Size(87, 50);
            chk_no.TabIndex = 32;
            chk_no.Text = "No";
            chk_no.UseVisualStyleBackColor = false;
            chk_no.CheckedChanged += No_CheckedChanged;
            // 
            // pic_imagen1
            // 
            pic_imagen1.BackColor = Color.Transparent;
            pic_imagen1.Dock = DockStyle.Fill;
            pic_imagen1.Image = (Image)resources.GetObject("pic_imagen1.Image");
            pic_imagen1.Location = new Point(0, 0);
            pic_imagen1.Margin = new Padding(3, 4, 3, 4);
            pic_imagen1.Name = "pic_imagen1";
            pic_imagen1.Size = new Size(1136, 739);
            pic_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imagen1.TabIndex = 35;
            pic_imagen1.TabStop = false;
            pic_imagen1.Click += pictureBox1_Click;
            // 
            // txt_dpi
            // 
            txt_dpi.BackColor = Color.FromArgb(70, 0, 0);
            txt_dpi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_dpi.ForeColor = Color.White;
            txt_dpi.Location = new Point(33, 283);
            txt_dpi.Margin = new Padding(3, 4, 3, 4);
            txt_dpi.Name = "txt_dpi";
            txt_dpi.Size = new Size(511, 32);
            txt_dpi.TabIndex = 37;
            txt_dpi.TextChanged += DPI_TextChanged;
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.FromArgb(70, 0, 0);
            txt_telefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefono.ForeColor = Color.White;
            txt_telefono.Location = new Point(33, 384);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(511, 32);
            txt_telefono.TabIndex = 38;
            txt_telefono.TextChanged += Telefono_TextChanged;
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.FromArgb(70, 0, 0);
            txt_direccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_direccion.ForeColor = Color.White;
            txt_direccion.Location = new Point(33, 472);
            txt_direccion.Margin = new Padding(3, 4, 3, 4);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(511, 32);
            txt_direccion.TabIndex = 39;
            txt_direccion.TextChanged += Dirección_TextChanged;
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.FromArgb(70, 0, 0);
            txt_correo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_correo.ForeColor = Color.White;
            txt_correo.Location = new Point(33, 569);
            txt_correo.Margin = new Padding(3, 4, 3, 4);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(511, 32);
            txt_correo.TabIndex = 40;
            txt_correo.TextChanged += Correo_TextChanged;
            // 
            // txt_codigoMembresia
            // 
            txt_codigoMembresia.BackColor = Color.FromArgb(70, 0, 0);
            txt_codigoMembresia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_codigoMembresia.ForeColor = Color.White;
            txt_codigoMembresia.Location = new Point(33, 660);
            txt_codigoMembresia.Margin = new Padding(3, 4, 3, 4);
            txt_codigoMembresia.Name = "txt_codigoMembresia";
            txt_codigoMembresia.Size = new Size(511, 32);
            txt_codigoMembresia.TabIndex = 41;
            txt_codigoMembresia.TextChanged += CodigodeMembresia_TextChanged;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(42, 0, 0);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(808, 315);
            pic_mascota.Margin = new Padding(5, 4, 5, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(219, 249);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 42;
            pic_mascota.TabStop = false;
            // 
            // txt_nombreCompleto
            // 
            txt_nombreCompleto.BackColor = Color.FromArgb(70, 0, 0);
            txt_nombreCompleto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombreCompleto.ForeColor = Color.White;
            txt_nombreCompleto.Location = new Point(33, 185);
            txt_nombreCompleto.Margin = new Padding(3, 4, 3, 4);
            txt_nombreCompleto.Name = "txt_nombreCompleto";
            txt_nombreCompleto.Size = new Size(511, 32);
            txt_nombreCompleto.TabIndex = 43;
            txt_nombreCompleto.TextChanged += NombreCompleto_TextChanged;
            // 
            // DetalleCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1136, 739);
            Controls.Add(txt_nombreCompleto);
            Controls.Add(pic_mascota);
            Controls.Add(txt_codigoMembresia);
            Controls.Add(txt_correo);
            Controls.Add(txt_direccion);
            Controls.Add(txt_telefono);
            Controls.Add(txt_dpi);
            Controls.Add(chk_no);
            Controls.Add(chk_si);
            Controls.Add(label8);
            Controls.Add(contadordeRenta);
            Controls.Add(btn_guardar);
            Controls.Add(pic_imagen1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetalleCliente";
            Text = "Detalle de Cliente";
            ((System.ComponentModel.ISupportInitialize)contadordeRenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.NumericUpDown contadordeRenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk_si;
        private System.Windows.Forms.CheckBox chk_no;
        private PictureBox pic_imagen1;
        private TextBox txt_dpi;
        private TextBox txt_telefono;
        private TextBox txt_direccion;
        private TextBox txt_correo;
        private TextBox txt_codigoMembresia;
        private PictureBox pic_mascota;
        private TextBox txt_nombreCompleto;
    }
}