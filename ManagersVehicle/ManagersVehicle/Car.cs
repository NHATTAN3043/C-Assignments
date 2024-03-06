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
            base.output();
            Console.WriteLine("Manufacturer: " + this.manufacturer);
        }
    }
}
