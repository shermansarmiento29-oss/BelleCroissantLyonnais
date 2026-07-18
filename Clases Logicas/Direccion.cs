using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_Logicas
{
    public class Direccion
    {
        public int IdUsuarioDireccion { get; set; }
        public int IdDireccion { get; set; }
        public string DireccionTexto { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Etiqueta { get; set; }
        public bool EsPreferida { get; set; }
    }
}
