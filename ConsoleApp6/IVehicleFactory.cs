using System;

namespace ConsoleApp6
{
    internal interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateTruck();
        IEngine CreateEngine();
    }
}
