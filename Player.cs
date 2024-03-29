﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Player : IshowData
    {
        string name;
        List<Item> items = new List<Item>();
        float experience;
        int level;
        float money;

        public Player(string name, float experience, int level, float money)
        {
            this.name = name;
            this.experience = experience;
            this.level = level;
            this.money = money;
        }

        public virtual string GetName(string name)
        {
            this.name = name;
            return name;
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
            return "Nombre: " + name + " " + "Experiencia: " + experience + " " + "Nivel: " + level;
        }
        public string GetDetails()
        {
            return "Nombre: " + name + " " + "Experiencia: " + experience + " " + "Nivel: " + level;
        }

        public void GetItem(Item item)
        {
            items.Add(item);
        }
    }

}
