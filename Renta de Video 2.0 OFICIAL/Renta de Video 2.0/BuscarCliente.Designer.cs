namespace Renta_de_Video_2._0
{
    partial class BuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCliente));
            btn_buscar = new Button();
            pic_imagen1 = new PictureBox();
            txt_codigoMembresia = new TextBox();
            pic_mascota = new PictureBox();
            dgv_cliente = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            DPI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            btn_registro = new Button();
            btn_detalleCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_cliente).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.DarkOrange;
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(131, 440);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(129, 79);
            btn_buscar.TabIndex = 7;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += OnBuscar_Click;
            // 
            // pic_imagen1
            // 
            pic_imagen1.BackColor = Color.Transparent;
            pic_imagen1.Dock = DockStyle.Fill;
            pic_imagen1.Image = (Image)resources.GetObject("pic_imagen1.Image");
            pic_imagen1.Location = new Point(0, 0);
            pic_imagen1.Margin = new Padding(3, 4, 3, 4);
            pic_imagen1.Name = "pic_imagen1";
            pic_imagen1.Size = new Size(1136, 739);
            pic_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imagen1.TabIndex = 19;
            pic_imagen1.TabStop = false;
            // 
            // txt_codigoMembresia
            // 
            txt_codigoMembresia.BackColor = Color.FromArgb(70, 0, 0);
            txt_codigoMembresia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_codigoMembresia.ForeColor = Color.White;
            txt_codigoMembresia.Location = new Point(21, 369);
            txt_codigoMembresia.Margin = new Padding(3, 4, 3, 4);
            txt_codigoMembresia.Name = "txt_codigoMembresia";
            txt_codigoMembresia.Size = new Size(276, 32);
            txt_codigoMembresia.TabIndex = 20;
            txt_codigoMembresia.TextChanged += Codigo_Membresia_TextChanged;
            // 
            // pic_mascota
            // 
            pic_mascota.BackColor = Color.FromArgb(42, 0, 0);
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(104, 503);
            pic_mascota.Margin = new Padding(5, 4, 5, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(193, 235);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 25;
            pic_mascota.TabStop = false;
            // 
            // dgv_cliente
            // 
            dgv_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cliente.Columns.AddRange(new DataGridViewColumn[] { Nombre, DPI, Telefono, Direccion, Correo });
            dgv_cliente.Location = new Point(400, 369);
            dgv_cliente.Margin = new Padding(3, 4, 3, 4);
            dgv_cliente.Name = "dgv_cliente";
            dgv_cliente.RowHeadersWidth = 51;
            dgv_cliente.Size = new Size(675, 200);
            dgv_cliente.TabIndex = 26;
            dgv_cliente.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre_C";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // DPI
            // 
            DPI.HeaderText = "DPI";
            DPI.MinimumWidth = 6;
            DPI.Name = "DPI";
            DPI.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // btn_registro
            // 
            btn_registro.BackColor = Color.DarkOrange;
            btn_registro.Cursor = Cursors.Hand;
            btn_registro.FlatStyle = FlatStyle.Popup;
            btn_registro.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registro.Location = new Point(561, 75);
            btn_registro.Margin = new Padding(3, 4, 3, 4);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(166, 72);
            btn_registro.TabIndex = 27;
            btn_registro.Text = "Registro Cliente";
            btn_registro.UseVisualStyleBackColor = false;
            btn_registro.Click += On_Registro;
            // 
            // btn_detalleCliente
            // 
            btn_detalleCliente.BackColor = Color.DarkOrange;
            btn_detalleCliente.Cursor = Cursors.Hand;
            btn_detalleCliente.FlatStyle = FlatStyle.Popup;
            btn_detalleCliente.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_detalleCliente.Location = new Point(869, 75);
            btn_detalleCliente.Margin = new Padding(3, 4, 3, 4);
            btn_detalleCliente.Name = "btn_detalleCliente";
            btn_detalleCliente.Size = new Size(166, 72);
            btn_detalleCliente.TabIndex = 28;
            btn_detalleCliente.Text = "Detalle Cliente";
            btn_detalleCliente.UseVisualStyleBackColor = false;
            btn_detalleCliente.Click += On_Detalle;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1136, 739);
            Controls.Add(btn_detalleCliente);
            Controls.Add(btn_registro);
            Controls.Add(dgv_cliente);
            Controls.Add(pic_mascota);
            Controls.Add(txt_codigoMembresia);
            Controls.Add(btn_buscar);
            Controls.Add(pic_imagen1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuscarCliente";
            Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar;
        private PictureBox pic_imagen1;
        private TextBox txt_codigoMembresia;
        private PictureBox pic_mascota;
        private DataGridView dgv_cliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DPI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
        private Button btn_registro;
        private Button btn_detalleCliente;
    }
}