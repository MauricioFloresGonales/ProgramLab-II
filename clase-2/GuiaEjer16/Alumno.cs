using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjer16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        string apellido;
        int legajo;
        string nombre;
        
        public string SetNombre(string auxNombre)
        {
            return this.nombre = auxNombre;
        }
        public string SetNombre(string auxNombre)
        {
            return this.nombre = auxNombre;
        }
        public string SetApellido(string auxApellido)
        {
            return this.apellido = auxApellido;
        }
        public string SetLegajo(string auxLegajo)
        {
            return this.legajo = auxLegajo;
        }


        public void CalcularFinal()
        {
            
        }
    }
}
