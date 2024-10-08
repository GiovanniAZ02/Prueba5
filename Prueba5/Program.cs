using System;

namespace Tarea
{
    class Program
    {
        public static void Main(string[] args)
        {
            int CalculoTotal = 0;

            Console.WriteLine("Grupo 1M2-S");

            do
            {
                Console.WriteLine("Ingrese la Asistencia Total: ");
                CalculoTotal = Convert.ToInt32(Console.ReadLine());
                if (CalculoTotal < 0)
                {
                    Console.WriteLine("Ingrese un numero Positivo");
                }

            } while (CalculoTotal < 0);


            Console.WriteLine("Ingrese la Cantidad de Estudiante");
            int estudiante = Convert.ToInt32(Console.ReadLine());

            string[] CantidadNombre = new string[estudiante];
            double[] CantidadAsistencia = new double[estudiante];

            for (int i = 0; i < CantidadNombre.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Nombre del Estudiante {i + 1}");
                CantidadNombre[i] = Convert.ToString(Console.ReadLine());

                do
                {

                    Console.WriteLine("Ingrese las Sesiones Asistida: ");
                    CantidadAsistencia[i] = Convert.ToDouble(Console.ReadLine());
                    if (CantidadAsistencia[i] < 0)
                    {

                        Console.WriteLine("Ingrese un numero Positivo");
                    }

                } while (CantidadAsistencia[i] < 0);

                var informa = new Universidad.Estudiantes
                {

                    Nombre = CantidadNombre[i],
                    TotalSec = CalculoTotal,
                    TotalAsist = CantidadAsistencia[i],

                };
                informa.MostrarInformacion();

            }

            Console.WriteLine();
            Console.WriteLine("Los Nombre Ingresados Fueron: ");
            foreach (var i in CantidadNombre)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//C: \Users\T440\Documents\