namespace Vista
{
    partial class FormModificarAlumno
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
            gBoxModificarAlumno = new GroupBox();
            cmbGradoAcademico = new ComboBox();
            lblGradoAcademico = new Label();
            btnAceptar = new Button();
            cmbSexo = new ComboBox();
            dtpFechaDeNacimiento = new DateTimePicker();
            txtEmail = new TextBox();
            txtPais = new TextBox();
            txtProvincia = new TextBox();
            txtCodigoPostal = new TextBox();
            txtLocalidad = new TextBox();
            txtDomicilio = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblSexo = new Label();
            lblEmail = new Label();
            lblPais = new Label();
            lblProvincia = new Label();
            lblCodigoPostal = new Label();
            lblLocalidad = new Label();
            lblDomicilio = new Label();
            lblFechaDeNacimiento = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnVolver = new Button();
            gBoxModificarAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxModificarAlumno
            // 
            gBoxModificarAlumno.Controls.Add(cmbGradoAcademico);
            gBoxModificarAlumno.Controls.Add(lblGradoAcademico);
            gBoxModificarAlumno.Controls.Add(btnAceptar);
            gBoxModificarAlumno.Controls.Add(cmbSexo);
            gBoxModificarAlumno.Controls.Add(dtpFechaDeNacimiento);
            gBoxModificarAlumno.Controls.Add(txtEmail);
            gBoxModificarAlumno.Controls.Add(txtPais);
            gBoxModificarAlumno.Controls.Add(txtProvincia);
            gBoxModificarAlumno.Controls.Add(txtCodigoPostal);
            gBoxModificarAlumno.Controls.Add(txtLocalidad);
            gBoxModificarAlumno.Controls.Add(txtDomicilio);
            gBoxModificarAlumno.Controls.Add(txtDni);
            gBoxModificarAlumno.Controls.Add(txtApellido);
            gBoxModificarAlumno.Controls.Add(txtNombre);
            gBoxModificarAlumno.Controls.Add(lblSexo);
            gBoxModificarAlumno.Controls.Add(lblEmail);
            gBoxModificarAlumno.Controls.Add(lblPais);
            gBoxModificarAlumno.Controls.Add(lblProvincia);
            gBoxModificarAlumno.Controls.Add(lblCodigoPostal);
            gBoxModificarAlumno.Controls.Add(lblLocalidad);
            gBoxModificarAlumno.Controls.Add(lblDomicilio);
            gBoxModificarAlumno.Controls.Add(lblFechaDeNacimiento);
            gBoxModificarAlumno.Controls.Add(lblDni);
            gBoxModificarAlumno.Controls.Add(lblApellido);
            gBoxModificarAlumno.Controls.Add(lblNombre);
            gBoxModificarAlumno.Location = new Point(12, 12);
            gBoxModificarAlumno.Name = "gBoxModificarAlumno";
            gBoxModificarAlumno.Size = new Size(729, 300);
            gBoxModificarAlumno.TabIndex = 0;
            gBoxModificarAlumno.TabStop = false;
            gBoxModificarAlumno.Text = "Modificar Alumno";
            // 
            // cmbGradoAcademico
            // 
            cmbGradoAcademico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradoAcademico.FormattingEnabled = true;
            cmbGradoAcademico.Location = new Point(452, 196);
            cmbGradoAcademico.Name = "cmbGradoAcademico";
            cmbGradoAcademico.Size = new Size(233, 23);
            cmbGradoAcademico.TabIndex = 49;
            // 
            // lblGradoAcademico
            // 
            lblGradoAcademico.AutoSize = true;
            lblGradoAcademico.Location = new Point(404, 199);
            lblGradoAcademico.Name = "lblGradoAcademico";
            lblGradoAcademico.Size = new Size(42, 15);
            lblGradoAcademico.TabIndex = 48;
            lblGradoAcademico.Text = "Grado:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(323, 257);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 47;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(452, 163);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(233, 23);
            cmbSexo.TabIndex = 46;
            // 
            // dtpFechaDeNacimiento
            // 
            dtpFechaDeNacimiento.Location = new Point(92, 131);
            dtpFechaDeNacimiento.MaxDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            dtpFechaDeNacimiento.Size = new Size(233, 23);
            dtpFechaDeNacimiento.TabIndex = 45;
            dtpFechaDeNacimiento.Value = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(452, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 44;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(452, 102);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(233, 23);
            txtPais.TabIndex = 43;
            txtPais.KeyPress += txtPais_KeyPress;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(452, 69);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(233, 23);
            txtProvincia.TabIndex = 42;
            txtProvincia.KeyPress += txtProvincia_KeyPress;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(452, 34);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(233, 23);
            txtCodigoPostal.TabIndex = 41;
            txtCodigoPostal.KeyPress += txtCodigoPostal_KeyPress;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(92, 196);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(233, 23);
            txtLocalidad.TabIndex = 40;
            txtLocalidad.KeyPress += txtLocalidad_KeyPress;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(92, 163);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(233, 23);
            txtDomicilio.TabIndex = 39;
            txtDomicilio.KeyPress += txtDomicilio_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(92, 102);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(233, 23);
            txtDni.TabIndex = 38;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(92, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 23);
            txtApellido.TabIndex = 37;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 36;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(408, 166);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 35;
            lblSexo.Text = "Sexo:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(404, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email:";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(412, 105);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 33;
            lblPais.Text = "Pais:";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(384, 72);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(59, 15);
            lblProvincia.TabIndex = 32;
            lblProvincia.Text = "Provincia:";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(359, 37);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(84, 15);
            lblCodigoPostal.TabIndex = 31;
            lblCodigoPostal.Text = "Código postal:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(25, 199);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 30;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(25, 166);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(61, 15);
            lblDomicilio.TabIndex = 29;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblFechaDeNacimiento
            // 
            lblFechaDeNacimiento.AutoSize = true;
            lblFechaDeNacimiento.Location = new Point(14, 133);
            lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            lblFechaDeNacimiento.Size = new Size(72, 15);
            lblFechaDeNacimiento.TabIndex = 28;
            lblFechaDeNacimiento.Text = "Nacimiento:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(53, 105);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 15);
            lblDni.TabIndex = 27;
            lblDni.Text = "DNI: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 72);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 26;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre:";
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
            // FormModificarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(gBoxModificarAlumno);
            Name = "FormModificarAlumno";
            Text = "FormModificarAlumno";
            gBoxModificarAlumno.ResumeLayout(false);
            gBoxModificarAlumno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxModificarAlumno;
        private ComboBox cmbGradoAcademico;
        private Label lblGradoAcademico;
        private Button btnAceptar;
        private ComboBox cmbSexo;
        private DateTimePicker dtpFechaDeNacimiento;
        private TextBox txtEmail;
        private TextBox txtPais;
        private TextBox txtProvincia;
        private TextBox txtCodigoPostal;
        private TextBox txtLocalidad;
        private TextBox txtDomicilio;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblSexo;
        private Label lblEmail;
        private Label lblPais;
        private Label lblProvincia;
        private Label lblCodigoPostal;
        private Label lblLocalidad;
        private Label lblDomicilio;
        private Label lblFechaDeNacimiento;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnVolver;
    }
}