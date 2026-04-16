using System;
using System.Collections.Generic;

namespace GestorDeTareas
{
    internal class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("=== GESTOR DE TAREAS ===");
                Console.WriteLine("1. Ver tareas");
                Console.WriteLine("2. Agregar tarea");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        MostrarTareas();
                        break;
                    case 2:
                        AgregarTarea();
                        break;
                    case 3:
                        EliminarTarea();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        static void MostrarTareas()
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE TAREAS ===");

            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Clear();
            Console.WriteLine("=== AGREGAR TAREA ===");
            Console.Write("Escribe la nueva tarea: ");
            string tarea = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(tarea))
            {
                tareas.Add(tarea);
                Console.WriteLine("Tarea agregada correctamente.");
            }
            else
            {
                Console.WriteLine("No puedes agregar una tarea vacía.");
            }
        }

        static void EliminarTarea()
        {
            Console.Clear();
            MostrarTareas();

            if (tareas.Count > 0)
            {
                Console.Write("\nNúmero de tarea a eliminar: ");
                int indice;
                if (int.TryParse(Console.ReadLine(), out indice))
                {
                    if (indice > 0 && indice <= tareas.Count)
                    {
                        tareas.RemoveAt(indice - 1);
                        Console.WriteLine("Tarea eliminada.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
        }
    }
}