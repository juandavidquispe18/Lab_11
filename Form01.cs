using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Form01
    {
        public static List<int> notas = new List<int>();
        public static void menu_principal() {

            Console.WriteLine("================================");
            Console.WriteLine("Casos con Arreglos");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar notas");
            Console.WriteLine("2: Hallar la nota mayor");
            Console.WriteLine("3: Hallar la nota menor");
            Console.WriteLine("4: Encontrar una nota");
            Console.WriteLine("5: Modificar una nota");
            Console.WriteLine("6: Ver notas registradas");
            Console.WriteLine("7: Salir");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
        }

        public static void registro_nota() {

            Console.Clear();
            int numero_nota = notas.Count + 1;
            Console.WriteLine("================================");
            Console.WriteLine("Registrar una nota");
            Console.Write($"Ingresa la nota Nro {numero_nota}: ");

            if (int.TryParse(Console.ReadLine(), out int nota)) {

                notas.Add(nota);
                Console.WriteLine("Nota registrada con éxito.");
            }
            else
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar otra nota");
            Console.WriteLine("2: Regresar");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion)) {

                switch (opcion) {

                    case 1:
                        registro_nota();
                        break;
                    case 2:
                        break;
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
        }

        public static void revelar_nota_mayor() {

            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
            }
            else
            {
                Console.WriteLine("================================");
                Console.WriteLine("La nota mayor");
                Console.WriteLine("================================");
                int nota_mayor = notas.Max();
                string notas_registradas = string.Join(" ", notas);
                Console.WriteLine("La nota mayor es: " + nota_mayor);
                Console.WriteLine(notas_registradas);
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void mostrar_nota_menor() {

            if (notas.Count == 0) {

                Console.WriteLine("No hay notas registradas.");
            }
            else
            {
                Console.WriteLine("================================");
                Console.WriteLine("La nota menor");
                Console.WriteLine("================================");
                int num_menor = notas.Min();
                string num_registradas = string.Join(" ", notas);
                Console.WriteLine("La nota mayor es: " + num_menor);
                Console.WriteLine(num_registradas);
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void busqueda_nota() {

            Console.WriteLine("================================");
            Console.WriteLine("Buscar nota");
            Console.Write("Ingrese la nota a buscar: ");

            if (int.TryParse(Console.ReadLine(), out int buscar_nota)) {

                int index = notas.IndexOf(buscar_nota);
                if (index != -1) {

                    Console.WriteLine("La nota está en la posición " + index);
                    Console.WriteLine("================================");

                    for (int i = 0; i < notas.Count; i++) {

                        Console.WriteLine($"{i} -> {notas[i]}");
                    }

                    Console.WriteLine("================================");
                    Console.WriteLine("1: Regresar");
                }
                else
                {
                    Console.WriteLine("La nota no se encontró en la lista.");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Regresar");
                }
            }
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }


        public static void cambiar_nota() {

            Console.WriteLine("================================");
            Console.WriteLine("Modificar nota");
            Console.WriteLine("================================");

            if (notas.Count == 0) {

                Console.WriteLine("No hay notas registradas para modificar.");
            }
            else
            {
                Console.Write("Ingrese la posición: ");

                if (int.TryParse(Console.ReadLine(), out int posicion)) {

                    if (posicion >= 1 && posicion <= notas.Count) {

                        Console.Write("Ingrese el nuevo valor: ");

                        if (int.TryParse(Console.ReadLine(), out int new_valor)) {

                            int nota_anterior = notas[posicion - 1];
                            notas[posicion - 1] = new_valor;

                            Console.WriteLine("Antes: " + nota_anterior);
                            Console.WriteLine("Después: " + new_valor);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Por favor, ingrese una posición válida.");
                    }
                }
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.ReadKey();
            Console.Clear();
        }


        public static void revelar_registro_notas() {

            Console.WriteLine("================================");
            Console.WriteLine("Notas registradas:");

            if (notas.Count > 1) {

                Console.WriteLine(string.Join(" ", notas));
            }
            else
            {
                Console.WriteLine("No hay notas registradas.");
            }
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
