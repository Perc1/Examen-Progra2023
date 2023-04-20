using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Item
    {
        public string name;
        public string itemtype;
        float price;

        public Item(string name, string itemtype, float price)
        {
            this.name = name;
            this.itemtype = itemtype;
            this.price = price;
        }

        public virtual void Datos()
        {
            Console.WriteLine("Item Name: " + name);
            Console.WriteLine("Item Type: " + itemtype);
            Console.WriteLine("Item Price: " + price);
        }

    }
}
