using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Product
    {
        public int stock;
        public string name;
        public int cost;
        public string company;
        public int price;

        public Product(int stock, string name, int cost, string company, int price)
        {
            this.stock = stock;
            this.name = name;
            this.cost = cost;
            this.company = company;
            this.price = price;

            Console.WriteLine("Product");
            Console.WriteLine("Name:" + name + "\n Stock: " + stock + 
                "\n Cost: " + cost + 
                "\n Company: " + company + 
                "\n Price: " + price);
        }
    }
}
