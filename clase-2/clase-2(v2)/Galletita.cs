using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2_v2_
{
    class Galletita
    {
        private string sabor;
        private bool bajoEnCaloria;

        public string GetSabor()
        {
            return this.sabor;
        }
        /// <summary>
        /// Setea el nombre del sabor
        /// </summary>
        /// <param name="nombreSabor"> nombre a setear</param>
        /// <returns></returns>
        public string SetSabor(string nombreSabor)
        {
            return this.sabor = nombreSabor;
        }
    }
}
