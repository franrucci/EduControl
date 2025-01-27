namespace Vista
{
    partial class FormCambiarContraseña
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
            gBoxCambiarContraseña = new GroupBox();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            btnAceptar = new Button();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            btnVolver = new Button();
            gBoxCambiarContraseña.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxCambiarContraseña
            // 
            gBoxCambiarContraseña.Controls.Add(txtNombreUsuario);
            gBoxCambiarContraseña.Controls.Add(lblNombreUsuario);
            gBoxCambiarContraseña.Controls.Add(btnAceptar);
            gBoxCambiarContraseña.Controls.Add(txtContraseña);
            gBoxCambiarContraseña.Controls.Add(lblContraseña);
            gBoxCambiarContraseña.Location = new Point(12, 12);
            gBoxCambiarContraseña.Name = "gBoxCambiarContraseña";
            gBoxCambiarContraseña.Size = new Size(729, 177);
            gBoxCambiarContraseña.TabIndex = 0;
            gBoxCambiarContraseña.TabStop = false;
            gBoxCambiarContraseña.Text = "Nueva Contraseña";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(145, 50);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(179, 23);
            txtNombreUsuario.TabIndex = 33;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(26, 53);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(113, 15);
            lblNombreUsuario.TabIndex = 32;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(477, 77);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(163, 28);
            btnAceptar.TabIndex = 31;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(145, 100);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(179, 23);
            txtContraseña.TabIndex = 30;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(69, 103);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 29;
            lblContraseña.Text = "Contraseña:";
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
            // FormCambiarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxCambiarContraseña);
            Name = "FormCambiarContraseña";
            Text = "FormCambiarContraseña";
            Load += FormCambiarContraseña_Load;
            gBoxCambiarContraseña.ResumeLayout(false);
            gBoxCambiarContraseña.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxCambiarContraseña;
        private Button btnAceptar;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Button btnVolver;
    }
}