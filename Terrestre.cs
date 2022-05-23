using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Terrestre : SuperClaseVehiculos
    {
        private int cantidadLlantas;

        public int CantidadLlantas
        {
            get { return cantidadLlantas; }
            set { cantidadLlantas = value; }
        }



        private string nombreTerrestre;

        public string NombreTerrestre
        {
            get { return nombreTerrestre; }
            set { nombreTerrestre = value; }
        }

    }
}
