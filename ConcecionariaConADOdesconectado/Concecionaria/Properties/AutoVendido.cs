using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concecionaria.Properties
{
    public class AutoVendido
    {
        private string patente;
        private int dni;
        public string Patente { get { return patente; } set { patente = value; } }
        public int Dni { get { return dni; } set { dni = value; } }

        public AutoVendido(string cpatente, int cdni)
        {
            this.patente = cpatente;
            this.dni = cdni;  
        }

    }
}
