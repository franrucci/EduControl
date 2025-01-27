namespace Vista
{
    partial class FormAgregarNuevoAlumno
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
            gBoxNuevoAlumno = new GroupBox();
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
            btnRegistrarAlumnoExistente = new Button();
            btnVolver = new Button();
            gBoxNuevoAlumno.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxNuevoAlumno
            // 
            gBoxNuevoAlumno.Controls.Add(cmbGradoAcademico);
            gBoxNuevoAlumno.Controls.Add(lblGradoAcademico);
            gBoxNuevoAlumno.Controls.Add(btnAceptar);
            gBoxNuevoAlumno.Controls.Add(cmbSexo);
            gBoxNuevoAlumno.Controls.Add(dtpFechaDeNacimiento);
            gBoxNuevoAlumno.Controls.Add(txtEmail);
            gBoxNuevoAlumno.Controls.Add(txtPais);
            gBoxNuevoAlumno.Controls.Add(txtProvincia);
            gBoxNuevoAlumno.Controls.Add(txtCodigoPostal);
            gBoxNuevoAlumno.Controls.Add(txtLocalidad);
            gBoxNuevoAlumno.Controls.Add(txtDomicilio);
            gBoxNuevoAlumno.Controls.Add(txtDni);
            gBoxNuevoAlumno.Controls.Add(txtApellido);
            gBoxNuevoAlumno.Controls.Add(txtNombre);
            gBoxNuevoAlumno.Controls.Add(lblSexo);
            gBoxNuevoAlumno.Controls.Add(lblEmail);
            gBoxNuevoAlumno.Controls.Add(lblPais);
            gBoxNuevoAlumno.Controls.Add(lblProvincia);
            gBoxNuevoAlumno.Controls.Add(lblCodigoPostal);
            gBoxNuevoAlumno.Controls.Add(lblLocalidad);
            gBoxNuevoAlumno.Controls.Add(lblDomicilio);
            gBoxNuevoAlumno.Controls.Add(lblFechaDeNacimiento);
            gBoxNuevoAlumno.Controls.Add(lblDni);
            gBoxNuevoAlumno.Controls.Add(lblApellido);
            gBoxNuevoAlumno.Controls.Add(lblNombre);
            gBoxNuevoAlumno.Location = new Point(12, 12);
            gBoxNuevoAlumno.Name = "gBoxNuevoAlumno";
            gBoxNuevoAlumno.Size = new Size(428, 501);
            gBoxNuevoAlumno.TabIndex = 0;
            gBoxNuevoAlumno.TabStop = false;
            gBoxNuevoAlumno.Text = "Nuevo alumno";
            // 
            // cmbGradoAcademico
            // 
            cmbGradoAcademico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradoAcademico.FormattingEnabled = true;
            cmbGradoAcademico.Location = new Point(100, 388);
            cmbGradoAcademico.Name = "cmbGradoAcademico";
            cmbGradoAcademico.Size = new Size(233, 23);
            cmbGradoAcademico.TabIndex = 24;
            // 
            // lblGradoAcademico
            // 
            lblGradoAcademico.AutoSize = true;
            lblGradoAcademico.Location = new Point(59, 392);
            lblGradoAcademico.Name = "lblGradoAcademico";
            lblGradoAcademico.Size = new Size(42, 15);
            lblGradoAcademico.TabIndex = 23;
            lblGradoAcademico.Text = "Grado:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(172, 452);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(100, 350);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(233, 23);
            cmbSexo.TabIndex = 21;
            // 
            // dtpFechaDeNacimiento
            // 
            dtpFechaDeNacimiento.Location = new Point(100, 125);
            dtpFechaDeNacimiento.MaxDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            dtpFechaDeNacimiento.Size = new Size(233, 23);
            dtpFechaDeNacimiento.TabIndex = 20;
            dtpFechaDeNacimiento.Value = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 318);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 19;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(100, 289);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(233, 23);
            txtPais.TabIndex = 18;
            txtPais.KeyPress += txtPais_KeyPress;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(100, 254);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(233, 23);
            txtProvincia.TabIndex = 17;
            txtProvincia.KeyPress += txtProvincia_KeyPress;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(100, 221);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(233, 23);
            txtCodigoPostal.TabIndex = 16;
            txtCodigoPostal.KeyPress += txtCodigoPostal_KeyPress;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(100, 190);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(233, 23);
            txtLocalidad.TabIndex = 15;
            txtLocalidad.KeyPress += txtLocalidad_KeyPress;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(100, 157);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(233, 23);
            txtDomicilio.TabIndex = 14;
            txtDomicilio.KeyPress += txtDomicilio_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(100, 96);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(233, 23);
            txtDni.TabIndex = 13;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(100, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 23);
            txtApellido.TabIndex = 12;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 11;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(59, 353);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(55, 320);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(63, 292);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 8;
            lblPais.Text = "Pais:";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(35, 257);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(59, 15);
            lblProvincia.TabIndex = 7;
            lblProvincia.Text = "Provincia:";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(10, 224);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(84, 15);
            lblCodigoPostal.TabIndex = 6;
            lblCodigoPostal.Text = "Código postal:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(33, 193);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(61, 15);
            lblLocalidad.TabIndex = 5;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(33, 160);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(61, 15);
            lblDomicilio.TabIndex = 4;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblFechaDeNacimiento
            // 
            lblFechaDeNacimiento.AutoSize = true;
            lblFechaDeNacimiento.Location = new Point(22, 127);
            lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            lblFechaDeNacimiento.Size = new Size(72, 15);
            lblFechaDeNacimiento.TabIndex = 3;
            lblFechaDeNacimiento.Text = "Nacimiento:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(61, 99);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(40, 66);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnRegistrarAlumnoExistente
            // 
            btnRegistrarAlumnoExistente.Location = new Point(457, 37);
            btnRegistrarAlumnoExistente.Name = "btnRegistrarAlumnoExistente";
            btnRegistrarAlumnoExistente.Size = new Size(284, 56);
            btnRegistrarAlumnoExistente.TabIndex = 1;
            btnRegistrarAlumnoExistente.Text = "REGISTRAR ALUMNO EXISTENTE";
            btnRegistrarAlumnoExistente.UseVisualStyleBackColor = true;
            btnRegistrarAlumnoExistente.Click += btnRegistrarAlumnoExistente_Click;
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
            // FormAgregarNuevoAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 601);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarAlumnoExistente);
            Controls.Add(gBoxNuevoAlumno);
            Name = "FormAgregarNuevoAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar nuevo alumno";
            gBoxNuevoAlumno.ResumeLayout(false);
            gBoxNuevoAlumno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxNuevoAlumno;
        private Label lblCodigoPostal;
        private Label lblLocalidad;
        private Label lblDomicilio;
        private Label lblFechaDeNacimiento;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
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
        private DateTimePicker dtpFechaDeNacimiento;
        private ComboBox cmbSexo;
        private Button btnAceptar;
        private Label lblGradoAcademico;
        private ComboBox cmbGradoAcademico;
        private Button btnRegistrarAlumnoExistente;
        private Button btnVolver;
    }
}