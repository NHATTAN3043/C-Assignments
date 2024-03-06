using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagersVehicle
{
    internal class ListTruck
    {
        List<Truck> trucks = new List<Truck>();
        public void inputListTruck()
        {
            int n = 0;
            Truck truck = null;
            do
            {
                truck = new Truck();
                truck.input();
                trucks.Add(truck);
                Console.WriteLine("Input 1 to Continue or any number to Exit");
                n = Int16.Parse(Console.ReadLine());
            } while (n == 1);
        }
        public void outputListTruck(IEnumerable<Truck> listT)
        {
            if (listT == null)
            {
                Console.WriteLine("List Cars isEmpty");
            }
            foreach (Truck truck in listT)
            {
                truck.output();
            }
        }
        public void outputListTruck()
        {
            if (trucks == null)
            {
                Console.WriteLine("List Cars isEmpty");
            }
            foreach (Truck truck in trucks)
            {
                truck.output();
            }
        }
        public void sortYomTruck()
        {
            var sortedCars = trucks.OrderByDescending(truck => truck.Yom).ToList();
            this.outputListTruck(sortedCars);
        }
        public void getManagerCompany()
        {
            // lay thong tin theo name va manager
            var truckInfo = trucks.Select(truck => $"{truck.Name} - {truck.ManagerCompany}");
            foreach (var truck in truckInfo)
            {
                Console.WriteLine($"Truck: {truck}");
            }
        }
    }
}
