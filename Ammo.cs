using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Ammo : Item
    {
        protected float damage;
        protected float price;

        public float Damage { get { return damage; } }
        public float Price { get { return price; } }

        protected Ammo(string name,float damage, float price, string itemtype) : base(name,itemtype,price)
        {
            this.damage = damage;
        }


    }
}
