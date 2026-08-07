namespace Renta_de_Video_2._0
{
    partial class Detalle_De_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_De_Factura));
            dgv_detalleFactura = new DataGridView();
            btn_regresar = new Button();
            pictureBox1 = new PictureBox();
            txt_fecha = new TextBox();
            txt_cliente = new TextBox();
            txt_codigo = new TextBox();
            txt_totalPagar = new TextBox();
            pictureBox2 = new PictureBox();
            btn_salir = new Button();
            btn_buscar = new Button();
            Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_detalleFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgv_detalleFactura
            // 
            dgv_detalleFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_detalleFactura.BackgroundColor = Color.FromArgb(64, 0, 0);
            dgv_detalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_detalleFactura.GridColor = SystemColors.WindowText;
            dgv_detalleFactura.Location = new Point(549, 75);
            dgv_detalleFactura.Margin = new Padding(3, 4, 3, 4);
            dgv_detalleFactura.Name = "dgv_detalleFactura";
            dgv_detalleFactura.RowHeadersWidth = 51;
            dgv_detalleFactura.RowTemplate.Height = 24;
            dgv_detalleFactura.Size = new Size(633, 120);
            dgv_detalleFactura.TabIndex = 20;
            // 
            // btn_regresar
            // 
            btn_regresar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_regresar.BackColor = Color.DarkOrange;
            btn_regresar.Cursor = Cursors.Hand;
            btn_regresar.FlatStyle = FlatStyle.Popup;
            btn_regresar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar.Location = new Point(1074, 252);
            btn_regresar.Margin = new Padding(3, 4, 3, 4);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(108, 48);
            btn_regresar.TabIndex = 22;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = false;
            btn_regresar.Click += OnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1213, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // txt_fecha
            // 
            txt_fecha.BackColor = Color.FromArgb(42, 18, 11);
            txt_fecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_fecha.ForeColor = Color.White;
            txt_fecha.Location = new Point(88, 145);
            txt_fecha.Margin = new Padding(3, 4, 3, 4);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(180, 32);
            txt_fecha.TabIndex = 40;
            // 
            // txt_cliente
            // 
            txt_cliente.BackColor = Color.FromArgb(42, 18, 11);
            txt_cliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_cliente.ForeColor = Color.White;
            txt_cliente.Location = new Point(88, 105);
            txt_cliente.Margin = new Padding(3, 4, 3, 4);
            txt_cliente.Name = "txt_cliente";
            txt_cliente.Size = new Size(180, 32);
            txt_cliente.TabIndex = 41;
            // 
            // txt_codigo
            // 
            txt_codigo.BackColor = Color.FromArgb(42, 18, 11);
            txt_codigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_codigo.ForeColor = Color.White;
            txt_codigo.Location = new Point(88, 65);
            txt_codigo.Margin = new Padding(3, 4, 3, 4);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(180, 32);
            txt_codigo.TabIndex = 42;
            // 
            // txt_totalPagar
            // 
            txt_totalPagar.BackColor = Color.FromArgb(42, 18, 11);
            txt_totalPagar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_totalPagar.ForeColor = Color.White;
            txt_totalPagar.Location = new Point(904, 203);
            txt_totalPagar.Margin = new Padding(3, 4, 3, 4);
            txt_totalPagar.Name = "txt_totalPagar";
            txt_totalPagar.ReadOnly = true;
            txt_totalPagar.Size = new Size(180, 32);
            txt_totalPagar.TabIndex = 43;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 342);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 249);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.White;
            btn_salir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.Location = new Point(1158, 16);
            btn_salir.Margin = new Padding(5, 4, 5, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(40, 36);
            btn_salir.TabIndex = 47;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += OnSalir_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.DarkOrange;
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(1074, 316);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(108, 49);
            btn_buscar.TabIndex = 48;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += OnBuscar_Click;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscar.BackColor = Color.DarkOrange;
            Buscar.FlatStyle = FlatStyle.Popup;
            Buscar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.Location = new Point(904, 532);
            Buscar.Margin = new Padding(3, 4, 3, 4);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(278, 46);
            Buscar.TabIndex = 49;
            Buscar.Text = "Pagar Mora";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += OnMora_Click;
            // 
            // Detalle_De_Factura
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1213, 591);
            Controls.Add(Buscar);
            Controls.Add(btn_buscar);
            Controls.Add(btn_salir);
            Controls.Add(pictureBox2);
            Controls.Add(txt_totalPagar);
            Controls.Add(txt_codigo);
            Controls.Add(txt_cliente);
            Controls.Add(txt_fecha);
            Controls.Add(btn_regresar);
            Controls.Add(dgv_detalleFactura);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Detalle_De_Factura";
            Text = "Detalle_De_Factura";
            ((System.ComponentModel.ISupportInitialize)dgv_detalleFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_detalleFactura;
        private System.Windows.Forms.Button btn_regresar;
        private PictureBox pictureBox1;
        private TextBox txt_fecha;
        private TextBox txt_cliente;
        private TextBox txt_codigo;
        private TextBox txt_totalPagar;
        private PictureBox pictureBox2;
        private Button btn_salir;
        private Button btn_buscar;
        private Button Buscar;
    }
}