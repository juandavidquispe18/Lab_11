using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Program
    {
        public static List<int> notas = new List<int>();
        static void Main(string[] args)
        {
            int opcion;
            do {

                Form01.menu_principal();
                if (int.TryParse(Console.ReadLine(), out opcion)) {

                    switch (opcion) {

                        case 1:
                            Console.Clear();
                            Form01.registro_nota();
                            if (int.TryParse(Console.ReadLine(), out opcion)) {

                                switch (opcion) {

                                    case 1:
                                        Form01.registro_nota();
                                        break;
                                    case 2: break;
                                    default:
                                        Console.WriteLine("Error: Selecciona la opción 2 para regresar.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Selecciona la opción 2 para regresar.");
                            }

                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            Form01.revelar_nota_mayor();
                            break;
                        case 3:
                            Console.Clear();
                            Form01.mostrar_nota_menor();
                            break;
                        case 4:
                            Console.Clear();
                            Form01.busqueda_nota();
                            break;
                        case 5:
                            Console.Clear();
                            Form01.cambiar_nota();
                            break;
                        case 6:
                            Console.Clear();
                            Form01.revelar_registro_notas();
                            break;
                        case 7:
                            Console.WriteLine("¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Error: Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                
            } while (opcion != 7);
            Console.ReadKey();
        }
    }
}
