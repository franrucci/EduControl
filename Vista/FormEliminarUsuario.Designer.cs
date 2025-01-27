namespace Vista
{
    partial class FormEliminarUsuario
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
            gBoxEliminarUsuario = new GroupBox();
            btnEliminarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            btnVolver = new Button();
            gBoxEliminarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gBoxEliminarUsuario
            // 
            gBoxEliminarUsuario.Controls.Add(btnEliminarUsuario);
            gBoxEliminarUsuario.Controls.Add(dgvUsuarios);
            gBoxEliminarUsuario.Location = new Point(12, 12);
            gBoxEliminarUsuario.Name = "gBoxEliminarUsuario";
            gBoxEliminarUsuario.Size = new Size(729, 337);
            gBoxEliminarUsuario.TabIndex = 1;
            gBoxEliminarUsuario.TabStop = false;
            gBoxEliminarUsuario.Text = "Seleccione un usuario a eliminar";
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(247, 287);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(232, 31);
            btnEliminarUsuario.TabIndex = 5;
            btnEliminarUsuario.Tag = "7";
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
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
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormEliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxEliminarUsuario);
            Name = "FormEliminarUsuario";
            Text = "FormEliminarUsuario";
            gBoxEliminarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxEliminarUsuario;
        private Button btnEliminarUsuario;
        private DataGridView dgvUsuarios;
        private Button btnVolver;
    }
}