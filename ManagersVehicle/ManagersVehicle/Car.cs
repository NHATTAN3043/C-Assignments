using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagersVehicle
{
    internal class Car : Vehicle
    {
        private string manufacturer;
        public string Manufacturer{
            get{
                return manufacturer;
             }
            set { 
                manufacturer = value;
            }

        }
        public Car(string id, string name, int yom, string color, double price, int amount, string manufacturer) : base(id, name, yom, color, price, amount)
        {
            this.manufacturer = manufacturer;
        }
        public Car() { }

        public override void input()
        {
            base.input();
            Console.WriteLine("Input manufacturer: ");
            this.manufacturer = Console.ReadLine();
        }

        public override void output()
        {
            Console.WriteLine($"ID: {this.id} | Name: {this.name} | YOM: {this.yom} | Color: {this.color} | Price: {this.price} | Amount: {this.amount} | Manufacturer: {this.manufacturer}");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
