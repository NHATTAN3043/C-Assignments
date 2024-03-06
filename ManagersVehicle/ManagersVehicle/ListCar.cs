using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagersVehicle
{
    internal class ListCar : Car
    {
        List<Car> listCars = new List<Car>();
        public void inputListCar()
        {
            int n = 0;
            Car car = null;
            do
            {
                car = new Car();
                car.input();
                listCars.Add(car);
                Console.WriteLine("Input 1 to Continue or any number to Exit");
                n = Int16.Parse(Console.ReadLine());
            } while (n == 1);
        }
        public void outputListCar(IEnumerable<Car> listC)
        {
            if (listC == null)
            {
                Console.WriteLine("List Cars isEmpty");
            }
            foreach (Car car in listC)
            {
                car.output();
            }
        }
        public void outputListCar()
        {
            if (listCars == null)
            {
                Console.WriteLine("List Cars isEmpty");
            }
            foreach (Car car in listCars)
            {
                car.output();
            }
        }
        public  void filterPriceCar(double start, double end)
        {
            var list = listCars.Where(car => car.Price > start && car.Price < end);
            this.outputListCar(list);

        }
        public void filterYomCar(int yom)
        {
            var list = listCars.Where(car => car.Yom > yom);
            this.outputListCar(list);
        }
        public void groupByMFTandSumValues()
        {
            var list = listCars
             .GroupBy(car => car.Manufacturer)
             .Select(group => new
             {
                 Manufacturer = group.Key,
                 TotalValues = group.Sum(car => car.Price * car.Amount)
             }) ;
            foreach (var item in list)
            {
                Console.WriteLine($"Manufacturer: {item.Manufacturer}, Total values: {item.TotalValues}");
            }
           
        }
    }
}
