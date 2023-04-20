using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ConvoList : NPC
    {
        string Convo1;
        string Convo2;
        string Convo3;

        public ConvoList (string Convo1, string Convo2, string Convo3)
        {
            this.Convo1 = Convo1;
            this.Convo2 = Convo2;
            this.Convo3 = Convo3;
        }
    }
}
