using PROG8051_Assign3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to VRMS - Your very own vehicle rental management system");
        Console.WriteLine("\nVehicles available in fleet:");

        RentalAgency rentalAgency = new RentalAgency();

        // Inventory Data
        Car car = new Car();
        car.Model = "2024 Tesla Model 3";
        car.Manufacturer = "Tesla";
        car.Year = 2024;
        car.Seats = 5;
        car.EngineType = "Electric";
        car.Transmission = "1-speed direct drive";
        car.Convertible = false;
        car.RentalPrice = 145;

        Truck truck = new Truck();
        truck.Model = "2024 Hyundai Santa Cruz SE";
        truck.Manufacturer = "Hyundai";
        truck.Year = 2024;
        truck.Capacity = 1411;
        truck.TruckType = "Pickup";
        truck.FourWheelDrive = false;
        truck.RentalPrice = 120;

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Model = "MT-07";
        motorcycle.Manufacturer = "Yamaha";
        motorcycle.Year = 2014;
        motorcycle.EngineCapacity = 3.7;
        motorcycle.FuelType = "Gas";
        motorcycle.HasFairing = false;
        motorcycle.RentalPrice = 165;

        rentalAgency.Fleet.Add(car);
        rentalAgency.Fleet.Add(truck);
        rentalAgency.Fleet.Add(motorcycle);

        car.DisplayDetails();
        truck.DisplayDetails();
        motorcycle.DisplayDetails();

        rentalAgency.init();
    }
}