namespace Vista
{
    partial class FormEliminarRol
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
            gBoxEliminarRol = new GroupBox();
            btnEliminar = new Button();
            lblAclaracion = new Label();
            cmbRol = new ComboBox();
            lblRol = new Label();
            btnVolver = new Button();
            gBoxEliminarRol.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxEliminarRol
            // 
            gBoxEliminarRol.Controls.Add(btnEliminar);
            gBoxEliminarRol.Controls.Add(lblAclaracion);
            gBoxEliminarRol.Controls.Add(cmbRol);
            gBoxEliminarRol.Controls.Add(lblRol);
            gBoxEliminarRol.Location = new Point(12, 12);
            gBoxEliminarRol.Name = "gBoxEliminarRol";
            gBoxEliminarRol.Size = new Size(729, 145);
            gBoxEliminarRol.TabIndex = 0;
            gBoxEliminarRol.TabStop = false;
            gBoxEliminarRol.Text = "Eliminar Rol";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(512, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 28);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar Rol";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblAclaracion
            // 
            lblAclaracion.AutoSize = true;
            lblAclaracion.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAclaracion.Location = new Point(85, 84);
            lblAclaracion.Name = "lblAclaracion";
            lblAclaracion.Size = new Size(122, 13);
            lblAclaracion.TabIndex = 29;
            lblAclaracion.Text = "Indique el rol a eliminar.";
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
            // FormEliminarRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxEliminarRol);
            Name = "FormEliminarRol";
            Text = "FormEliminarRol";
            Load += FormEliminarRol_Load;
            gBoxEliminarRol.ResumeLayout(false);
            gBoxEliminarRol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxEliminarRol;
        private ComboBox cmbRol;
        private Label lblRol;
        private Label lblAclaracion;
        private Button btnEliminar;
        private Button btnVolver;
    }
}