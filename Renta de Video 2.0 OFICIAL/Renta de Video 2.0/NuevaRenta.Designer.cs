namespace Renta_de_Video_2._0
{
    partial class NuevaRenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaRenta));
            txt_fechaRenta = new TextBox();
            txt_membresia = new TextBox();
            btn_buscar = new Button();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            txt_totalapagar = new TextBox();
            txt_subtotal = new TextBox();
            txt_fechaLimite = new TextBox();
            pnl_pelicula3 = new Panel();
            chk_4 = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            pnl_pelicula4 = new Panel();
            chk_3 = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            pnl_pelicula2 = new Panel();
            chk_2 = new CheckBox();
            label9 = new Label();
            label15 = new Label();
            btn_confirmar = new Button();
            pnl_pelicula1 = new Panel();
            chk_1 = new CheckBox();
            label5 = new Label();
            label2 = new Label();
            btn_devolucion = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_pelicula3.SuspendLayout();
            pnl_pelicula4.SuspendLayout();
            pnl_pelicula2.SuspendLayout();
            pnl_pelicula1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_fechaRenta
            // 
            txt_fechaRenta.BackColor = Color.FromArgb(64, 0, 0);
            txt_fechaRenta.Font = new Font("Segoe UI", 8.25F);
            txt_fechaRenta.ForeColor = Color.White;
            txt_fechaRenta.Location = new Point(997, 383);
            txt_fechaRenta.Margin = new Padding(5, 4, 5, 4);
            txt_fechaRenta.Name = "txt_fechaRenta";
            txt_fechaRenta.Size = new Size(100, 26);
            txt_fechaRenta.TabIndex = 19;
            txt_fechaRenta.TextChanged += fencharent_TextChanged;
            // 
            // txt_membresia
            // 
            txt_membresia.BackColor = Color.FromArgb(64, 0, 0);
            txt_membresia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_membresia.ForeColor = Color.White;
            txt_membresia.Location = new Point(5, 189);
            txt_membresia.Margin = new Padding(5, 4, 5, 4);
            txt_membresia.Name = "txt_membresia";
            txt_membresia.Size = new Size(194, 42);
            txt_membresia.TabIndex = 18;
            txt_membresia.TextChanged += membresia_TextChanged;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.DarkOrange;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(204, 187);
            btn_buscar.Margin = new Padding(5, 4, 5, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(88, 57);
            btn_buscar.TabIndex = 17;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += OnBuscar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Controls.Add(txt_totalapagar);
            panelContenedor.Controls.Add(txt_subtotal);
            panelContenedor.Controls.Add(txt_fechaLimite);
            panelContenedor.Controls.Add(pnl_pelicula3);
            panelContenedor.Controls.Add(button2);
            panelContenedor.Controls.Add(pnl_pelicula4);
            panelContenedor.Controls.Add(pnl_pelicula2);
            panelContenedor.Controls.Add(txt_fechaRenta);
            panelContenedor.Controls.Add(txt_membresia);
            panelContenedor.Controls.Add(btn_buscar);
            panelContenedor.Controls.Add(btn_confirmar);
            panelContenedor.Controls.Add(pnl_pelicula1);
            panelContenedor.Controls.Add(btn_devolucion);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(5, 4, 5, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1136, 738);
            panelContenedor.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(42, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1192, 360);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // txt_totalapagar
            // 
            txt_totalapagar.BackColor = Color.FromArgb(64, 0, 0);
            txt_totalapagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_totalapagar.ForeColor = Color.White;
            txt_totalapagar.Location = new Point(997, 487);
            txt_totalapagar.Margin = new Padding(5, 4, 5, 4);
            txt_totalapagar.Name = "txt_totalapagar";
            txt_totalapagar.Size = new Size(100, 34);
            txt_totalapagar.TabIndex = 43;
            txt_totalapagar.TextChanged += totalapagar_TextChanged;
            // 
            // txt_subtotal
            // 
            txt_subtotal.BackColor = Color.FromArgb(64, 0, 0);
            txt_subtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_subtotal.ForeColor = Color.White;
            txt_subtotal.Location = new Point(997, 445);
            txt_subtotal.Margin = new Padding(5, 4, 5, 4);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(100, 34);
            txt_subtotal.TabIndex = 42;
            txt_subtotal.TextChanged += Subtotal_TextChanged;
            // 
            // txt_fechaLimite
            // 
            txt_fechaLimite.BackColor = Color.FromArgb(64, 0, 0);
            txt_fechaLimite.Font = new Font("Segoe UI", 8.25F);
            txt_fechaLimite.ForeColor = Color.White;
            txt_fechaLimite.Location = new Point(997, 411);
            txt_fechaLimite.Margin = new Padding(5, 4, 5, 4);
            txt_fechaLimite.Name = "txt_fechaLimite";
            txt_fechaLimite.Size = new Size(100, 26);
            txt_fechaLimite.TabIndex = 41;
            txt_fechaLimite.TextChanged += fechalim_TextChanged;
            // 
            // pnl_pelicula3
            // 
            pnl_pelicula3.Controls.Add(chk_4);
            pnl_pelicula3.Controls.Add(label1);
            pnl_pelicula3.Controls.Add(label3);
            pnl_pelicula3.Location = new Point(414, 379);
            pnl_pelicula3.Margin = new Padding(5, 4, 5, 4);
            pnl_pelicula3.Name = "pnl_pelicula3";
            pnl_pelicula3.Size = new Size(378, 128);
            pnl_pelicula3.TabIndex = 28;
            pnl_pelicula3.Paint += Pelicula4_Paint;
            // 
            // chk_4
            // 
            chk_4.AutoSize = true;
            chk_4.Location = new Point(355, 4);
            chk_4.Margin = new Padding(5, 4, 5, 4);
            chk_4.Name = "chk_4";
            chk_4.Size = new Size(18, 17);
            chk_4.TabIndex = 27;
            chk_4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 24;
            label1.Text = "IMAGEN de PORTADA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 103);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 22;
            label3.Text = "PELICULA DE EJEMPLO";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1496, 16);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 27;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += OnSalir_Click;
            // 
            // pnl_pelicula4
            // 
            pnl_pelicula4.Controls.Add(chk_3);
            pnl_pelicula4.Controls.Add(label16);
            pnl_pelicula4.Controls.Add(label17);
            pnl_pelicula4.Location = new Point(414, 526);
            pnl_pelicula4.Margin = new Padding(5, 4, 5, 4);
            pnl_pelicula4.Name = "pnl_pelicula4";
            pnl_pelicula4.Size = new Size(378, 126);
            pnl_pelicula4.TabIndex = 26;
            pnl_pelicula4.Paint += Pelicula3_Paint;
            // 
            // chk_3
            // 
            chk_3.AutoSize = true;
            chk_3.Location = new Point(355, 4);
            chk_3.Margin = new Padding(5, 4, 5, 4);
            chk_3.Name = "chk_3";
            chk_3.Size = new Size(18, 17);
            chk_3.TabIndex = 27;
            chk_3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(49, 21);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(155, 20);
            label16.TabIndex = 24;
            label16.Text = "IMAGEN de PORTADA";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(43, 103);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(158, 20);
            label17.TabIndex = 22;
            label17.Text = "PELICULA DE EJEMPLO";
            // 
            // pnl_pelicula2
            // 
            pnl_pelicula2.Controls.Add(chk_2);
            pnl_pelicula2.Controls.Add(label9);
            pnl_pelicula2.Controls.Add(label15);
            pnl_pelicula2.Location = new Point(23, 526);
            pnl_pelicula2.Margin = new Padding(5, 4, 5, 4);
            pnl_pelicula2.Name = "pnl_pelicula2";
            pnl_pelicula2.Size = new Size(381, 126);
            pnl_pelicula2.TabIndex = 25;
            pnl_pelicula2.Paint += Pelicula2_Paint;
            // 
            // chk_2
            // 
            chk_2.AutoSize = true;
            chk_2.Location = new Point(358, 4);
            chk_2.Margin = new Padding(5, 4, 5, 4);
            chk_2.Name = "chk_2";
            chk_2.Size = new Size(18, 17);
            chk_2.TabIndex = 26;
            chk_2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 21);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(155, 20);
            label9.TabIndex = 24;
            label9.Text = "IMAGEN de PORTADA";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(43, 103);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(158, 20);
            label15.TabIndex = 22;
            label15.Text = "PELICULA DE EJEMPLO";
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = Color.DarkOrange;
            btn_confirmar.FlatStyle = FlatStyle.Popup;
            btn_confirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_confirmar.Location = new Point(851, 529);
            btn_confirmar.Margin = new Padding(5, 4, 5, 4);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(246, 57);
            btn_confirmar.TabIndex = 2;
            btn_confirmar.Text = "Confirmar RENTA generar FACTURA";
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += OnRenta_Factura_Click;
            // 
            // pnl_pelicula1
            // 
            pnl_pelicula1.Controls.Add(chk_1);
            pnl_pelicula1.Controls.Add(label5);
            pnl_pelicula1.Controls.Add(label2);
            pnl_pelicula1.Location = new Point(23, 379);
            pnl_pelicula1.Margin = new Padding(5, 4, 5, 4);
            pnl_pelicula1.Name = "pnl_pelicula1";
            pnl_pelicula1.Size = new Size(381, 128);
            pnl_pelicula1.TabIndex = 23;
            pnl_pelicula1.Paint += Pelicula1_Paint;
            // 
            // chk_1
            // 
            chk_1.AutoSize = true;
            chk_1.Location = new Point(358, 4);
            chk_1.Margin = new Padding(5, 4, 5, 4);
            chk_1.Name = "chk_1";
            chk_1.Size = new Size(18, 17);
            chk_1.TabIndex = 25;
            chk_1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 21);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 24;
            label5.Text = "IMAGEN de PORTADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 103);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 22;
            label2.Text = "PELICULA DE EJEMPLO";
            // 
            // btn_devolucion
            // 
            btn_devolucion.BackColor = Color.DarkOrange;
            btn_devolucion.FlatStyle = FlatStyle.Popup;
            btn_devolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_devolucion.Location = new Point(876, 13);
            btn_devolucion.Margin = new Padding(5, 4, 5, 4);
            btn_devolucion.Name = "btn_devolucion";
            btn_devolucion.Size = new Size(246, 57);
            btn_devolucion.TabIndex = 45;
            btn_devolucion.Text = "Ir a Devolución";
            btn_devolucion.UseVisualStyleBackColor = false;
            btn_devolucion.Click += OnDevolucion_Click;
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
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // NuevaRenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 738);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "NuevaRenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rentas";
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_pelicula3.ResumeLayout(false);
            pnl_pelicula3.PerformLayout();
            pnl_pelicula4.ResumeLayout(false);
            pnl_pelicula4.PerformLayout();
            pnl_pelicula2.ResumeLayout(false);
            pnl_pelicula2.PerformLayout();
            pnl_pelicula1.ResumeLayout(false);
            pnl_pelicula1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_fechaRenta;
        private System.Windows.Forms.TextBox txt_membresia;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pnl_pelicula4;
        private System.Windows.Forms.CheckBox chk_3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnl_pelicula2;
        private System.Windows.Forms.CheckBox chk_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnl_pelicula1;
        private System.Windows.Forms.CheckBox chk_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox txt_fechaLimite;
        private Panel pnl_pelicula3;
        private CheckBox chk_4;
        private Label label1;
        private Label label3;
        private TextBox txt_totalapagar;
        private TextBox txt_subtotal;
        private PictureBox pictureBox2;
        private Button btn_devolucion;
    }
}