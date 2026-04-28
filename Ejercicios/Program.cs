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
            ActividadC5 A1 = new ActividadC5();

            Console.WriteLine("Seleccione a que actividad quiere entrar");
            Console.WriteLine("Precione 1 para la actividad 1 (suma de dos Números)");
            Console.WriteLine("Precione 3 para la actividad 3 (Promedio de 10 Números)");
            Console.WriteLine("Precione 5 para la actividad 5 (Número Primos)");

            Opcion = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Bienvenido a la actividad {Opcion}");
            //Uso de formato swich para invocar las actividades, esto reduce el uso de memoria
            switch (Opcion) {
                case 1:
                    Console.WriteLine("Escriba el Primer número");
                    A = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Escriba el Segundo número");
                    B = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"La suma de {A} y de {B} es: " + A1.Suma(A, B));
                    break;
                case 3:
                    for (Opcion = 1; Opcion <= 10; Opcion++)
                    {
                        Console.WriteLine($"Por Favor, ingrese el número {Opcion}");
                        A = Convert.ToInt16(Console.ReadLine());
                        Tot = Tot + A;                        
                    }
                    Console.WriteLine($"El premedio de los {(Opcion-1)} números es de: " + A1.Promedio(Tot, Opcion));
                    break;
                case 5:
                    Tot = 1;
                    Console.WriteLine("Escribe un número para saber si es primo o no");
                    A = Convert.ToInt32(Console.ReadLine());                    
                    B = 2;
                    while (Tot != 0){                        
                        Tot = A1.Resto(A, B);
                        Console.WriteLine($"Vuelta {B} con resto {Tot}");
                        B = B + 1;
                    };
                    if (B != A){
                        Console.WriteLine($"El valor de {A} es Primo");
                    }else{
                        Console.WriteLine($"El valor de {A} no es Primo");
                    }
                    break;
                default:
                    Console.WriteLine("Nha, es broma, esta actividad no exite");
                    break;
            }            
            Console.WriteLine("Preciona cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
