using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Enemigo : NPC
    {
        List<Item> items = new List<Item>();
        float experience;
        int level;
        float damage;
        string name;
        float life;
        string type;


        public Enemigo(string name, float life, string type,float experience,int level,float damage) : base(name,life,type)
        {
            this.name = name;
            this.life = life;
            this.type = type;
            this.experience = experience;
            this.level = level;
            this.damage = damage;
        }

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
        public void GetItem(Item item)
        {
            items.Add(item);
        }
    }
}
