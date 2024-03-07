using System;
using System.Runtime.CompilerServices;

namespace ManagersVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            while (n != 0)
            {
                Console.WriteLine("Input 1 LISTCAR || Input 2 LISTTRUCK || Input 0 EXIT");
                n = int.Parse(Console.ReadLine());
                if (n != 1 && n != 2)
                {
                    Console.WriteLine("Thank you for use ");

                }
                else
                {
                    if (n == 1)
                    {
                        ListCar cars = new ListCar();
                        string i = null;
                        do
                        {
                            Console.WriteLine("Input 'a' to Input data| 'b' Print ListCar| 'c' filter price| 'd' filter yom| 'f' group by MFT");
                            Console.WriteLine("Input E to EXIT");
                            i = Console.ReadLine();
                            switch (i.ToLower())
                            {
                                case "a":
                                    cars.inputListCar(); break;
                                case "b":
                                    Console.WriteLine("===== LIST CAR ====");
                                    cars.outputListCar(); break;
                                case "c":
                                    Console.WriteLine("== LIST CAR HAVE PRICE 100.000 - 250.000 ==");
                                    cars.filterPriceCar(100000, 250000);
                                    break;
                                case "d":
                                    Console.WriteLine("== LIST CAR'S YOM > 1990 ==");
                                    cars.filterYomCar(1990); break;
                                case "f":
                                    Console.WriteLine("==GROUP BY MFT and Total Values ==");
                                    cars.groupByMFTandSumValues();
                                    break;
                                case "e": break;
                                default: Console.WriteLine("Please input correct"); break;

                            }
                        } while (i != "e");
                    }
                    if (n == 2)
                    {
                        ListTruck trucks = new ListTruck();
                        string u = null;
                        do
                        {
                            Console.WriteLine("Input 'a' to input LISTTRUCK| 'b' Print LIST TRUCK| 'c' get Manager Company| 'd' Sort YOM ");
                            Console.WriteLine("Input 'e' to EXIT");
                            u = Console.ReadLine();
                            switch (u.ToLower())
                            {
                                case "a":
                                    trucks.inputListTruck(); break;
                                case "b":
                                    Console.WriteLine("===== LIST TRUCK ====");
                                    trucks.outputListTruck(); break;
                                case "c":
                                    Console.WriteLine("== LIST MANAGER COMPANY ==");
                                    trucks.getManagerCompany();
                                    break;
                                case "d":
                                    Console.WriteLine("== SORT BY YEAR OF MAKE ==");
                                    trucks.sortYomTruck(); break;
                                case "e": break;
                                default: Console.WriteLine("Please input correct"); break;

                            }
                        } while (u != "e");
                    }
                }
            }
                    
        }
    }
}
