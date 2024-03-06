using System;

namespace ManagersVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ListCar cars = new ListCar();
            cars.inputListCar();
            Console.WriteLine("LIST CARS: ");
            cars.outputListCar();
            cars.groupByMFTandSumValues();
          //  Console.WriteLine("Danh sach xe sau khi loc Price: ");
           // cars.filterPriceCar(100000, 250000);
           // Console.WriteLine("Danh sach xe sau khi loc YOM: ");
           // cars.filterYomCar(1990); */
            ListTruck trucks = new ListTruck();
            trucks.inputListTruck();
            Console.Write("LIST TRUCK");
            trucks.outputListTruck();
            trucks.getManagerCompany();
           // trucks.sortYomTruck();

        }
    }
}
