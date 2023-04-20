using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Seller : NPC, IshowData
    {

        List<Item> item = new List<Item>();
        float money;

        public Seller(float money) 
        {
            this.money = money;
        }

        public virtual float GetMoney(float money)
        {
            this.money = money;
            return money;
        }


        public string ShowData()
        {
            return "Dinero: " + money;
        }
    }
}
