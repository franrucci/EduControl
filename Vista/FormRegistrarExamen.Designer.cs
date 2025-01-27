namespace Vista
{
    partial class FormRegistrarExamen
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
            gBoxRegistrarExamen = new GroupBox();
            btnAceptar = new Button();
            cmbTrimestre = new ComboBox();
            cmbTipoDeExamen = new ComboBox();
            cmbMateria = new ComboBox();
            txtNota = new TextBox();
            lblNota = new Label();
            lblTrimestre = new Label();
            lblTipoDeExamen = new Label();
            lblMateria = new Label();
            btnVolver = new Button();
            gBoxRegistrarExamen.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxRegistrarExamen
            // 
            gBoxRegistrarExamen.Controls.Add(btnAceptar);
            gBoxRegistrarExamen.Controls.Add(cmbTrimestre);
            gBoxRegistrarExamen.Controls.Add(cmbTipoDeExamen);
            gBoxRegistrarExamen.Controls.Add(cmbMateria);
            gBoxRegistrarExamen.Controls.Add(txtNota);
            gBoxRegistrarExamen.Controls.Add(lblNota);
            gBoxRegistrarExamen.Controls.Add(lblTrimestre);
            gBoxRegistrarExamen.Controls.Add(lblTipoDeExamen);
            gBoxRegistrarExamen.Controls.Add(lblMateria);
            gBoxRegistrarExamen.Location = new Point(12, 12);
            gBoxRegistrarExamen.Name = "gBoxRegistrarExamen";
            gBoxRegistrarExamen.Size = new Size(729, 200);
            gBoxRegistrarExamen.TabIndex = 0;
            gBoxRegistrarExamen.TabStop = false;
            gBoxRegistrarExamen.Text = "Nuevo Examen";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(638, 90);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(87, 110);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 9;
            // 
            // cmbTipoDeExamen
            // 
            cmbTipoDeExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeExamen.FormattingEnabled = true;
            cmbTipoDeExamen.Location = new Point(123, 75);
            cmbTipoDeExamen.Name = "cmbTipoDeExamen";
            cmbTipoDeExamen.Size = new Size(121, 23);
            cmbTipoDeExamen.TabIndex = 8;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(79, 40);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 7;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(65, 146);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 5;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(23, 149);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(36, 15);
            lblNota.TabIndex = 3;
            lblNota.Text = "Nota:";
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(23, 113);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 2;
            lblTrimestre.Text = "Trimestre:";
            // 
            // lblTipoDeExamen
            // 
            lblTipoDeExamen.AutoSize = true;
            lblTipoDeExamen.Location = new Point(23, 78);
            lblTipoDeExamen.Name = "lblTipoDeExamen";
            lblTipoDeExamen.Size = new Size(94, 15);
            lblTipoDeExamen.TabIndex = 1;
            lblTipoDeExamen.Text = "Tipo de examen:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(23, 43);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "Materia:";
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
            // FormRegistrarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxRegistrarExamen);
            Name = "FormRegistrarExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Examen";
            gBoxRegistrarExamen.ResumeLayout(false);
            gBoxRegistrarExamen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxRegistrarExamen;
        private Label lblNota;
        private Label lblTrimestre;
        private Label lblTipoDeExamen;
        private Label lblMateria;
        private ComboBox cmbTrimestre;
        private ComboBox cmbTipoDeExamen;
        private ComboBox cmbMateria;
        private TextBox txtNota;
        private Button btnAceptar;
        private Button btnVolver;
    }
}