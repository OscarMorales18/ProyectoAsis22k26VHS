namespace Renta_de_Video_2._0
{
    partial class InventarioLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioLista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            cmbGenero = new ComboBox();
            cmbClasificacion = new ComboBox();
            btnNuevoVideo = new Button();
            txtBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel2 = new Panel();
            btnGuardar = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            txtEstado = new TextBox();
            txtCodigo = new TextBox();
            txtCopias = new TextBox();
            txtTitulo = new TextBox();
            txtAnio = new TextBox();
            txtGenero = new TextBox();
            txtDirector = new TextBox();
            pictureBox3 = new PictureBox();
            dgwVideo = new DataGridView();
            lblConteo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwVideo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 9, 1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(cmbClasificacion);
            panel1.Controls.Add(btnNuevoVideo);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1511, 153);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1078, 7);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(205, 64);
            button1.TabIndex = 24;
            button1.Text = "REPORTE";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(142, 103);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // cmbGenero
            // 
            cmbGenero.Cursor = Cursors.Hand;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FlatStyle = FlatStyle.Flat;
            cmbGenero.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbGenero.ForeColor = Color.FromArgb(34, 9, 1);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Todos los géneros", "Terror", "Comedia", "Drama", "Acción", "Familiar", "Suspenso" });
            cmbGenero.Location = new Point(795, 105);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(265, 25);
            cmbGenero.TabIndex = 5;
            cmbGenero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;
            // 
            // cmbClasificacion
            // 
            cmbClasificacion.BackColor = Color.White;
            cmbClasificacion.Cursor = Cursors.Hand;
            cmbClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClasificacion.FlatStyle = FlatStyle.Flat;
            cmbClasificacion.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClasificacion.ForeColor = Color.FromArgb(34, 9, 1);
            cmbClasificacion.FormattingEnabled = true;
            cmbClasificacion.Items.AddRange(new object[] { "clasificacion", "G", "PG", "PG-13" });
            cmbClasificacion.Location = new Point(507, 103);
            cmbClasificacion.Margin = new Padding(3, 4, 3, 4);
            cmbClasificacion.Name = "cmbClasificacion";
            cmbClasificacion.Size = new Size(265, 26);
            cmbClasificacion.TabIndex = 6;
            cmbClasificacion.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // btnNuevoVideo
            // 
            btnNuevoVideo.BackColor = Color.DarkOrange;
            btnNuevoVideo.Cursor = Cursors.Hand;
            btnNuevoVideo.FlatStyle = FlatStyle.Popup;
            btnNuevoVideo.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoVideo.Image = (Image)resources.GetObject("btnNuevoVideo.Image");
            btnNuevoVideo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoVideo.Location = new Point(1078, 79);
            btnNuevoVideo.Margin = new Padding(3, 4, 3, 4);
            btnNuevoVideo.Name = "btnNuevoVideo";
            btnNuevoVideo.Size = new Size(205, 64);
            btnNuevoVideo.TabIndex = 23;
            btnNuevoVideo.Text = "       NUEVO VIDEO";
            btnNuevoVideo.UseVisualStyleBackColor = false;
            btnNuevoVideo.Click += btnNuevoVideo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(181, 105);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(298, 31);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 67);
            label2.Name = "label2";
            label2.Size = new Size(499, 17);
            label2.TabIndex = 1;
            label2.Text = "CÁTALOGO COMPLETO DE CINTAS VHS DISPONIBLES EN TIENDA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 170, 28);
            label1.Location = new Point(126, 12);
            label1.Name = "label1";
            label1.Size = new Size(245, 51);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            label1.Click += label1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(246, 170, 28);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(35, 557);
            btnEliminar.Margin = new Padding(5, 4, 5, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(55, 64);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(34, 9, 1);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(106, 557);
            btnEditar.Margin = new Padding(5, 4, 5, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(55, 64);
            btnEditar.TabIndex = 3;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(98, 23, 8);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(dgwVideo);
            panel2.Controls.Add(lblConteo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 153);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1511, 780);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(246, 170, 28);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(175, 557);
            btnGuardar.Margin = new Padding(5, 4, 5, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(55, 64);
            btnGuardar.TabIndex = 40;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(txtEstado);
            panel3.Controls.Add(txtCodigo);
            panel3.Controls.Add(txtCopias);
            panel3.Controls.Add(txtTitulo);
            panel3.Controls.Add(txtAnio);
            panel3.Controls.Add(txtGenero);
            panel3.Controls.Add(txtDirector);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(972, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 780);
            panel3.TabIndex = 39;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(437, 19);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEstado.BorderStyle = BorderStyle.FixedSingle;
            txtEstado.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEstado.ForeColor = Color.Black;
            txtEstado.Location = new Point(230, 648);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Multiline = true;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(280, 38);
            txtEstado.TabIndex = 38;
            txtEstado.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(230, 113);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(280, 38);
            txtCodigo.TabIndex = 25;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TextChanged += textBox2_TextChanged;
            // 
            // txtCopias
            // 
            txtCopias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCopias.BorderStyle = BorderStyle.FixedSingle;
            txtCopias.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCopias.ForeColor = Color.Black;
            txtCopias.Location = new Point(230, 557);
            txtCopias.Margin = new Padding(3, 4, 3, 4);
            txtCopias.Multiline = true;
            txtCopias.Name = "txtCopias";
            txtCopias.Size = new Size(280, 38);
            txtCopias.TabIndex = 37;
            txtCopias.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.Black;
            txtTitulo.Location = new Point(230, 203);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(280, 38);
            txtTitulo.TabIndex = 33;
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAnio
            // 
            txtAnio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnio.BorderStyle = BorderStyle.FixedSingle;
            txtAnio.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAnio.ForeColor = Color.Black;
            txtAnio.Location = new Point(230, 473);
            txtAnio.Margin = new Padding(3, 4, 3, 4);
            txtAnio.Multiline = true;
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(280, 38);
            txtAnio.TabIndex = 36;
            txtAnio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGenero
            // 
            txtGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGenero.BorderStyle = BorderStyle.FixedSingle;
            txtGenero.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGenero.ForeColor = Color.Black;
            txtGenero.Location = new Point(230, 293);
            txtGenero.Margin = new Padding(3, 4, 3, 4);
            txtGenero.Multiline = true;
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(280, 38);
            txtGenero.TabIndex = 34;
            txtGenero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDirector
            // 
            txtDirector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDirector.BorderStyle = BorderStyle.FixedSingle;
            txtDirector.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDirector.ForeColor = Color.Black;
            txtDirector.Location = new Point(230, 385);
            txtDirector.Margin = new Padding(3, 4, 3, 4);
            txtDirector.Multiline = true;
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(280, 38);
            txtDirector.TabIndex = 35;
            txtDirector.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(45, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(491, 780);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // dgwVideo
            // 
            dgwVideo.AllowUserToDeleteRows = false;
            dgwVideo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwVideo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwVideo.BackgroundColor = Color.White;
            dgwVideo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 9, 1);
            dataGridViewCellStyle1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(98, 23, 8);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwVideo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwVideo.ColumnHeadersHeight = 29;
            dgwVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwVideo.EnableHeadersVisualStyles = false;
            dgwVideo.GridColor = Color.Black;
            dgwVideo.Location = new Point(12, 83);
            dgwVideo.Margin = new Padding(3, 4, 3, 4);
            dgwVideo.Name = "dgwVideo";
            dgwVideo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 170, 28);
            dataGridViewCellStyle2.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 9, 1);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwVideo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgwVideo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(246, 170, 28);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgwVideo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgwVideo.Size = new Size(767, 457);
            dgwVideo.TabIndex = 8;
            dgwVideo.SelectionChanged += dgwVideo_SelectionChanged;
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConteo.ForeColor = Color.White;
            lblConteo.Location = new Point(23, 44);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(198, 24);
            lblConteo.TabIndex = 0;
            lblConteo.Text = "MOSTRANDO # VIDEOS";
            lblConteo.Click += lblConteo_Click;
            // 
            // InventarioLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 170, 28);
            ClientSize = new Size(1511, 933);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "InventarioLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventarioLista";
            Load += InventarioLista_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwVideo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cmbGenero;
        private Label lblConteo;
        private ComboBox cmbClasificacion;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgwVideo;
        private Button btnNuevoVideo;
        private PictureBox pictureBox3;
        private TextBox txtCodigo;
        private TextBox txtCopias;
        private TextBox txtEstado;
        private TextBox textBox7;
        private TextBox txtAnio;
        private TextBox textBox5;
        private TextBox txtGenero;
        private TextBox txtDirector;
        private TextBox txtTitulo;
        private Panel panel3;
        private Button btnGuardar;
        private PictureBox pictureBox4;
        private Button button1;
    }
}