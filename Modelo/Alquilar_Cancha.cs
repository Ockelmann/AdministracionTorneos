using System;

namespace Administracion_Torneos.Modelo
{
    public class Alquilar_Cancha
    {

        public int NoCancha { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Apartada { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Final { get; set; }
        public decimal Total { get; set; }


    }
}
