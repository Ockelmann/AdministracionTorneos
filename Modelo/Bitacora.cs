using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Torneos.Modelo
{
    public class Bitacora
    {
        public int id_bitacora { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora_Entrada { get; set; }
        public Boolean TORNEO { get; set; }
        public Boolean EQUIPO { get; set; }
        public Boolean ENTRENADOR { get; set; }
        public Boolean USUARIOS { get; set; }
        public Boolean ARBITROS { get; set; }
        public Boolean AMONESTACIONES { get; set; }
        public Boolean PAGO_AMONESTACIONES { get; set; }
        public Boolean CLIENTES { get; set; }
        public Boolean JUGADORES { get; set; }
        public Boolean CANCHAS { get; set; }
        public Boolean REPORTES { get; set; }
        public Boolean ALQUILER_CANCHA { get; set; }

    }
}
