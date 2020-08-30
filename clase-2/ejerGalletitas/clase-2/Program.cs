using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Galletita galletita_1;
            galletita_1 = new Galletita();

            Galletita galletita_2 = new Galletita();

            galletita_1.sabor = "vainilla";

            galletita_1.bajaCaloria = true;*/

            Galletita galletita_1 = new Galletita();
            Galletita galletita_2 = new Galletita();
            galletita_1.SetSabor("vainilla");
            galletita_2.SetSabor("chocolate");
            Console.WriteLine(galletita_1.GetSabor());
            Console.WriteLine(galletita_2.GetSabor());
            Console.ReadKey();
        }
    }
}
