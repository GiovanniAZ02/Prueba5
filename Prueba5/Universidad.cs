using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba5
{
    public class Universidad
    {
        public class Estudiantes
        {
            public string Nombre { get; set; }
            public double TotalSec { get; set; } // Total de sesiones
            public double TotalAsist { get; set; } // Asistencias

            public class Asistencia
            {
                public static double Porcentaje(double asistencias, double totalSesiones)
                {
                    if (totalSesiones == 0)
                    {
                        return 0; // Evitar división por cero
                    }
                    return (asistencias / totalSesiones) * 100;
                }
            }
        }
    }
}
