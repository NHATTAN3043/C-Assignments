using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagersVehicle
{
    internal class Truck : Vehicle
    {
        private string managerCompany;
        public string ManagerCompany
        {
            get { return managerCompany; }
            set { managerCompany = value; }
        }

        public Truck(string id, string name, int yom, string color, double price, int amount, string managerCompany) : base(id, name, yom, color, price, amount)
        {
            this.managerCompany = managerCompany;
        }
        public Truck() { }

        public override void input()
        {
            base.input();
            Console.WriteLine("Input ManagerCompany: ");
            this.managerCompany = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("ManagerCompany: " + this.managerCompany);

        }
    }
}
