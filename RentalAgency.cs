

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
            // Exit running loop if true
            bool shouldExit = false;

            while (shouldExit != true)
            {
                // Print main menu for rental agency
                Console.WriteLine("\nSelect and option from the main menu:");
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
                        Console.WriteLine($"\n \nTotal revenue: \"${TotalRevenue}\"");
                        break;
                    case 'x':
                        shouldExit = true;
                        break;
                }
            }
        }

        // Display number of cars, trucks or motorcycles in inventory
        public void DisplayFleet()
        {

            if (Fleet.Count == 0)
            {
                Console.WriteLine("\nEmpty fleet. Would you like to create a new entry? Y/N");

                if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    AddToFleet(); // Adds new vehicle to inventory
                }
                else
                {
                    return;
                }
            }

            // Get total number of vehicles
            Dictionary<string, int> fleetRecord = new Dictionary<string, int>() { { "CAR", 0 }, { "TRUCK", 0 }, { "MOTORCYCLE", 0 } };

            for (int i = 0; i < Fleet.Count; i++)
            {
                string vehicleType = Fleet[i].Type;

                if (fleetRecord.ContainsKey(vehicleType))
                {
                    fleetRecord[vehicleType] = fleetRecord[vehicleType] + 1;
                }
            }

            Console.WriteLine("\n \nFleet:");
            Fleet.ForEach(vehicle =>
            {
                vehicle.DisplayDetails();
            });
            Console.WriteLine($"\nCars: {fleetRecord["CAR"]}");
            Console.WriteLine($"Trucks: {fleetRecord["TRUCK"]}");
            Console.WriteLine($"Motorcycles: {fleetRecord["MOTORCYCLE"]}");
        }

        // Adds new vehicle to inventory
        public void AddToFleet()
        {
            Console.Write("\n \nEnter the vehicle type you want to add (Car, Truck, Motorcycle): ");
            string vehicleType = Console.ReadLine()?.ToUpper();

            Vehicle vehicle = null;

            string model = "";
            string manufacturer = "";
            int year = DateTime.Now.Year;

            if ((new List<string> { "CAR", "TRUCK", "MOTORCYCLE" }).Contains(vehicleType))
            {
                Console.WriteLine($"\nEnter details for the {vehicleType}:");

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

                            Console.Write("How many seats (1-10): ");
                            int seats = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Engine Type: ");
                            string engineType = Console.ReadLine();

                            Console.Write("Transmission: ");
                            string transmission = Console.ReadLine();

                            Console.Write("Is it a convertible (true/false): ");
                            bool convertible = Convert.ToBoolean(Console.ReadLine());

                            car.Model = model;
                            car.Manufacturer = manufacturer;
                            car.Year = year;

                            car.Seats = seats;
                            car.EngineType = engineType;
                            car.Transmission = transmission;
                            car.Convertible = convertible;

                            vehicle = car;
                        }
                        break;
                    case "TRUCK":
                        {
                            Truck truck = new Truck();

                            Console.Write("Capacity (1-1000): ");
                            double capacity = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Truck Type: ");
                            string truckType = Console.ReadLine();

                            Console.Write("Is it a four wheel drive (true/false): ");
                            bool fourWheelDrive = Convert.ToBoolean(Console.ReadLine());

                            truck.Model = model;
                            truck.Manufacturer = manufacturer;
                            truck.Year = year;

                            truck.Capacity = capacity;
                            truck.TruckType = truckType;
                            truck.FourWheelDrive = fourWheelDrive;

                            vehicle = truck;

                        }
                        break;
                    case "MOTORCYCLE":
                        {
                            Motorcycle motorcycle = new Motorcycle();

                            Console.Write("Engine Capacity (1-1000): ");
                            double engineCapacity = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Fuel Type: ");
                            string fuelType = Console.ReadLine();

                            Console.Write("Does it have fairing (true/false): ");
                            bool hasFairing = Convert.ToBoolean(Console.ReadLine());

                            motorcycle.Model = model;
                            motorcycle.Manufacturer = manufacturer;
                            motorcycle.Year = year;

                            motorcycle.EngineCapacity = engineCapacity;
                            motorcycle.FuelType = fuelType;
                            motorcycle.HasFairing = hasFairing;

                            vehicle = motorcycle;
                        }
                        break;
                }

                if (vehicle != null)
                {
                    Console.Write("Rental Price: ");
                    double rentalPrice = Convert.ToDouble(Console.ReadLine());

                    vehicle.RentalPrice = rentalPrice;

                    Fleet.Add(vehicle);

                    Console.WriteLine($"\nAdded {vehicleType} to fleet.");
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

        // Removes vehicle from inventory
        public void RemoveFromFleet()
        {
            Console.Write("\n \nEnter the Product ID of the vehicle you want to remove from the fleet: ");
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

            if (vehicleMatch != null)
            {
                Fleet = filteredList;

                Console.WriteLine($"\nYou have removed vehicle with ProductID \"{vehicleMatch.ProductID}\".");

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

        // Rents a vehicle from inventory
        public void RentFromFleet()
        {
            Console.Write("\n \nEnter the Product ID of the vehicle you want to rent from the fleet: ");
            string vehicleID = Console.ReadLine();

            Vehicle vehicleMatch = null;

            for (int i = 0; i < Fleet.Count; i++)
            {
                Vehicle vehicle = Fleet[i];

                if (vehicle.ProductID == vehicleID)
                {
                    vehicleMatch = vehicle;
                    break;
                }
            }

            if (vehicleMatch != null)
            {
                vehicleMatch.DisplayDetails();

                Console.WriteLine($"\n\"{vehicleMatch.Type}\" with Product ID \"{vehicleMatch.ProductID}\" is available to rent at \"${vehicleMatch.RentalPrice}\". Request? Y/N");

                if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    TotalRevenue += vehicleMatch.RentalPrice;

                    Console.WriteLine("\nRide requested!");
                }
            }
            else
            {
                Console.WriteLine("\nNo match found. Try searching again? Y/N");

                if (Char.ToLower(Console.ReadKey().KeyChar) == 'y')
                {
                    RentFromFleet();
                }
            }
        }
    }
}
