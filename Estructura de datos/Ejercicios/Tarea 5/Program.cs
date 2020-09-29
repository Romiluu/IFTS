using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Program
    {
        // Tarea 1: Crea una función llamada "Signo";, que reciba un número real, y devuelva un
        //número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.
        /*
        public static float Signo(float nreal)
        {
            if (nreal < 0)
            {
                return -1;
            }
            if (nreal > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            float resultado;
            float numero = 8;
            resultado = Signo(numero);
            Console.WriteLine(resultado);
            Console.ReadKey();
            }
        */

        //Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como
        //parámetros. El resultado será otro número entero.

        /*public static int Menor(int numero1, int numero2)
        {


            if (numero1 < numero2)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }

        static void Main(string[] args)
        {
            int resultado2;
            int numero1 = 12;
            int numero2 = 6;
            resultado2 = Menor(numero1, numero2);
            Console.WriteLine(resultado2);
            Console.ReadKey();
        }
        */

        //Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano "true" 
        //si es un número primo o "false" en caso contrario.
        /*
        static bool EsPrimo(int n)
        {
            bool Resultado = true;
            if (n % 2 == 0)
                Resultado = false;
            return Resultado;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nùmero ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(n));
            Console.ReadKey();

        }
        */

        //Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del 
        //código con su resultado y análisis del mismo.
        /*
        static void Main(string[] args)
        {
            Console.Clear();

            //dibujo de cada linea (bucle externo)

            for (int fila = 1; fila <= 7; fila++)
            {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" "); //espacio en blanco

                //dibuja estrellas (2do bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");

                Console.WriteLine(" ");
            }

            Console.ReadKey();  // Se ve un triangulo de 7 pisos hecho de estrellas
        }
        */

        //Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar o dividir 
        //los dos números que se le indiquen como parámetros. Ejemplos de su uso sería "calcula 2 + 3" o "calcula
        //5 * 60". (Utilice Funciones)

        /*public static int calcula(int numero1, string operador, int numero2)
        {
            int resultado = 0;
            if (operador == "+")
                resultado = numero1 + numero2;
            if (operador == "-")
                resultado = numero1 - numero2;
            if (operador == "*")
                resultado = numero1 * numero2;
            if (operador == "/")
                resultado = numero1 / numero2;
            return resultado;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique que operacion desea realizar:  + , - , * , ó / ");
            string operador = Console.ReadLine();
            Console.WriteLine("Ingrese segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado es {0}", calcula(numero1, operador, numero2));
            Console.ReadKey();
            Console.ReadLine();

        }
        */

        //Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como resultado
        //la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.

        /*static int SumaCifras(string n)
        {
            int resultado = 0;
            int numeros;
            foreach (char cifras in n)
            {
                numeros = (int)char.GetNumericValue(cifras);
                resultado += numeros;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de varias cifras: ");
            string cifra = Console.ReadLine();
            Console.WriteLine("La sumatora de las cifras es {0}", SumaCifras(cifra));
            Console.ReadKey();
        }
        */

        //Tarea 7 (Opcional): Crea una función "Triángulo" que reciba una letra y un número, y escriba un "triángulo" 
        //formado por esa letra, que tenga como anchura inicial la que se ha indicado. Por ejemplo, si la letra 
        //es * y la anchura es 4, debería escribir 
        //**** 
        //*** 
        //** 
        //*

        /*public static void Triangulo(string letra, int numero)
        {
            for (int ancho = numero; ancho >= 1; ancho--)
            {
                for (int contador = 0; contador < ancho; contador++)
                    Console.Write(letra);
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una letra ");
            string letra = Console.ReadLine();
            Console.WriteLine("Escribe una numero ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Triangulo(letra, numero);
            Console.ReadLine();

        }
        */
    }
}

    

