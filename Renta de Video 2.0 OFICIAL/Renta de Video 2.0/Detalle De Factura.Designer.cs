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
            dataGridView1 = new DataGridView();
            Video = new DataGridViewTextBoxColumn();
            Precio_Renta = new DataGridViewTextBoxColumn();
            Mora = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Regresar = new Button();
            pictureBox1 = new PictureBox();
            Fecha = new TextBox();
            Cliente = new TextBox();
            Codigo = new TextBox();
            TotalPagar = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 0, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Video, Precio_Renta, Mora, Subtotal });
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(484, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(554, 68);
            dataGridView1.TabIndex = 20;
            // 
            // Video
            // 
            Video.HeaderText = "Video";
            Video.MinimumWidth = 6;
            Video.Name = "Video";
            Video.Width = 125;
            // 
            // Precio_Renta
            // 
            Precio_Renta.HeaderText = "Precio_Renta";
            Precio_Renta.MinimumWidth = 6;
            Precio_Renta.Name = "Precio_Renta";
            Precio_Renta.Width = 125;
            // 
            // Mora
            // 
            Mora.HeaderText = "Mora";
            Mora.MinimumWidth = 6;
            Mora.Name = "Mora";
            Mora.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.DarkOrange;
            Regresar.Cursor = Cursors.Hand;
            Regresar.FlatStyle = FlatStyle.Popup;
            Regresar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Regresar.Location = new Point(946, 279);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(102, 36);
            Regresar.TabIndex = 22;
            Regresar.Text = "Regresar";
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1069, 622);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Fecha
            // 
            Fecha.BackColor = Color.FromArgb(42, 18, 11);
            Fecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fecha.Location = new Point(77, 163);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(158, 27);
            Fecha.TabIndex = 40;
            Fecha.TextChanged += Fecha_TextChanged;
            // 
            // Cliente
            // 
            Cliente.BackColor = Color.FromArgb(42, 18, 11);
            Cliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cliente.Location = new Point(77, 122);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(158, 27);
            Cliente.TabIndex = 41;
            Cliente.TextChanged += Cliente_TextChanged;
            // 
            // Codigo
            // 
            Codigo.BackColor = Color.FromArgb(42, 18, 11);
            Codigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Codigo.Location = new Point(77, 79);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(158, 27);
            Codigo.TabIndex = 42;
            Codigo.TextChanged += Codigo_TextChanged;
            // 
            // TotalPagar
            // 
            TotalPagar.BackColor = Color.FromArgb(42, 18, 11);
            TotalPagar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPagar.Location = new Point(890, 235);
            TotalPagar.Name = "TotalPagar";
            TotalPagar.Size = new Size(158, 27);
            TotalPagar.TabIndex = 43;
            TotalPagar.TextChanged += TotalPagar_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 435);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // Detalle_De_Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 622);
            Controls.Add(pictureBox2);
            Controls.Add(TotalPagar);
            Controls.Add(Codigo);
            Controls.Add(Cliente);
            Controls.Add(Fecha);
            Controls.Add(Regresar);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Detalle_De_Factura";
            Text = "Detalle_De_Factura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button Regresar;
        private PictureBox pictureBox1;
        private TextBox Fecha;
        private TextBox Cliente;
        private TextBox Codigo;
        private TextBox TotalPagar;
        private PictureBox pictureBox2;
    }
}