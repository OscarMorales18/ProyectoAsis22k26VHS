namespace Renta_de_Video_2._0
{
    partial class InventarioRegistro
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button6 = new Button();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            panelContenedor = new Panel();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            textBox4 = new TextBox();
            label14 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button8 = new Button();
            label13 = new Label();
            listBox1 = new ListBox();
            label12 = new Label();
            button2 = new Button();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 205);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 9;
            label7.Text = "TITULO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 8;
            label6.Text = "CODIGO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 468);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 7;
            label5.Text = "DISPONIBILIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 6;
            label4.Text = "DETALLES DE PELICULA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "IDENTIFICACION";
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(612, 525);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(241, 45);
            button6.TabIndex = 2;
            button6.Text = "GUARDAR";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Bright", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 14);
            label1.TabIndex = 0;
            label1.Text = "NUEVO VIDEO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(709, 412);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 11;
            label9.Text = "AÑO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 401);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 10;
            label8.Text = "GENERO";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(button2);
            panelContenedor.Controls.Add(numericUpDown2);
            panelContenedor.Controls.Add(numericUpDown1);
            panelContenedor.Controls.Add(textBox4);
            panelContenedor.Controls.Add(label14);
            panelContenedor.Controls.Add(textBox3);
            panelContenedor.Controls.Add(textBox2);
            panelContenedor.Controls.Add(textBox1);
            panelContenedor.Controls.Add(button8);
            panelContenedor.Controls.Add(label13);
            panelContenedor.Controls.Add(listBox1);
            panelContenedor.Controls.Add(label12);
            panelContenedor.Controls.Add(label9);
            panelContenedor.Controls.Add(label8);
            panelContenedor.Controls.Add(label7);
            panelContenedor.Controls.Add(label6);
            panelContenedor.Controls.Add(label5);
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(label3);
            panelContenedor.Controls.Add(button6);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(4, 4, 4, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1053, 562);
            panelContenedor.TabIndex = 8;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(27, 538);
            numericUpDown2.Margin = new Padding(4, 4, 4, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(155, 23);
            numericUpDown2.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(766, 412);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(155, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(488, 406);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(116, 23);
            textBox4.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(367, 406);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 21;
            label14.Text = "DIRECTOR";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 401);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(488, 202);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 200);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 18;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(342, 525);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(241, 45);
            button8.TabIndex = 17;
            button8.Text = "CANCELAR";
            button8.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(720, 36);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 16;
            label13.Text = "VISTA PREVIA ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(720, 65);
            listBox1.Margin = new Padding(4, 4, 4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 184);
            listBox1.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(25, 100);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(345, 15);
            label12.TabIndex = 14;
            label12.Text = "Completa los datos para agregar una cinta al catalogo";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(978, 12);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(35, 27);
            button2.TabIndex = 25;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // InventarioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 562);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "InventarioRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventarioRegistro";
            Load += InventarioRegistro_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Button button2;
    }
}