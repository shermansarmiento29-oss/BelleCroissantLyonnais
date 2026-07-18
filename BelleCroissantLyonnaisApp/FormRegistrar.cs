using Clases_Logicas;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BelleCroissantLyonnaisApp
{
    public partial class FormRegistrar : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public FormRegistrar()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            comboBox1.DataSource = usuarioDAO.ObtenerPreguntasCatalogo();
            comboBox1.DisplayMember = "Pregunta";
            comboBox1.ValueMember = "IdPregunta";
            comboBox1.SelectedIndex = -1;
        }



     

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            // 1. Campos obligatorios vacíos
            if (string.IsNullOrWhiteSpace(textBox1nombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApekkido.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreo.Text) ||
                string.IsNullOrWhiteSpace(textBoxcontraseña.Text) ||
                string.IsNullOrWhiteSpace(textBoxconfirmarpaswor.Text) ||
                string.IsNullOrWhiteSpace(textBoxRespuestaseguridad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                textBoxCorreo.Focus();
                return;
            }

            // 2. Combo de pregunta seleccionado (ANTES de usar su valor)
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una pregunta de seguridad.");
                comboBox1.Focus();
                return;
            }

            // 3. Formato de correo
            if (!Regex.IsMatch(textBoxCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                textBoxCorreo.Focus();
                return;
            }

            // 4. Contraseñas coinciden
            if (textBoxcontraseña.Text != textBoxconfirmarpaswor.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                textBoxconfirmarpaswor.Focus();
                return;
            }

            // 5. Correo duplicado
            if (usuarioDAO.EmailExiste(textBoxCorreo.Text.Trim()))
            {
                MessageBox.Show("Este correo ya está registrado.", "Email duplicado");
                textBoxCorreo.Focus();
                return;
            }

            // 6. Armar el objeto Usuario
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = textBox1nombre.Text.Trim(),
                Apellido = textBoxApekkido.Text.Trim(),
                Correo = textBoxCorreo.Text.ToLower().Trim(),
                Contraseña = textBoxcontraseña.Text.Trim(),
                Suscripcion = checkBoxSub.Checked
            };

            // 7. Insertar usuario
            bool resultado = usuarioDAO.InsertarUser(nuevoUsuario);

            if (resultado)
            {
                // 8. Insertar la pregunta de seguridad asociada
                int idPregunta = Convert.ToInt32(comboBox1.SelectedValue);
                usuarioDAO.InsertarPreguntaSeguridad(nuevoUsuario.Correo, idPregunta, textBoxRespuestaseguridad.Text.Trim());

                MessageBox.Show("Registro Exitoso");
                this.Close();
                FormLogin formlogin = new FormLogin();
                formlogin.Show();
            }
            else
            {
                MessageBox.Show("No se pudo crear la cuenta. Intente de nuevo.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin formlogin = new FormLogin(); 
            formlogin.Show();
        }
    }
}