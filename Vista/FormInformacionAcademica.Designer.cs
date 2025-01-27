namespace Vista
{
    partial class FormInformacionAcademica
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
            gBoxInformacionAcademica = new GroupBox();
            btnDescargar = new Button();
            dgvBoletines = new DataGridView();
            btnVolver = new Button();
            gBoxInformacionAcademica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBoletines).BeginInit();
            SuspendLayout();
            // 
            // gBoxInformacionAcademica
            // 
            gBoxInformacionAcademica.Controls.Add(btnDescargar);
            gBoxInformacionAcademica.Controls.Add(dgvBoletines);
            gBoxInformacionAcademica.Location = new Point(12, 12);
            gBoxInformacionAcademica.Name = "gBoxInformacionAcademica";
            gBoxInformacionAcademica.Size = new Size(729, 368);
            gBoxInformacionAcademica.TabIndex = 0;
            gBoxInformacionAcademica.TabStop = false;
            gBoxInformacionAcademica.Text = "Boletines";
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(318, 330);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 23);
            btnDescargar.TabIndex = 1;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // dgvBoletines
            // 
            dgvBoletines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBoletines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoletines.Location = new Point(6, 22);
            dgvBoletines.Name = "dgvBoletines";
            dgvBoletines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoletines.Size = new Size(717, 291);
            dgvBoletines.TabIndex = 0;
            dgvBoletines.SelectionChanged += dgvBoletines_SelectionChanged;
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
            // FormInformacionAcademica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxInformacionAcademica);
            Name = "FormInformacionAcademica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Información académica";
            gBoxInformacionAcademica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBoletines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxInformacionAcademica;
        private Button btnVolver;
        private Button btnDescargar;
        private DataGridView dgvBoletines;
    }
}