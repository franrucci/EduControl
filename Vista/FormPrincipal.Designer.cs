namespace Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btnAuditoria = new Button();
            btnMiUsuario = new Button();
            btnCerrarSesion = new Button();
            lblRol = new Label();
            lblUser = new Label();
            pictureBox2 = new PictureBox();
            btnUsuarios = new Button();
            btnAlumnos = new Button();
            btnCiclosAcademicos = new Button();
            panelBarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1019, 650);
            panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = SystemColors.Control;
            panelFormularios.Controls.Add(pictureBox1);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(250, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(769, 610);
            panelFormularios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(4, 41, 68);
            panelMenu.Controls.Add(btnAuditoria);
            panelMenu.Controls.Add(btnMiUsuario);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(lblRol);
            panelMenu.Controls.Add(lblUser);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnAlumnos);
            panelMenu.Controls.Add(btnCiclosAcademicos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 610);
            panelMenu.TabIndex = 1;
            // 
            // btnAuditoria
            // 
            btnAuditoria.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnAuditoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI", 9F);
            btnAuditoria.ForeColor = Color.Gainsboro;
            btnAuditoria.Image = (Image)resources.GetObject("btnAuditoria.Image");
            btnAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.Location = new Point(0, 407);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(250, 41);
            btnAuditoria.TabIndex = 8;
            btnAuditoria.Text = "    Auditoria";
            btnAuditoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditoria.UseVisualStyleBackColor = true;
            // 
            // btnMiUsuario
            // 
            btnMiUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnMiUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnMiUsuario.FlatStyle = FlatStyle.Flat;
            btnMiUsuario.Font = new Font("Segoe UI", 9F);
            btnMiUsuario.ForeColor = Color.Gainsboro;
            btnMiUsuario.Image = (Image)resources.GetObject("btnMiUsuario.Image");
            btnMiUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnMiUsuario.Location = new Point(0, 345);
            btnMiUsuario.Name = "btnMiUsuario";
            btnMiUsuario.Size = new Size(250, 41);
            btnMiUsuario.TabIndex = 7;
            btnMiUsuario.Text = "    Mi Usuario";
            btnMiUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMiUsuario.UseVisualStyleBackColor = true;
            btnMiUsuario.Click += btnMiUsuario_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 557);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 41);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.Transparent;
            lblRol.Location = new Point(79, 58);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(32, 17);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.Transparent;
            lblUser.Location = new Point(78, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(63, 17);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuario: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9F);
            btnUsuarios.ForeColor = Color.Gainsboro;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 283);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(250, 41);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Administrar Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnAlumnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnAlumnos.FlatStyle = FlatStyle.Flat;
            btnAlumnos.Font = new Font("Segoe UI", 9F);
            btnAlumnos.ForeColor = Color.Gainsboro;
            btnAlumnos.Image = (Image)resources.GetObject("btnAlumnos.Image");
            btnAlumnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlumnos.Location = new Point(0, 224);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(250, 41);
            btnAlumnos.TabIndex = 1;
            btnAlumnos.Text = "     Alumnos";
            btnAlumnos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnCiclosAcademicos
            // 
            btnCiclosAcademicos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnCiclosAcademicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnCiclosAcademicos.FlatStyle = FlatStyle.Flat;
            btnCiclosAcademicos.Font = new Font("Segoe UI", 9F);
            btnCiclosAcademicos.ForeColor = Color.Gainsboro;
            btnCiclosAcademicos.Image = (Image)resources.GetObject("btnCiclosAcademicos.Image");
            btnCiclosAcademicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCiclosAcademicos.Location = new Point(0, 162);
            btnCiclosAcademicos.Name = "btnCiclosAcademicos";
            btnCiclosAcademicos.Size = new Size(250, 41);
            btnCiclosAcademicos.TabIndex = 0;
            btnCiclosAcademicos.Text = "Ciclos Academicos";
            btnCiclosAcademicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCiclosAcademicos.UseVisualStyleBackColor = true;
            btnCiclosAcademicos.Click += btnCiclosAcademicos_Click_1;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(13, 93, 142);
            panelBarraTitulo.Controls.Add(btnMinimizar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1019, 40);
            panelBarraTitulo.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(969, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(16, 16);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(991, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(16, 16);
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 650);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 400);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += FormPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelBarraTitulo;
        private Panel panelFormularios;
        private Panel panelMenu;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Button btnCiclosAcademicos;
        private PictureBox pictureBox1;
        private Button btnAlumnos;
        private Button btnUsuarios;
        private PictureBox pictureBox2;
        private Label lblUser;
        private Label lblRol;
        private Button btnCerrarSesion;
        private Button btnMiUsuario;
        private Button btnAuditoria;
    }
}
