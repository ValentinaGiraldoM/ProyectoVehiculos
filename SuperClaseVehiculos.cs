using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class SuperClaseVehiculos
    {
        private string nombreVehiculo;
        public string NombreVehiculo 
        {
            get { return nombreVehiculo; }
            set { nombreVehiculo = value; } 
        }

        private string tipoMotor;

        public string TipoMotor
        {
            get { return tipoMotor; }
            set { tipoMotor = value; }
        }

        private int cantidadPersonas;
        public int CantidadPersonas
        {
            get { return cantidadPersonas; }
            set { cantidadPersonas = value; }
        }
    }
}
		
