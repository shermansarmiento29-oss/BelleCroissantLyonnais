using Clases_Logicas;
using System;
using System.Windows.Forms;

namespace BelleCroissantLyonnaisApp
{
    public partial class FormPerfil : Form
    {
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly string correoUsuario;

        public FormPerfil(string correo)
        {
            InitializeComponent();
            correoUsuario = correo;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            Usuario usuario = usuarioDAO.ObtenerUsuarioPorCorreo(correoUsuario);

            if (usuario == null)
            {
                MessageBox.Show("No se pudo cargar el perfil.");
                this.Close();
                return;
            }

            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtCorreo.Text = usuario.Correo;
            txtTelefono.Text = usuario.Telefono;
            chkSuscripcion.Checked = usuario.Suscripcion;

            // Marcar el radio button correcto según lo guardado
            if (usuario.IdMetodoEntrega != 0)
            {
                var metodos = usuarioDAO.ObtenerMetodosEntrega();
                foreach (var m in metodos)
                {
                    if (m.IdMetodoEntrega == usuario.IdMetodoEntrega)
                    {
                        if (m.NombreMetodo == "Recogida") radioRecogida.Checked = true;
                        else if (m.NombreMetodo == "Entrega") radioEntrega.Checked = true;
                    }
                }
            }
        }

    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatosUsuario(); // descarta cambios, recarga los datos originales


            this.Close();
            

            FormLogin formulario = new FormLogin();
            formulario.Show();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            lblMensaje.ForeColor = System.Drawing.Color.Red;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                lblMensaje.Text = "Nombre y apellido son obligatorios.";
                return;
            }

            int idMetodo = 0;
            var metodos = usuarioDAO.ObtenerMetodosEntrega();
            foreach (var m in metodos)
            {
                if (radioRecogida.Checked && m.NombreMetodo == "Recogida") idMetodo = m.IdMetodoEntrega;
                if (radioEntrega.Checked && m.NombreMetodo == "Entrega") idMetodo = m.IdMetodoEntrega;
            }

            Usuario usuarioActualizado = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Correo = correoUsuario,
                Telefono = txtTelefono.Text.Trim(),
                Imagen = "", 
                Suscripcion = chkSuscripcion.Checked,
                IdMetodoEntrega = idMetodo
            };

            bool actualizado = usuarioDAO.ActualizarPerfil(usuarioActualizado);

            if (actualizado)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "Perfil actualizado correctamente.";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el perfil.";
            }
        }
    }
}