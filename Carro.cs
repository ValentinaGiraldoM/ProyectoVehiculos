using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Carro : Terrestre
    {
        
        private int nombreCarro;
        public int NombreCarro
        { 
            get { return nombreCarro; }
            set { nombreCarro = value; }
        }


        private string tipoCarro;
        public string TipoCarro
        { 
            get { return tipoCarro; }
            set { tipoCarro = value; }   
        }

        private string tamaño;
        public string Tamaño
        {
            get { return tamaño;}
            set { tamaño = value; }
        }
    }
}
