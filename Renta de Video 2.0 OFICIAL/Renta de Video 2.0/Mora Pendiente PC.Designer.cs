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
            Buscar = new Button();
            dataGridView1 = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Codigo_Membresia = new DataGridViewTextBoxColumn();
            Codigo_Renta = new DataGridViewTextBoxColumn();
            Días_De_Atraso = new DataGridViewTextBoxColumn();
            Mora_Pendiente = new DataGridViewTextBoxColumn();
            label2 = new Label();
            Marcarpago = new Button();
            pictureBox1 = new PictureBox();
            totalmora = new TextBox();
            Buscar_cliente = new TextBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscar.BackColor = Color.DarkOrange;
            Buscar.FlatStyle = FlatStyle.Popup;
            Buscar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.Location = new Point(567, 140);
            Buscar.Margin = new Padding(3, 4, 3, 4);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(108, 46);
            Buscar.TabIndex = 23;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(41, 0, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cliente, Codigo_Membresia, Codigo_Renta, Días_De_Atraso, Mora_Pendiente });
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(677, 188);
            dataGridView1.TabIndex = 24;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(42, 0, 0);
            label2.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(886, 158);
            label2.Name = "label2";
            label2.Size = new Size(202, 39);
            label2.TabIndex = 25;
            label2.Text = "Total Mora";
            // 
            // Marcarpago
            // 
            Marcarpago.BackColor = Color.DarkOrange;
            Marcarpago.FlatStyle = FlatStyle.Popup;
            Marcarpago.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Marcarpago.Location = new Point(944, 334);
            Marcarpago.Margin = new Padding(3, 4, 3, 4);
            Marcarpago.Name = "Marcarpago";
            Marcarpago.Size = new Size(131, 48);
            Marcarpago.TabIndex = 27;
            Marcarpago.Text = "Marcar Pago";
            Marcarpago.UseVisualStyleBackColor = false;
            Marcarpago.Click += Marcarpago_Click;
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
            // totalmora
            // 
            totalmora.BackColor = Color.FromArgb(42, 18, 11);
            totalmora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalmora.ForeColor = Color.White;
            totalmora.Location = new Point(875, 264);
            totalmora.Margin = new Padding(3, 4, 3, 4);
            totalmora.Name = "totalmora";
            totalmora.Size = new Size(234, 32);
            totalmora.TabIndex = 38;
            totalmora.TextChanged += totalmora_TextChanged;
            // 
            // Buscar_cliente
            // 
            Buscar_cliente.BackColor = Color.FromArgb(42, 18, 11);
            Buscar_cliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Buscar_cliente.ForeColor = Color.White;
            Buscar_cliente.Location = new Point(17, 146);
            Buscar_cliente.Margin = new Padding(3, 4, 3, 4);
            Buscar_cliente.Name = "Buscar_cliente";
            Buscar_cliente.Size = new Size(362, 32);
            Buscar_cliente.TabIndex = 39;
            Buscar_cliente.TextChanged += Buscar_cliente_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(903, 411);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 249);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
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
            button2.Click += button2_Click;
            // 
            // Mora_Pendiente_PC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 738);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(Buscar_cliente);
            Controls.Add(totalmora);
            Controls.Add(Marcarpago);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(Buscar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mora_Pendiente_PC";
            Text = "Mora_Pendiente_PC";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Días_De_Atraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mora_Pendiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Marcarpago;
        private PictureBox pictureBox1;
        private TextBox totalmora;
        private TextBox Buscar_cliente;
        private PictureBox pictureBox2;
        private Button button2;
    }
}