namespace Vista
{
    partial class FormAlumnos
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
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            btnEnviarEmail = new Button();
            btnRendimientoAnual = new Button();
            btnDatosPersonales = new Button();
            btnGenerarBoletin = new Button();
            btnRegistarObservacion = new Button();
            btnRegistrarExamen = new Button();
            btnRegistrarAsistencia = new Button();
            btnInformacionAcademica = new Button();
            dgvAlumnos = new DataGridView();
            btnVolver = new Button();
            gBoxAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // gBoxAlumnos
            // 
            gBoxAlumnos.Controls.Add(txtBuscar);
            gBoxAlumnos.Controls.Add(lblBuscar);
            gBoxAlumnos.Controls.Add(btnEnviarEmail);
            gBoxAlumnos.Controls.Add(btnRendimientoAnual);
            gBoxAlumnos.Controls.Add(btnDatosPersonales);
            gBoxAlumnos.Controls.Add(btnGenerarBoletin);
            gBoxAlumnos.Controls.Add(btnRegistarObservacion);
            gBoxAlumnos.Controls.Add(btnRegistrarExamen);
            gBoxAlumnos.Controls.Add(btnRegistrarAsistencia);
            gBoxAlumnos.Controls.Add(btnInformacionAcademica);
            gBoxAlumnos.Controls.Add(dgvAlumnos);
            gBoxAlumnos.Location = new Point(12, 12);
            gBoxAlumnos.Name = "gBoxAlumnos";
            gBoxAlumnos.Size = new Size(729, 386);
            gBoxAlumnos.TabIndex = 0;
            gBoxAlumnos.TabStop = false;
            gBoxAlumnos.Text = "Alumnos";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(114, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(274, 23);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(19, 34);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(89, 15);
            lblBuscar.TabIndex = 14;
            lblBuscar.Text = "Buscar por DNI:";
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Location = new Point(485, 217);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(232, 31);
            btnEnviarEmail.TabIndex = 8;
            btnEnviarEmail.Tag = "11";
            btnEnviarEmail.Text = "Enviar E-mail";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            btnEnviarEmail.Click += btnEnviarEmail_Click;
            // 
            // btnRendimientoAnual
            // 
            btnRendimientoAnual.Location = new Point(485, 291);
            btnRendimientoAnual.Name = "btnRendimientoAnual";
            btnRendimientoAnual.Size = new Size(232, 31);
            btnRendimientoAnual.TabIndex = 7;
            btnRendimientoAnual.Tag = "13";
            btnRendimientoAnual.Text = "Rendimiento anual";
            btnRendimientoAnual.UseVisualStyleBackColor = true;
            btnRendimientoAnual.Click += btnRendimientoAnual_Click;
            // 
            // btnDatosPersonales
            // 
            btnDatosPersonales.Location = new Point(485, 328);
            btnDatosPersonales.Name = "btnDatosPersonales";
            btnDatosPersonales.Size = new Size(232, 31);
            btnDatosPersonales.TabIndex = 1;
            btnDatosPersonales.Tag = "14";
            btnDatosPersonales.Text = "Datos personales";
            btnDatosPersonales.UseVisualStyleBackColor = true;
            btnDatosPersonales.Click += btnDatosPersonales_Click;
            // 
            // btnGenerarBoletin
            // 
            btnGenerarBoletin.Location = new Point(485, 180);
            btnGenerarBoletin.Name = "btnGenerarBoletin";
            btnGenerarBoletin.Size = new Size(232, 31);
            btnGenerarBoletin.TabIndex = 6;
            btnGenerarBoletin.Tag = "10";
            btnGenerarBoletin.Text = "Generar boletín";
            btnGenerarBoletin.UseVisualStyleBackColor = true;
            btnGenerarBoletin.Click += btnGenerarBoletin_Click;
            // 
            // btnRegistarObservacion
            // 
            btnRegistarObservacion.Location = new Point(485, 143);
            btnRegistarObservacion.Name = "btnRegistarObservacion";
            btnRegistarObservacion.Size = new Size(232, 31);
            btnRegistarObservacion.TabIndex = 5;
            btnRegistarObservacion.Tag = "9";
            btnRegistarObservacion.Text = "Registrar obervación";
            btnRegistarObservacion.UseVisualStyleBackColor = true;
            btnRegistarObservacion.Click += btnRegistarObservacion_Click;
            // 
            // btnRegistrarExamen
            // 
            btnRegistrarExamen.Location = new Point(485, 69);
            btnRegistrarExamen.Name = "btnRegistrarExamen";
            btnRegistrarExamen.Size = new Size(232, 31);
            btnRegistrarExamen.TabIndex = 4;
            btnRegistrarExamen.Tag = "7";
            btnRegistrarExamen.Text = "Registrar examen";
            btnRegistrarExamen.UseVisualStyleBackColor = true;
            btnRegistrarExamen.Click += btnRegistrarExamen_Click;
            // 
            // btnRegistrarAsistencia
            // 
            btnRegistrarAsistencia.Location = new Point(485, 106);
            btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            btnRegistrarAsistencia.Size = new Size(232, 31);
            btnRegistrarAsistencia.TabIndex = 3;
            btnRegistrarAsistencia.Tag = "8";
            btnRegistrarAsistencia.Text = "Registrar asistencia";
            btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            btnRegistrarAsistencia.Click += btnRegistrarAsistencia_Click;
            // 
            // btnInformacionAcademica
            // 
            btnInformacionAcademica.Location = new Point(485, 254);
            btnInformacionAcademica.Name = "btnInformacionAcademica";
            btnInformacionAcademica.Size = new Size(232, 31);
            btnInformacionAcademica.TabIndex = 2;
            btnInformacionAcademica.Tag = "12";
            btnInformacionAcademica.Text = "Información academica";
            btnInformacionAcademica.UseVisualStyleBackColor = true;
            btnInformacionAcademica.Click += btnInformacionAcademica_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(19, 69);
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
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxAlumnos);
            Name = "FormAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos";
            Load += FormAlumnos_Load;
            gBoxAlumnos.ResumeLayout(false);
            gBoxAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxAlumnos;
        private DataGridView dgvAlumnos;
        private Button btnRegistrarExamen;
        private Button btnRegistrarAsistencia;
        private Button btnInformacionAcademica;
        private Button btnDatosPersonales;
        private Button btnEnviarEmail;
        private Button btnRendimientoAnual;
        private Button btnGenerarBoletin;
        private Button btnRegistarObservacion;
        private Button btnVolver;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}