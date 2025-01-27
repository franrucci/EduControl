namespace Vista
{
    partial class FormCuotasMensuales
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
            gBoxCuotasMensuales = new GroupBox();
            btnRegistrarNuevaCuota = new Button();
            dgvCuotasMensuales = new DataGridView();
            btnVolver = new Button();
            gBoxCuotasMensuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasMensuales).BeginInit();
            SuspendLayout();
            // 
            // gBoxCuotasMensuales
            // 
            gBoxCuotasMensuales.Controls.Add(btnRegistrarNuevaCuota);
            gBoxCuotasMensuales.Controls.Add(dgvCuotasMensuales);
            gBoxCuotasMensuales.Location = new Point(12, 12);
            gBoxCuotasMensuales.Name = "gBoxCuotasMensuales";
            gBoxCuotasMensuales.Size = new Size(729, 332);
            gBoxCuotasMensuales.TabIndex = 0;
            gBoxCuotasMensuales.TabStop = false;
            gBoxCuotasMensuales.Text = "Cuotas Mensuales";
            // 
            // btnRegistrarNuevaCuota
            // 
            btnRegistrarNuevaCuota.Location = new Point(482, 22);
            btnRegistrarNuevaCuota.Name = "btnRegistrarNuevaCuota";
            btnRegistrarNuevaCuota.Size = new Size(232, 31);
            btnRegistrarNuevaCuota.TabIndex = 5;
            btnRegistrarNuevaCuota.Text = "Registrar Nueva Cuota";
            btnRegistrarNuevaCuota.UseVisualStyleBackColor = true;
            btnRegistrarNuevaCuota.Click += btnRegistrarNuevaCuota_Click;
            // 
            // dgvCuotasMensuales
            // 
            dgvCuotasMensuales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuotasMensuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotasMensuales.Location = new Point(17, 22);
            dgvCuotasMensuales.Name = "dgvCuotasMensuales";
            dgvCuotasMensuales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuotasMensuales.Size = new Size(433, 290);
            dgvCuotasMensuales.TabIndex = 0;
            dgvCuotasMensuales.SelectionChanged += dgvCiclosAcademicos_SelectionChanged;
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
            // FormCuotasMensuales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxCuotasMensuales);
            Name = "FormCuotasMensuales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuotas Mensuales";
            gBoxCuotasMensuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuotasMensuales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxCuotasMensuales;
        private DataGridView dgvCuotasMensuales;
        private Button btnRegistrarNuevaCuota;
        private Button btnVolver;
    }
}