namespace Vista
{
    partial class FormPagarCuotaMensual
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
            gBoxCuotas = new GroupBox();
            btnPagarCuota = new Button();
            dgvCuotasImpagas = new DataGridView();
            btnVolver = new Button();
            gBoxCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasImpagas).BeginInit();
            SuspendLayout();
            // 
            // gBoxCuotas
            // 
            gBoxCuotas.Controls.Add(btnPagarCuota);
            gBoxCuotas.Controls.Add(dgvCuotasImpagas);
            gBoxCuotas.Location = new Point(12, 12);
            gBoxCuotas.Name = "gBoxCuotas";
            gBoxCuotas.Size = new Size(729, 344);
            gBoxCuotas.TabIndex = 0;
            gBoxCuotas.TabStop = false;
            gBoxCuotas.Text = "Cuotas impagas";
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(491, 22);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(232, 31);
            btnPagarCuota.TabIndex = 2;
            btnPagarCuota.Text = "Pagar Cuota";
            btnPagarCuota.UseVisualStyleBackColor = true;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // dgvCuotasImpagas
            // 
            dgvCuotasImpagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuotasImpagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotasImpagas.Location = new Point(6, 22);
            dgvCuotasImpagas.Name = "dgvCuotasImpagas";
            dgvCuotasImpagas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuotasImpagas.Size = new Size(459, 316);
            dgvCuotasImpagas.TabIndex = 0;
            dgvCuotasImpagas.SelectionChanged += dgvCuotasImpagas_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 566);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormPagarCuotaMensual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxCuotas);
            Name = "FormPagarCuotaMensual";
            Text = "FormPagarCuotaMensual";
            gBoxCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuotasImpagas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxCuotas;
        private DataGridView dgvCuotasImpagas;
        private Button btnVolver;
        private Button btnPagarCuota;
    }
}