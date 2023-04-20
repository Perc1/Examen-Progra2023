using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class MeleeWeapon : Weapon
    {
        protected MeleeWeapon(string name, float damage, float attackSpeed, float price, string itemtype) : base(name, damage, attackSpeed, price,itemtype)
        {
        }
    }
}
