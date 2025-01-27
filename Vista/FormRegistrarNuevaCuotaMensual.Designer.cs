namespace Vista
{
    partial class FormRegistrarNuevaCuotaMensual
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
            gBoxRegistrarNuevaCuota = new GroupBox();
            btnAceptar = new Button();
            txtPrecio = new TextBox();
            lblMonto = new Label();
            cmbMes = new ComboBox();
            txtCicloAcademico = new TextBox();
            lblMes = new Label();
            lblCicloAcademico = new Label();
            btnVolver = new Button();
            gBoxRegistrarNuevaCuota.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegistrarNuevaCuota
            // 
            gBoxRegistrarNuevaCuota.Controls.Add(btnAceptar);
            gBoxRegistrarNuevaCuota.Controls.Add(txtPrecio);
            gBoxRegistrarNuevaCuota.Controls.Add(lblMonto);
            gBoxRegistrarNuevaCuota.Controls.Add(cmbMes);
            gBoxRegistrarNuevaCuota.Controls.Add(txtCicloAcademico);
            gBoxRegistrarNuevaCuota.Controls.Add(lblMes);
            gBoxRegistrarNuevaCuota.Controls.Add(lblCicloAcademico);
            gBoxRegistrarNuevaCuota.Location = new Point(12, 12);
            gBoxRegistrarNuevaCuota.Name = "gBoxRegistrarNuevaCuota";
            gBoxRegistrarNuevaCuota.Size = new Size(729, 171);
            gBoxRegistrarNuevaCuota.TabIndex = 0;
            gBoxRegistrarNuevaCuota.TabStop = false;
            gBoxRegistrarNuevaCuota.Text = "Nueva Cuota";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(632, 74);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(128, 112);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(79, 115);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Precio:";
            // 
            // cmbMes
            // 
            cmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMes.FormattingEnabled = true;
            cmbMes.Location = new Point(128, 74);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(48, 23);
            cmbMes.TabIndex = 3;
            // 
            // txtCicloAcademico
            // 
            txtCicloAcademico.Location = new Point(128, 37);
            txtCicloAcademico.Name = "txtCicloAcademico";
            txtCicloAcademico.ReadOnly = true;
            txtCicloAcademico.Size = new Size(100, 23);
            txtCicloAcademico.TabIndex = 2;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(90, 77);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(32, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes:";
            // 
            // lblCicloAcademico
            // 
            lblCicloAcademico.AutoSize = true;
            lblCicloAcademico.Location = new Point(22, 37);
            lblCicloAcademico.Name = "lblCicloAcademico";
            lblCicloAcademico.Size = new Size(100, 15);
            lblCicloAcademico.TabIndex = 0;
            lblCicloAcademico.Text = "Ciclo Academico:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormRegistrarNuevaCuotaMensual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxRegistrarNuevaCuota);
            Name = "FormRegistrarNuevaCuotaMensual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarNuevaCuotaMensual";
            gBoxRegistrarNuevaCuota.ResumeLayout(false);
            gBoxRegistrarNuevaCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxRegistrarNuevaCuota;
        private Label lblMonto;
        private ComboBox cmbMes;
        private TextBox txtCicloAcademico;
        private Label lblMes;
        private Label lblCicloAcademico;
        private Button btnAceptar;
        private TextBox txtPrecio;
        private Button btnVolver;
    }
}