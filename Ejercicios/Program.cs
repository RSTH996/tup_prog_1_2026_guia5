using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int A, B, Opcion, Tot = 0;
            ActividadUno A1 = new ActividadUno();

            Console.WriteLine("Seleccione a que actividad quiere entrar");
            Console.WriteLine("Precione 1 para la actividad 1 (suma de dos Números)");
            Console.WriteLine("Precione 3 para la actividad 3 (Promedio de 10 Números)");

            Opcion = Convert.ToInt16(Console.ReadLine());
            switch (Opcion) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Bienvenido a la actividad 1");
                    Console.WriteLine("Escriba el Primer número");
                    A = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Escriba el Segundo número");
                    B = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"La suma de {A} y de {B} es: " + A1.Suma(A, B));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Bienvenido a la actividad 3");
                    for (Opcion = 1; Opcion <= 10; Opcion++)
                    {
                        Console.WriteLine($"Por Favor, ingrese el número {Opcion}");
                        A = Convert.ToInt16(Console.ReadLine());
                        Tot = Tot + A;                        
                    }
                    Console.WriteLine($"El premedio de los {(Opcion-1)} números es de: " + A1.Promedio(Tot, Opcion));
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            
            Console.WriteLine("Preciona cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
