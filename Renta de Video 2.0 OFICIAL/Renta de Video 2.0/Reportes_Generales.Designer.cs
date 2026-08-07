namespace Renta_de_Video_2._0
{
    partial class Reportes_Generales
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
            dvg_Usuarios = new DataGridView();
            Id_Usuario = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contrasena = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dvg_Mora = new DataGridView();
            Id_Mora = new DataGridViewTextBoxColumn();
            Id_Devolucion = new DataGridViewTextBoxColumn();
            Dias_Atraso = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Estado_Pago = new DataGridViewTextBoxColumn();
            dvg_Rentas = new DataGridView();
            Id_Renta = new DataGridViewTextBoxColumn();
            Fecha_Renta = new DataGridViewTextBoxColumn();
            Fecha_Limite = new DataGridViewTextBoxColumn();
            Esttado = new DataGridViewTextBoxColumn();
            Id_Cliente = new DataGridViewTextBoxColumn();
            Id_Emplleado = new DataGridViewTextBoxColumn();
            dvg_Videos = new DataGridView();
            Id_Video = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Precio_Stock = new DataGridViewTextBoxColumn();
            Esstado = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Clasificacion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            dvg_Empleados = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Id_Empleado = new DataGridViewTextBoxColumn();
            Puesto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)dvg_Usuarios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg_Mora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Rentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Videos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Empleados).BeginInit();
            SuspendLayout();
            // 
            // dvg_Usuarios
            // 
            dvg_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Usuarios.Columns.AddRange(new DataGridViewColumn[] { Id_Usuario, Usuario, Contrasena, IdEmpleado, Rol, Estado });
            dvg_Usuarios.Location = new Point(13, 45);
            dvg_Usuarios.Name = "dvg_Usuarios";
            dvg_Usuarios.RowHeadersWidth = 51;
            dvg_Usuarios.Size = new Size(653, 150);
            dvg_Usuarios.TabIndex = 32;
            dvg_Usuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id_Usuario
            // 
            Id_Usuario.HeaderText = "Id_Usuario";
            Id_Usuario.Name = "Id_Usuario";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Contrasena
            // 
            Contrasena.HeaderText = "Contrasena";
            Contrasena.Name = "Contrasena";
            // 
            // IdEmpleado
            // 
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.Name = "IdEmpleado";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(99, 23, 9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dvg_Mora);
            panel1.Controls.Add(dvg_Rentas);
            panel1.Controls.Add(dvg_Videos);
            panel1.Controls.Add(dvg_Empleados);
            panel1.Controls.Add(dvg_Usuarios);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 687);
            panel1.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(99, 23, 9);
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox5.ForeColor = Color.FromArgb(253, 143, 84);
            textBox5.Location = new Point(674, 406);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 27);
            textBox5.TabIndex = 41;
            textBox5.Text = "Reporte de Moras:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(99, 23, 9);
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox4.ForeColor = Color.FromArgb(253, 143, 84);
            textBox4.Location = new Point(13, 406);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 40;
            textBox4.Text = "Reporte de Rentas:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(99, 23, 9);
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox3.ForeColor = Color.FromArgb(253, 143, 84);
            textBox3.Location = new Point(85, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 39;
            textBox3.Text = "Reporte de Videos:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(99, 23, 9);
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(253, 143, 84);
            textBox2.Location = new Point(684, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 38;
            textBox2.Text = "Reporte de Empleados:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(99, 23, 9);
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(253, 143, 84);
            textBox1.Location = new Point(13, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 37;
            textBox1.Text = "Reporte de Usuarios:";
            // 
            // dvg_Mora
            // 
            dvg_Mora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Mora.Columns.AddRange(new DataGridViewColumn[] { Id_Mora, Id_Devolucion, Dias_Atraso, Monto, Estado_Pago });
            dvg_Mora.Location = new Point(674, 435);
            dvg_Mora.Name = "dvg_Mora";
            dvg_Mora.Size = new Size(435, 150);
            dvg_Mora.TabIndex = 36;
            // 
            // Id_Mora
            // 
            Id_Mora.HeaderText = "Id_Mora";
            Id_Mora.Name = "Id_Mora";
            // 
            // Id_Devolucion
            // 
            Id_Devolucion.HeaderText = "Id_Devolucion";
            Id_Devolucion.Name = "Id_Devolucion";
            // 
            // Dias_Atraso
            // 
            Dias_Atraso.HeaderText = "Dias_Atraso";
            Dias_Atraso.Name = "Dias_Atraso";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Estado_Pago
            // 
            Estado_Pago.HeaderText = "Estado_Pago";
            Estado_Pago.Name = "Estado_Pago";
            // 
            // dvg_Rentas
            // 
            dvg_Rentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Rentas.Columns.AddRange(new DataGridViewColumn[] { Id_Renta, Fecha_Renta, Fecha_Limite, Esttado, Id_Cliente, Id_Emplleado });
            dvg_Rentas.Location = new Point(13, 435);
            dvg_Rentas.Name = "dvg_Rentas";
            dvg_Rentas.Size = new Size(643, 150);
            dvg_Rentas.TabIndex = 35;
            // 
            // Id_Renta
            // 
            Id_Renta.HeaderText = "Id_Renta";
            Id_Renta.Name = "Id_Renta";
            // 
            // Fecha_Renta
            // 
            Fecha_Renta.HeaderText = "Fecha_Renta";
            Fecha_Renta.Name = "Fecha_Renta";
            // 
            // Fecha_Limite
            // 
            Fecha_Limite.HeaderText = "Fecha_Limite";
            Fecha_Limite.Name = "Fecha_Limite";
            // 
            // Esttado
            // 
            Esttado.HeaderText = "Esttado";
            Esttado.Name = "Esttado";
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "Id_Cliente";
            Id_Cliente.Name = "Id_Cliente";
            // 
            // Id_Emplleado
            // 
            Id_Emplleado.HeaderText = "Id_Emplleado";
            Id_Emplleado.Name = "Id_Emplleado";
            // 
            // dvg_Videos
            // 
            dvg_Videos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Videos.Columns.AddRange(new DataGridViewColumn[] { Id_Video, Titulo, Genero, Precio_Stock, Esstado, Año, Clasificacion, Duracion, Idioma });
            dvg_Videos.Location = new Point(85, 241);
            dvg_Videos.Name = "dvg_Videos";
            dvg_Videos.Size = new Size(946, 150);
            dvg_Videos.TabIndex = 34;
            // 
            // Id_Video
            // 
            Id_Video.HeaderText = "Id_Video";
            Id_Video.Name = "Id_Video";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // Precio_Stock
            // 
            Precio_Stock.HeaderText = "Precio_Stock";
            Precio_Stock.Name = "Precio_Stock";
            // 
            // Esstado
            // 
            Esstado.HeaderText = "Esstado";
            Esstado.Name = "Esstado";
            // 
            // Año
            // 
            Año.HeaderText = "Año";
            Año.Name = "Año";
            // 
            // Clasificacion
            // 
            Clasificacion.HeaderText = "Clasificacion";
            Clasificacion.Name = "Clasificacion";
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            // 
            // dvg_Empleados
            // 
            dvg_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_Empleados.Columns.AddRange(new DataGridViewColumn[] { Nombre, Id_Empleado, Puesto, Telefono });
            dvg_Empleados.Location = new Point(684, 45);
            dvg_Empleados.Name = "dvg_Empleados";
            dvg_Empleados.Size = new Size(425, 150);
            dvg_Empleados.TabIndex = 33;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Id_Empleado
            // 
            Id_Empleado.HeaderText = "Id_Empleado";
            Id_Empleado.Name = "Id_Empleado";
            // 
            // Puesto
            // 
            Puesto.HeaderText = "Puesto";
            Puesto.Name = "Puesto";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Reportes_Generales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 687);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportes_Generales";
            Text = "Form1";
            Load += Reportes_Generales_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_Usuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvg_Mora).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Rentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Videos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_Empleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvg_Usuarios;
        private Panel panel1;
        private DataGridView dvg_Empleados;
        private DataGridViewTextBoxColumn Id_Usuario;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contrasena;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id_Empleado;
        private DataGridViewTextBoxColumn Puesto;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridView dvg_Videos;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private DataGridViewTextBoxColumn Id_Video;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Precio_Stock;
        private DataGridViewTextBoxColumn Esstado;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridView dvg_Rentas;
        private DataGridViewTextBoxColumn Id_Renta;
        private DataGridViewTextBoxColumn Fecha_Renta;
        private DataGridViewTextBoxColumn Fecha_Limite;
        private DataGridViewTextBoxColumn Esttado;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Id_Emplleado;
        private DataGridView dvg_Mora;
        private DataGridViewTextBoxColumn Id_Mora;
        private DataGridViewTextBoxColumn Id_Devolucion;
        private DataGridViewTextBoxColumn Dias_Atraso;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Estado_Pago;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}