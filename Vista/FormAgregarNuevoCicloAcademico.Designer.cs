namespace Vista
{
    partial class FormAgregarNuevoCicloAcademico
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
            gBoxNuevoCicloAcademico = new GroupBox();
            btnAceptar = new Button();
            txtAño = new TextBox();
            lblAño = new Label();
            btnVolver = new Button();
            gBoxNuevoCicloAcademico.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxNuevoCicloAcademico
            // 
            gBoxNuevoCicloAcademico.Controls.Add(btnAceptar);
            gBoxNuevoCicloAcademico.Controls.Add(txtAño);
            gBoxNuevoCicloAcademico.Controls.Add(lblAño);
            gBoxNuevoCicloAcademico.Location = new Point(12, 12);
            gBoxNuevoCicloAcademico.Name = "gBoxNuevoCicloAcademico";
            gBoxNuevoCicloAcademico.Size = new Size(729, 100);
            gBoxNuevoCicloAcademico.TabIndex = 0;
            gBoxNuevoCicloAcademico.TabStop = false;
            gBoxNuevoCicloAcademico.Text = "Nuevo Ciclo Académico";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(638, 43);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(61, 43);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 1;
            txtAño.KeyPress += txtAño_KeyPress;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(23, 46);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(32, 15);
            lblAño.TabIndex = 0;
            lblAño.Text = "Año:";
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
            // FormAgregarNuevoCicloAcademico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxNuevoCicloAcademico);
            Name = "FormAgregarNuevoCicloAcademico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo ciclo academico";
            gBoxNuevoCicloAcademico.ResumeLayout(false);
            gBoxNuevoCicloAcademico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxNuevoCicloAcademico;
        private Button btnAceptar;
        private TextBox txtAño;
        private Label lblAño;
        private Button btnVolver;
    }
}