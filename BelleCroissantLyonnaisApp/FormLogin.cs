using Clases_Logicas;

namespace BelleCroissantLyonnaisApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public UsuarioDAO userDa = new UsuarioDAO();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            // Paso 1: validar que no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                lblError.Text = "Debe ingresar correo y contraseña.";
                return;
            }

            // Paso 2: preguntarle al DAO si existe esa combinación correo/contraseña
            bool existe = userDa.Login(txtCorreo.Text.Trim(), txtContrasena.Text);

            // Paso 3: mostrar resultado
            if (!existe)
            {
                lblError.Text = "Credenciales no válidas.";
                return;
            }

            MessageBox.Show("Inicio de sesión exitoso.");

            // Abrir el formulario de perfil



            FormPerfil formPerfil = new FormPerfil(txtCorreo.Text.Trim());
            formPerfil.Show();

            this.Hide();
        }

        private void buttonCrear_cuenta_Click(object sender, EventArgs e)
        {

            FormRegistrar formulario = new FormRegistrar();
            formulario.Show();

            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
