namespace Vista
{
    partial class FormGrados
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
            gBoxGrados = new GroupBox();
            btnSeleccionar = new Button();
            dgvGrados = new DataGridView();
            btnVolver = new Button();
            gBoxGrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrados).BeginInit();
            SuspendLayout();
            // 
            // gBoxGrados
            // 
            gBoxGrados.Controls.Add(btnSeleccionar);
            gBoxGrados.Controls.Add(dgvGrados);
            gBoxGrados.Location = new Point(12, 12);
            gBoxGrados.Name = "gBoxGrados";
            gBoxGrados.Size = new Size(729, 318);
            gBoxGrados.TabIndex = 0;
            gBoxGrados.TabStop = false;
            gBoxGrados.Text = "N° Grado";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(328, 283);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(75, 23);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // dgvGrados
            // 
            dgvGrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrados.Location = new Point(6, 22);
            dgvGrados.Name = "dgvGrados";
            dgvGrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrados.Size = new Size(717, 248);
            dgvGrados.TabIndex = 0;
            dgvGrados.SelectionChanged += dgvGrados_SelectionChanged;
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
            // FormGrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxGrados);
            Name = "FormGrados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grados";
            gBoxGrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxGrados;
        private Button btnSeleccionar;
        private DataGridView dgvGrados;
        private Button btnVolver;
    }
}