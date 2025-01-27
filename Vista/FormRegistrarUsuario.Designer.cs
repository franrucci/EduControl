namespace Vista
{
    partial class FormRegistrarUsuario
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
            gBoxRegistrarUsuario = new GroupBox();
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
            gBoxRegistrarUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegistrarUsuario
            // 
            gBoxRegistrarUsuario.Controls.Add(txtEmail);
            gBoxRegistrarUsuario.Controls.Add(lblEmail);
            gBoxRegistrarUsuario.Controls.Add(btnAceptar);
            gBoxRegistrarUsuario.Controls.Add(cmbRol);
            gBoxRegistrarUsuario.Controls.Add(lblRol);
            gBoxRegistrarUsuario.Controls.Add(txtContraseña);
            gBoxRegistrarUsuario.Controls.Add(lblContraseña);
            gBoxRegistrarUsuario.Controls.Add(txtNombreUsuario);
            gBoxRegistrarUsuario.Controls.Add(lblNombreUsuario);
            gBoxRegistrarUsuario.Location = new Point(12, 12);
            gBoxRegistrarUsuario.Name = "gBoxRegistrarUsuario";
            gBoxRegistrarUsuario.Size = new Size(729, 276);
            gBoxRegistrarUsuario.TabIndex = 0;
            gBoxRegistrarUsuario.TabStop = false;
            gBoxRegistrarUsuario.Text = "Nuevo Usuario";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(515, 100);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(163, 28);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(153, 214);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(179, 23);
            cmbRol.TabIndex = 19;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(120, 217);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 18;
            lblRol.Text = "Rol:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(153, 104);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(179, 23);
            txtContraseña.TabIndex = 17;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(77, 107);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 16;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(153, 44);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(179, 23);
            txtNombreUsuario.TabIndex = 15;
            txtNombreUsuario.KeyPress += txtNombreUsuario_KeyPress;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(34, 47);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(113, 15);
            lblNombreUsuario.TabIndex = 14;
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
            txtEmail.Location = new Point(153, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(106, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "E-mail";
            // 
            // FormRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxRegistrarUsuario);
            Name = "FormRegistrarUsuario";
            Text = "FormRegistrarUsuario";
            Load += FormRegistrarUsuario_Load;
            gBoxRegistrarUsuario.ResumeLayout(false);
            gBoxRegistrarUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxRegistrarUsuario;
        private Button btnAceptar;
        private ComboBox cmbRol;
        private Label lblRol;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Button btnVolver;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}