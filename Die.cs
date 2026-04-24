using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicey_Chances
{
    internal class Die
    {
        public static int amount { get; protected set; } = 0;
        public int id { get; protected set; }
        public int[] Sides { get; protected set; }
        Random rand = new Random();

        public Die(int[] sides)
        {
            id = amount;
            amount++;
            Sides = sides;
        }

        public Die()
        {
            id = amount;
            amount++;
            Sides = new int[6];
            Sides[0] = 1;
            Sides[1] = 2;
            Sides[2] = 3;
            Sides[3] = 4;
            Sides[4] = 5;
            Sides[5] = 6;
        }
    }
}
