using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightLib;

namespace SimulatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Escribe el identificador");
                //   string nombre = Console.ReadLine();
                string identificador = Console.ReadLine();

                Console.WriteLine("Escribe la velocidad");
                double velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                string linea = Console.ReadLine();
                string[] trozos = linea.Split(' ');
                double ix = Convert.ToDouble(trozos[0]);
                double iy = Convert.ToDouble(trozos[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                double fx = Convert.ToDouble(trozos[0]);
                double fy = Convert.ToDouble(trozos[1]);

                FlightPlan plan_a = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);

                Console.WriteLine("Escribe el identificador");
                //   string nombre = Console.ReadLine();
                identificador = Console.ReadLine();

                Console.WriteLine("Escribe la velocidad");
                velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                ix = Convert.ToDouble(trozos[0]);
                iy = Convert.ToDouble(trozos[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                fx = Convert.ToDouble(trozos[0]);
                fy = Convert.ToDouble(trozos[1]);

                FlightPlan plan_b = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);
                int ciclos = 10;
                int intervaloTiempo = 10;
                double distanciaSeguridad = 10;

                int i = 0;
                while(i < ciclos)
                {
                    plan_a.EscribeConsola();
                    plan_a.Mover(intervaloTiempo);
                    plan_a.EscribeConsola();
                    plan_b.EscribeConsola();
                    plan_b.Mover(intervaloTiempo);
                    plan_b.EscribeConsola();
                    if (plan_a.Conflicto(plan_b, distanciaSeguridad))
                        Console.WriteLine("CONFLICTO!!");
                    i++;
                }

                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("There is a format error, please try again");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The number of values is not correct, introduce 2 nubers separated by comas");
            }
            Console.ReadKey();

        }
    }
}
