using System.Diagnostics;
using PROG8051_Assign3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to VRMS - Your very own vehicle rental management system");

        RentalAgency rentalAgency = new RentalAgency();

        // mock inventory data

        Car car = new Car();

        car.setModel("2024 Tesla Model 3");
        car.setManufacturer("Tesla");
        car.setYear(2024);
        car.setSeats(5);
        car.setEngineType("Electric");
        car.setTransmission("1-speed direct drive");
        car.setConvertible(false);
        car.setRentalPrice(145);
        Truck truck = new Truck();

        truck.setModel("2024 Hyundai Santa Cruz SE");
        truck.setManufacturer("Hyundai");
        truck.setYear(2024);
        truck.setCapacity(1411);
        truck.setTruckType("Pickup");
        truck.setFourWheelDrive(false);
        truck.setRentalPrice(120);

        Motorcycle motorcycle = new Motorcycle();

        motorcycle.setModel("MT-07");
        motorcycle.setManufacturer("Yamaha");
        motorcycle.setYear(2014);
        motorcycle.setEngineCapacity(3.7);
        motorcycle.setFuelType("Gas");
        motorcycle.setHasFairing(false);
        motorcycle.setRentalPrice(165);

        rentalAgency.Fleet.Add(car);
        rentalAgency.Fleet.Add(truck);
        rentalAgency.Fleet.Add(motorcycle);

        car.DisplayDetails();
        truck.DisplayDetails();
        motorcycle.DisplayDetails();

        rentalAgency.init();
    }
}