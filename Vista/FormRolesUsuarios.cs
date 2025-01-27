using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Vista
{
    public partial class FormRolesUsuarios : Form
    {
        private bool EsNuevoRol; // Define si se trata de un nuevo rol
        private int? RolId; // ID del rol a modificar (nullable)
        public FormRolesUsuarios()
        {
            InitializeComponent();
            EsNuevoRol = true; // Indica que se está creando un nuevo rol
            RolId = null; // No hay rol asociado todavía
        }

        public FormRolesUsuarios(int rolId)
        {
            InitializeComponent();
            EsNuevoRol = false; // Indica que se está modificando un rol
            RolId = rolId; // Asigna el ID del rol a modificar
        }

        private void CargarRol(int rolId)
        {
            // Obtener los permisos asociados al rol
            var permisos = ControladoraPermisos.Instancia.ObtenerPermisosPorRol(rolId);

            // Marcar los checkboxes correspondientes
            foreach (Control control in gBoxControles.Controls)
            {
                if (control is CheckBox chkBox)
                {
                    var opcionId = Convert.ToInt32(chkBox.Tag);
                    var permiso = permisos.FirstOrDefault(p => p.OpcionId == opcionId);

                    if (permiso != null)
                    {
                        chkBox.Checked = permiso.Permitido; // Marca según el permiso
                    }
                }
            }

            // Opcional: Cargar el nombre del rol en el TextBox
            var rol = ControladoraRoles.Instancia.ObtenerRolPorId(rolId);
            if (rol != null)
            {
                txtUsuario.Text = rol.RolNombre;
            }
        }


        private void CheckRol()
        {
            int rolId = ControladoraRoles.Instancia.ObtenerIdPorNombre(txtUsuario.Text);

            // Elimina los permisos anteriores del rol
            ControladoraPermisos.Instancia.EliminarPermisosPorRol(rolId);

            // Recorre los CheckBox y guarda los permisos actualizados
            foreach (Control control in gBoxControles.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Tag != null)
                {
                    if (int.TryParse(checkBox.Tag.ToString(), out int opcionId))
                    {
                        Permiso permisoEntidad = new Permiso
                        {
                            RolUsuarioId = rolId,
                            OpcionId = opcionId,
                            Permitido = checkBox.Checked
                        };

                        // Guarda el permiso
                        ControladoraPermisos.Instancia.GuardarPermiso(permisoEntidad);
                    }
                }
            }
        }


        private void Limpiar()
        {
            // Limpiar el TextBox y darle el foco
            txtUsuario.Text = string.Empty;
            txtUsuario.Focus();

            // Reemplazar panel1.Controls por groupBox.Controls
            foreach (Control chk in gBoxControles.Controls) // Asegúrate de que 'groupBox' sea el nombre del GroupBox
            {
                if (chk is System.Windows.Forms.CheckBox)
                {
                    // Desmarcar los CheckBox
                    if (((System.Windows.Forms.CheckBox)chk).Checked)
                        ((System.Windows.Forms.CheckBox)chk).Checked = false;
                }
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el rol.");
                return false;
            }

            bool nombreRepetido = ControladoraRoles.Instancia.ValidarNombre(txtUsuario.Text, RolId);
            if (nombreRepetido)
            {
                MessageBox.Show("El nombre del rol ya existe.");
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (RolId.HasValue)  // Si estamos editando un rol
                {
                    // Modificar un rol existente
                    ControladoraRoles.Instancia.ModificarRol(RolId.Value, txtUsuario.Text);  // Asegúrate de implementar el método ModificarRol en ControladoraRoles
                }
                else
                {
                    // Agregar un nuevo rol
                    // Guarda el nuevo rol y asigna su ID
                    RolId = ControladoraRoles.Instancia.GuardarRol(txtUsuario.Text);  // Asume que GuardarRol retorna el ID del nuevo rol
                }

                // Después de guardar el rol, guarda los permisos
                CheckRol();

                // Limpiar los campos
                Limpiar();

                MessageBox.Show("Rol de usuario guardado");
            }
        }


        private void GuardarPermisos()
        {
            if (RolId.HasValue)
            {
                // Eliminar permisos existentes para este rol
                ControladoraPermisos.Instancia.EliminarPermisosPorRol(RolId.Value);
            }

            // Guardar los nuevos permisos
            foreach (Control control in gBoxControles.Controls)
            {
                if (control is CheckBox chkBox)
                {
                    var permiso = new Permiso
                    {
                        RolUsuarioId = RolId.Value,
                        OpcionId = Convert.ToInt32(chkBox.Tag),
                        Permitido = chkBox.Checked
                    };

                    ControladoraPermisos.Instancia.GuardarPermiso(permiso);
                }
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chBoxEnviarEmail_CheckedChanged(object sender, EventArgs e)
        {
            // Asegurar que el otro CheckBox esté sincronizado
            chBoxEnviarEmail1.Checked = chBoxEnviarEmail.Checked;
        }

        private void chBoxEnviarEmail1_CheckedChanged(object sender, EventArgs e)
        {
            // Asegurar que el otro CheckBox esté sincronizado
            chBoxEnviarEmail.Checked = chBoxEnviarEmail1.Checked;
        }

        private void chBoxDatosPersonales_CheckedChanged(object sender, EventArgs e)
        {
            // Asegurar que el otro CheckBox esté sincronizado
            chBoxDatosPersonales1.Checked = chBoxDatosPersonales.Checked;
        }

        private void chBoxDatosPersonales1_CheckedChanged(object sender, EventArgs e)
        {
            // Asegurar que el otro CheckBox esté sincronizado
            chBoxDatosPersonales.Checked = chBoxDatosPersonales1.Checked;
        }

        private void chBoxInformacionAcademica_CheckedChanged(object sender, EventArgs e)
        {
            chBoxInformacionAcademica1.Checked = chBoxInformacionAcademica.Checked;
        }

        private void chBoxInformacionAcademica1_CheckedChanged(object sender, EventArgs e)
        {
            chBoxInformacionAcademica.Checked = chBoxInformacionAcademica1.Checked;
        }

        private void gBoxControles_Paint(object sender, PaintEventArgs e)
        {
            // Evita que se dibuje el borde del GroupBox
            e.Graphics.Clear(gBoxControles.BackColor);
        }

        private void FormRolesUsuarios_Load(object sender, EventArgs e)
        {
            if (!EsNuevoRol && RolId.HasValue)
            {
                // Cargar los datos del rol existente
                CargarRol(RolId.Value);
            }
        }
    }
}