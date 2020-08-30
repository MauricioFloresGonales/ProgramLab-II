using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje[] personajes = new Personaje[3];

            personajes[0].SetNombre("mauricio");
            personajes[1].SetNombre("gonzales");
            personajes[2].SetNombre("flores");

            foreach (var personaje in personajes)
            {
                personaje.GetNombre();
            }
            Console.ReadKey();
        }
    }
}
