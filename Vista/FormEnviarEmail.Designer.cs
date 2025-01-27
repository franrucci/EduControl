namespace Vista
{
    partial class FormEnviarEmail
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
            gBoxEnviarEmail = new GroupBox();
            txtPara = new TextBox();
            btnEnviar = new Button();
            txtMensaje = new TextBox();
            txtAsunto = new TextBox();
            txtDe = new TextBox();
            lblMensaje = new Label();
            lblAsunto = new Label();
            lblPara = new Label();
            lblDe = new Label();
            btnVolver = new Button();
            gBoxEnviarEmail.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxEnviarEmail
            // 
            gBoxEnviarEmail.Controls.Add(txtPara);
            gBoxEnviarEmail.Controls.Add(btnEnviar);
            gBoxEnviarEmail.Controls.Add(txtMensaje);
            gBoxEnviarEmail.Controls.Add(txtAsunto);
            gBoxEnviarEmail.Controls.Add(txtDe);
            gBoxEnviarEmail.Controls.Add(lblMensaje);
            gBoxEnviarEmail.Controls.Add(lblAsunto);
            gBoxEnviarEmail.Controls.Add(lblPara);
            gBoxEnviarEmail.Controls.Add(lblDe);
            gBoxEnviarEmail.Location = new Point(12, 12);
            gBoxEnviarEmail.Name = "gBoxEnviarEmail";
            gBoxEnviarEmail.Size = new Size(729, 362);
            gBoxEnviarEmail.TabIndex = 0;
            gBoxEnviarEmail.TabStop = false;
            gBoxEnviarEmail.Text = "Nuevo E-mail";
            // 
            // txtPara
            // 
            txtPara.Location = new Point(62, 87);
            txtPara.Name = "txtPara";
            txtPara.ReadOnly = true;
            txtPara.Size = new Size(264, 23);
            txtPara.TabIndex = 9;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(331, 328);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(62, 201);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(650, 102);
            txtMensaje.TabIndex = 6;
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(62, 142);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(264, 23);
            txtAsunto.TabIndex = 5;
            // 
            // txtDe
            // 
            txtDe.Location = new Point(62, 36);
            txtDe.Name = "txtDe";
            txtDe.ReadOnly = true;
            txtDe.Size = new Size(264, 23);
            txtDe.TabIndex = 4;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(6, 204);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(54, 15);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Mensaje:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Location = new Point(12, 145);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(48, 15);
            lblAsunto.TabIndex = 2;
            lblAsunto.Text = "Asunto:";
            // 
            // lblPara
            // 
            lblPara.AutoSize = true;
            lblPara.Location = new Point(23, 90);
            lblPara.Name = "lblPara";
            lblPara.Size = new Size(33, 15);
            lblPara.TabIndex = 1;
            lblPara.Text = "Para:";
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Location = new Point(36, 36);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(24, 15);
            lblDe.TabIndex = 0;
            lblDe.Text = "De:";
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
            // FormEnviarEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxEnviarEmail);
            Name = "FormEnviarEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enviar Email";
            gBoxEnviarEmail.ResumeLayout(false);
            gBoxEnviarEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxEnviarEmail;
        private Label lblPara;
        private Label lblDe;
        private Button btnEnviar;
        private TextBox txtMensaje;
        private TextBox txtAsunto;
        private TextBox txtDe;
        private Label lblMensaje;
        private Label lblAsunto;
        private Button btnVolver;
        private TextBox txtPara;
    }
}