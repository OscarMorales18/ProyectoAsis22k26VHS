namespace Renta_de_Video_2._0
{
    partial class FormWalkthriught3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWalkthriught3));
            button1 = new Button();
            ContadordeRenta = new NumericUpDown();
            label8 = new Label();
            si = new CheckBox();
            No = new CheckBox();
            pictureBox1 = new PictureBox();
            DPI = new TextBox();
            Telefono = new TextBox();
            Dirección = new TextBox();
            Correo = new TextBox();
            CodigodeMembresia = new TextBox();
            pictureBox2 = new PictureBox();
            NombreCompleto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ContadordeRenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(785, 775);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(462, 74);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ContadordeRenta
            // 
            ContadordeRenta.BackColor = Color.FromArgb(64, 0, 0);
            ContadordeRenta.Cursor = Cursors.Hand;
            ContadordeRenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContadordeRenta.ForeColor = SystemColors.ButtonFace;
            ContadordeRenta.Location = new Point(959, 71);
            ContadordeRenta.Margin = new Padding(3, 4, 3, 4);
            ContadordeRenta.Name = "ContadordeRenta";
            ContadordeRenta.Size = new Size(105, 34);
            ContadordeRenta.TabIndex = 28;
            ContadordeRenta.ValueChanged += ContadordeRenta_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1011, 411);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 30;
            // 
            // si
            // 
            si.AutoSize = true;
            si.BackColor = Color.OliveDrab;
            si.CheckAlign = ContentAlignment.MiddleRight;
            si.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            si.Location = new Point(850, 199);
            si.Margin = new Padding(3, 4, 3, 4);
            si.Name = "si";
            si.Size = new Size(73, 54);
            si.TabIndex = 31;
            si.Text = "Si";
            si.UseVisualStyleBackColor = false;
            si.CheckedChanged += si_CheckedChanged;
            // 
            // No
            // 
            No.AutoSize = true;
            No.BackColor = Color.Brown;
            No.CheckAlign = ContentAlignment.MiddleRight;
            No.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            No.Location = new Point(1011, 203);
            No.Margin = new Padding(3, 4, 3, 4);
            No.Name = "No";
            No.Size = new Size(87, 50);
            No.TabIndex = 32;
            No.Text = "No";
            No.UseVisualStyleBackColor = false;
            No.CheckedChanged += No_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1277, 862);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DPI
            // 
            DPI.BackColor = Color.FromArgb(70, 0, 0);
            DPI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DPI.ForeColor = Color.White;
            DPI.Location = new Point(33, 351);
            DPI.Margin = new Padding(3, 4, 3, 4);
            DPI.Name = "DPI";
            DPI.Size = new Size(511, 32);
            DPI.TabIndex = 37;
            DPI.TextChanged += DPI_TextChanged;
            // 
            // Telefono
            // 
            Telefono.BackColor = Color.FromArgb(70, 0, 0);
            Telefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Telefono.ForeColor = Color.White;
            Telefono.Location = new Point(33, 477);
            Telefono.Margin = new Padding(3, 4, 3, 4);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(511, 32);
            Telefono.TabIndex = 38;
            Telefono.TextChanged += Telefono_TextChanged;
            // 
            // Dirección
            // 
            Dirección.BackColor = Color.FromArgb(70, 0, 0);
            Dirección.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dirección.ForeColor = Color.White;
            Dirección.Location = new Point(33, 579);
            Dirección.Margin = new Padding(3, 4, 3, 4);
            Dirección.Name = "Dirección";
            Dirección.Size = new Size(511, 32);
            Dirección.TabIndex = 39;
            Dirección.TextChanged += Dirección_TextChanged;
            // 
            // Correo
            // 
            Correo.BackColor = Color.FromArgb(70, 0, 0);
            Correo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Correo.ForeColor = Color.White;
            Correo.Location = new Point(33, 700);
            Correo.Margin = new Padding(3, 4, 3, 4);
            Correo.Name = "Correo";
            Correo.Size = new Size(511, 32);
            Correo.TabIndex = 40;
            Correo.TextChanged += Correo_TextChanged;
            // 
            // CodigodeMembresia
            // 
            CodigodeMembresia.BackColor = Color.FromArgb(70, 0, 0);
            CodigodeMembresia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodigodeMembresia.ForeColor = Color.White;
            CodigodeMembresia.Location = new Point(33, 807);
            CodigodeMembresia.Margin = new Padding(3, 4, 3, 4);
            CodigodeMembresia.Name = "CodigodeMembresia";
            CodigodeMembresia.Size = new Size(511, 32);
            CodigodeMembresia.TabIndex = 41;
            CodigodeMembresia.TextChanged += CodigodeMembresia_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(863, 317);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 249);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // NombreCompleto
            // 
            NombreCompleto.BackColor = Color.FromArgb(70, 0, 0);
            NombreCompleto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreCompleto.ForeColor = Color.White;
            NombreCompleto.Location = new Point(33, 235);
            NombreCompleto.Margin = new Padding(3, 4, 3, 4);
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Size = new Size(511, 32);
            NombreCompleto.TabIndex = 43;
            NombreCompleto.TextChanged += NombreCompleto_TextChanged;
            // 
            // FormWalkthriught3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1277, 862);
            Controls.Add(NombreCompleto);
            Controls.Add(pictureBox2);
            Controls.Add(CodigodeMembresia);
            Controls.Add(Correo);
            Controls.Add(Dirección);
            Controls.Add(Telefono);
            Controls.Add(DPI);
            Controls.Add(No);
            Controls.Add(si);
            Controls.Add(label8);
            Controls.Add(ContadordeRenta);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormWalkthriught3";
            Text = "FormWalkthriught3";
            ((System.ComponentModel.ISupportInitialize)ContadordeRenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ContadordeRenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox si;
        private System.Windows.Forms.CheckBox No;
        private PictureBox pictureBox1;
        private TextBox DPI;
        private TextBox Telefono;
        private TextBox Dirección;
        private TextBox Correo;
        private TextBox CodigodeMembresia;
        private PictureBox pictureBox2;
        private TextBox NombreCompleto;
    }
}