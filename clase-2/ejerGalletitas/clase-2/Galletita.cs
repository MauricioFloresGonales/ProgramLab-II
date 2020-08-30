using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2
{
    public class Galletita
    {
        private string sabor = "vainilla";
        private string nombre;
        private bool bajaCaloria = true;

        public string GetSabor()
        {
            return this.sabor;
        }

         string SetSabor(string saborASetear)
        {
            return this.sabor = saborASetear;
        }
    }
}
