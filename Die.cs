using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicey_Chances
{
    internal class Die
    {
        public int id { get; protected set; }
        public int[] Sides { get; protected set; }

        public Die(int id, int[] sides)
        {
            this.id = id;
            Sides = sides;
        }

        public Die()
        {
            id = 0;
            Sides = new int[6];
        }
    }
}
