namespace Vista
{
    partial class FormRegistrarObservacion
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
            gBoxRegistrarInformacion = new GroupBox();
            btnAceptar = new Button();
            txtObservacion = new TextBox();
            lblObservacion = new Label();
            cmbTrimestre = new ComboBox();
            lblTrimestre = new Label();
            btnVolver = new Button();
            gBoxRegistrarInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegistrarInformacion
            // 
            gBoxRegistrarInformacion.Controls.Add(btnAceptar);
            gBoxRegistrarInformacion.Controls.Add(txtObservacion);
            gBoxRegistrarInformacion.Controls.Add(lblObservacion);
            gBoxRegistrarInformacion.Controls.Add(cmbTrimestre);
            gBoxRegistrarInformacion.Controls.Add(lblTrimestre);
            gBoxRegistrarInformacion.Location = new Point(12, 12);
            gBoxRegistrarInformacion.Name = "gBoxRegistrarInformacion";
            gBoxRegistrarInformacion.Size = new Size(729, 273);
            gBoxRegistrarInformacion.TabIndex = 0;
            gBoxRegistrarInformacion.TabStop = false;
            gBoxRegistrarInformacion.Text = "Nueva Observación";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(346, 238);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(103, 76);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(603, 145);
            txtObservacion.TabIndex = 3;
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Location = new Point(21, 76);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(76, 15);
            lblObservacion.TabIndex = 2;
            lblObservacion.Text = "Observación:";
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(103, 33);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 1;
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(39, 36);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 0;
            lblTrimestre.Text = "Trimestre:";
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
            // FormRegistrarObservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxRegistrarInformacion);
            Name = "FormRegistrarObservacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Observación";
            gBoxRegistrarInformacion.ResumeLayout(false);
            gBoxRegistrarInformacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxRegistrarInformacion;
        private ComboBox cmbTrimestre;
        private Label lblTrimestre;
        private Button btnAceptar;
        private TextBox txtObservacion;
        private Label lblObservacion;
        private Button btnVolver;
    }
}