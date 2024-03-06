using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagersVehicle
{
    internal class Vehicle
    {
        protected string id { get; set ;}
        protected string name;
        protected int yom {  get; set ;}
        protected string color { get; set ; }
        protected double price;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get 
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Yom
        {
            get
            {
                return yom;
            }
            set
            {
                yom = value;
            }
        }
        protected int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set {
                amount = value;
            }
        }

        public Vehicle(string id, string name, int yom, string color, double price, int amount)
        {
            this.id = id;
            this.name = name;
            this.yom = yom;
            this.color = color;
            this.price = price;
            this.amount = amount;
        }
        public Vehicle() { }
        public virtual void input()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Input id: ");
                    this.id = Console.ReadLine();
                    Console.WriteLine("Input name: ");
                    this.name = Console.ReadLine();
                    Console.WriteLine("Input yom: ");
                    this.yom = Int16.Parse(Console.ReadLine());
                    Console.WriteLine("Input color: ");
                    this.color = Console.ReadLine();
                    Console.WriteLine("Input price: ");
                    this.price = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Input amount: ");
                    this.amount = Int16.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Try input one more !");
                }
            }
           
           
        }
        public virtual void output()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Year of maked: " + this.yom);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Amount: " + this.amount);
        }
    }
}
