namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gasoline Vehicle Factory
            IVehicleFactory gasolineFactory = new GasolineVehicleFactory();

            Console.WriteLine("GASOLINE VEHICLES");

            IEngine gasolineEngine = gasolineFactory.CreateEngine();
            gasolineEngine.Start();

            IVehicle gasolineCar = gasolineFactory.CreateCar();
            gasolineCar.ShowDetails();

            IVehicle gasolineTruck = gasolineFactory.CreateTruck();
            gasolineTruck.ShowDetails();


            Console.WriteLine();


            // Electric Vehicle Factory
            IVehicleFactory electricFactory = new ElectricVehicleFactory();

            Console.WriteLine("ELECTRIC VEHICLES");

            IEngine electricEngine = electricFactory.CreateEngine();
            electricEngine.Start();

            IVehicle electricCar = electricFactory.CreateCar();
            electricCar.ShowDetails();

            IVehicle electricTruck = electricFactory.CreateTruck();
            electricTruck.ShowDetails();

            Console.ReadLine();
        }
    }
}