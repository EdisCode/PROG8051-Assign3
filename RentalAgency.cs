using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assign3
{
    internal class RentalAgency
    {
        public List<Vehicle> Fleet;
        private double TotalRevenue;

        public RentalAgency()
        {
            Fleet = new List<Vehicle>();
            TotalRevenue = 0.0D;
        }

        public void init()
        {
            bool shouldExit = false;

            while (shouldExit != true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("\tDisplay fleet:      a");
                Console.WriteLine("\tAdd to fleet:       b");
                Console.WriteLine("\tRemove from fleet:  c");
                Console.WriteLine("\tRent from fleet:    d");
                Console.WriteLine("\tTotal revenue:      e");
                Console.WriteLine("\tExit:               x");

                switch (Char.ToLower(Console.ReadKey().KeyChar))
                {
                    case 'a':
                        DisplayFleet();
                        break;
                    case 'b':
                        AddToFleet();
                        break;
                    case 'c':
                        RemoveFromFleet();
                        break;
                    case 'd':
                        RentFromFleet();
                        break;
                    case 'e':
                        Console.WriteLine($"\nTotal revenue: {TotalRevenue}");
                        break;
                    case 'x':
                        shouldExit = true;
                        break;
                }
            }
        }

        public void DisplayFleet()
        {

            if (Fleet.Count == 0)
            {
                Console.WriteLine("\nEmpty fleet. Would you like to create a new entry? Y/N");

                if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    AddToFleet();
                }
                else
                {
                    return;
                }
            }

            Dictionary<string, int> fleetRecord = new Dictionary<string, int>() { { "CAR", 0 }, { "TRUCK", 0 }, { "MOTORCYCLE", 0 } };

            for (int i = 0; i < Fleet.Count; i++)
            {
                string vehicleType = Fleet[i].Type;

                if (fleetRecord.ContainsKey(vehicleType))
                {
                    fleetRecord[vehicleType] = fleetRecord[vehicleType] + 1;
                }
            }

            Console.WriteLine("\nFleet:");
            Console.WriteLine($"\tCars {fleetRecord["CAR"]}");
            Console.WriteLine($"\tTrucks {fleetRecord["TRUCK"]}");
            Console.WriteLine($"\tMotorcycles {fleetRecord["MOTORCYCLE"]}");
        }

        public void AddToFleet()
        {
            Console.WriteLine("\nEnter vehicle type (Car, Motorcycle, Truck): ");
            string vehicleType = Console.ReadLine()?.ToUpper();

            Vehicle vehicle = null;

            string model = "";
            string manufacturer = "";
            int year = DateTime.Now.Year;

            if ((new List<string> { "CAR", "TRUCK", "MOTORCYCLE" }).Contains(vehicleType))
            {
                Console.WriteLine($"\nEnter details for {vehicleType}");

                Console.Write("\nModel: ");
                model = Console.ReadLine();

                Console.Write("Manufacturer: ");
                manufacturer = Console.ReadLine();

                Console.Write("Year: ");
                year = Convert.ToInt32(Console.ReadLine());

                switch (vehicleType)
                {
                    case "CAR":
                        {

                            Car car = new Car();

                            Console.Write("Seats: ");
                            int seats = Convert.ToInt32(Console.ReadLine());

                            Console.Write("EngineType: ");
                            string engineType = Console.ReadLine();

                            Console.Write("Transmission: ");
                            string transmission = Console.ReadLine();

                            Console.Write("Convertible: ");
                            bool convertible = Convert.ToBoolean(Console.ReadLine());

                            car.setModel(model);
                            car.setManufacturer(manufacturer);
                            car.setYear(year);

                            car.setSeats(seats);
                            car.setEngineType(engineType);
                            car.setTransmission(transmission);
                            car.setConvertible(convertible);

                            vehicle = car;
                        }
                        break;
                    case "TRUCK":
                        {
                            Truck truck = new Truck();

                            Console.Write("Capacity: ");
                            double capacity = Convert.ToDouble(Console.ReadLine());

                            Console.Write("TruckType: ");
                            string truckType = Console.ReadLine();

                            Console.Write("FourWheelDrive: ");
                            bool fourWheelDrive = Convert.ToBoolean(Console.ReadLine());

                            truck.setModel(model);
                            truck.setManufacturer(manufacturer);
                            truck.setYear(year);

                            truck.setCapacity(capacity);
                            truck.setTruckType(truckType);
                            truck.setFourWheelDrive(fourWheelDrive);

                            vehicle = truck;

                        }
                        break;
                    case "MOTORCYCLE":
                        {
                            Motorcycle motorcycle = new Motorcycle();

                            Console.Write("EngineCapacity: ");
                            double engineCapacity = Convert.ToDouble(Console.ReadLine());

                            Console.Write("FuelType: ");
                            string fuelType = Console.ReadLine();

                            Console.Write("HasFairing: ");
                            bool hasFairing = Convert.ToBoolean(Console.ReadLine());

                            motorcycle.setModel(model);
                            motorcycle.setManufacturer(manufacturer);
                            motorcycle.setYear(year);

                            motorcycle.setEngineCapacity(engineCapacity);
                            motorcycle.setFuelType(fuelType);
                            motorcycle.setHasFairing(hasFairing);

                            vehicle = motorcycle;
                        }
                        break;
                }

                if (vehicle != null)
                {
                    Console.Write("RentalPrice: ");
                    double rentalPrice = Convert.ToDouble(Console.ReadLine());

                    vehicle.setRentalPrice(rentalPrice);

                    Fleet.Add(vehicle);

                    Console.Clear();

                    Console.WriteLine($"\nAdded {vehicleType} to fleet");
                    vehicle.DisplayDetails();
                }
            }
            else
            {
                Console.WriteLine($"\nInvalid vehicle of type \"{vehicleType}\" submitted. Try again? Y/N");

                if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    AddToFleet();
                }
            }
        }

        public void RemoveFromFleet()
        {
            Console.WriteLine("\nEnter id of vehicle: ");
            string vehicleID = Console.ReadLine();

            Vehicle vehicleMatch = null;
            List<Vehicle> filteredList = new List<Vehicle>();

            for (int i = 0; i < Fleet.Count; i++)
            {
                Vehicle vehicle = Fleet[i];

                if (vehicle.ProductID == vehicleID)
                {
                    vehicleMatch = vehicle;
                }
                else
                {
                    filteredList.Add(vehicle);
                }
            }

            Console.Clear();

            if (vehicleMatch != null)
            {
                Fleet = filteredList;

                Console.WriteLine($"\nRemoved entry with productID \"{vehicleMatch.ProductID}\"");

                vehicleMatch.DisplayDetails();
            }
            else
            {
                Console.WriteLine("\nNo match found. Try again? Y/N");

                if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    RemoveFromFleet();
                }

            }
        }

        public void RentFromFleet()
        {
            Console.WriteLine("\nEnter vehicle type (Car, Motorcycle, Truck): ");
            string vehicleType = Console.ReadLine()?.ToUpper();
        }
    }

}
