namespace Vista
{
    partial class FormRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperarContraseña));
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            btnEnviar = new Button();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(212, 57);
            label1.Name = "label1";
            label1.Size = new Size(349, 33);
            label1.TabIndex = 9;
            label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(176, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(416, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "E-mail";
            txtEmail.Enter += txtUsuario_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(176, 162);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 10;
            label2.Text = "Ingrese su E-mail";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(40, 40, 40);
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.LightGray;
            btnEnviar.Location = new Point(235, 202);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(316, 40);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Enviar E-mail";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(714, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(16, 16);
            btnMinimizar.TabIndex = 13;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(736, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(16, 16);
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormRecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(764, 291);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEnviar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRecuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRecuperarContraseña";
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Button btnEnviar;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
    }
}