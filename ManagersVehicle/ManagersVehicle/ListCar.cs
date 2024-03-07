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
        // ham nhap list car
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
        // ham in list car co doi 
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
        // ham in khong doi
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
        // ham loc xe theo gia xe
        public  void filterPriceCar(double start, double end)
        {
            var list = listCars.Where(car => car.Price > start && car.Price < end);
            if (list == null)
                Console.WriteLine("LIST CAR IS EMPTY ");
            else
                this.outputListCar(list);

        }
        // ham loc xe theo nam san xuat 
        public void filterYomCar(int yom)
        {
            var list = listCars.Where(car => car.Yom > yom);
            if (list == null)
                Console.WriteLine("LIST CAR IS EMPTY ");
            else
                this.outputListCar(list);        
        }
        // ham nhom xe theo hang san xuat va tinh tong gia tri xe cua hang do
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
