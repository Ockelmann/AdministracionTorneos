using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Torneos.Modelo
{
    public  class Horario
    {
        public string dia { get; set; }
        public TimeSpan Hora_Apertura { get; set; }
        public TimeSpan Hora_Cierre { get; set; }
    }
}
