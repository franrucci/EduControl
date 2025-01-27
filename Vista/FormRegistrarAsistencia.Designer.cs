namespace Vista
{
    partial class FormRegistrarAsistencia
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
            gBoxRegistrarAsistencia = new GroupBox();
            btnAceptar = new Button();
            cmbTipoDeAsistencia = new ComboBox();
            cmbTrimestre = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblTipoDeAsistencia = new Label();
            lblTrimestre = new Label();
            lblFecha = new Label();
            btnVolver = new Button();
            gBoxRegistrarAsistencia.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegistrarAsistencia
            // 
            gBoxRegistrarAsistencia.Controls.Add(btnAceptar);
            gBoxRegistrarAsistencia.Controls.Add(cmbTipoDeAsistencia);
            gBoxRegistrarAsistencia.Controls.Add(cmbTrimestre);
            gBoxRegistrarAsistencia.Controls.Add(dtpFecha);
            gBoxRegistrarAsistencia.Controls.Add(lblTipoDeAsistencia);
            gBoxRegistrarAsistencia.Controls.Add(lblTrimestre);
            gBoxRegistrarAsistencia.Controls.Add(lblFecha);
            gBoxRegistrarAsistencia.Location = new Point(12, 12);
            gBoxRegistrarAsistencia.Name = "gBoxRegistrarAsistencia";
            gBoxRegistrarAsistencia.Size = new Size(729, 180);
            gBoxRegistrarAsistencia.TabIndex = 0;
            gBoxRegistrarAsistencia.TabStop = false;
            gBoxRegistrarAsistencia.Text = "Nueva Asistencia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(630, 75);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTipoDeAsistencia
            // 
            cmbTipoDeAsistencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeAsistencia.FormattingEnabled = true;
            cmbTipoDeAsistencia.Location = new Point(71, 117);
            cmbTipoDeAsistencia.Name = "cmbTipoDeAsistencia";
            cmbTipoDeAsistencia.Size = new Size(121, 23);
            cmbTipoDeAsistencia.TabIndex = 5;
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(71, 75);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 4;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(71, 34);
            dtpFecha.MaxDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            dtpFecha.Value = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            // 
            // lblTipoDeAsistencia
            // 
            lblTipoDeAsistencia.AutoSize = true;
            lblTipoDeAsistencia.Location = new Point(36, 120);
            lblTipoDeAsistencia.Name = "lblTipoDeAsistencia";
            lblTipoDeAsistencia.Size = new Size(33, 15);
            lblTipoDeAsistencia.TabIndex = 2;
            lblTipoDeAsistencia.Text = "Tipo:";
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(11, 78);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 1;
            lblTrimestre.Text = "Trimestre:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(25, 37);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha: ";
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
            // FormRegistrarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxRegistrarAsistencia);
            Name = "FormRegistrarAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Asistencia";
            gBoxRegistrarAsistencia.ResumeLayout(false);
            gBoxRegistrarAsistencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxRegistrarAsistencia;
        private Label lblTrimestre;
        private Label lblFecha;
        private ComboBox cmbTipoDeAsistencia;
        private ComboBox cmbTrimestre;
        private DateTimePicker dtpFecha;
        private Label lblTipoDeAsistencia;
        private Button btnAceptar;
        private Button btnVolver;
    }
}