using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Sword : MeleeWeapon
    {
        public Sword(string name, float damage, float attackSpeed, float price) : base(name, damage, attackSpeed, price)
        {
        }
    }
}
