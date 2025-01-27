namespace Vista
{
    partial class FormDatosDePagoDeCuota
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
            txtMonto = new TextBox();
            dgvMonto = new Label();
            btnContinuar = new Button();
            txtCodigoDeComprobante = new TextBox();
            lblCodigoDeComprobante = new Label();
            dtpFecha = new DateTimePicker();
            lblFechaDePago = new Label();
            cmbTipoDePago = new ComboBox();
            lblTipoDePago = new Label();
            txtDniPagador = new TextBox();
            lblDniPagador = new Label();
            txtApellidoPagador = new TextBox();
            lblApellidoPagador = new Label();
            txtNombrePagador = new TextBox();
            lblNombrePagador = new Label();
            txtAlumno = new TextBox();
            lblAlumno = new Label();
            txtCicloAcademicoAño = new TextBox();
            txtCuotaMes = new TextBox();
            lblCicloAcademicoAño = new Label();
            lblCuotaMes = new Label();
            btnVolver = new Button();
            gBoxPagarCuota.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxPagarCuota
            // 
            gBoxPagarCuota.Controls.Add(txtMonto);
            gBoxPagarCuota.Controls.Add(dgvMonto);
            gBoxPagarCuota.Controls.Add(btnContinuar);
            gBoxPagarCuota.Controls.Add(txtCodigoDeComprobante);
            gBoxPagarCuota.Controls.Add(lblCodigoDeComprobante);
            gBoxPagarCuota.Controls.Add(dtpFecha);
            gBoxPagarCuota.Controls.Add(lblFechaDePago);
            gBoxPagarCuota.Controls.Add(cmbTipoDePago);
            gBoxPagarCuota.Controls.Add(lblTipoDePago);
            gBoxPagarCuota.Controls.Add(txtDniPagador);
            gBoxPagarCuota.Controls.Add(lblDniPagador);
            gBoxPagarCuota.Controls.Add(txtApellidoPagador);
            gBoxPagarCuota.Controls.Add(lblApellidoPagador);
            gBoxPagarCuota.Controls.Add(txtNombrePagador);
            gBoxPagarCuota.Controls.Add(lblNombrePagador);
            gBoxPagarCuota.Controls.Add(txtAlumno);
            gBoxPagarCuota.Controls.Add(lblAlumno);
            gBoxPagarCuota.Controls.Add(txtCicloAcademicoAño);
            gBoxPagarCuota.Controls.Add(txtCuotaMes);
            gBoxPagarCuota.Controls.Add(lblCicloAcademicoAño);
            gBoxPagarCuota.Controls.Add(lblCuotaMes);
            gBoxPagarCuota.Location = new Point(12, 12);
            gBoxPagarCuota.Name = "gBoxPagarCuota";
            gBoxPagarCuota.Size = new Size(729, 503);
            gBoxPagarCuota.TabIndex = 1;
            gBoxPagarCuota.TabStop = false;
            gBoxPagarCuota.Text = "Pago de Cuota Mensual";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(159, 194);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 20;
            // 
            // dgvMonto
            // 
            dgvMonto.AutoSize = true;
            dgvMonto.Location = new Point(65, 197);
            dgvMonto.Name = "dgvMonto";
            dgvMonto.Size = new Size(88, 15);
            dgvMonto.TabIndex = 19;
            dgvMonto.Text = "Monto a pagar:";
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(335, 456);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 18;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // txtCodigoDeComprobante
            // 
            txtCodigoDeComprobante.Location = new Point(159, 410);
            txtCodigoDeComprobante.Name = "txtCodigoDeComprobante";
            txtCodigoDeComprobante.Size = new Size(235, 23);
            txtCodigoDeComprobante.TabIndex = 17;
            txtCodigoDeComprobante.KeyPress += txtCodigoDeComprobante_KeyPress;
            // 
            // lblCodigoDeComprobante
            // 
            lblCodigoDeComprobante.AutoSize = true;
            lblCodigoDeComprobante.Location = new Point(13, 413);
            lblCodigoDeComprobante.Name = "lblCodigoDeComprobante";
            lblCodigoDeComprobante.Size = new Size(140, 15);
            lblCodigoDeComprobante.TabIndex = 16;
            lblCodigoDeComprobante.Text = "Código de comprobante:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(159, 153);
            dtpFecha.MaxDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 15;
            dtpFecha.Value = new DateTime(2024, 12, 2, 0, 0, 0, 0);
            // 
            // lblFechaDePago
            // 
            lblFechaDePago.AutoSize = true;
            lblFechaDePago.Location = new Point(112, 156);
            lblFechaDePago.Name = "lblFechaDePago";
            lblFechaDePago.Size = new Size(41, 15);
            lblFechaDePago.TabIndex = 14;
            lblFechaDePago.Text = "Fecha:";
            // 
            // cmbTipoDePago
            // 
            cmbTipoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDePago.FormattingEnabled = true;
            cmbTipoDePago.Location = new Point(159, 366);
            cmbTipoDePago.Name = "cmbTipoDePago";
            cmbTipoDePago.Size = new Size(121, 23);
            cmbTipoDePago.TabIndex = 13;
            // 
            // lblTipoDePago
            // 
            lblTipoDePago.AutoSize = true;
            lblTipoDePago.Location = new Point(74, 369);
            lblTipoDePago.Name = "lblTipoDePago";
            lblTipoDePago.Size = new Size(79, 15);
            lblTipoDePago.TabIndex = 12;
            lblTipoDePago.Text = "Tipo de pago:";
            // 
            // txtDniPagador
            // 
            txtDniPagador.Location = new Point(159, 324);
            txtDniPagador.Name = "txtDniPagador";
            txtDniPagador.Size = new Size(235, 23);
            txtDniPagador.TabIndex = 11;
            txtDniPagador.KeyPress += txtDniPagador_KeyPress;
            // 
            // lblDniPagador
            // 
            lblDniPagador.AutoSize = true;
            lblDniPagador.Location = new Point(57, 327);
            lblDniPagador.Name = "lblDniPagador";
            lblDniPagador.Size = new Size(96, 15);
            lblDniPagador.TabIndex = 10;
            lblDniPagador.Text = "DNI del pagador:";
            // 
            // txtApellidoPagador
            // 
            txtApellidoPagador.Location = new Point(159, 283);
            txtApellidoPagador.Name = "txtApellidoPagador";
            txtApellidoPagador.Size = new Size(235, 23);
            txtApellidoPagador.TabIndex = 9;
            txtApellidoPagador.KeyPress += txtApellidoPagador_KeyPress;
            // 
            // lblApellidoPagador
            // 
            lblApellidoPagador.AutoSize = true;
            lblApellidoPagador.Location = new Point(33, 286);
            lblApellidoPagador.Name = "lblApellidoPagador";
            lblApellidoPagador.Size = new Size(120, 15);
            lblApellidoPagador.TabIndex = 8;
            lblApellidoPagador.Text = "Apellido del pagador:";
            // 
            // txtNombrePagador
            // 
            txtNombrePagador.Location = new Point(159, 237);
            txtNombrePagador.Name = "txtNombrePagador";
            txtNombrePagador.Size = new Size(235, 23);
            txtNombrePagador.TabIndex = 7;
            txtNombrePagador.KeyPress += txtNombrePagador_KeyPress;
            // 
            // lblNombrePagador
            // 
            lblNombrePagador.AutoSize = true;
            lblNombrePagador.Location = new Point(33, 240);
            lblNombrePagador.Name = "lblNombrePagador";
            lblNombrePagador.Size = new Size(120, 15);
            lblNombrePagador.TabIndex = 6;
            lblNombrePagador.Text = "Nombre del pagador:";
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
            // txtCicloAcademicoAño
            // 
            txtCicloAcademicoAño.Location = new Point(353, 88);
            txtCicloAcademicoAño.Name = "txtCicloAcademicoAño";
            txtCicloAcademicoAño.ReadOnly = true;
            txtCicloAcademicoAño.Size = new Size(100, 23);
            txtCicloAcademicoAño.TabIndex = 3;
            // 
            // txtCuotaMes
            // 
            txtCuotaMes.Location = new Point(84, 88);
            txtCuotaMes.Name = "txtCuotaMes";
            txtCuotaMes.ReadOnly = true;
            txtCuotaMes.Size = new Size(100, 23);
            txtCuotaMes.TabIndex = 2;
            // 
            // lblCicloAcademicoAño
            // 
            lblCicloAcademicoAño.AutoSize = true;
            lblCicloAcademicoAño.Location = new Point(247, 91);
            lblCicloAcademicoAño.Name = "lblCicloAcademicoAño";
            lblCicloAcademicoAño.Size = new Size(100, 15);
            lblCicloAcademicoAño.TabIndex = 1;
            lblCicloAcademicoAño.Text = "Ciclo Academico:";
            // 
            // lblCuotaMes
            // 
            lblCuotaMes.AutoSize = true;
            lblCuotaMes.Location = new Point(19, 91);
            lblCuotaMes.Name = "lblCuotaMes";
            lblCuotaMes.Size = new Size(59, 15);
            lblCuotaMes.TabIndex = 0;
            lblCuotaMes.Text = "Cuota N°:";
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
            // FormDatosDePagoDeCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxPagarCuota);
            Name = "FormDatosDePagoDeCuota";
            Text = "FormDatosDePagoDeCuota";
            gBoxPagarCuota.ResumeLayout(false);
            gBoxPagarCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxPagarCuota;
        private TextBox txtMonto;
        private Label dgvMonto;
        private Button btnContinuar;
        private TextBox txtCodigoDeComprobante;
        private Label lblCodigoDeComprobante;
        private DateTimePicker dtpFecha;
        private Label lblFechaDePago;
        private ComboBox cmbTipoDePago;
        private Label lblTipoDePago;
        private TextBox txtDniPagador;
        private Label lblDniPagador;
        private TextBox txtApellidoPagador;
        private Label lblApellidoPagador;
        private TextBox txtNombrePagador;
        private Label lblNombrePagador;
        private TextBox txtAlumno;
        private Label lblAlumno;
        private TextBox txtCicloAcademicoAño;
        private TextBox txtCuotaMes;
        private Label lblCicloAcademicoAño;
        private Label lblCuotaMes;
        private Button btnVolver;
    }
}