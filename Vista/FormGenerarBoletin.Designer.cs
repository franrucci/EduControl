namespace Vista
{
    partial class FormGenerarBoletin
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
            gBoxGenerarBoletin = new GroupBox();
            btnAceptar = new Button();
            cmbNumTrimestre = new ComboBox();
            lblTrimestre = new Label();
            btnVolver = new Button();
            gBoxGenerarBoletin.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxGenerarBoletin
            // 
            gBoxGenerarBoletin.Controls.Add(btnAceptar);
            gBoxGenerarBoletin.Controls.Add(cmbNumTrimestre);
            gBoxGenerarBoletin.Controls.Add(lblTrimestre);
            gBoxGenerarBoletin.Location = new Point(12, 12);
            gBoxGenerarBoletin.Name = "gBoxGenerarBoletin";
            gBoxGenerarBoletin.Size = new Size(729, 90);
            gBoxGenerarBoletin.TabIndex = 0;
            gBoxGenerarBoletin.TabStop = false;
            gBoxGenerarBoletin.Text = "Generar Boletín";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(631, 35);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbNumTrimestre
            // 
            cmbNumTrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNumTrimestre.FormattingEnabled = true;
            cmbNumTrimestre.Location = new Point(140, 35);
            cmbNumTrimestre.Name = "cmbNumTrimestre";
            cmbNumTrimestre.Size = new Size(121, 23);
            cmbNumTrimestre.TabIndex = 1;
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(22, 38);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(112, 15);
            lblTrimestre.TabIndex = 0;
            lblTrimestre.Text = "Indíque el trimestre:";
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
            // FormGenerarBoletin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxGenerarBoletin);
            Name = "FormGenerarBoletin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Boletin";
            gBoxGenerarBoletin.ResumeLayout(false);
            gBoxGenerarBoletin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxGenerarBoletin;
        private ComboBox cmbNumTrimestre;
        private Label lblTrimestre;
        private Button btnAceptar;
        private Button btnVolver;
    }
}