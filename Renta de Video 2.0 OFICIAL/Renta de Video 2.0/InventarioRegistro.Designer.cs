namespace Renta_de_Video_2._0
{
    partial class InventarioRegistro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioRegistro));
            GuardarVideo = new Button();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            nudPrecio = new NumericUpDown();
            label1 = new Label();
            cmbClasificacion = new ComboBox();
            label4 = new Label();
            nudDuracion = new NumericUpDown();
            cmbGenero = new ComboBox();
            preves = new TextBox();
            prevco = new TextBox();
            prevtitulo = new TextBox();
            nudCopias = new NumericUpDown();
            nudAnio = new NumericUpDown();
            prevdirea = new TextBox();
            txtDirector = new TextBox();
            txtTitulo = new TextBox();
            txtCodigo = new TextBox();
            btncancelari = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCopias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GuardarVideo
            // 
            GuardarVideo.BackColor = Color.FromArgb(246, 170, 28);
            GuardarVideo.FlatStyle = FlatStyle.Flat;
            GuardarVideo.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuardarVideo.Location = new Point(360, 625);
            GuardarVideo.Margin = new Padding(4);
            GuardarVideo.Name = "GuardarVideo";
            GuardarVideo.Size = new Size(118, 44);
            GuardarVideo.TabIndex = 2;
            GuardarVideo.Text = "GUARDAR";
            GuardarVideo.UseVisualStyleBackColor = false;
            GuardarVideo.Click += GuardarVideo_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(nudPrecio);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(cmbClasificacion);
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(nudDuracion);
            panelContenedor.Controls.Add(cmbGenero);
            panelContenedor.Controls.Add(preves);
            panelContenedor.Controls.Add(prevco);
            panelContenedor.Controls.Add(prevtitulo);
            panelContenedor.Controls.Add(nudCopias);
            panelContenedor.Controls.Add(nudAnio);
            panelContenedor.Controls.Add(prevdirea);
            panelContenedor.Controls.Add(txtDirector);
            panelContenedor.Controls.Add(txtTitulo);
            panelContenedor.Controls.Add(txtCodigo);
            panelContenedor.Controls.Add(btncancelari);
            panelContenedor.Controls.Add(GuardarVideo);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1136, 738);
            panelContenedor.TabIndex = 8;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(34, 9, 1);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(827, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(34, 9, 1);
            label2.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(285, 510);
            label2.Name = "label2";
            label2.Size = new Size(169, 38);
            label2.TabIndex = 36;
            label2.Text = "Duración en minutos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudPrecio.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudPrecio.Location = new Point(465, 564);
            nudPrecio.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 35;
            nudPrecio.TextAlign = HorizontalAlignment.Center;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.Leave += nudPrecio_Leave;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(34, 9, 1);
            label1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(301, 417);
            label1.Name = "label1";
            label1.Size = new Size(121, 19);
            label1.TabIndex = 34;
            label1.Text = "Clasificación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbClasificacion
            // 
            cmbClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClasificacion.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClasificacion.FormattingEnabled = true;
            cmbClasificacion.Items.AddRange(new object[] { "Selecciona clasificación", "G", "PG", "PG-13", "R", "A", "B", "B-12", "B-15C" });
            cmbClasificacion.Location = new Point(309, 442);
            cmbClasificacion.Name = "cmbClasificacion";
            cmbClasificacion.Size = new Size(220, 23);
            cmbClasificacion.TabIndex = 33;
            cmbClasificacion.Leave += cmbClasificacion_Leave;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(34, 9, 1);
            label4.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(467, 522);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 32;
            label4.Text = "Precio de renta";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDuracion
            // 
            nudDuracion.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudDuracion.Location = new Point(309, 562);
            nudDuracion.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(120, 23);
            nudDuracion.TabIndex = 31;
            nudDuracion.TextAlign = HorizontalAlignment.Center;
            nudDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuracion.Leave += nudDuracion_Leave;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Selecciona un género", "Acción", "Animación", "Aventura", "Ciencia Ficción", "Comedia", "Drama", "Familiar", "Romance", "Suspenso", "Terror" });
            cmbGenero.Location = new Point(120, 360);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(220, 23);
            cmbGenero.TabIndex = 30;
            cmbGenero.Leave += cmbGenero_Leave;
            // 
            // preves
            // 
            preves.BackColor = Color.White;
            preves.BorderStyle = BorderStyle.None;
            preves.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preves.ForeColor = Color.Black;
            preves.Location = new Point(935, 400);
            preves.Margin = new Padding(4);
            preves.Multiline = true;
            preves.Name = "preves";
            preves.Size = new Size(95, 28);
            preves.TabIndex = 29;
            preves.TextAlign = HorizontalAlignment.Center;
            // 
            // prevco
            // 
            prevco.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevco.Location = new Point(707, 400);
            prevco.Margin = new Padding(4);
            prevco.Multiline = true;
            prevco.Name = "prevco";
            prevco.Size = new Size(72, 28);
            prevco.TabIndex = 28;
            prevco.TextAlign = HorizontalAlignment.Center;
            // 
            // prevtitulo
            // 
            prevtitulo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevtitulo.Location = new Point(709, 258);
            prevtitulo.Margin = new Padding(4);
            prevtitulo.Multiline = true;
            prevtitulo.Name = "prevtitulo";
            prevtitulo.Size = new Size(321, 28);
            prevtitulo.TabIndex = 27;
            prevtitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // nudCopias
            // 
            nudCopias.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudCopias.Location = new Point(124, 558);
            nudCopias.Margin = new Padding(4);
            nudCopias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCopias.Name = "nudCopias";
            nudCopias.Size = new Size(155, 25);
            nudCopias.TabIndex = 24;
            nudCopias.TextAlign = HorizontalAlignment.Center;
            nudCopias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCopias.ValueChanged += nudCopias_ValueChanged;
            nudCopias.Leave += nudCopias_Leave;
            // 
            // nudAnio
            // 
            nudAnio.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudAnio.Location = new Point(123, 439);
            nudAnio.Margin = new Padding(4);
            nudAnio.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 1888, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(155, 25);
            nudAnio.TabIndex = 23;
            nudAnio.TextAlign = HorizontalAlignment.Center;
            nudAnio.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nudAnio.ValueChanged += nudAnio_ValueChanged;
            nudAnio.Leave += nudAnio_Leave;
            // 
            // prevdirea
            // 
            prevdirea.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevdirea.Location = new Point(709, 319);
            prevdirea.Margin = new Padding(4);
            prevdirea.Multiline = true;
            prevdirea.Name = "prevdirea";
            prevdirea.Size = new Size(321, 29);
            prevdirea.TabIndex = 22;
            prevdirea.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDirector
            // 
            txtDirector.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDirector.Location = new Point(376, 356);
            txtDirector.Margin = new Padding(4);
            txtDirector.MaxLength = 100;
            txtDirector.Multiline = true;
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(238, 35);
            txtDirector.TabIndex = 20;
            txtDirector.TextAlign = HorizontalAlignment.Center;
            txtDirector.TextChanged += txtDirector_TextChanged;
            txtDirector.Leave += txtDirector_Leave;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(314, 236);
            txtTitulo.Margin = new Padding(4);
            txtTitulo.MaxLength = 150;
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(277, 31);
            txtTitulo.TabIndex = 19;
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            txtTitulo.Leave += txtTitulo_Leave;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(255, 210, 106);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(122, 236);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(142, 31);
            txtCodigo.TabIndex = 18;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btncancelari
            // 
            btncancelari.BackColor = Color.FromArgb(246, 170, 28);
            btncancelari.FlatStyle = FlatStyle.Flat;
            btncancelari.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelari.Location = new Point(496, 625);
            btncancelari.Margin = new Padding(4);
            btncancelari.Name = "btncancelari";
            btncancelari.Size = new Size(118, 41);
            btncancelari.TabIndex = 17;
            btncancelari.Text = "CANCELAR";
            btncancelari.UseVisualStyleBackColor = false;
            btncancelari.Click += btncancelari_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1136, 738);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // InventarioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 738);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "InventarioRegistro";
            StartPosition = FormStartPosition.Manual;
            Text = "InventarioRegistro";
            Load += InventarioRegistro_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCopias).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button GuardarVideo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btncancelari;
        private System.Windows.Forms.NumericUpDown nudCopias;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox preves;
        private System.Windows.Forms.TextBox prevco;
        private System.Windows.Forms.TextBox prevdirea;
        private System.Windows.Forms.TextBox prevtitulo;
        private System.Windows.Forms.NumericUpDown nudDuracion;  // ← corregido
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private PictureBox pictureBox2;
    }
}