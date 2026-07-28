namespace Renta_de_Video_2._0
{
    partial class Mora_Pendiente_PC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Renta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Días_De_Atraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mora_Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-2, 645);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 31);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 56);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(376, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Codigo_Membresia,
            this.Codigo_Renta,
            this.Días_De_Atraso,
            this.Mora_Pendiente});
            this.dataGridView1.Location = new System.Drawing.Point(17, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // Codigo_Membresia
            // 
            this.Codigo_Membresia.HeaderText = "Codigo_Membresia";
            this.Codigo_Membresia.MinimumWidth = 6;
            this.Codigo_Membresia.Name = "Codigo_Membresia";
            this.Codigo_Membresia.Width = 125;
            // 
            // Codigo_Renta
            // 
            this.Codigo_Renta.HeaderText = "Codigo_Renta";
            this.Codigo_Renta.MinimumWidth = 6;
            this.Codigo_Renta.Name = "Codigo_Renta";
            this.Codigo_Renta.Width = 125;
            // 
            // Días_De_Atraso
            // 
            this.Días_De_Atraso.HeaderText = "Días_De_Atraso";
            this.Días_De_Atraso.MinimumWidth = 6;
            this.Días_De_Atraso.Name = "Días_De_Atraso";
            this.Días_De_Atraso.Width = 125;
            // 
            // Mora_Pendiente
            // 
            this.Mora_Pendiente.HeaderText = "Mora_Pendiente";
            this.Mora_Pendiente.MinimumWidth = 6;
            this.Mora_Pendiente.Name = "Mora_Pendiente";
            this.Mora_Pendiente.Width = 125;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(827, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Mora";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(896, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Marcar Pago";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Mora_Pendiente_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mora_Pendiente_PC";
            this.Text = "Mora_Pendiente_PC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Días_De_Atraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mora_Pendiente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}