namespace Vista
{
    partial class FormCiclosAcademicos
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
            gBoxCiclosAcademicos = new GroupBox();
            btnSeleccionar = new Button();
            dgvCiclosAcademicos = new DataGridView();
            btnAgregarNuevoCiclo = new Button();
            btnVolver = new Button();
            gBoxCiclosAcademicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiclosAcademicos).BeginInit();
            SuspendLayout();
            // 
            // gBoxCiclosAcademicos
            // 
            gBoxCiclosAcademicos.Controls.Add(btnSeleccionar);
            gBoxCiclosAcademicos.Controls.Add(dgvCiclosAcademicos);
            gBoxCiclosAcademicos.Location = new Point(12, 12);
            gBoxCiclosAcademicos.Name = "gBoxCiclosAcademicos";
            gBoxCiclosAcademicos.Size = new Size(609, 272);
            gBoxCiclosAcademicos.TabIndex = 0;
            gBoxCiclosAcademicos.TabStop = false;
            gBoxCiclosAcademicos.Text = "Ciclo Académico";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(253, 237);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(97, 23);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // dgvCiclosAcademicos
            // 
            dgvCiclosAcademicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCiclosAcademicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiclosAcademicos.Location = new Point(6, 22);
            dgvCiclosAcademicos.Name = "dgvCiclosAcademicos";
            dgvCiclosAcademicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiclosAcademicos.Size = new Size(597, 204);
            dgvCiclosAcademicos.TabIndex = 0;
            dgvCiclosAcademicos.SelectionChanged += dgvCiclosAcademicos_SelectionChanged;
            // 
            // btnAgregarNuevoCiclo
            // 
            btnAgregarNuevoCiclo.Location = new Point(629, 34);
            btnAgregarNuevoCiclo.Name = "btnAgregarNuevoCiclo";
            btnAgregarNuevoCiclo.Size = new Size(114, 46);
            btnAgregarNuevoCiclo.TabIndex = 1;
            btnAgregarNuevoCiclo.Tag = "1";
            btnAgregarNuevoCiclo.Text = "Agregar nuevo ciclo academico";
            btnAgregarNuevoCiclo.UseVisualStyleBackColor = true;
            btnAgregarNuevoCiclo.Click += btnAgregarNuevoCiclo_Click;
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
            // FormCiclosAcademicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarNuevoCiclo);
            Controls.Add(gBoxCiclosAcademicos);
            Name = "FormCiclosAcademicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciclos academicos";
            FormClosed += FormCiclosAcademicos_FormClosed;
            Load += FormCiclosAcademicos_Load;
            gBoxCiclosAcademicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCiclosAcademicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxCiclosAcademicos;
        private Button btnSeleccionar;
        private DataGridView dgvCiclosAcademicos;
        private Button btnAgregarNuevoCiclo;
        private Button btnVolver;
    }
}