namespace Vista
{
    partial class FormModificarRol
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
            gBoxModificarRol = new GroupBox();
            btnModificarRol = new Button();
            lblAclaracion = new Label();
            cmbRol = new ComboBox();
            lblRol = new Label();
            btnVolver = new Button();
            gBoxModificarRol.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxModificarRol
            // 
            gBoxModificarRol.Controls.Add(btnModificarRol);
            gBoxModificarRol.Controls.Add(lblAclaracion);
            gBoxModificarRol.Controls.Add(cmbRol);
            gBoxModificarRol.Controls.Add(lblRol);
            gBoxModificarRol.Location = new Point(12, 12);
            gBoxModificarRol.Name = "gBoxModificarRol";
            gBoxModificarRol.Size = new Size(729, 145);
            gBoxModificarRol.TabIndex = 1;
            gBoxModificarRol.TabStop = false;
            gBoxModificarRol.Text = "Modificar Rol";
            // 
            // btnModificarRol
            // 
            btnModificarRol.Location = new Point(512, 58);
            btnModificarRol.Name = "btnModificarRol";
            btnModificarRol.Size = new Size(163, 28);
            btnModificarRol.TabIndex = 30;
            btnModificarRol.Text = "Modificar Rol";
            btnModificarRol.UseVisualStyleBackColor = true;
            btnModificarRol.Click += btnModificarRol_Click;
            // 
            // lblAclaracion
            // 
            lblAclaracion.AutoSize = true;
            lblAclaracion.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAclaracion.Location = new Point(85, 84);
            lblAclaracion.Name = "lblAclaracion";
            lblAclaracion.Size = new Size(128, 13);
            lblAclaracion.TabIndex = 29;
            lblAclaracion.Text = "Indique el rol a modificar.";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(85, 58);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(179, 23);
            cmbRol.TabIndex = 28;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(52, 61);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 27;
            lblRol.Text = "Rol:";
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
            // FormModificarRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxModificarRol);
            Name = "FormModificarRol";
            Text = "FormModificarRol";
            Load += FormModificarRol_Load;
            gBoxModificarRol.ResumeLayout(false);
            gBoxModificarRol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxModificarRol;
        private Button btnModificarRol;
        private Label lblAclaracion;
        private ComboBox cmbRol;
        private Label lblRol;
        private Button btnVolver;
    }
}