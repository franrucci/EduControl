namespace Vista
{
    partial class FormAgregarTrimestre
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
            gBoxNuevoTrimestre = new GroupBox();
            btnAceptar = new Button();
            txtDiasTotalesHabiles = new TextBox();
            cmbNumeroDeTrimestre = new ComboBox();
            lblDiasTotalesHabiles = new Label();
            lblNumTrimestre = new Label();
            btnVolver = new Button();
            gBoxNuevoTrimestre.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxNuevoTrimestre
            // 
            gBoxNuevoTrimestre.Controls.Add(btnAceptar);
            gBoxNuevoTrimestre.Controls.Add(txtDiasTotalesHabiles);
            gBoxNuevoTrimestre.Controls.Add(cmbNumeroDeTrimestre);
            gBoxNuevoTrimestre.Controls.Add(lblDiasTotalesHabiles);
            gBoxNuevoTrimestre.Controls.Add(lblNumTrimestre);
            gBoxNuevoTrimestre.Location = new Point(12, 12);
            gBoxNuevoTrimestre.Name = "gBoxNuevoTrimestre";
            gBoxNuevoTrimestre.Size = new Size(729, 133);
            gBoxNuevoTrimestre.TabIndex = 0;
            gBoxNuevoTrimestre.TabStop = false;
            gBoxNuevoTrimestre.Text = "Nuevo trimestre";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(624, 61);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDiasTotalesHabiles
            // 
            txtDiasTotalesHabiles.Location = new Point(146, 78);
            txtDiasTotalesHabiles.Name = "txtDiasTotalesHabiles";
            txtDiasTotalesHabiles.Size = new Size(121, 23);
            txtDiasTotalesHabiles.TabIndex = 3;
            txtDiasTotalesHabiles.KeyPress += txtDiasTotalesHabiles_KeyPress;
            // 
            // cmbNumeroDeTrimestre
            // 
            cmbNumeroDeTrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNumeroDeTrimestre.FormattingEnabled = true;
            cmbNumeroDeTrimestre.Location = new Point(146, 37);
            cmbNumeroDeTrimestre.Name = "cmbNumeroDeTrimestre";
            cmbNumeroDeTrimestre.Size = new Size(121, 23);
            cmbNumeroDeTrimestre.TabIndex = 2;
            // 
            // lblDiasTotalesHabiles
            // 
            lblDiasTotalesHabiles.AutoSize = true;
            lblDiasTotalesHabiles.Location = new Point(30, 81);
            lblDiasTotalesHabiles.Name = "lblDiasTotalesHabiles";
            lblDiasTotalesHabiles.Size = new Size(110, 15);
            lblDiasTotalesHabiles.TabIndex = 1;
            lblDiasTotalesHabiles.Text = "Dias totales habiles:";
            // 
            // lblNumTrimestre
            // 
            lblNumTrimestre.AutoSize = true;
            lblNumTrimestre.Location = new Point(20, 40);
            lblNumTrimestre.Name = "lblNumTrimestre";
            lblNumTrimestre.Size = new Size(120, 15);
            lblNumTrimestre.TabIndex = 0;
            lblNumTrimestre.Text = "Numero de trimestre:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAgregarTrimestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxNuevoTrimestre);
            Name = "FormAgregarTrimestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar trimestre";
            gBoxNuevoTrimestre.ResumeLayout(false);
            gBoxNuevoTrimestre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxNuevoTrimestre;
        private Button btnAceptar;
        private TextBox txtDiasTotalesHabiles;
        private ComboBox cmbNumeroDeTrimestre;
        private Label lblDiasTotalesHabiles;
        private Label lblNumTrimestre;
        private Button btnVolver;
    }
}