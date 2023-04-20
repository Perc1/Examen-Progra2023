using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Enemigo : NPC
    {
        List<Items> items = new List<Items>();
        float experience;
        int level;
        float damage;


        public virtual float GetDamage(float damage)
        {
            this.damage = damage;
            return damage;
        }

        public virtual float GetExperience(float experience)
        {
            this.experience = experience;
            return experience;
        }

        public virtual float GetLevel(int level)
        {
            this.level = level;
            return level;
        }

        public string ShowData()
        {
            return "Daño: " + damage + "  " + "Experiencia: " + experience + "   " +" Nivel: " + level;
        }
        public void GetItem(Items item)
        {
            items.Add(item);
        }
    }
}
