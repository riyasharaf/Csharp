using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Allconceptspractice
{
    //    Design a ShoppingCart class where :
    //Each cart can hold up to 5 items.
    //Use an indexer to get/set items in the cart.
    //    Use a constructor to initialize the cart.
    //Add a method GetTotalItems() that returns how many items are in the cart.
    //Use a property CustomerName with get and set.
    //Write code to demonstrate:
    //Creating a cart
    //Adding items  
    //Displaying total items and customer name


    public class Shoppingcart
    {
        private new Item[] i1 = new Item[3];
        public string CustName { get; set; }

        public Shoppingcart(string CustName)
        {
            this.CustName = CustName;
        }

        public Item this[int index]
        {
            get { return i1[index]; }
            set { i1[index] = value; }

        }

        public int totalitems()
        {
            int count = 0;
            foreach (var items in i1)
            {
                if (items != null) { count++; }


            }
            return count;
        }
    }
}
