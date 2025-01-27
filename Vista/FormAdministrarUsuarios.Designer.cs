namespace Vista
{
    partial class FormAdministrarUsuarios
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
            gBoxBotones = new GroupBox();
            btnEliminarRol = new Button();
            btnModificarUsuario = new Button();
            btnRegistroDeRolUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnAgregarUsuario = new Button();
            btnVolver = new Button();
            btnModificarRol = new Button();
            gBoxBotones.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxBotones
            // 
            gBoxBotones.Controls.Add(btnModificarRol);
            gBoxBotones.Controls.Add(btnEliminarRol);
            gBoxBotones.Controls.Add(btnModificarUsuario);
            gBoxBotones.Controls.Add(btnRegistroDeRolUsuario);
            gBoxBotones.Controls.Add(btnEliminarUsuario);
            gBoxBotones.Controls.Add(btnAgregarUsuario);
            gBoxBotones.Location = new Point(12, 12);
            gBoxBotones.Name = "gBoxBotones";
            gBoxBotones.Size = new Size(729, 338);
            gBoxBotones.TabIndex = 0;
            gBoxBotones.TabStop = false;
            gBoxBotones.Text = "Todos los Usuarios";
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.Location = new Point(72, 234);
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(212, 39);
            btnEliminarRol.TabIndex = 4;
            btnEliminarRol.Tag = "25";
            btnEliminarRol.Text = "Eliminar Rol";
            btnEliminarRol.UseVisualStyleBackColor = true;
            btnEliminarRol.Click += btnEliminarRol_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(419, 143);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(212, 39);
            btnModificarUsuario.TabIndex = 3;
            btnModificarUsuario.Tag = "26";
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnRegistroDeRolUsuario
            // 
            btnRegistroDeRolUsuario.Location = new Point(72, 52);
            btnRegistroDeRolUsuario.Name = "btnRegistroDeRolUsuario";
            btnRegistroDeRolUsuario.Size = new Size(212, 39);
            btnRegistroDeRolUsuario.TabIndex = 2;
            btnRegistroDeRolUsuario.Tag = "24";
            btnRegistroDeRolUsuario.Text = "Registrar Nuevo Rol";
            btnRegistroDeRolUsuario.UseVisualStyleBackColor = true;
            btnRegistroDeRolUsuario.Click += btnRegistroDeRolUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(419, 234);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(212, 39);
            btnEliminarUsuario.TabIndex = 1;
            btnEliminarUsuario.Tag = "23";
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(419, 52);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(212, 39);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Tag = "22";
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
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
            // btnModificarRol
            // 
            btnModificarRol.Location = new Point(72, 143);
            btnModificarRol.Name = "btnModificarRol";
            btnModificarRol.Size = new Size(212, 39);
            btnModificarRol.TabIndex = 5;
            btnModificarRol.Tag = "27";
            btnModificarRol.Text = "Modificar Rol";
            btnModificarRol.UseVisualStyleBackColor = true;
            btnModificarRol.Click += btnModificarRol_Click;
            // 
            // FormAdministrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxBotones);
            Name = "FormAdministrarUsuarios";
            Text = "FormAdministrarUsuarios";
            Load += FormAdministrarUsuarios_Load;
            gBoxBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxBotones;
        private Button btnVolver;
        private Button btnEliminarUsuario;
        private Button btnAgregarUsuario;
        private Button btnRegistroDeRolUsuario;
        private Button btnModificarUsuario;
        private Button btnEliminarRol;
        private Button btnModificarRol;
    }
}