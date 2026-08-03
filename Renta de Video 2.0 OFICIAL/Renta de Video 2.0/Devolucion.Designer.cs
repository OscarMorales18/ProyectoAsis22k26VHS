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
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            Listadevideos = new ListBox();
            button1 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 52);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Maroon;
            panel2.Location = new Point(-3, 611);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 29);
            panel2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Transparent;
            textBox1.Location = new Point(15, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(210, 22);
            label1.TabIndex = 12;
            label1.Text = "Codigo de Membresia";
            // 
            // Listadevideos
            // 
            Listadevideos.FormattingEnabled = true;
            Listadevideos.Location = new Point(15, 212);
            Listadevideos.Name = "Listadevideos";
            Listadevideos.Size = new Size(246, 199);
            Listadevideos.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(73, 150);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 451);
            label2.Name = "label2";
            label2.Size = new Size(207, 22);
            label2.TabIndex = 16;
            label2.Text = "Fecha de Devolucion ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 502);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(854, 212);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 18;
            label3.Text = "Cálculo de mora";
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(834, 487);
            button2.Name = "button2";
            button2.Size = new Size(192, 36);
            button2.TabIndex = 19;
            button2.Text = "Confirmar Devolucion";
            button2.UseVisualStyleBackColor = false;
            // 
            // Devolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1070, 652);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Listadevideos);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Devolucion";
            Text = "Devolucion";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Listadevideos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}