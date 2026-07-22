using Clases_Logicas;
using System;
using System.Windows.Forms;
using System.IO;

namespace BelleCroissantLyonnaisApp
{
    public partial class FormPerfil : Form
    {
        private readonly PedidoDAO pedidoDAO = new PedidoDAO();
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly string correoUsuario;
        private readonly DireccionDAO direccionDAO = new DireccionDAO();
        private List<Direccion> direccionesActuales = new List<Direccion>();
        private int idUsuarioActual;
        private string rutaImagenSeleccionada = "";

        public FormPerfil(string correo)
        {
            InitializeComponent();
            correoUsuario = correo;
            CargarDatosUsuario();
            CargarDirecciones();
            CargarPedidos();
        }

        private void CargarDirecciones()
        {
            Usuario usuario = usuarioDAO.ObtenerUsuarioPorCorreo(correoUsuario);
            idUsuarioActual = usuario.IdUsuario;

            if (usuario == null)
            {
                MessageBox.Show($"No se encontró un usuario con el correo: '{correoUsuario}'. Verifique que coincida exactamente con el que está en la base de datos.");
                return;
            }

            idUsuarioActual = usuario.IdUsuario;

            direccionesActuales = direccionDAO.ObtenerDireccionesPorUsuario(idUsuarioActual);

            listBoxDirecciones.Items.Clear();
            foreach (var d in direccionesActuales)
            {
                string estrella = d.EsPreferida ? "★ " : "";
                listBoxDirecciones.Items.Add($"{estrella}{d.Etiqueta}: {d.DireccionTexto}, {d.Ciudad}");
            }
        }

        private void listBoxDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDirecciones.SelectedIndex;
            if (index == -1) return;

            Direccion seleccionada = direccionesActuales[index];
            txtDireccionTexto.Text = seleccionada.DireccionTexto;
            txtCodigoPostal.Text = seleccionada.CodigoPostal;
            txtCiudad.Text = seleccionada.Ciudad;
            txtPais.Text = seleccionada.Pais;
            txtEtiqueta.Text = seleccionada.Etiqueta;
            chkEsPreferida.Checked = seleccionada.EsPreferida;
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
            /*
            // --- Imagen de perfil ---
            string rutaImagenPredeterminada = Path.Combine(Application.StartupPath, "Images", "default.png");

            if (!string.IsNullOrEmpty(usuario.Imagen))
            {
                string rutaCompleta = Path.Combine(Application.StartupPath, usuario.Imagen);
                if (File.Exists(rutaCompleta))
                {
                    pictureBoxPerfil.Image = Image.FromFile(rutaCompleta);
                    rutaImagenSeleccionada = usuario.Imagen;
                }
                else
                {
                    // el usuario tiene una ruta guardada pero el archivo ya no existe
                    pictureBoxPerfil.Image = Image.FromFile(rutaImagenPredeterminada);
                    rutaImagenSeleccionada = "";
                }
            }
            else
            {
                // el usuario nunca subió foto
                pictureBoxPerfil.Image = Image.FromFile(rutaImagenPredeterminada);
                rutaImagenSeleccionada = "";
            }

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
            }*/
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

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("idUsuarioActual es: " + idUsuarioActual);

            if (string.IsNullOrWhiteSpace(txtDireccionTexto.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Complete todos los campos de la dirección.");
                return;
            }

            Direccion nueva = new Direccion
            {
                DireccionTexto = txtDireccionTexto.Text.Trim(),
                CodigoPostal = txtCodigoPostal.Text.Trim(),
                Ciudad = txtCiudad.Text.Trim(),
                Pais = txtPais.Text.Trim(),
                Etiqueta = txtEtiqueta.Text.Trim(),
                EsPreferida = chkEsPreferida.Checked
            };

            bool agregada = direccionDAO.AgregarDireccion(idUsuarioActual, nueva);

            if (agregada)
            {
                MessageBox.Show("Dirección agregada.");
                LimpiarCamposDireccion();
                CargarDirecciones();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la dirección.");
            }
        }




        private void LimpiarCamposDireccion()
        {
            txtDireccionTexto.Clear();
            txtCodigoPostal.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
            txtEtiqueta.Clear();
            chkEsPreferida.Checked = false;
        }

        private void btnGuardarDireccion_Click_1(object sender, EventArgs e)
        {

            int index = listBoxDirecciones.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Seleccione una dirección de la lista para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDireccionTexto.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Complete todos los campos de la dirección.");
                return;
            }

            Direccion seleccionada = direccionesActuales[index];
            seleccionada.DireccionTexto = txtDireccionTexto.Text.Trim();
            seleccionada.CodigoPostal = txtCodigoPostal.Text.Trim();
            seleccionada.Ciudad = txtCiudad.Text.Trim();
            seleccionada.Pais = txtPais.Text.Trim();

            bool actualizada = direccionDAO.ActualizarDireccion(seleccionada);

            // Si marcaron/desmarcaron "preferida", actualizarlo aparte
            if (chkEsPreferida.Checked && !seleccionada.EsPreferida)
            {
                direccionDAO.MarcarComoPreferida(idUsuarioActual, seleccionada.IdUsuarioDireccion);
            }

            if (actualizada)
            {
                MessageBox.Show("Dirección actualizada.");
                LimpiarCamposDireccion();
                CargarDirecciones();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la dirección.");
            }
        }

        private void btnEliminarDireccion_Click_1(object sender, EventArgs e)
        {
            int index = listBoxDirecciones.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Seleccione una dirección de la lista para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea eliminar esta dirección?",
                "Confirmar eliminación");

            if (confirmacion == DialogResult.Yes) return;

            Direccion seleccionada = direccionesActuales[index];
            bool eliminada = direccionDAO.EliminarDireccion(seleccionada.IdUsuarioDireccion, seleccionada.IdDireccion);

            if (eliminada)
            {
                MessageBox.Show("Dirección eliminada.");
                LimpiarCamposDireccion();
                CargarDirecciones();

            }
            else
            {
                MessageBox.Show("No se pudo eliminar la dirección.");
            }
        }
        private void CargarPedidos()
        {
            var pedidos = pedidoDAO.ObtenerPedidosPorUsuario(idUsuarioActual);

            listViewPedidos.Items.Clear();
            foreach (var p in pedidos)
            {
                ListViewItem item = new ListViewItem(p.IdPedido.ToString());
                item.SubItems.Add(p.FechaPedido.ToString("dd/MM/yyyy"));
                item.SubItems.Add(p.Total.ToString("C")); // formato de moneda
                item.SubItems.Add(p.NombreEstado);
                listViewPedidos.Items.Add(item);
            }
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string carpetaImagenes = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(carpetaImagenes))
                        Directory.CreateDirectory(carpetaImagenes);

                    string nombreArchivo = correoUsuario + "_" + Path.GetFileName(abrir.FileName);
                    string rutaDestino = Path.Combine(carpetaImagenes, nombreArchivo);

                    File.Copy(abrir.FileName, rutaDestino, true); // copia el archivo, sobrescribe si ya existe

                    pictureBoxPerfil.Image = Image.FromFile(rutaDestino);
                    pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;

                    rutaImagenSeleccionada = Path.Combine("Images", nombreArchivo); // esto es lo que se guarda en la BD
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                }


            }  
        }
    }

}