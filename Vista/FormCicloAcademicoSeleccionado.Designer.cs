namespace Vista
{
    partial class FormCicloAcademicoSeleccionado
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
            gBoxCicloAcademicoSeleccionado = new GroupBox();
            txtCicloAcademicoSeleccionado = new TextBox();
            lblCicloAcademicoSeleccionado = new Label();
            btnGradosAcademicos = new Button();
            btnAgregarAlumno = new Button();
            btnAgregarTrimestre = new Button();
            btnVolver = new Button();
            btnCuotasMensuales = new Button();
            gBoxCicloAcademicoSeleccionado.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxCicloAcademicoSeleccionado
            // 
            gBoxCicloAcademicoSeleccionado.Controls.Add(txtCicloAcademicoSeleccionado);
            gBoxCicloAcademicoSeleccionado.Controls.Add(lblCicloAcademicoSeleccionado);
            gBoxCicloAcademicoSeleccionado.Location = new Point(12, 12);
            gBoxCicloAcademicoSeleccionado.Name = "gBoxCicloAcademicoSeleccionado";
            gBoxCicloAcademicoSeleccionado.Size = new Size(729, 67);
            gBoxCicloAcademicoSeleccionado.TabIndex = 0;
            gBoxCicloAcademicoSeleccionado.TabStop = false;
            // 
            // txtCicloAcademicoSeleccionado
            // 
            txtCicloAcademicoSeleccionado.Location = new Point(126, 26);
            txtCicloAcademicoSeleccionado.Name = "txtCicloAcademicoSeleccionado";
            txtCicloAcademicoSeleccionado.ReadOnly = true;
            txtCicloAcademicoSeleccionado.Size = new Size(100, 23);
            txtCicloAcademicoSeleccionado.TabIndex = 1;
            // 
            // lblCicloAcademicoSeleccionado
            // 
            lblCicloAcademicoSeleccionado.AutoSize = true;
            lblCicloAcademicoSeleccionado.Location = new Point(19, 29);
            lblCicloAcademicoSeleccionado.Name = "lblCicloAcademicoSeleccionado";
            lblCicloAcademicoSeleccionado.Size = new Size(101, 15);
            lblCicloAcademicoSeleccionado.TabIndex = 0;
            lblCicloAcademicoSeleccionado.Text = "Ciclo académico: ";
            // 
            // btnGradosAcademicos
            // 
            btnGradosAcademicos.Location = new Point(21, 108);
            btnGradosAcademicos.Name = "btnGradosAcademicos";
            btnGradosAcademicos.Size = new Size(101, 50);
            btnGradosAcademicos.TabIndex = 1;
            btnGradosAcademicos.Tag = "2";
            btnGradosAcademicos.Text = "Grados";
            btnGradosAcademicos.UseVisualStyleBackColor = true;
            btnGradosAcademicos.Click += btnGradosAcademicos_Click;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(156, 108);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(101, 50);
            btnAgregarAlumno.TabIndex = 2;
            btnAgregarAlumno.Tag = "3";
            btnAgregarAlumno.Text = "Agregar Nuevo Alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // btnAgregarTrimestre
            // 
            btnAgregarTrimestre.Location = new Point(292, 108);
            btnAgregarTrimestre.Name = "btnAgregarTrimestre";
            btnAgregarTrimestre.Size = new Size(101, 50);
            btnAgregarTrimestre.TabIndex = 3;
            btnAgregarTrimestre.Tag = "5";
            btnAgregarTrimestre.Text = "Agregar Trimestre";
            btnAgregarTrimestre.UseVisualStyleBackColor = true;
            btnAgregarTrimestre.Click += btnAgregarTrimestre_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCuotasMensuales
            // 
            btnCuotasMensuales.Location = new Point(428, 108);
            btnCuotasMensuales.Name = "btnCuotasMensuales";
            btnCuotasMensuales.Size = new Size(101, 50);
            btnCuotasMensuales.TabIndex = 5;
            btnCuotasMensuales.Tag = "6";
            btnCuotasMensuales.Text = "Cuotas Mensuales";
            btnCuotasMensuales.UseVisualStyleBackColor = true;
            btnCuotasMensuales.Click += btnCuotasMensuales_Click;
            // 
            // FormCicloAcademicoSeleccionado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnCuotasMensuales);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarTrimestre);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(btnGradosAcademicos);
            Controls.Add(gBoxCicloAcademicoSeleccionado);
            Name = "FormCicloAcademicoSeleccionado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CicloAcademico";
            FormClosed += FormCicloAcademicoSeleccionado_FormClosed;
            Load += FormCicloAcademicoSeleccionado_Load;
            gBoxCicloAcademicoSeleccionado.ResumeLayout(false);
            gBoxCicloAcademicoSeleccionado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxCicloAcademicoSeleccionado;
        private Label lblCicloAcademicoSeleccionado;
        private TextBox txtCicloAcademicoSeleccionado;
        private Button btnGradosAcademicos;
        private Button btnAgregarAlumno;
        private Button btnAgregarTrimestre;
        private Button btnVolver;
        private Button btnCuotasMensuales;
    }
}