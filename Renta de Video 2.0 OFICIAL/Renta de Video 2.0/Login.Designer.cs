namespace Renta_de_Video_2._0
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pic_logo = new PictureBox();
            lbl_titulo = new Label();
            lbl_bienvenida = new Label();
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            lbl_password = new Label();
            button1 = new Button();
            pic_mascota = new PictureBox();
            pic_imagen1 = new PictureBox();
            pic_imagen2 = new PictureBox();
            btn_salir = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pic_logo
            // 
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(368, 18);
            pic_logo.Margin = new Padding(5, 4, 5, 4);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(591, 300);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 0;
            pic_logo.TabStop = false;
            pic_logo.Click += pictureBox1_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Rockwell Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = Color.FromArgb(246, 170, 28);
            lbl_titulo.Location = new Point(552, 226);
            lbl_titulo.Margin = new Padding(5, 0, 5, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(193, 55);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "POPFLIX";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_titulo.Click += label1_Click;
            // 
            // lbl_bienvenida
            // 
            lbl_bienvenida.AutoSize = true;
            lbl_bienvenida.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_bienvenida.ForeColor = Color.White;
            lbl_bienvenida.Location = new Point(409, 328);
            lbl_bienvenida.Margin = new Padding(5, 0, 5, 0);
            lbl_bienvenida.Name = "lbl_bienvenida";
            lbl_bienvenida.Size = new Size(499, 23);
            lbl_bienvenida.TabIndex = 2;
            lbl_bienvenida.Text = "Bienvenido de nuevo. Inicia sesión para continuar";
            lbl_bienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Rockwell Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.FromArgb(188, 57, 8);
            lbl_usuario.Location = new Point(362, 416);
            lbl_usuario.Margin = new Padding(5, 0, 5, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(86, 29);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuario";
            lbl_usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.Location = new Point(454, 460);
            txt_usuario.Margin = new Padding(5, 4, 5, 4);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(478, 52);
            txt_usuario.TabIndex = 4;
            txt_usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(455, 572);
            txt_password.Margin = new Padding(5, 4, 5, 4);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(478, 52);
            txt_password.TabIndex = 5;
            txt_password.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Rockwell Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = Color.FromArgb(188, 57, 8);
            lbl_password.Location = new Point(362, 530);
            lbl_password.Margin = new Padding(5, 0, 5, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(120, 29);
            lbl_password.TabIndex = 6;
            lbl_password.Text = "Contraseña";
            lbl_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Rockwell Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(478, 686);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(398, 110);
            button1.TabIndex = 7;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += OnSesion_Click;
            // 
            // pic_mascota
            // 
            pic_mascota.Image = (Image)resources.GetObject("pic_mascota.Image");
            pic_mascota.Location = new Point(16, 572);
            pic_mascota.Margin = new Padding(5, 4, 5, 4);
            pic_mascota.Name = "pic_mascota";
            pic_mascota.Size = new Size(210, 302);
            pic_mascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_mascota.TabIndex = 8;
            pic_mascota.TabStop = false;
            // 
            // pic_imagen1
            // 
            pic_imagen1.BackColor = Color.Transparent;
            pic_imagen1.Image = (Image)resources.GetObject("pic_imagen1.Image");
            pic_imagen1.Location = new Point(410, 454);
            pic_imagen1.Margin = new Padding(5, 4, 5, 4);
            pic_imagen1.Name = "pic_imagen1";
            pic_imagen1.Size = new Size(35, 44);
            pic_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imagen1.TabIndex = 9;
            pic_imagen1.TabStop = false;
            // 
            // pic_imagen2
            // 
            pic_imagen2.Image = (Image)resources.GetObject("pic_imagen2.Image");
            pic_imagen2.Location = new Point(410, 570);
            pic_imagen2.Margin = new Padding(5, 4, 5, 4);
            pic_imagen2.Name = "pic_imagen2";
            pic_imagen2.Size = new Size(35, 42);
            pic_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imagen2.TabIndex = 10;
            pic_imagen2.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.White;
            btn_salir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.Location = new Point(1310, 18);
            btn_salir.Margin = new Padding(5, 4, 5, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(40, 36);
            btn_salir.TabIndex = 11;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += OnSalir_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(903, 578);
            pictureBox5.Margin = new Padding(5, 4, 5, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 23, 8);
            ClientSize = new Size(1366, 788);
            Controls.Add(pictureBox5);
            Controls.Add(btn_salir);
            Controls.Add(pic_imagen2);
            Controls.Add(pic_imagen1);
            Controls.Add(button1);
            Controls.Add(lbl_password);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(lbl_bienvenida);
            Controls.Add(lbl_titulo);
            Controls.Add(pic_logo);
            Controls.Add(pic_mascota);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_mascota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_imagen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_mascota;
        private System.Windows.Forms.PictureBox pic_imagen1;
        private System.Windows.Forms.PictureBox pic_imagen2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

