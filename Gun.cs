using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Gun : RangeWeapon
    {
        public Gun(string name, float damage, float attackSpeed, float price, Ammo ammo) : base(name, damage, attackSpeed, price, ammo)
        {
        }
    }
}
