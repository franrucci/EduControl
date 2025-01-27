namespace Vista
{
    partial class FormMiUsuario
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
            gBoxMisDatos = new GroupBox();
            txtRol = new TextBox();
            txtNombreUsuario = new TextBox();
            lblRol = new Label();
            lblNombreUsuario = new Label();
            btnCambiarContraseña = new Button();
            btnVolver = new Button();
            gBoxMisDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxMisDatos
            // 
            gBoxMisDatos.Controls.Add(txtRol);
            gBoxMisDatos.Controls.Add(txtNombreUsuario);
            gBoxMisDatos.Controls.Add(lblRol);
            gBoxMisDatos.Controls.Add(lblNombreUsuario);
            gBoxMisDatos.Location = new Point(12, 12);
            gBoxMisDatos.Name = "gBoxMisDatos";
            gBoxMisDatos.Size = new Size(729, 144);
            gBoxMisDatos.TabIndex = 0;
            gBoxMisDatos.TabStop = false;
            gBoxMisDatos.Text = "Mis datos";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(142, 86);
            txtRol.Name = "txtRol";
            txtRol.ReadOnly = true;
            txtRol.Size = new Size(278, 23);
            txtRol.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(142, 38);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(278, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(109, 89);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(24, 41);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(112, 15);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Location = new Point(36, 182);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(212, 39);
            btnCambiarContraseña.TabIndex = 3;
            btnCambiarContraseña.Tag = "24";
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormMiUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(gBoxMisDatos);
            Name = "FormMiUsuario";
            Text = "FormMiUsuario";
            Load += FormMiUsuario_Load_1;
            gBoxMisDatos.ResumeLayout(false);
            gBoxMisDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxMisDatos;
        private Label lblRol;
        private Label lblNombreUsuario;
        private TextBox txtRol;
        private TextBox txtNombreUsuario;
        private Button btnCambiarContraseña;
        private Button btnVolver;
    }
}