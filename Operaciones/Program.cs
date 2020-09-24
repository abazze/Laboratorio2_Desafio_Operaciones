using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones
{
    class Operacion
    {
        public static int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }

    class Program
    {
        //Variable para guardar el resultado
        static int resultado;

        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }

        public static void menu()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Operaciones Matemáticas");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("   1) Sumar");
                Console.WriteLine("   2) Restar");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Resultado: {0}", resultado);
                Console.WriteLine("---------------------------------------------");
                Console.Write("Ingrese una opción del menú(0 para salir): ");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //if (opcion != 0 && opcion != 1 && opcion != 2)
                    if(opcion < 0 || opcion > 2)
                        opcion = -1;
                }
                catch(Exception ex)
                {
                    Console.Write("La opción ingresada no es un número válido. Por favor presione una tecla para volver a intentarlo...");
                    opcion = -1;
                }
            } while (opcion == -1);

            switch (opcion)
            {
                case 0:
                    Console.Write("Presione una tecla para salir...");
                    break;
                case 1:
                case 2:
                    pedirValores(opcion);
                    break;
            }
        }

        public static void pedirValores(int opcion)
        {
            int posicion = 1;
            int numero1 = 0, numero2 = 0;
            do
            {
                Console.Write("Ingrese el {0}° valor: ", posicion);
                try
                {
                    if (posicion == 1)
                        numero1 = Convert.ToInt32(Console.ReadLine());
                    if (posicion == 2)
                        numero2 = Convert.ToInt32(Console.ReadLine());

                    ++posicion;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("El valor ingresado no es un número válido. Por favor ingrese otro valor.");
                }
            } while (posicion <= 2);

            if (opcion == 1)
                resultado = Operacion.sumar(numero1, numero2);
            else
                resultado = Operacion.restar(numero1, numero2);

            menu();
        }
    }
}
