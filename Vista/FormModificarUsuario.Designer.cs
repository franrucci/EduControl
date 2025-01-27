namespace Vista
{
    partial class FormModificarUsuario
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
            gBoxModificarUsuario = new GroupBox();
            btnModificarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            btnVolver = new Button();
            gBoxModificarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gBoxModificarUsuario
            // 
            gBoxModificarUsuario.Controls.Add(btnModificarUsuario);
            gBoxModificarUsuario.Controls.Add(dgvUsuarios);
            gBoxModificarUsuario.Location = new Point(12, 12);
            gBoxModificarUsuario.Name = "gBoxModificarUsuario";
            gBoxModificarUsuario.Size = new Size(729, 337);
            gBoxModificarUsuario.TabIndex = 0;
            gBoxModificarUsuario.TabStop = false;
            gBoxModificarUsuario.Text = "Seleccione un usuario a modificar";
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(247, 287);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(232, 31);
            btnModificarUsuario.TabIndex = 5;
            btnModificarUsuario.Tag = "7";
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(6, 32);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(717, 239);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
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
            // FormModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxModificarUsuario);
            Name = "FormModificarUsuario";
            Text = "FormModificarUsuario";
            Load += FormModificarUsuario_Load;
            gBoxModificarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxModificarUsuario;
        private Button btnVolver;
        private DataGridView dgvUsuarios;
        private Button btnModificarUsuario;
    }
}