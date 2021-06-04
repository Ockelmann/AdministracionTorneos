using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Torneos.Modelo
{
    public class Alquiler_Arbitro
    {
        public int id { get; set; }
        public int dpi_arbitro { get; set; }
        public DateTime fecha_apartado { get; set; }
        public TimeSpan hora_inicio { get; set; }
        public TimeSpan hora_final { get; set; }
        public decimal total { get; set; }
    }
}
