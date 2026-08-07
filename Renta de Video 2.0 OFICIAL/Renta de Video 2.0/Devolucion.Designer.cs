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
            pictureBox2 = new PictureBox();
            btnConfirmar = new Button();
            lblTotal = new Label();
            lblMora = new Label();
            lblSubtotal = new Label();
            lblDiasAtraso = new Label();
            lblFechaDevolucion = new Label();
            lblFechaLimite = new Label();
            dgwVideod = new DataGridView();
            txtNombreCliente = new TextBox();
            txtMembresia = new TextBox();
            dtpDevolucion = new DateTimePicker();
            btnBuscar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwVideod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblMora);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(lblDiasAtraso);
            panel1.Controls.Add(lblFechaDevolucion);
            panel1.Controls.Add(lblFechaLimite);
            panel1.Controls.Add(dgwVideod);
            panel1.Controls.Add(txtNombreCliente);
            panel1.Controls.Add(txtMembresia);
            panel1.Controls.Add(dtpDevolucion);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 738);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(34, 9, 1);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(922, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(246, 170, 28);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(522, 532);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(548, 48);
            btnConfirmar.TabIndex = 22;
            btnConfirmar.Text = "CONFIRMAR DEVOLUCIÓN";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(922, 448);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(148, 38);
            lblTotal.TabIndex = 21;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMora
            // 
            lblMora.BackColor = Color.FromArgb(246, 170, 28);
            lblMora.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMora.ForeColor = Color.Black;
            lblMora.Location = new Point(922, 381);
            lblMora.Name = "lblMora";
            lblMora.Size = new Size(148, 27);
            lblMora.TabIndex = 20;
            lblMora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(922, 333);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(148, 27);
            lblSubtotal.TabIndex = 19;
            lblSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiasAtraso
            // 
            lblDiasAtraso.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiasAtraso.Location = new Point(922, 271);
            lblDiasAtraso.Name = "lblDiasAtraso";
            lblDiasAtraso.Size = new Size(148, 27);
            lblDiasAtraso.TabIndex = 18;
            lblDiasAtraso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaDevolucion.Location = new Point(922, 232);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(148, 27);
            lblFechaDevolucion.TabIndex = 17;
            lblFechaDevolucion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaLimite.Location = new Point(922, 192);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(148, 27);
            lblFechaLimite.TabIndex = 16;
            lblFechaLimite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgwVideod
            // 
            dgwVideod.AllowUserToDeleteRows = false;
            dgwVideod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwVideod.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwVideod.BackgroundColor = Color.White;
            dgwVideod.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 9, 1);
            dataGridViewCellStyle1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(98, 23, 8);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwVideod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwVideod.ColumnHeadersHeight = 29;
            dgwVideod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwVideod.EnableHeadersVisualStyles = false;
            dgwVideod.GridColor = Color.Black;
            dgwVideod.Location = new Point(54, 356);
            dgwVideod.Name = "dgwVideod";
            dgwVideod.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 170, 28);
            dataGridViewCellStyle2.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 9, 1);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwVideod.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgwVideod.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(246, 170, 28);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgwVideod.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgwVideod.Size = new Size(414, 178);
            dgwVideod.TabIndex = 15;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCliente.Location = new Point(210, 152);
            txtNombreCliente.Multiline = true;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(245, 25);
            txtNombreCliente.TabIndex = 14;
            txtNombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMembresia
            // 
            txtMembresia.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMembresia.Location = new Point(74, 227);
            txtMembresia.Multiline = true;
            txtMembresia.Name = "txtMembresia";
            txtMembresia.Size = new Size(266, 40);
            txtMembresia.TabIndex = 13;
            txtMembresia.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.CalendarFont = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDevolucion.CalendarMonthBackground = Color.White;
            dtpDevolucion.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDevolucion.Location = new Point(63, 634);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(345, 25);
            dtpDevolucion.TabIndex = 12;
            dtpDevolucion.ValueChanged += dtpDevolucion_ValueChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(246, 170, 28);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(357, 222);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 48);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1136, 738);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Devolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1136, 738);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Devolucion";
            Text = "Devolucion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwVideod).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnBuscar;
        private Label lblFechaLimite;
        private DateTimePicker dtpDevolucion;
        private TextBox txtMembresia;
        private TextBox txtNombreCliente;
        private DataGridView dgwVideod;
        private Label lblTotal;
        private Label lblMora;
        private Label lblSubtotal;
        private Label lblDiasAtraso;
        private Label lblFechaDevolucion;
        private Button btnConfirmar;
        private PictureBox pictureBox2;
    }
}