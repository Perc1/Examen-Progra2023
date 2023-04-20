using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Potion : IshowData
    {
        float health;
        public Potion(float health)
        {
            this.health = health;

        }


        public string ShowData() 
        {
            return $"{health}";
        }

    }
}
