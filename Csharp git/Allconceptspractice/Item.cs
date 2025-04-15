using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allconceptspractice
{
    public class Item
    {
        public string Name {  get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Item(string name , int quan , double price) 
        { 
            this.Name = name;
            this.Quantity = quan;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Item: {Name}, Quantity: {Quantity}, Price: {Price}";
        }

    }
}
