using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_final_romi
{
    class Metodos
    {
        public Stack<int> miPila; //atributo comparte en diferentes funciones en diferentes clases; se le agrega el tipo para que traiga la func revers

        public void Crear_Pila()
        {

            string respuesta = "";
            if (miPila != null && miPila.Count > 0)  // validacion cuando hay pila y se crea una nueva
            {
                Console.WriteLine("Hay una pila con patentes, desea reemplazar SI o NO ");
                respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "si")
                {
                    miPila = new Stack<int>(); // cración de Pila en atributo
                    Console.WriteLine("Se creo la Pila ");
                }


            }
            else
            {
                miPila = new Stack<int>(); // cración de Pila en atributo                
                Console.WriteLine("Se creo la Pila ");
            }
        }


        public Stack<int> Borrar_Pila()
        {
            string confirmacion = "";
            if (miPila == null)
            {
                Console.WriteLine("No hay Pila, favor crear Pila opción 1 ");
            }

            else
            {                
                Console.WriteLine("Esta por eliminar la pila, Desea continuar? SI/NO ");
                confirmacion = Console.ReadLine().ToLower();
            }
            if (confirmacion == "si") ;
            {
                miPila = null;
            }
            Console.WriteLine("Se elimino Pila");
            if (confirmacion == "no") ;
            {
                return miPila;
            }

        }

        public void Agregar_Patente()
        {
            if (miPila == null)
            {
                Console.WriteLine("No hay pila. Crea la pila con opción 1 ");
            }

            else
            {
                Console.WriteLine("Ingrese patente ");
                string patente = Console.ReadLine();
                int patentes = 0;

                while (String.IsNullOrWhiteSpace(patente) || !patente.All(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))

                    Console.WriteLine("Se agrego patente" + patente, "correctamente");               

                miPila.Push(patentes);


            }


        }
        public void Borrar_Patente()
        {

            if (miPila == null)
            {
                Console.WriteLine("No hay Pila o no hay pedidos para borrar ");
            }

            else
            {
                int Borrado_elemento = 0;

                Console.WriteLine("Cual Nro. de patente desea borrar? ");
                string Element_borrar = Console.ReadLine();

                int.TryParse(Element_borrar, out Borrado_elemento);
                Stack<int> Recorrer_Pila = new Stack<int>(); // creo nueva cola

                while (miPila.Count > 0)
                {
                    if ((int)miPila.Peek() == Borrado_elemento) //Peek devuelve un elemento y se convierte a entero.  Se compara primer elemento con 
                    {
                        miPila.Pop();// elemento que se eliminar
                    }
                    else
                    {

                        Recorrer_Pila.Push((int)miPila.Pop()); //elemento que se enconlan en la nueva cola cuando no es la opcion seleccionada

                    }
                }
                miPila = Recorrer_Pila; // se reemplaza  cola

                Console.WriteLine("La patente {0} fue eliminada de la Pila ", Element_borrar);
                //como hacer una obcion de menu volver a elegir otra opcion y q no se termine otra arriba falta el while cuando la opcion es respues si
                //q sea swicht y cuando eleija laopcion salir se frena q sea while true

            }

        }

        public void Listar_Patentes()
        {
            if (miPila == null)
            {
                Console.WriteLine("No hay pila. Crea la pila con opción 1 ");
            }

            else
            {
                foreach (var elem in miPila)
                {

                    Console.WriteLine("listado de patentes: {0} ", elem);
                }
            }

        }

        public void listar_Ultima_Patente()
        {
            if (miPila == null || miPila.Count == 0) //verifica que halla cola ò pedidos ingresados
            {
                Console.WriteLine("No hay pila o no hay patentes. Cree pila o agregue patentes. ");
            }

            else
            {

                miPila = new Stack<int>(miPila.Reverse()); // reverse devuelve una cola
                int pedido_ulti = miPila.Peek();
                miPila = new Stack<int>(miPila.Reverse());//vuelven las pocisiones al estado original               
                Console.WriteLine("La ultima patente es {0}", pedido_ulti);
            }

        }



        public void listar_Primera_patente()

        {
            if (miPila == null || miPila.Count == 0) //verifica que haya pila o pedidos ingresados
            {
                Console.WriteLine("No hay pila o no hay patentes. Cree pila o agregue patentes. ");
            }

            else
            {
                int primer_patente = miPila.Peek();//Muestra el primer elemento sin eliminarlo           
                Console.WriteLine("{0}, es la primer patente de la lista", primer_patente);
            }

        }

        public void Cantidad_patentes()
        {
            if (miPila == null || miPila.Count == 0) //verifica que halla cola ò pedidos ingresados
            {
                Console.WriteLine("No hay pilaa o no hay patentes. Cree pila o agregue patentes. ");
            }


            else
            {
                int cantidad_patente = miPila.Count();
                Console.WriteLine("El total de patentes es de {0}", cantidad_patente);
            }

        }

        public void Buscar_patente()
        {
            if (miPila == null || miPila.Count == 0) //verifica que haya pila o pedidos ingresados
            {
                Console.WriteLine("No hay pila o no hay patentes. Cree pila o agregue patentes. ");
            }
            else
            {
                Console.WriteLine("Que patente desea buscar? ");
                string buscar_patente = Console.ReadLine();
                int buscar = 0;
                int.TryParse(buscar_patente, out buscar); // lo convierto en numero
                int numers = 0; // contador


                if (miPila.Contains(buscar)) // Determina si el elemento se encuentra dentro de la Pila
                {
                    foreach (var item in miPila) //foreach recorre por cada elemento que contiene la pila
                    {
                        if (item == buscar)
                        {
                            Console.WriteLine("La patente se encuentra en la pocisión {0}", numers + 1);
                        }
                        numers++;
                    }
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("La patente no se encuentra en la lista");
                }
            }

        }
        public void imprimir_csv()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre del archivo: "); //Te pide el nombre del archivo

                string fileName = Console.ReadLine() + ".txt";  //Agrega extension

                StreamWriter writer = System.IO.File.CreateText(fileName);



                writer.Close(); //Cierro archivo

                FileInfo fi = new FileInfo(fileName); //Uso file info para acceder a informacion del archivo y luego poder consultar el directorio
                DirectoryInfo di = fi.Directory; //Guardo el directorio en una variable para indicarselo al usuario

                Console.WriteLine("\nEl archivo {0} esta listo para imprimir en la ruta {1}.", fileName.ToUpper(), di);
            }

            catch (IOException) //Atrapa el error al manipular el archivo si es que hay
            {
                Console.WriteLine("\nError con el archivo.");
            }

        }




    }
}
    
