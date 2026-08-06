namespace Renta_de_Video_2._0
{
    partial class Auditoria
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auditoria));
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtBuscar = new TextBox();
            btnRefrescar = new Button();
            dgvAuditoria = new DataGridView();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(250, 168, 25);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(317, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "AUDITORÍA DEL SISTEMA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(224, 224, 224);
            lblSubtitulo.Location = new Point(34, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(375, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Historial de modificaciones, operaciones e ingresos al sistema.";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Location = new Point(685, 60);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(220, 27);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.FromArgb(250, 168, 25);
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.Black;
            btnRefrescar.Location = new Point(938, 60);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(100, 32);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.AllowUserToAddRows = false;
            dgvAuditoria.AllowUserToDeleteRows = false;
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditoria.BackgroundColor = Color.FromArgb(45, 8, 5);
            dgvAuditoria.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 168, 25);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAuditoria.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAuditoria.EnableHeadersVisualStyles = false;
            dgvAuditoria.Location = new Point(37, 110);
            dgvAuditoria.MultiSelect = false;
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.RowHeadersVisible = false;
            dgvAuditoria.RowHeadersWidth = 51;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.Size = new Size(1013, 564);
            dgvAuditoria.TabIndex = 4;
            dgvAuditoria.CellContentClick += dgvAuditoria_CellContentClick;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(250, 168, 25);
            lblBuscar.Location = new Point(685, 25);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(124, 15);
            lblBuscar.TabIndex = 5;
            lblBuscar.Text = "FILTRAR REGISTROS:";
            // 
            // Auditoria
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(59, 11, 7);
            ClientSize = new Size(1147, 711);
            Controls.Add(lblBuscar);
            Controls.Add(dgvAuditoria);
            Controls.Add(btnRefrescar);
            Controls.Add(txtBuscar);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Auditoria";
            Text = "Auditoria";
            Load += Auditoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Label lblBuscar;
    }
}