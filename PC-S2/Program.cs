using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola,xdddub desde Visual Studio 🚀");


            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Bienvenido, {nombre} 👋");

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}