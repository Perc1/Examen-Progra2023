﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Bullet : Ammo
    {
        public Bullet(string name ,float damage, float price,string itemtype) : base(name,damage, price, itemtype)
        {
        }
    }
}
