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
            btn_reporte = new Button();
            pictureBox2 = new PictureBox();
            cmb_genero = new ComboBox();
            cmb_clasificacion = new ComboBox();
            btn_nuevoVideo = new Button();
            txt_buscar = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btn_eliminar = new Button();
            btn_editar = new Button();
            panel2 = new Panel();
            btn_guardar = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            txt_estado = new TextBox();
            txt_codigo = new TextBox();
            txt_copias = new TextBox();
            txt_titulo = new TextBox();
            txt_anio = new TextBox();
            txt_genero = new TextBox();
            txt_director = new TextBox();
            pic_informacion = new PictureBox();
            dgv_video = new DataGridView();
            lblConteo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_informacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_video).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 9, 1);
            panel1.Controls.Add(btn_reporte);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(cmb_genero);
            panel1.Controls.Add(cmb_clasificacion);
            panel1.Controls.Add(btn_nuevoVideo);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 153);
            panel1.TabIndex = 0;
            // 
            // btn_reporte
            // 
            btn_reporte.BackColor = Color.DarkOrange;
            btn_reporte.Cursor = Cursors.Hand;
            btn_reporte.FlatStyle = FlatStyle.Popup;
            btn_reporte.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reporte.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reporte.Location = new Point(1078, 7);
            btn_reporte.Margin = new Padding(3, 4, 3, 4);
            btn_reporte.Name = "btn_reporte";
            btn_reporte.Size = new Size(205, 64);
            btn_reporte.TabIndex = 24;
            btn_reporte.Text = "REPORTE";
            btn_reporte.UseVisualStyleBackColor = false;
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
            // cmb_genero
            // 
            cmb_genero.Cursor = Cursors.Hand;
            cmb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_genero.FlatStyle = FlatStyle.Flat;
            cmb_genero.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_genero.ForeColor = Color.FromArgb(34, 9, 1);
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "Todos los géneros", "Terror", "Comedia", "Drama", "Acción", "Familiar", "Suspenso" });
            cmb_genero.Location = new Point(795, 105);
            cmb_genero.Margin = new Padding(3, 4, 3, 4);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(265, 25);
            cmb_genero.TabIndex = 5;
            cmb_genero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;
            // 
            // cmb_clasificacion
            // 
            cmb_clasificacion.BackColor = Color.White;
            cmb_clasificacion.Cursor = Cursors.Hand;
            cmb_clasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_clasificacion.FlatStyle = FlatStyle.Flat;
            cmb_clasificacion.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_clasificacion.ForeColor = Color.FromArgb(34, 9, 1);
            cmb_clasificacion.FormattingEnabled = true;
            cmb_clasificacion.Items.AddRange(new object[] { "clasificacion", "G", "PG", "PG-13" });
            cmb_clasificacion.Location = new Point(507, 103);
            cmb_clasificacion.Margin = new Padding(3, 4, 3, 4);
            cmb_clasificacion.Name = "cmb_clasificacion";
            cmb_clasificacion.Size = new Size(265, 26);
            cmb_clasificacion.TabIndex = 6;
            cmb_clasificacion.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // btn_nuevoVideo
            // 
            btn_nuevoVideo.BackColor = Color.DarkOrange;
            btn_nuevoVideo.Cursor = Cursors.Hand;
            btn_nuevoVideo.FlatStyle = FlatStyle.Popup;
            btn_nuevoVideo.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nuevoVideo.Image = (Image)resources.GetObject("btn_nuevoVideo.Image");
            btn_nuevoVideo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nuevoVideo.Location = new Point(1078, 79);
            btn_nuevoVideo.Margin = new Padding(3, 4, 3, 4);
            btn_nuevoVideo.Name = "btn_nuevoVideo";
            btn_nuevoVideo.Size = new Size(205, 64);
            btn_nuevoVideo.TabIndex = 23;
            btn_nuevoVideo.Text = "       NUEVO VIDEO";
            btn_nuevoVideo.UseVisualStyleBackColor = false;
            btn_nuevoVideo.Click += OnNuevoVideo_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(181, 105);
            txt_buscar.Margin = new Padding(3, 4, 3, 4);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(298, 31);
            txt_buscar.TabIndex = 3;
            txt_buscar.TextAlign = HorizontalAlignment.Center;
            txt_buscar.TextChanged += txtBuscar_TextChanged;
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
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(246, 170, 28);
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.BorderColor = Color.Black;
            btn_eliminar.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_eliminar.FlatAppearance.MouseOverBackColor = Color.White;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.ForeColor = Color.Black;
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(35, 557);
            btn_eliminar.Margin = new Padding(5, 4, 5, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(55, 64);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += OnEliminar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(34, 9, 1);
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderColor = Color.Black;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_editar.FlatAppearance.MouseOverBackColor = Color.White;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.ForeColor = Color.Black;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editar.Location = new Point(106, 557);
            btn_editar.Margin = new Padding(5, 4, 5, 4);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(55, 64);
            btn_editar.TabIndex = 3;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += OnEditar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(98, 23, 8);
            panel2.Controls.Add(btn_guardar);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(btn_editar);
            panel2.Controls.Add(dgv_video);
            panel2.Controls.Add(lblConteo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 153);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 831);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(246, 170, 28);
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatAppearance.BorderColor = Color.Black;
            btn_guardar.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.White;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = Color.Black;
            btn_guardar.Image = (Image)resources.GetObject("btn_guardar.Image");
            btn_guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_guardar.Location = new Point(175, 557);
            btn_guardar.Margin = new Padding(5, 4, 5, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(55, 64);
            btn_guardar.TabIndex = 40;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Visible = false;
            btn_guardar.Click += OnGuardar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(txt_estado);
            panel3.Controls.Add(txt_codigo);
            panel3.Controls.Add(txt_copias);
            panel3.Controls.Add(txt_titulo);
            panel3.Controls.Add(txt_anio);
            panel3.Controls.Add(txt_genero);
            panel3.Controls.Add(txt_director);
            panel3.Controls.Add(pic_informacion);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(759, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 831);
            panel3.TabIndex = 39;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(437, 19);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // txt_estado
            // 
            txt_estado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_estado.BorderStyle = BorderStyle.FixedSingle;
            txt_estado.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_estado.ForeColor = Color.Black;
            txt_estado.Location = new Point(230, 648);
            txt_estado.Margin = new Padding(3, 4, 3, 4);
            txt_estado.Multiline = true;
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(280, 38);
            txt_estado.TabIndex = 38;
            txt_estado.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_codigo
            // 
            txt_codigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_codigo.BorderStyle = BorderStyle.FixedSingle;
            txt_codigo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_codigo.ForeColor = Color.Black;
            txt_codigo.Location = new Point(230, 113);
            txt_codigo.Margin = new Padding(3, 4, 3, 4);
            txt_codigo.Multiline = true;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(280, 38);
            txt_codigo.TabIndex = 25;
            txt_codigo.TextAlign = HorizontalAlignment.Center;
            txt_codigo.TextChanged += textBox2_TextChanged;
            // 
            // txt_copias
            // 
            txt_copias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_copias.BorderStyle = BorderStyle.FixedSingle;
            txt_copias.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_copias.ForeColor = Color.Black;
            txt_copias.Location = new Point(230, 557);
            txt_copias.Margin = new Padding(3, 4, 3, 4);
            txt_copias.Multiline = true;
            txt_copias.Name = "txt_copias";
            txt_copias.Size = new Size(280, 38);
            txt_copias.TabIndex = 37;
            txt_copias.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_titulo
            // 
            txt_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_titulo.BorderStyle = BorderStyle.FixedSingle;
            txt_titulo.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_titulo.ForeColor = Color.Black;
            txt_titulo.Location = new Point(230, 203);
            txt_titulo.Margin = new Padding(3, 4, 3, 4);
            txt_titulo.Multiline = true;
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(280, 38);
            txt_titulo.TabIndex = 33;
            txt_titulo.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_anio
            // 
            txt_anio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_anio.BorderStyle = BorderStyle.FixedSingle;
            txt_anio.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_anio.ForeColor = Color.Black;
            txt_anio.Location = new Point(230, 473);
            txt_anio.Margin = new Padding(3, 4, 3, 4);
            txt_anio.Multiline = true;
            txt_anio.Name = "txt_anio";
            txt_anio.Size = new Size(280, 38);
            txt_anio.TabIndex = 36;
            txt_anio.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_genero
            // 
            txt_genero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_genero.BorderStyle = BorderStyle.FixedSingle;
            txt_genero.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_genero.ForeColor = Color.Black;
            txt_genero.Location = new Point(230, 293);
            txt_genero.Margin = new Padding(3, 4, 3, 4);
            txt_genero.Multiline = true;
            txt_genero.Name = "txt_genero";
            txt_genero.Size = new Size(280, 38);
            txt_genero.TabIndex = 34;
            txt_genero.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_director
            // 
            txt_director.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_director.BorderStyle = BorderStyle.FixedSingle;
            txt_director.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_director.ForeColor = Color.Black;
            txt_director.Location = new Point(230, 385);
            txt_director.Margin = new Padding(3, 4, 3, 4);
            txt_director.Multiline = true;
            txt_director.Name = "txt_director";
            txt_director.Size = new Size(280, 38);
            txt_director.TabIndex = 35;
            txt_director.TextAlign = HorizontalAlignment.Center;
            // 
            // pic_informacion
            // 
            pic_informacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pic_informacion.Image = (Image)resources.GetObject("pic_informacion.Image");
            pic_informacion.Location = new Point(45, 0);
            pic_informacion.Margin = new Padding(3, 4, 3, 4);
            pic_informacion.Name = "pic_informacion";
            pic_informacion.Size = new Size(491, 780);
            pic_informacion.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_informacion.TabIndex = 24;
            pic_informacion.TabStop = false;
            pic_informacion.Click += pictureBox3_Click_1;
            // 
            // dgv_video
            // 
            dgv_video.AllowUserToDeleteRows = false;
            dgv_video.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_video.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_video.BackgroundColor = Color.White;
            dgv_video.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 9, 1);
            dataGridViewCellStyle1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(98, 23, 8);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_video.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_video.ColumnHeadersHeight = 29;
            dgv_video.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_video.EnableHeadersVisualStyles = false;
            dgv_video.GridColor = Color.Black;
            dgv_video.Location = new Point(11, 83);
            dgv_video.Margin = new Padding(3, 4, 3, 4);
            dgv_video.Name = "dgv_video";
            dgv_video.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 170, 28);
            dataGridViewCellStyle2.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 9, 1);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_video.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_video.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(246, 170, 28);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_video.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_video.Size = new Size(767, 457);
            dgv_video.TabIndex = 8;
            dgv_video.SelectionChanged += dgwVideo_SelectionChanged;
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
            ClientSize = new Size(1298, 984);
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
            ((System.ComponentModel.ISupportInitialize)pic_informacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_video).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txt_buscar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cmb_genero;
        private Label lblConteo;
        private ComboBox cmb_clasificacion;
        private Button btn_editar;
        private Button btn_eliminar;
        private DataGridView dgv_video;
        private Button btn_nuevoVideo;
        private PictureBox pic_informacion;
        private TextBox txt_codigo;
        private TextBox txt_copias;
        private TextBox txt_estado;
        private TextBox textBox7;
        private TextBox txt_anio;
        private TextBox textBox5;
        private TextBox txt_genero;
        private TextBox txt_director;
        private TextBox txt_titulo;
        private Panel panel3;
        private Button btn_guardar;
        private PictureBox pictureBox4;
        private Button btn_reporte;
    }
}