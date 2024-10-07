using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Prueba5.Universidad;
using static Prueba5.Universidad.Estudiantes;

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

    public static class Extensiones
    {
        public static void MostrarInformacion(this Estudiantes texto)
        {
            double asistencia = Asistencia.Porcentaje(texto.TotalAsist, texto.TotalSec);
            Console.WriteLine($"Nombre del Estudiante: {texto.Nombre}");
            Console.WriteLine($"Total de Sesiones: {texto.TotalSec}");
            Console.WriteLine($"Sesiones Asistidas: {texto.TotalAsist}");
            Console.WriteLine($"Porcentaje de Asistencia: {asistencia}%");

            if (asistencia >= 75)
            {
                Console.WriteLine("El estudiante cumple con el requisito de asistencia.");
            }
            else
            {
                Console.WriteLine("El estudiante no cumple con el requisito de asistencia.");
            }
        }
    }
}
