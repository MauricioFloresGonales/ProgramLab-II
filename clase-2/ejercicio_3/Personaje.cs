using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Personaje
    {
        string nombre;
        int edad;


        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public string GetNombre()
        {
           return this.nombre;
        }

        public static string MostrarMensaje(Personaje auxPersonaje)
        {
            return auxPersonaje.GetNombre();
        }
    }
}
