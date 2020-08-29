using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numero = 250;
            int cero = 1;
            double numeroLargo = 200; //el doble que un int
                                      //tring valor;
            string valorTexto = "22";
            bool logico = true;
            DateTime dateTime = DateTime.Now;


            if (numero == 9)
                numero = 3;

            //rogram miPrograma;

            //f(miPrograma == null)
            //    valor = String.Empty;

            //conversion explicita
            numero = (int)numeroLargo;

            //conversion implicita
            numeroLargo = numero;

            //conversion por parseo
            numero = int.Parse(valorTexto);

            //if
            logico = cero == 0 ? false : true;

            //sumar la hora actual con los segundos solo si alguno es mayor a 25
            int salida = suma(dateTime.Minute, dateTime.Second);
            Console.Write("el resultado es:");
            Console.WriteLine(salida);
            Console.ReadLine();// es para parar la consola

            //Concatenarc
            Console.Write("el resultado es: " + salida);
            Console.Write($"el resultado es: {salida}");
            Console.Write("el resultado es: {0}",salida);


            //pedir 5 nombres y mostrarlos en pantalla
            string[] nombres;
            nombres = new string[5];

            //for 
            for (int i = 0; i < 5; i++)
            {
                Console.Write("ingrese el nombre: ");
                nombres[i] = Console.ReadLine();
            }

            //foreach
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            foreach (var item in nombres)
            {
                Console.WriteLine("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            }

        }

        static int suma(int numeroUno, int numeroDos)
        {
            int resultado = 0;
            if (numeroUno > 25 || numeroDos > 25)
                resultado = numeroUno + numeroDos;
            return resultado;
        }
    }
}
