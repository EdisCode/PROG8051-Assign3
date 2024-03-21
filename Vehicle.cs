using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assign3
{
    abstract class Vehicle
    {
        public readonly string ProductID;

        public abstract string Type { get; }

        protected string Model;
        protected string Manufacturer;
        protected int Year;
        protected double RentalPrice;

        public Vehicle()
        {
            ProductID = (System.Guid.NewGuid()).ToString();
        }

        public string getModel()
        {
            return Model;
        }

        public void setModel(string value)
        {
            Model = value;
        }

        public string getManufacturer()
        {
            return Manufacturer;
        }

        public void setManufacturer(string value)
        {
            Manufacturer = value;
        }

        public int getYear()
        {
            return Year;
        }

        public void setYear(int value)
        {
            Year = value;
        }

        public double getRentalPrice()
        {
            return RentalPrice;
        }

        public void setRentalPrice(double value)
        {
            RentalPrice = value;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"\nProductID: \"{ProductID}\"");
            Console.WriteLine($"Model: \"{Model}\"");
            Console.WriteLine($"Manufacturer: \"{Manufacturer}\"");
            Console.WriteLine($"Year: \"{Year}\"");
            Console.WriteLine($"RentalPrice: \"{RentalPrice}\"");
        }
    }
}
