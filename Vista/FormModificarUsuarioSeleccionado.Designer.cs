namespace Vista
{
    partial class FormModificarUsuarioSeleccionado
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
            gBoxUsuarioSeleccionado = new GroupBox();
            lblAclaracion = new Label();
            btnAceptar = new Button();
            cmbRol = new ComboBox();
            lblRol = new Label();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            btnVolver = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            gBoxUsuarioSeleccionado.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxUsuarioSeleccionado
            // 
            gBoxUsuarioSeleccionado.Controls.Add(txtEmail);
            gBoxUsuarioSeleccionado.Controls.Add(lblEmail);
            gBoxUsuarioSeleccionado.Controls.Add(lblAclaracion);
            gBoxUsuarioSeleccionado.Controls.Add(btnAceptar);
            gBoxUsuarioSeleccionado.Controls.Add(cmbRol);
            gBoxUsuarioSeleccionado.Controls.Add(lblRol);
            gBoxUsuarioSeleccionado.Controls.Add(txtContraseña);
            gBoxUsuarioSeleccionado.Controls.Add(lblContraseña);
            gBoxUsuarioSeleccionado.Controls.Add(txtNombreUsuario);
            gBoxUsuarioSeleccionado.Controls.Add(lblNombreUsuario);
            gBoxUsuarioSeleccionado.Location = new Point(12, 12);
            gBoxUsuarioSeleccionado.Name = "gBoxUsuarioSeleccionado";
            gBoxUsuarioSeleccionado.Size = new Size(729, 275);
            gBoxUsuarioSeleccionado.TabIndex = 0;
            gBoxUsuarioSeleccionado.TabStop = false;
            gBoxUsuarioSeleccionado.Text = "Datos a modificar";
            // 
            // lblAclaracion
            // 
            lblAclaracion.AutoSize = true;
            lblAclaracion.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAclaracion.Location = new Point(59, 180);
            lblAclaracion.Name = "lblAclaracion";
            lblAclaracion.Size = new Size(353, 13);
            lblAclaracion.TabIndex = 28;
            lblAclaracion.Text = "Aclaración: Si desea mantener la contraseña actual, deje vacio este campo.";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(518, 123);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(163, 28);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(135, 222);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(179, 23);
            cmbRol.TabIndex = 26;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(102, 225);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 25;
            lblRol.Text = "Rol:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(135, 154);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(179, 23);
            txtContraseña.TabIndex = 24;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(59, 157);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 23;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(135, 43);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(179, 23);
            txtNombreUsuario.TabIndex = 22;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(16, 46);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(113, 15);
            lblNombreUsuario.TabIndex = 21;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(85, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "E-mail:";
            // 
            // FormModificarUsuarioSeleccionado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxUsuarioSeleccionado);
            Name = "FormModificarUsuarioSeleccionado";
            Text = "FormModificarUsuarioSeleccionado";
            gBoxUsuarioSeleccionado.ResumeLayout(false);
            gBoxUsuarioSeleccionado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxUsuarioSeleccionado;
        private Button btnAceptar;
        private ComboBox cmbRol;
        private Label lblRol;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Button btnVolver;
        private Label lblAclaracion;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}