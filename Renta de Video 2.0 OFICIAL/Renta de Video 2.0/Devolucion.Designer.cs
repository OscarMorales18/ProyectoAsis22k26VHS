namespace Renta_de_Video_2._0
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pic_mascota = new PictureBox();
            btn_confirmar = new Button();
            lbl_total = new Label();
            lbl_mora = new Label();
            lbl_subtotal = new Label();
            lbl_diasAtraso = new Label();
            lbl_fechaDevolucion = new Label();
            lbl_fechaLimite = new Label();
            dgv_video = new DataGridView();
            txt_nombreCliente = new TextBox();
            txt_membresia = new TextBox();
            dtpDevolucion = new DateTimePicker();
            btn_buscar = new Button();
            pic_general = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_video).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_general).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 133);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pic_mascota);
            panel1.Controls.Add(btn_confirmar);
            panel1.Controls.Add(lbl_total);
            panel1.Controls.Add(lbl_mora);
            panel1.Controls.Add(lbl_subtotal);
            panel1.Controls.Add(lbl_diasAtraso);
            panel1.Controls.Add(lbl_fechaDevolucion);
            panel1.Controls.Add(lbl_fechaLimite);
            panel1.Controls.Add(dgv_video);
            panel1.Controls.Add(txt_nombreCliente);
            panel1.Controls.Add(txt_membresia);
            panel1.Controls.Add(dtpDevolucion);
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(pic_general);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 984);
            panel1.TabIndex = 1;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(34, 9, 1);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(1054, 36);
            pic_mascota.Margin = new Padding(3, 4, 3, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(114, 133);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 23;
            pic_mascota.TabStop = false;
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = Color.FromArgb(246, 170, 28);
            btn_confirmar.FlatAppearance.BorderSize = 0;
            btn_confirmar.FlatStyle = FlatStyle.Flat;
            btn_confirmar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_confirmar.Location = new Point(597, 709);
            btn_confirmar.Margin = new Padding(3, 4, 3, 4);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(626, 64);
            btn_confirmar.TabIndex = 22;
            btn_confirmar.Text = "CONFIRMAR DEVOLUCIÓN";
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += OnConfirmar_Click;
            // 
            // lbl_total
            // 
            lbl_total.BorderStyle = BorderStyle.FixedSingle;
            lbl_total.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(1054, 597);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(169, 50);
            lbl_total.TabIndex = 21;
            lbl_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_mora
            // 
            lbl_mora.BackColor = Color.FromArgb(246, 170, 28);
            lbl_mora.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mora.ForeColor = Color.Black;
            lbl_mora.Location = new Point(1054, 508);
            lbl_mora.Name = "lbl_mora";
            lbl_mora.Size = new Size(169, 36);
            lbl_mora.TabIndex = 20;
            lbl_mora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_subtotal.Location = new Point(1054, 444);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(169, 36);
            lbl_subtotal.TabIndex = 19;
            lbl_subtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_diasAtraso
            // 
            lbl_diasAtraso.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_diasAtraso.Location = new Point(1054, 361);
            lbl_diasAtraso.Name = "lbl_diasAtraso";
            lbl_diasAtraso.Size = new Size(169, 36);
            lbl_diasAtraso.TabIndex = 18;
            lbl_diasAtraso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_fechaDevolucion
            // 
            lbl_fechaDevolucion.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fechaDevolucion.Location = new Point(1054, 309);
            lbl_fechaDevolucion.Name = "lbl_fechaDevolucion";
            lbl_fechaDevolucion.Size = new Size(169, 36);
            lbl_fechaDevolucion.TabIndex = 17;
            lbl_fechaDevolucion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_fechaLimite
            // 
            lbl_fechaLimite.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fechaLimite.Location = new Point(1054, 256);
            lbl_fechaLimite.Name = "lbl_fechaLimite";
            lbl_fechaLimite.Size = new Size(169, 36);
            lbl_fechaLimite.TabIndex = 16;
            lbl_fechaLimite.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(98, 23, 8);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_video.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_video.ColumnHeadersHeight = 29;
            dgv_video.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_video.EnableHeadersVisualStyles = false;
            dgv_video.GridColor = Color.Black;
            dgv_video.Location = new Point(62, 475);
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
            dgv_video.Size = new Size(473, 237);
            dgv_video.TabIndex = 15;
            // 
            // txt_nombreCliente
            // 
            txt_nombreCliente.Enabled = false;
            txt_nombreCliente.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_nombreCliente.Location = new Point(240, 203);
            txt_nombreCliente.Margin = new Padding(3, 4, 3, 4);
            txt_nombreCliente.Multiline = true;
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.ReadOnly = true;
            txt_nombreCliente.Size = new Size(279, 32);
            txt_nombreCliente.TabIndex = 14;
            txt_nombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_membresia
            // 
            txt_membresia.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_membresia.Location = new Point(85, 303);
            txt_membresia.Margin = new Padding(3, 4, 3, 4);
            txt_membresia.Multiline = true;
            txt_membresia.Name = "txt_membresia";
            txt_membresia.Size = new Size(303, 52);
            txt_membresia.TabIndex = 13;
            txt_membresia.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.CalendarFont = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDevolucion.CalendarMonthBackground = Color.White;
            dtpDevolucion.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDevolucion.Location = new Point(72, 845);
            dtpDevolucion.Margin = new Padding(3, 4, 3, 4);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(394, 30);
            dtpDevolucion.TabIndex = 12;
            dtpDevolucion.ValueChanged += dtpDevolucion_ValueChanged;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(246, 170, 28);
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(408, 296);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(127, 64);
            btn_buscar.TabIndex = 3;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += OnBuscar_Click;
            // 
            // pic_general
            // 
            pic_general.Dock = DockStyle.Fill;
            pic_general.Image = (Image)resources.GetObject("pic_general.Image");
            pic_general.Location = new Point(0, 0);
            pic_general.Margin = new Padding(3, 4, 3, 4);
            pic_general.Name = "pic_general";
            pic_general.Size = new Size(1298, 984);
            pic_general.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_general.TabIndex = 0;
            pic_general.TabStop = false;
            pic_general.Click += pictureBox1_Click;
            // 
            // Devolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1298, 984);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Devolucion";
            Text = "Devolucion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_video).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_general).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pic_general;
        private Button btn_buscar;
        private Label lbl_fechaLimite;
        private DateTimePicker dtpDevolucion;
        private TextBox txt_membresia;
        private TextBox txt_nombreCliente;
        private DataGridView dgv_video;
        private Label lbl_total;
        private Label lbl_mora;
        private Label lbl_subtotal;
        private Label lbl_diasAtraso;
        private Label lbl_fechaDevolucion;
        private Button btn_confirmar;
        private PictureBox pic_mascota;
    }
}