using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Torneos.Modelo
{
    public class ReporteDisponibilidad
    {
        public int id { get; set; }
        public int NoCancha { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Apartada { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Final { get; set; }
        public decimal Total { get; set; }
    }
}
