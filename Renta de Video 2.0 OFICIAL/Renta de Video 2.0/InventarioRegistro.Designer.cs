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
            btn_guardar = new Button();
            panelContenedor = new Panel();
            pic_mascota = new PictureBox();
            label2 = new Label();
            nud_precio = new NumericUpDown();
            label1 = new Label();
            cmb_clasificacion = new ComboBox();
            label4 = new Label();
            nud_duracion = new NumericUpDown();
            cmb_genero = new ComboBox();
            txt_previoEstado = new TextBox();
            txt_previoCopias = new TextBox();
            txt_previoTitulo = new TextBox();
            nud_copias = new NumericUpDown();
            nud_anio = new NumericUpDown();
            txt_prevAnio = new TextBox();
            txt_director = new TextBox();
            txt_titulo = new TextBox();
            txt_codigo = new TextBox();
            btn_cancelar = new Button();
            pic_imagen1 = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_precio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_copias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_anio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).BeginInit();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(246, 170, 28);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(411, 833);
            btn_guardar.Margin = new Padding(5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(135, 59);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "GUARDAR";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += OnGuardar_Video_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(pic_mascota);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(nud_precio);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(cmb_clasificacion);
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(nud_duracion);
            panelContenedor.Controls.Add(cmb_genero);
            panelContenedor.Controls.Add(txt_previoEstado);
            panelContenedor.Controls.Add(txt_previoCopias);
            panelContenedor.Controls.Add(txt_previoTitulo);
            panelContenedor.Controls.Add(nud_copias);
            panelContenedor.Controls.Add(nud_anio);
            panelContenedor.Controls.Add(txt_prevAnio);
            panelContenedor.Controls.Add(txt_director);
            panelContenedor.Controls.Add(txt_titulo);
            panelContenedor.Controls.Add(txt_codigo);
            panelContenedor.Controls.Add(btn_cancelar);
            panelContenedor.Controls.Add(btn_guardar);
            panelContenedor.Controls.Add(pic_imagen1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1298, 984);
            panelContenedor.TabIndex = 8;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(34, 9, 1);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(945, 91);
            pic_mascota.Margin = new Padding(3, 4, 3, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(91, 107);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 37;
            pic_mascota.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(34, 9, 1);
            label2.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(326, 680);
            label2.Name = "label2";
            label2.Size = new Size(193, 51);
            label2.TabIndex = 36;
            label2.Text = "Duración en minutos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nud_precio
            // 
            nud_precio.DecimalPlaces = 2;
            nud_precio.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nud_precio.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nud_precio.Location = new Point(531, 752);
            nud_precio.Margin = new Padding(3, 4, 3, 4);
            nud_precio.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            nud_precio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_precio.Name = "nud_precio";
            nud_precio.Size = new Size(137, 27);
            nud_precio.TabIndex = 35;
            nud_precio.TextAlign = HorizontalAlignment.Center;
            nud_precio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_precio.Leave += nudPrecio_Leave;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(34, 9, 1);
            label1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 556);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 34;
            label1.Text = "Clasificación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_clasificacion
            // 
            cmb_clasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_clasificacion.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_clasificacion.FormattingEnabled = true;
            cmb_clasificacion.Items.AddRange(new object[] { "Selecciona clasificación", "G", "PG", "PG-13", "R", "A", "B", "B-12", "B-15C" });
            cmb_clasificacion.Location = new Point(353, 589);
            cmb_clasificacion.Margin = new Padding(3, 4, 3, 4);
            cmb_clasificacion.Name = "cmb_clasificacion";
            cmb_clasificacion.Size = new Size(251, 25);
            cmb_clasificacion.TabIndex = 33;
            cmb_clasificacion.Leave += cmbClasificacion_Leave;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(34, 9, 1);
            label4.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(534, 696);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 32;
            label4.Text = "Precio de renta";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nud_duracion
            // 
            nud_duracion.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nud_duracion.Location = new Point(353, 749);
            nud_duracion.Margin = new Padding(3, 4, 3, 4);
            nud_duracion.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nud_duracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_duracion.Name = "nud_duracion";
            nud_duracion.Size = new Size(137, 27);
            nud_duracion.TabIndex = 31;
            nud_duracion.TextAlign = HorizontalAlignment.Center;
            nud_duracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_duracion.Leave += nudDuracion_Leave;
            // 
            // cmb_genero
            // 
            cmb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_genero.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "Selecciona un género", "Acción", "Animación", "Aventura", "Ciencia Ficción", "Comedia", "Drama", "Familiar", "Romance", "Suspenso", "Terror" });
            cmb_genero.Location = new Point(137, 480);
            cmb_genero.Margin = new Padding(3, 4, 3, 4);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(251, 25);
            cmb_genero.TabIndex = 30;
            cmb_genero.Leave += cmbGenero_Leave;
            // 
            // txt_previoEstado
            // 
            txt_previoEstado.BackColor = Color.White;
            txt_previoEstado.BorderStyle = BorderStyle.None;
            txt_previoEstado.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_previoEstado.ForeColor = Color.Black;
            txt_previoEstado.Location = new Point(1069, 533);
            txt_previoEstado.Margin = new Padding(5);
            txt_previoEstado.Multiline = true;
            txt_previoEstado.Name = "txt_previoEstado";
            txt_previoEstado.Size = new Size(109, 37);
            txt_previoEstado.TabIndex = 29;
            txt_previoEstado.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_previoCopias
            // 
            txt_previoCopias.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_previoCopias.Location = new Point(808, 533);
            txt_previoCopias.Margin = new Padding(5);
            txt_previoCopias.Multiline = true;
            txt_previoCopias.Name = "txt_previoCopias";
            txt_previoCopias.Size = new Size(82, 36);
            txt_previoCopias.TabIndex = 28;
            txt_previoCopias.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_previoTitulo
            // 
            txt_previoTitulo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_previoTitulo.Location = new Point(810, 344);
            txt_previoTitulo.Margin = new Padding(5);
            txt_previoTitulo.Multiline = true;
            txt_previoTitulo.Name = "txt_previoTitulo";
            txt_previoTitulo.Size = new Size(366, 36);
            txt_previoTitulo.TabIndex = 27;
            txt_previoTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // nud_copias
            // 
            nud_copias.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nud_copias.Location = new Point(142, 744);
            nud_copias.Margin = new Padding(5);
            nud_copias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_copias.Name = "nud_copias";
            nud_copias.Size = new Size(177, 30);
            nud_copias.TabIndex = 24;
            nud_copias.TextAlign = HorizontalAlignment.Center;
            nud_copias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_copias.ValueChanged += nudCopias_ValueChanged;
            nud_copias.Leave += nudCopias_Leave;
            // 
            // nud_anio
            // 
            nud_anio.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nud_anio.Location = new Point(141, 585);
            nud_anio.Margin = new Padding(5);
            nud_anio.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nud_anio.Minimum = new decimal(new int[] { 1888, 0, 0, 0 });
            nud_anio.Name = "nud_anio";
            nud_anio.Size = new Size(177, 30);
            nud_anio.TabIndex = 23;
            nud_anio.TextAlign = HorizontalAlignment.Center;
            nud_anio.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nud_anio.ValueChanged += nudAnio_ValueChanged;
            nud_anio.Leave += nudAnio_Leave;
            // 
            // txt_prevAnio
            // 
            txt_prevAnio.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_prevAnio.Location = new Point(810, 425);
            txt_prevAnio.Margin = new Padding(5);
            txt_prevAnio.Multiline = true;
            txt_prevAnio.Name = "txt_prevAnio";
            txt_prevAnio.Size = new Size(366, 37);
            txt_prevAnio.TabIndex = 22;
            txt_prevAnio.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_director
            // 
            txt_director.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_director.Location = new Point(430, 475);
            txt_director.Margin = new Padding(5);
            txt_director.MaxLength = 100;
            txt_director.Multiline = true;
            txt_director.Name = "txt_director";
            txt_director.Size = new Size(271, 45);
            txt_director.TabIndex = 20;
            txt_director.TextAlign = HorizontalAlignment.Center;
            txt_director.TextChanged += txtDirector_TextChanged;
            txt_director.Leave += txtDirector_Leave;
            // 
            // txt_titulo
            // 
            txt_titulo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_titulo.Location = new Point(359, 315);
            txt_titulo.Margin = new Padding(5);
            txt_titulo.MaxLength = 150;
            txt_titulo.Multiline = true;
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(316, 40);
            txt_titulo.TabIndex = 19;
            txt_titulo.TextAlign = HorizontalAlignment.Center;
            txt_titulo.TextChanged += txtTitulo_TextChanged;
            txt_titulo.Leave += txtTitulo_Leave;
            // 
            // txt_codigo
            // 
            txt_codigo.BackColor = Color.FromArgb(255, 210, 106);
            txt_codigo.BorderStyle = BorderStyle.None;
            txt_codigo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_codigo.ForeColor = Color.Black;
            txt_codigo.Location = new Point(139, 315);
            txt_codigo.Margin = new Padding(5);
            txt_codigo.Multiline = true;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(162, 41);
            txt_codigo.TabIndex = 18;
            txt_codigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(246, 170, 28);
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(567, 833);
            btn_cancelar.Margin = new Padding(5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(135, 55);
            btn_cancelar.TabIndex = 17;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btnCancelar_Click;
            // 
            // pic_imagen1
            // 
            pic_imagen1.Dock = DockStyle.Fill;
            pic_imagen1.Image = (Image)resources.GetObject("pic_imagen1.Image");
            pic_imagen1.Location = new Point(0, 0);
            pic_imagen1.Margin = new Padding(3, 4, 3, 4);
            pic_imagen1.Name = "pic_imagen1";
            pic_imagen1.Size = new Size(1298, 984);
            pic_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imagen1.TabIndex = 26;
            pic_imagen1.TabStop = false;
            pic_imagen1.Click += pictureBox1_Click;
            // 
            // InventarioRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 984);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "InventarioRegistro";
            StartPosition = FormStartPosition.Manual;
            Text = "InventarioRegistro";
            Load += InventarioRegistro_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_precio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_copias).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_anio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.NumericUpDown nud_copias;
        private System.Windows.Forms.NumericUpDown nud_anio;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.PictureBox pic_imagen1;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.TextBox txt_previoEstado;
        private System.Windows.Forms.TextBox txt_previoCopias;
        private System.Windows.Forms.TextBox txt_prevAnio;
        private System.Windows.Forms.TextBox txt_previoTitulo;
        private System.Windows.Forms.NumericUpDown nud_duracion;  // ← corregido
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_clasificacion;
        private PictureBox pic_mascota;
    }
}