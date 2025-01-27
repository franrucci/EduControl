namespace Vista
{
    partial class FormAlumnosTotal
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
            btnModificarAlumno = new Button();
            btnEliminarAlumno = new Button();
            btnPagarCuotas = new Button();
            btnEnviarEmail = new Button();
            btnDatosPersonales = new Button();
            btnInformacionAcademica = new Button();
            dgvAlumnos = new DataGridView();
            btnVolver = new Button();
            gBoxAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // gBoxAlumnos
            // 
            gBoxAlumnos.Controls.Add(btnModificarAlumno);
            gBoxAlumnos.Controls.Add(btnEliminarAlumno);
            gBoxAlumnos.Controls.Add(btnPagarCuotas);
            gBoxAlumnos.Controls.Add(btnEnviarEmail);
            gBoxAlumnos.Controls.Add(btnDatosPersonales);
            gBoxAlumnos.Controls.Add(btnInformacionAcademica);
            gBoxAlumnos.Controls.Add(dgvAlumnos);
            gBoxAlumnos.Location = new Point(12, 12);
            gBoxAlumnos.Name = "gBoxAlumnos";
            gBoxAlumnos.Size = new Size(729, 336);
            gBoxAlumnos.TabIndex = 1;
            gBoxAlumnos.TabStop = false;
            gBoxAlumnos.Text = "Alumnos";
            // 
            // btnModificarAlumno
            // 
            btnModificarAlumno.Location = new Point(487, 211);
            btnModificarAlumno.Name = "btnModificarAlumno";
            btnModificarAlumno.Size = new Size(232, 31);
            btnModificarAlumno.TabIndex = 11;
            btnModificarAlumno.Tag = "21";
            btnModificarAlumno.Text = "Modificar Alumno";
            btnModificarAlumno.UseVisualStyleBackColor = true;
            btnModificarAlumno.Click += btnModificarAlumno_Click;
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.Location = new Point(487, 172);
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.Size = new Size(232, 31);
            btnEliminarAlumno.TabIndex = 10;
            btnEliminarAlumno.Tag = "20";
            btnEliminarAlumno.Text = "Eliminar Alumno";
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            btnEliminarAlumno.Click += btnEliminarAlumno_Click;
            // 
            // btnPagarCuotas
            // 
            btnPagarCuotas.Location = new Point(487, 136);
            btnPagarCuotas.Name = "btnPagarCuotas";
            btnPagarCuotas.Size = new Size(232, 31);
            btnPagarCuotas.TabIndex = 9;
            btnPagarCuotas.Tag = "18";
            btnPagarCuotas.Text = "Pagar Cuota Mensual";
            btnPagarCuotas.UseVisualStyleBackColor = true;
            btnPagarCuotas.Click += btnPagarCuotas_Click;
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Location = new Point(487, 99);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(232, 31);
            btnEnviarEmail.TabIndex = 8;
            btnEnviarEmail.Tag = "17";
            btnEnviarEmail.Text = "Enviar E-mail";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            btnEnviarEmail.Click += btnEnviarEmail_Click;
            // 
            // btnDatosPersonales
            // 
            btnDatosPersonales.Location = new Point(487, 25);
            btnDatosPersonales.Name = "btnDatosPersonales";
            btnDatosPersonales.Size = new Size(232, 31);
            btnDatosPersonales.TabIndex = 1;
            btnDatosPersonales.Tag = "15";
            btnDatosPersonales.Text = "Datos personales";
            btnDatosPersonales.UseVisualStyleBackColor = true;
            btnDatosPersonales.Click += btnDatosPersonales_Click;
            // 
            // btnInformacionAcademica
            // 
            btnInformacionAcademica.Location = new Point(487, 62);
            btnInformacionAcademica.Name = "btnInformacionAcademica";
            btnInformacionAcademica.Size = new Size(232, 31);
            btnInformacionAcademica.TabIndex = 2;
            btnInformacionAcademica.Tag = "16";
            btnInformacionAcademica.Text = "Información academica";
            btnInformacionAcademica.UseVisualStyleBackColor = true;
            btnInformacionAcademica.Click += btnInformacionAcademica_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(16, 25);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(440, 290);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
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
            // FormAlumnosTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxAlumnos);
            Name = "FormAlumnosTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlumnosTotal";
            Load += FormAlumnosTotal_Load;
            gBoxAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxAlumnos;
        private Button btnEnviarEmail;
        private Button btnDatosPersonales;
        private Button btnInformacionAcademica;
        private DataGridView dgvAlumnos;
        private Button btnVolver;
        private Button btnPagarCuotas;
        private Button btnModificarAlumno;
        private Button btnEliminarAlumno;
    }
}