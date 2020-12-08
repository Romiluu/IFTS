using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_final_romi
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos(); //instancia de clase de las funciones principales
            string opc = "0";
            while (opc != "11") //Creo un ciclo para que se repita el menu hasta que el usuario quiera salir
            {
                Console.Clear();
                Console.WriteLine("\nBienvenido al control de patentes\n");
                Console.WriteLine("\nMENU PRINCIPAL\n");
                Console.WriteLine("1) Crear Pila");
                Console.WriteLine("2) Borrar Pila");
                Console.WriteLine("3) Agregar patente");
                Console.WriteLine("4) Borrar patente");
                Console.WriteLine("5) Listar todas las patentes");
                Console.WriteLine("6) Listar última patente");
                Console.WriteLine("7) Listar primera patente");
                Console.WriteLine("8) Cantidad de patentes");
                Console.WriteLine("9) Buscar patente");
                Console.WriteLine("10) Guardar archivo para imprimir");
                Console.WriteLine("11) Salir");
                Console.Write("\r\nElija una opcion: ");
                opc = Console.ReadLine();

                switch (opc) //Menu
                {
                    case "1":
                        metodos.Crear_Pila(); //Le pasamos la lista con los 5 cafes
                        break;
                    case "2":
                        metodos.Borrar_Pila();
                        break;
                    case "3":
                        metodos.Agregar_Patente();
                        break;
                    case "4":
                        metodos.Borrar_Patente();
                        break;
                    case "5":
                        metodos.Listar_Patentes();
                        break;
                    case "6":
                        metodos.listar_Ultima_Patente();
                        break;
                    case "7":
                        metodos.listar_Primera_patente();
                        break;
                    case "8":
                        metodos.Cantidad_patentes();
                        break;
                    case "9":
                        metodos.Buscar_patente();
                        break;
                    case "10":
                        metodos.imprimir_csv();
                        break;                    
                    case "11":
                        Console.WriteLine("\nNos vemos!");
                        return;
                    default:
                        Console.WriteLine("\n\nOpcion no válida, volvé a intentarlo");                                               
                        break;
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar.");
                Console.ReadKey();
            }
        }

    }
}



        
    

