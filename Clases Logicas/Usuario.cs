using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_Logicas
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdMetodoEntrega { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public string Imagen { get; set; }
        public bool Suscripcion { get; set; }


    }
}
