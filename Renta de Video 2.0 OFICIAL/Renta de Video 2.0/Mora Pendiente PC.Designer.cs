namespace Renta_de_Video_2._0
{
    partial class Mora_Pendiente_PC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mora_Pendiente_PC));
            btn_buscar = new Button();
            dgv_moras = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Codigo_Membresia = new DataGridViewTextBoxColumn();
            Codigo_Renta = new DataGridViewTextBoxColumn();
            Días_De_Atraso = new DataGridViewTextBoxColumn();
            Mora_Pendiente = new DataGridViewTextBoxColumn();
            lbl_totalMora = new Label();
            btn_marcarPago = new Button();
            pictureBox1 = new PictureBox();
            txt_totalMora = new TextBox();
            txt_buscarCliente = new TextBox();
            pic_mascota = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_moras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_buscar.BackColor = Color.DarkOrange;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(567, 140);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(108, 46);
            btn_buscar.TabIndex = 23;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += OnBuscar_Click;
            // 
            // dgv_moras
            // 
            dgv_moras.BackgroundColor = Color.FromArgb(41, 0, 0);
            dgv_moras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_moras.Columns.AddRange(new DataGridViewColumn[] { Cliente, Codigo_Membresia, Codigo_Renta, Días_De_Atraso, Mora_Pendiente });
            dgv_moras.Location = new Point(12, 194);
            dgv_moras.Margin = new Padding(3, 4, 3, 4);
            dgv_moras.Name = "dgv_moras";
            dgv_moras.RowHeadersWidth = 51;
            dgv_moras.RowTemplate.Height = 24;
            dgv_moras.Size = new Size(677, 188);
            dgv_moras.TabIndex = 24;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Codigo_Membresia
            // 
            Codigo_Membresia.HeaderText = "Codigo_Membresia";
            Codigo_Membresia.MinimumWidth = 6;
            Codigo_Membresia.Name = "Codigo_Membresia";
            Codigo_Membresia.Width = 125;
            // 
            // Codigo_Renta
            // 
            Codigo_Renta.HeaderText = "Codigo_Renta";
            Codigo_Renta.MinimumWidth = 6;
            Codigo_Renta.Name = "Codigo_Renta";
            Codigo_Renta.Width = 125;
            // 
            // Días_De_Atraso
            // 
            Días_De_Atraso.HeaderText = "Días_De_Atraso";
            Días_De_Atraso.MinimumWidth = 6;
            Días_De_Atraso.Name = "Días_De_Atraso";
            Días_De_Atraso.Width = 125;
            // 
            // Mora_Pendiente
            // 
            Mora_Pendiente.HeaderText = "Mora_Pendiente";
            Mora_Pendiente.MinimumWidth = 6;
            Mora_Pendiente.Name = "Mora_Pendiente";
            Mora_Pendiente.Width = 125;
            // 
            // lbl_totalMora
            // 
            lbl_totalMora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_totalMora.AutoSize = true;
            lbl_totalMora.BackColor = Color.FromArgb(42, 0, 0);
            lbl_totalMora.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_totalMora.ForeColor = Color.Goldenrod;
            lbl_totalMora.Location = new Point(886, 158);
            lbl_totalMora.Name = "lbl_totalMora";
            lbl_totalMora.Size = new Size(202, 39);
            lbl_totalMora.TabIndex = 25;
            lbl_totalMora.Text = "Total Mora";
            // 
            // btn_marcarPago
            // 
            btn_marcarPago.BackColor = Color.DarkOrange;
            btn_marcarPago.FlatStyle = FlatStyle.Popup;
            btn_marcarPago.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_marcarPago.Location = new Point(944, 334);
            btn_marcarPago.Margin = new Padding(3, 4, 3, 4);
            btn_marcarPago.Name = "btn_marcarPago";
            btn_marcarPago.Size = new Size(131, 48);
            btn_marcarPago.TabIndex = 27;
            btn_marcarPago.Text = "Marcar Pago";
            btn_marcarPago.UseVisualStyleBackColor = false;
            btn_marcarPago.Click += OnMarcarpago_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1136, 738);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // txt_totalMora
            // 
            txt_totalMora.BackColor = Color.FromArgb(42, 18, 11);
            txt_totalMora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_totalMora.ForeColor = Color.White;
            txt_totalMora.Location = new Point(875, 264);
            txt_totalMora.Margin = new Padding(3, 4, 3, 4);
            txt_totalMora.Name = "txt_totalMora";
            txt_totalMora.Size = new Size(234, 32);
            txt_totalMora.TabIndex = 38;
            txt_totalMora.TextChanged += totalmora_TextChanged;
            // 
            // txt_buscarCliente
            // 
            txt_buscarCliente.BackColor = Color.FromArgb(42, 18, 11);
            txt_buscarCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_buscarCliente.ForeColor = Color.White;
            txt_buscarCliente.Location = new Point(17, 146);
            txt_buscarCliente.Margin = new Padding(3, 4, 3, 4);
            txt_buscarCliente.Name = "txt_buscarCliente";
            txt_buscarCliente.Size = new Size(362, 32);
            txt_buscarCliente.TabIndex = 39;
            txt_buscarCliente.TextChanged += Buscar_cliente_TextChanged;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(42, 0, 0);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(903, 411);
            pic_mascota.Margin = new Padding(5, 4, 5, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(219, 249);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 44;
            pic_mascota.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1096, 0);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 45;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += OnSalir_Click;
            // 
            // Mora_Pendiente_PC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 738);
            Controls.Add(button2);
            Controls.Add(pic_mascota);
            Controls.Add(txt_buscarCliente);
            Controls.Add(txt_totalMora);
            Controls.Add(btn_marcarPago);
            Controls.Add(lbl_totalMora);
            Controls.Add(dgv_moras);
            Controls.Add(btn_buscar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mora_Pendiente_PC";
            Text = "Mora_Pendiente_PC";
            ((System.ComponentModel.ISupportInitialize)dgv_moras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_moras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Días_De_Atraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mora_Pendiente;
        private System.Windows.Forms.Label lbl_totalMora;
        private System.Windows.Forms.Button btn_marcarPago;
        private PictureBox pictureBox1;
        private TextBox txt_totalMora;
        private TextBox txt_buscarCliente;
        private PictureBox pic_mascota;
        private Button button2;
    }
}