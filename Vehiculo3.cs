using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo2
{
    class mostrarVehiculo
    {
        static void Main(string[] args)
        {
            Vehículo Carro = new Vehículo();
            Carro.SetVehiculo("Gran_Turismo", "BMW");
            Carro.verVehiculo();
            Console.WriteLine();

            Vehículo Carro1 = new Vehículo();
            Carro1.SetVehiculo("porsche", "ferrari");
            Carro1.verVehiculo();
            Console.ReadKey();

        }
    }
}
