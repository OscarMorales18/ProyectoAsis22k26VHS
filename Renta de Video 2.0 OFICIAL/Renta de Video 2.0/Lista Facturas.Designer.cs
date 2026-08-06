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
            dgv_facturas = new DataGridView();
            txt_porcliente = new TextBox();
            btn_buscar = new Button();
            btn_verDetalle = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_facturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgv_facturas
            // 
            dgv_facturas.AccessibleRole = AccessibleRole.None;
            dgv_facturas.AllowUserToOrderColumns = true;
            dgv_facturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_facturas.BackgroundColor = Color.FromArgb(42, 0, 0);
            dgv_facturas.BorderStyle = BorderStyle.None;
            dgv_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_facturas.Location = new Point(153, 267);
            dgv_facturas.Margin = new Padding(3, 4, 3, 4);
            dgv_facturas.Name = "dgv_facturas";
            dgv_facturas.RowHeadersWidth = 51;
            dgv_facturas.RowTemplate.Height = 24;
            dgv_facturas.Size = new Size(1017, 227);
            dgv_facturas.TabIndex = 13;
            // 
            // txt_porcliente
            // 
            txt_porcliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_porcliente.BackColor = Color.FromArgb(42, 18, 11);
            txt_porcliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_porcliente.ForeColor = SystemColors.Window;
            txt_porcliente.Location = new Point(933, 67);
            txt_porcliente.Margin = new Padding(3, 4, 3, 4);
            txt_porcliente.Name = "txt_porcliente";
            txt_porcliente.Size = new Size(294, 32);
            txt_porcliente.TabIndex = 16;
            txt_porcliente.TextChanged += porcliente_TextChanged;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_buscar.BackColor = Color.DarkOrange;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(1233, 49);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(118, 71);
            btn_buscar.TabIndex = 17;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += OnBuscar_Click;
            // 
            // btn_verDetalle
            // 
            btn_verDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_verDetalle.BackColor = Color.DarkOrange;
            btn_verDetalle.Cursor = Cursors.Hand;
            btn_verDetalle.FlatStyle = FlatStyle.Popup;
            btn_verDetalle.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verDetalle.Location = new Point(583, 139);
            btn_verDetalle.Margin = new Padding(3, 4, 3, 4);
            btn_verDetalle.Name = "btn_verDetalle";
            btn_verDetalle.Size = new Size(259, 68);
            btn_verDetalle.TabIndex = 18;
            btn_verDetalle.Text = "Ver Detalle";
            btn_verDetalle.UseVisualStyleBackColor = false;
            btn_verDetalle.Click += OnVerDetalle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1386, 788);
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
            pictureBox2.Location = new Point(525, 493);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 278);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.White;
            btn_salir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.Location = new Point(1346, 0);
            btn_salir.Margin = new Padding(5, 4, 5, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(40, 41);
            btn_salir.TabIndex = 44;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += OnSalir_Click;
            // 
            // Lista_Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(btn_salir);
            Controls.Add(pictureBox2);
            Controls.Add(btn_verDetalle);
            Controls.Add(btn_buscar);
            Controls.Add(txt_porcliente);
            Controls.Add(dgv_facturas);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lista_Facturas";
            Text = "Lista_Facturas";
            Load += Lista_Facturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_facturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_facturas;
        private System.Windows.Forms.TextBox txt_porcliente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_verDetalle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_salir;
    }
}