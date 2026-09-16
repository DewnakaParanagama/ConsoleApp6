namespace ConsoleApp6
{
    internal class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new ElectricCar();
        }

        public IVehicle CreateTruck()
        {
            return new ElectricTruck();
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
