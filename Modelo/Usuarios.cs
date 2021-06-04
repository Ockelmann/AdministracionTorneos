using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Torneos.Modelo
{
    public class Usuarios
    {
        public int Id_usuarios { get; set; }
        public string dpi { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string user { get; set; }
        public string contraseña { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Puesto { get; set; }
        public string Rol { get; set; }
        public Boolean estado { get; set; }
    }
}
