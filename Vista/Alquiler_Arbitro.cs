using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Torneos.Vista
{
    public class Alquiler_Arbitro
    {
        public DateTime Fecha_Apartada { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Final { get; set; }
        public int Dpi_Arbitro { get; set; }
        public int Id_Alquiler { get; set; }
        public Decimal Total_Arbitraje { get; set; }
    }
}
