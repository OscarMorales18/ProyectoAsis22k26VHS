namespace Renta_de_Video_2._0
{
    partial class Lista_Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Facturas));
            dvg_facturas = new DataGridView();
            porcliente = new TextBox();
            Buscar = new Button();
            verdetalle = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_facturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dvg_facturas
            // 
            dvg_facturas.AccessibleRole = AccessibleRole.None;
            dvg_facturas.AllowUserToOrderColumns = true;
            dvg_facturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvg_facturas.BackgroundColor = Color.FromArgb(42, 0, 0);
            dvg_facturas.BorderStyle = BorderStyle.None;
            dvg_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_facturas.Location = new Point(134, 200);
            dvg_facturas.Name = "dvg_facturas";
            dvg_facturas.RowHeadersWidth = 51;
            dvg_facturas.RowTemplate.Height = 24;
            dvg_facturas.Size = new Size(890, 170);
            dvg_facturas.TabIndex = 13;
            // 
            // porcliente
            // 
            porcliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            porcliente.BackColor = Color.FromArgb(42, 18, 11);
            porcliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            porcliente.ForeColor = SystemColors.Window;
            porcliente.Location = new Point(815, 46);
            porcliente.Name = "porcliente";
            porcliente.Size = new Size(258, 27);
            porcliente.TabIndex = 16;
            porcliente.TextChanged += porcliente_TextChanged;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Buscar.BackColor = Color.DarkOrange;
            Buscar.FlatStyle = FlatStyle.Popup;
            Buscar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.Location = new Point(1079, 31);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(103, 59);
            Buscar.TabIndex = 17;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += OnBuscar_Click;
            // 
            // verdetalle
            // 
            verdetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            verdetalle.BackColor = Color.DarkOrange;
            verdetalle.Cursor = Cursors.Hand;
            verdetalle.FlatStyle = FlatStyle.Popup;
            verdetalle.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verdetalle.Location = new Point(510, 104);
            verdetalle.Name = "verdetalle";
            verdetalle.Size = new Size(227, 51);
            verdetalle.TabIndex = 18;
            verdetalle.Text = "Ver Detalle";
            verdetalle.UseVisualStyleBackColor = false;
            verdetalle.Click += OnVerDetalle_Click;
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
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(459, 362);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 216);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1064, 508);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(35, 31);
            button2.TabIndex = 44;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Lista_Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(verdetalle);
            Controls.Add(Buscar);
            Controls.Add(porcliente);
            Controls.Add(dvg_facturas);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Lista_Facturas";
            Text = "Lista_Facturas";
            Load += Lista_Facturas_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_facturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvg_facturas;
        private System.Windows.Forms.TextBox porcliente;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button verdetalle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}