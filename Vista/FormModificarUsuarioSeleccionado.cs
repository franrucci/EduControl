using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormModificarUsuarioSeleccionado : Form
    {
        Usuario usuario;
        public FormModificarUsuarioSeleccionado(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombreUsuario.Text = usuario.Usuario1;
            txtContraseña.Text = ""; // No mostrar la contraseña (campo vacío)
            txtContraseña.PasswordChar = '*'; // Mostrar como asteriscos
            txtEmail.Text = usuario.Email;
            CargarCombo();

            // Buscar y seleccionar el rol correspondiente al usuario
            foreach (var item in cmbRol.Items)
            {
                if (((RolUsuario)item).RolUsuarioId == usuario.RolId) // Comparar por RolUsuarioId o cualquier propiedad única
                {
                    cmbRol.SelectedItem = item;
                    break;
                }
            }
        }

        private void CargarCombo()
        {
            try
            {
                var Lst = ControladoraRoles.Instancia.ComboRol();
                cmbRol.DataSource = Lst;
                cmbRol.DisplayMember = "RolNombre";
                cmbRol.ValueMember = "RolUsuarioId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario.");
                return false;
            }
            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el rol.");
                return false;
            }
            return true;
        }

        /*
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                usuario.Usuario1 = txtNombreUsuario.Text;
                usuario.Password = txtContraseña.Text;
                usuario.RolId = (int)cmbRol.SelectedValue;
                var mensaje = ControladoraUsuarios.Instancia.ModificarUsuario(usuario);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }
        */


        /*
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool usuarioValido = ControladoraUsuarios.Instancia.ValidarUsuario(txtNombreUsuario.Text, usuario.UsuarioId);
            bool emailValido = ControladoraUsuarios.Instancia.ValidarEmail(txtEmail.Text, usuario.UsuarioId);
            if (ValidarDatos())
            {
                if (usuarioValido)
                {
                    if (emailValido)
                    {
                        // Crear un nuevo objeto Usuario con los datos modificados
                        usuario.Usuario1 = txtNombreUsuario.Text;

                        usuario.Password = txtContraseña.Text;
                        
                        // Si la contraseña está vacía, no se modifica; si no, se asigna la nueva
                        if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
                        {
                            usuario.Password = txtContraseña.Text; // Nueva contraseña que el usuario ha ingresado
                        }
                        else
                        {
                            usuario.Password = usuario.Password; // No modificar la contraseña si no se ha ingresado nada
                        }
                        
                        usuario.RolId = (int)cmbRol.SelectedValue;

                        // Llamar al método ModificarUsuario en la controladora
                        var mensaje = ControladoraUsuarios.Instancia.ModificarUsuario(usuario);
                        MessageBox.Show(mensaje);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error: El E-mail ya está registrado en el sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Debe elegir otro nombre de usuario.");
                }
                
            }
        }
        */
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool usuarioValido = ControladoraUsuarios.Instancia.ValidarUsuario(txtNombreUsuario.Text, usuario.UsuarioId);
            bool emailValido = ControladoraUsuarios.Instancia.ValidarEmail(txtEmail.Text, usuario.UsuarioId);

            if (ValidarDatos())
            {
                if (usuarioValido)
                {
                    if (emailValido)
                    {
                        // Crear un nuevo objeto Usuario con los datos modificados
                        usuario.Usuario1 = txtNombreUsuario.Text;

                        // Obtener la nueva contraseña ingresada por el usuario
                        // Si no se ha ingresado nada, se pasa una cadena vacía
                        string nuevaContraseña = string.IsNullOrWhiteSpace(txtContraseña.Text) ? string.Empty : txtContraseña.Text;

                        usuario.RolId = (int)cmbRol.SelectedValue;

                        // Llamar al método ModificarUsuario en la controladora, pasando la nueva contraseña
                        var mensaje = ControladoraUsuarios.Instancia.ModificarUsuario(usuario, nuevaContraseña);
                        MessageBox.Show(mensaje);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: El E-mail ya está registrado en el sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Debe elegir otro nombre de usuario.");
                }
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
