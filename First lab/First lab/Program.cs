using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstApp
{


    class Product
    {
        private byte id;
        private string date;
        private double price;

        public ushort GetId()
        {
            return this.id;
        }
        public void SetId(ushort id)
        {
            this.id = id;
        }

        public string GetDate()
        {
            return this.date;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }




        public Product()
        {
            //"Empty Parameterized Constructor"
        }

        public Product(byte id, string date, double price, AddressFormat address)
        {
            this.SetId(id);
            this.SetDate(Date);
            this.SetPriceprice);

        }

        public void ShowPoductInfo()
        {
            Console.WriteLine("Product Info:");
            Console.WriteLine("Product ID: {0}", this.GetId());
            Console.WriteLine("Product Date: {0}", this.GetDate());
            Console.WriteLine("Product Price: {0}\n", this.GetPrice());

        }
    }
}