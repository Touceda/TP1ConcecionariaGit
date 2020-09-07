using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concecionaria
{
    public class Auto
    {
        //patente año marca modelo precio
        private string patente;
        private int año;
        private string marca;
        private string modelo;
        private int precio;
        private string estado;

        public string Patente { get { return patente; } set { patente = value; } }
        public int Año { get { return año; } set { año = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public int Precio { get { return precio; } set { precio = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        public Auto(string cpatente, int caño, string cmarca, string cmodelo, int cprecio, string cestado)
        {
            this.patente = cpatente;
            this.año = caño;
            this.marca = cmarca;
            this.modelo = cmodelo;
            this.precio = cprecio;
            this.estado = cestado;
        }
    }
}
