using Modelo.Patron_Strategy;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        private SistemaColegio sistemaColegio;
        private static ControladoraUsuarios instancia;

        public static ControladoraUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraUsuarios();
                }
                return instancia;
            }
        }

        ControladoraUsuarios()
        {
            sistemaColegio = new SistemaColegio();
        }

        public List<Usuario> BuscarUsuario(string pUser, string pPas)
        {
            try
            {
                // Obtengo el usuario por nombre
                var usuario = sistemaColegio.Usuarios.FirstOrDefault(us => us.Usuario1 == pUser);

                if (usuario == null)
                {
                    return new List<Usuario>(); // Usuario no encontrado
                }

                // Verifica si pPas es un token válido
                if (EsTokenValido(pPas, usuario))
                {
                    return new List<Usuario> { usuario }; // Token válido
                }
                else
                {
                    // Verifica el hash de la contraseña ingresada
                    string hashIngresado = GenerarHash(pPas, usuario.Salt);
                    if (usuario.Password == hashIngresado)
                    {
                        return new List<Usuario> { usuario }; // Contraseña válida
                    }
                    else
                    {
                        return new List<Usuario>(); // Contraseña incorrecta
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar usuario: {ex.Message}", ex);
            }
        }

        private bool EsTokenValido(string tokenIngresado, Usuario usuario)
        {
            // Encripta el token ingresado
            string tokenEncriptadoIngresado = GenerarHash(tokenIngresado, usuario.Salt);

            // Compara el token ingresado con el token guardado en la base de datos
            return tokenEncriptadoIngresado == usuario.Token;
        }

        public string GuardarUsuario(Usuario pUsuario)
        {
            try
            {
                // Verifica si el nombre de usuario ya existe
                bool usuarioExiste = sistemaColegio.Usuarios.Any(u => u.Usuario1 == pUsuario.Usuario1);
                if (usuarioExiste)
                {
                    return "Error: Debe elegir otro nombre de usuario.";
                }

                // Verifica si el email ya existe
                bool emailExiste = sistemaColegio.Usuarios.Any(u => u.Email == pUsuario.Email);
                if (emailExiste)
                {
                    return "Error: El email ya está registrado.";
                }

                // Genera un salt único
                string salt = GenerarSalt();
                pUsuario.Salt = salt;

                // Genera hash de la contraseña
                pUsuario.Password = GenerarHash(pUsuario.Password, salt);

                sistemaColegio.Usuarios.Add(pUsuario);
                sistemaColegio.SaveChanges();

                return "El usuario se agregó correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el usuario: {ex.Message}";
            }
        }

        public Usuario RetornarUsuario(int usuId)
        {
            try
            {
                return sistemaColegio.Usuarios.FirstOrDefault(x => x.UsuarioId == usuId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar usuario: {ex.Message}", ex);
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            try
            {
                return sistemaColegio.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ValidarUsuario(string usuario, int usuarioId)
        {
            try
            {
                // Busca si ya existe el nombre de usuario, pero omitir el usuario actual
                var usuarioExistente = sistemaColegio.Usuarios
                    .FirstOrDefault(u => u.Usuario1 == usuario && u.UsuarioId != usuarioId);

                // Si se encuentra un usuario con el mismo nombre y diferente Id, es inválido
                if (usuarioExistente != null)
                {
                    return false; // Nombre de usuario ya existe
                }

                return true; // Nombre de usuario válido
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al validar el usuario: {ex.Message}");
                return false;
            }
        }

        public bool ValidarEmail(string email, int usuarioId)
        {
            try
            {
                // Busca si ya existe un correo electrónico, pero omitir el correo del usuario actual
                var emailExistente = sistemaColegio.Usuarios
                    .FirstOrDefault(u => u.Email == email && u.UsuarioId != usuarioId);

                // Si se encuentra un usuario con el mismo correo y diferente Id, es inválido
                if (emailExistente != null)
                {
                    return false; // Correo electrónico ya existe
                }
                return true; // Correo electrónico válido
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al validar el email: {ex.Message}");
                return false;
            }
        }

        public string ModificarUsuario(Usuario usuario, string contraseña)
        {
            try
            {
                var usuarioExistente = sistemaColegio.Usuarios.FirstOrDefault(x => x.UsuarioId == usuario.UsuarioId);
                if (usuarioExistente == null)
                {
                    return "El usuario no fue encontrado en el sistema.";
                }

                // Actualiza los datos personales que pueden cambiar
                usuarioExistente.Usuario1 = usuario.Usuario1;

                // Verifica si la contraseña fue cambiada
                if (!string.IsNullOrEmpty(contraseña) && contraseña != usuarioExistente.Password)
                {
                    // Si la contraseña fue modificada, generamos un nuevo salt
                    var salt = GenerarSalt();

                    // Genera el hash con el salt y la nueva contraseña
                    var hash = GenerarHash(contraseña, salt);  

                    // Asigna la contraseña encriptada junto con el salt al usuario
                    usuarioExistente.Password = hash;
                    usuarioExistente.Salt = salt;
                }

                // Actualiza el rol
                usuarioExistente.RolId = usuario.RolId;

                sistemaColegio.SaveChanges();

                return "El usuario se modificó correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al intentar modificar al usuario: {ex.Message}";
            }
        }

        public string ModificarContraseña(Usuario usuario)
        {
            try
            {
                var usuarioExistente = sistemaColegio.Usuarios.FirstOrDefault(x => x.UsuarioId == usuario.UsuarioId);

                if (usuarioExistente == null)
                {
                    return "El usuario no fue encontrado en el sistema.";
                }

                // Verifica si la contraseña fue cambiada
                if (!string.IsNullOrEmpty(usuario.Password))
                {
                    // Si la contraseña fue modificada, generamos un nuevo salt
                    var salt = GenerarSalt();

                    // Generamos el hash con el salt y la nueva contraseña
                    var hash = GenerarHash(usuario.Password, salt);  

                    // Asigna la contraseña encriptada y el salt al usuario
                    usuarioExistente.Password = hash;
                    usuarioExistente.Salt = salt;
                }

                // Elimina el token asociado al usuario, ya que la contraseña ha sido modificada
                usuarioExistente.Token = null;

                sistemaColegio.SaveChanges();

                return "La contraseña se modificó correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al intentar modificar la contraseña: {ex.Message}";
            }
        }

        public string EliminarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = sistemaColegio.Usuarios.FirstOrDefault(x => x.UsuarioId == usuario.UsuarioId);
                if (usuarioExistente == null)
                {
                    return "El usuario no fue encontrado en el sistema.";
                }

                sistemaColegio.Usuarios.Remove(usuarioExistente);
                sistemaColegio.SaveChanges();

                return "Usuario eliminado con éxito.";
            }
            catch (Exception ex)
            {
                return $"Error al intentar modificar al usuario: {ex.Message}";
            }
        }

        // Genera un hash con SHA-256
        public string GenerarHash(string contraseña, string salt)
        {
            try
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    string contraseñaConSalt = contraseña + salt;
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseñaConSalt));
                    StringBuilder resultado = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        resultado.Append(b.ToString("x2"));
                    }
                    return resultado.ToString();
                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }

        // Genera un salt aleatorio
        public string GenerarSalt()
        {
            try
            {
                byte[] saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                return Convert.ToBase64String(saltBytes);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método para generar un token de recuperación
        public string GenerarToken()
        {
            try
            {
                // Generar un token aleatorio de 5 dígitos
                Random random = new Random();
                string token = random.Next(10000, 99999).ToString();

                return token;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método para encriptar el token usando el salt del usuario
        public string EncriptarToken(string token, string salt)
        {
            try
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    string tokenConSalt = token + salt;
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(tokenConSalt));
                    StringBuilder resultado = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        resultado.Append(b.ToString("x2"));
                    }
                    return resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Usuario BuscarUsuarioPorEmail(string email)
        {
            try
            {
                return sistemaColegio.Usuarios.FirstOrDefault(us => us.Email == email);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar usuario por correo: {ex.Message}", ex);
            }
        }

        // Método para actualizar un usuario con un nuevo token
        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                Usuario usuarioExistente = sistemaColegio.Usuarios.FirstOrDefault(u => u.UsuarioId == usuario.UsuarioId);

                if (usuarioExistente != null)
                {
                    // Actualiza el token
                    usuarioExistente.Token = usuario.Token;

                    sistemaColegio.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}", ex);
            }
        }

        public bool VerUsuariosConRol(int rolId)
        {
            try
            {
                // Verifica si existe al menos un usuario con el RolId especificado
                var existeUsuarioConRol = sistemaColegio.Usuarios.Any(x => x.RolId == rolId);

                return existeUsuarioConRol;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar verificar los usuarios con el RolId.", ex);
            }
        }
    }
}
