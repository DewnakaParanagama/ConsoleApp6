namespace ConsoleApp6
{
    internal class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new GasolineCar();
        }

        public IVehicle CreateTruck()
        {
            return new GasolineTruck();
        }

        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
    }
}