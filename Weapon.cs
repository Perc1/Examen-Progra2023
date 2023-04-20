using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Weapon : Item, IDetails
    {
        protected string name;
        protected string itemtype;
        protected float damage;
        protected float attackSpeed;
        protected float price;

        protected Weapon(string name, float damage, float attackSpeed, float price, string itemtype) : base(name, itemtype , price)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.itemtype = itemtype;
            this.price = price;
        }

        protected virtual float GetDamagePerSecond()
        {
            return damage * attackSpeed;
        }

        protected virtual float GetPrice()
        {
            return price;
        }

        public string GetDetails()
        {
            return $"{name}: tiene {GetDamagePerSecond()} de daño por segundo y su precio total es de {GetPrice()}";
        }
    }
}
