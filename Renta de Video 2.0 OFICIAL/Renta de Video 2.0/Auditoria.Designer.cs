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
            lbl_titulo = new Label();
            lblSubtitulo = new Label();
            txt_buscar = new TextBox();
            btn_refrescar = new Button();
            dgv_auditoria = new DataGridView();
            lbl_buscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_auditoria).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = Color.FromArgb(250, 168, 25);
            lbl_titulo.Location = new Point(30, 25);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(396, 48);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "AUDITORÍA DEL SISTEMA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(224, 224, 224);
            lblSubtitulo.Location = new Point(34, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(481, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Historial de modificaciones, operaciones e ingresos al sistema.";
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Segoe UI", 11F);
            txt_buscar.Location = new Point(685, 60);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(220, 32);
            txt_buscar.TabIndex = 2;
            txt_buscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btn_refrescar
            // 
            btn_refrescar.BackColor = Color.FromArgb(250, 168, 25);
            btn_refrescar.FlatStyle = FlatStyle.Flat;
            btn_refrescar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_refrescar.ForeColor = Color.Black;
            btn_refrescar.Location = new Point(938, 60);
            btn_refrescar.Name = "btn_refrescar";
            btn_refrescar.Size = new Size(100, 32);
            btn_refrescar.TabIndex = 3;
            btn_refrescar.Text = "Refrescar";
            btn_refrescar.UseVisualStyleBackColor = false;
            btn_refrescar.Click += OnRefrescar_Click;
            // 
            // dgv_auditoria
            // 
            dgv_auditoria.AllowUserToAddRows = false;
            dgv_auditoria.AllowUserToDeleteRows = false;
            dgv_auditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_auditoria.BackgroundColor = Color.FromArgb(45, 8, 5);
            dgv_auditoria.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 168, 25);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_auditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_auditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_auditoria.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_auditoria.EnableHeadersVisualStyles = false;
            dgv_auditoria.Location = new Point(37, 110);
            dgv_auditoria.MultiSelect = false;
            dgv_auditoria.Name = "dgv_auditoria";
            dgv_auditoria.ReadOnly = true;
            dgv_auditoria.RowHeadersVisible = false;
            dgv_auditoria.RowHeadersWidth = 51;
            dgv_auditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_auditoria.Size = new Size(1013, 564);
            dgv_auditoria.TabIndex = 4;
            dgv_auditoria.CellContentClick += dgvAuditoria_CellContentClick;
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_buscar.ForeColor = Color.FromArgb(250, 168, 25);
            lbl_buscar.Location = new Point(685, 25);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(157, 20);
            lbl_buscar.TabIndex = 5;
            lbl_buscar.Text = "FILTRAR REGISTROS:";
            // 
            // Auditoria
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(59, 11, 7);
            ClientSize = new Size(1147, 711);
            Controls.Add(lbl_buscar);
            Controls.Add(dgv_auditoria);
            Controls.Add(btn_refrescar);
            Controls.Add(txt_buscar);
            Controls.Add(lblSubtitulo);
            Controls.Add(lbl_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Auditoria";
            Text = "Auditoria";
            Load += Auditoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_auditoria).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridView dgv_auditoria;
        private System.Windows.Forms.Label lbl_buscar;
    }
}