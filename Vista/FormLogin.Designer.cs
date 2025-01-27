namespace Vista
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkContraseña = new LinkLabel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            txtContraseña1 = new TextBox();
            lblError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(40, 40, 40);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.LightGray;
            btnIngresar.Location = new Point(326, 246);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(408, 40);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(318, 115);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(416, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(485, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            // 
            // linkContraseña
            // 
            linkContraseña.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkContraseña.AutoSize = true;
            linkContraseña.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkContraseña.LinkColor = Color.DimGray;
            linkContraseña.Location = new Point(429, 304);
            linkContraseña.Name = "linkContraseña";
            linkContraseña.Size = new Size(198, 17);
            linkContraseña.TabIndex = 0;
            linkContraseña.TabStop = true;
            linkContraseña.Text = "¿Ha olvidado la contraseña?";
            linkContraseña.LinkClicked += linkContraseña_LinkClicked;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(730, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(16, 16);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(752, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(16, 16);
            btnCerrar.TabIndex = 8;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtContraseña1
            // 
            txtContraseña1.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña1.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña1.ForeColor = Color.DimGray;
            txtContraseña1.Location = new Point(318, 164);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(416, 27);
            txtContraseña1.TabIndex = 2;
            txtContraseña1.Text = "CONTRASEÑA";
            txtContraseña1.Enter += txtContraseña1_Enter;
            txtContraseña1.Leave += txtContraseña1_Leave;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("MS Reference Sans Serif", 9F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(326, 194);
            lblError.Name = "lblError";
            lblError.Size = new Size(38, 16);
            lblError.TabIndex = 10;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lblError);
            Controls.Add(txtContraseña1);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(linkContraseña);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Panel panel1;
        private Label label1;
        private LinkLabel linkContraseña;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private TextBox txtContraseña1;
        private Label lblError;
    }
}