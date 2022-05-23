namespace Vehiculos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SuperClaseVehiculos vehiculos;
            vehiculos = new SuperClaseVehiculos();

            vehiculos.NombreVehiculo = "Terrestre";
            vehiculos.TipoMotor = "MOTOR DIÉSEL";
            vehiculos.CantidadPersonas = 1;

            Console.WriteLine("EL NOMBRE DEL TIPO DE VEHICULO ES: ");
            Console.WriteLine(vehiculos.NombreVehiculo);
            Console.WriteLine("\nEl Motor de este vehiculo es: ");
            Console.WriteLine(vehiculos.TipoMotor);
            Console.WriteLine("\nLa cantidad de personas minimo que puede haber en un vehiculo es: ");
            Console.WriteLine(vehiculos.CantidadPersonas);

            


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Terrestre VehiculosTerrestres;
            VehiculosTerrestres = new Terrestre();

            VehiculosTerrestres.CantidadLlantas = 4;
            VehiculosTerrestres.CantidadPersonas = 4;
            VehiculosTerrestres.NombreTerrestre = "Carro";
            VehiculosTerrestres.TipoMotor = "MOTOR DIÉSEL";

            Console.WriteLine("\nRecuerde que en este Diagrama Existen las ramas" +
                "de Vehiculos Terrestres: Moto y Carro, en este caso nos enfocamos en el:\n");
            Console.WriteLine(VehiculosTerrestres.NombreTerrestre);
            Console.WriteLine("\nEl tipo de Motor en este Carro es:");
            Console.WriteLine(VehiculosTerrestres.TipoMotor);
            Console.WriteLine("(El tipo de Motor puede Variar...)\n");
            Console.WriteLine(VehiculosTerrestres.CantidadPersonas);
            Console.WriteLine("\n(La cantidad de Personas puede variar...)");
            Console.WriteLine(VehiculosTerrestres.CantidadLlantas);
            Console.WriteLine("La Cantidad de Llantas comun en un Carro son 4," +
                "pero esta cantidad puede variar...");
            
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            Carro CarroVehiculo;
            CarroVehiculo = new Carro();

            CarroVehiculo.NombreVehiculo = "chevrolet";
            CarroVehiculo.TipoCarro = "Colectivo";
            CarroVehiculo.Tamaño = "Mediano";
            

            Console.WriteLine("\nEl nombre de la Marca del Carro es:");
            Console.WriteLine(CarroVehiculo.NombreVehiculo);
            Console.WriteLine("\nEl tipo del carro es: ");
            Console.WriteLine(CarroVehiculo.TipoCarro);
            Console.WriteLine("\nEl tamaño del Carro es: ");
            Console.WriteLine(CarroVehiculo.Tamaño);

            ///////////////////////////////////////////////////////////////////////////

            Colectivo CarroColectivo;
            CarroColectivo = new Colectivo();

            CarroColectivo.ColorPlaca = "Blanca";
            CarroColectivo.TipoServicio = "Publico";

            Console.WriteLine("\nEl color de las placas de cols carros Colectivos son blancas ya que muestra que presta un servicio...");
            Console.WriteLine(CarroColectivo.ColorPlaca);
            Console.WriteLine("\nEl tipo de servicio que presta los colectivos pueden ser Privados o Publicos, es este caso es: ");
            Console.WriteLine(CarroColectivo.TipoServicio);

            /////////////////////////////////////////////////////////////////////////////////

            Escolares ColectivosEscolares;
            ColectivosEscolares = new Escolares();

            ColectivosEscolares.CantidadPersonas =  15;

            Console.WriteLine("\n La cantidad de Estudiantes que puede transportar los colectivos a servicio Estudiantil son: ");
            Console.WriteLine(ColectivosEscolares.CantidadPersonas);
        }

    }
}
