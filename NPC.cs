using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class NPC
    {
        protected string name;
        protected float life;
        protected string type;


        public NPC(string name, float life, string type)
        {
            this.name = name;
            this.life = life;
            this.type = type;
        }

        public abstract string GiveType();
    }
}
