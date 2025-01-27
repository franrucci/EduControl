namespace Vista
{
    partial class FormRegistrarAlumnoExistente
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
            gBoxAlumnos = new GroupBox();
            lblGradoAcademico = new Label();
            cmbGradoAcademico = new ComboBox();
            btnRegistrarAlumno = new Button();
            dgvAlumnos = new DataGridView();
            btnVolver = new Button();
            gBoxAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // gBoxAlumnos
            // 
            gBoxAlumnos.Controls.Add(lblGradoAcademico);
            gBoxAlumnos.Controls.Add(cmbGradoAcademico);
            gBoxAlumnos.Controls.Add(btnRegistrarAlumno);
            gBoxAlumnos.Controls.Add(dgvAlumnos);
            gBoxAlumnos.Location = new Point(12, 12);
            gBoxAlumnos.Name = "gBoxAlumnos";
            gBoxAlumnos.Size = new Size(729, 309);
            gBoxAlumnos.TabIndex = 0;
            gBoxAlumnos.TabStop = false;
            gBoxAlumnos.Text = "Nuevo Alumno Existente";
            // 
            // lblGradoAcademico
            // 
            lblGradoAcademico.AutoSize = true;
            lblGradoAcademico.Location = new Point(17, 234);
            lblGradoAcademico.Name = "lblGradoAcademico";
            lblGradoAcademico.Size = new Size(42, 15);
            lblGradoAcademico.TabIndex = 26;
            lblGradoAcademico.Text = "Grado:";
            // 
            // cmbGradoAcademico
            // 
            cmbGradoAcademico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradoAcademico.FormattingEnabled = true;
            cmbGradoAcademico.Location = new Point(65, 231);
            cmbGradoAcademico.Name = "cmbGradoAcademico";
            cmbGradoAcademico.Size = new Size(233, 23);
            cmbGradoAcademico.TabIndex = 25;
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.Location = new Point(320, 271);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.Size = new Size(120, 23);
            btnRegistrarAlumno.TabIndex = 1;
            btnRegistrarAlumno.Text = "Registrar alumno";
            btnRegistrarAlumno.UseVisualStyleBackColor = true;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(6, 22);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(717, 182);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
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
            // FormRegistrarAlumnoExistente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxAlumnos);
            Name = "FormRegistrarAlumnoExistente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar alumno existente";
            gBoxAlumnos.ResumeLayout(false);
            gBoxAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxAlumnos;
        private DataGridView dgvAlumnos;
        private Button btnRegistrarAlumno;
        private ComboBox cmbGradoAcademico;
        private Label lblGradoAcademico;
        private Button btnVolver;
    }
}