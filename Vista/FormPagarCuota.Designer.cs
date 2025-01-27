namespace Vista
{
    partial class FormPagarCuota
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
            gBoxPagarCuota = new GroupBox();
            gBoxDatosAlumno = new GroupBox();
            txtCuotaMes = new TextBox();
            btnContinuar = new Button();
            lblCuotaMes = new Label();
            lblCicloAcademicoAño = new Label();
            txtCicloAcademicoAño = new TextBox();
            dtpFecha = new DateTimePicker();
            lblFechaDePago = new Label();
            txtAlumno = new TextBox();
            lblAlumno = new Label();
            btnVolver = new Button();
            gBoxPagarCuota.SuspendLayout();
            gBoxDatosAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxPagarCuota
            // 
            gBoxPagarCuota.Controls.Add(gBoxDatosAlumno);
            gBoxPagarCuota.Controls.Add(txtAlumno);
            gBoxPagarCuota.Controls.Add(lblAlumno);
            gBoxPagarCuota.Location = new Point(12, 12);
            gBoxPagarCuota.Name = "gBoxPagarCuota";
            gBoxPagarCuota.Size = new Size(729, 453);
            gBoxPagarCuota.TabIndex = 0;
            gBoxPagarCuota.TabStop = false;
            gBoxPagarCuota.Text = "Pago de Cuota Mensual";
            // 
            // gBoxDatosAlumno
            // 
            gBoxDatosAlumno.Controls.Add(txtCuotaMes);
            gBoxDatosAlumno.Controls.Add(btnContinuar);
            gBoxDatosAlumno.Controls.Add(lblCuotaMes);
            gBoxDatosAlumno.Controls.Add(lblCicloAcademicoAño);
            gBoxDatosAlumno.Controls.Add(txtCicloAcademicoAño);
            gBoxDatosAlumno.Controls.Add(dtpFecha);
            gBoxDatosAlumno.Controls.Add(lblFechaDePago);
            gBoxDatosAlumno.Location = new Point(6, 78);
            gBoxDatosAlumno.Name = "gBoxDatosAlumno";
            gBoxDatosAlumno.Size = new Size(717, 130);
            gBoxDatosAlumno.TabIndex = 21;
            gBoxDatosAlumno.TabStop = false;
            // 
            // txtCuotaMes
            // 
            txtCuotaMes.Location = new Point(105, 22);
            txtCuotaMes.Name = "txtCuotaMes";
            txtCuotaMes.ReadOnly = true;
            txtCuotaMes.Size = new Size(100, 23);
            txtCuotaMes.TabIndex = 2;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(600, 60);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(96, 37);
            btnContinuar.TabIndex = 18;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblCuotaMes
            // 
            lblCuotaMes.AutoSize = true;
            lblCuotaMes.Location = new Point(40, 25);
            lblCuotaMes.Name = "lblCuotaMes";
            lblCuotaMes.Size = new Size(59, 15);
            lblCuotaMes.TabIndex = 0;
            lblCuotaMes.Text = "Cuota N°:";
            // 
            // lblCicloAcademicoAño
            // 
            lblCicloAcademicoAño.AutoSize = true;
            lblCicloAcademicoAño.Location = new Point(268, 25);
            lblCicloAcademicoAño.Name = "lblCicloAcademicoAño";
            lblCicloAcademicoAño.Size = new Size(100, 15);
            lblCicloAcademicoAño.TabIndex = 1;
            lblCicloAcademicoAño.Text = "Ciclo Academico:";
            // 
            // txtCicloAcademicoAño
            // 
            txtCicloAcademicoAño.Location = new Point(374, 22);
            txtCicloAcademicoAño.Name = "txtCicloAcademicoAño";
            txtCicloAcademicoAño.ReadOnly = true;
            txtCicloAcademicoAño.Size = new Size(100, 23);
            txtCicloAcademicoAño.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(105, 74);
            dtpFecha.MaxDate = new DateTime(2024, 12, 10, 14, 41, 22, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(229, 23);
            dtpFecha.TabIndex = 15;
            dtpFecha.Value = new DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // lblFechaDePago
            // 
            lblFechaDePago.AutoSize = true;
            lblFechaDePago.Location = new Point(58, 77);
            lblFechaDePago.Name = "lblFechaDePago";
            lblFechaDePago.Size = new Size(41, 15);
            lblFechaDePago.TabIndex = 14;
            lblFechaDePago.Text = "Fecha:";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(84, 35);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.ReadOnly = true;
            txtAlumno.Size = new Size(296, 23);
            txtAlumno.TabIndex = 5;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(25, 38);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(53, 15);
            lblAlumno.TabIndex = 4;
            lblAlumno.Text = "Alumno:";
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
            // FormPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxPagarCuota);
            Name = "FormPagarCuota";
            Text = "FormPagarCuota";
            gBoxPagarCuota.ResumeLayout(false);
            gBoxPagarCuota.PerformLayout();
            gBoxDatosAlumno.ResumeLayout(false);
            gBoxDatosAlumno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxPagarCuota;
        private TextBox txtCicloAcademicoAño;
        private TextBox txtCuotaMes;
        private Label lblCicloAcademicoAño;
        private Label lblCuotaMes;
        private TextBox txtAlumno;
        private Label lblAlumno;
        private Label lblFechaDePago;
        private DateTimePicker dtpFecha;
        private Button btnContinuar;
        private Button btnVolver;
        private GroupBox gBoxDatosAlumno;
    }
}