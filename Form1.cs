using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dicey_Chances
{
    public partial class GameWindow : Form
    {
        private static readonly Random _rnd = new Random();

        Die[] dice = new Die[1];
        int GlobalID = 0;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            int[] basesides = { 1, 2, 3, 4, 5, 6, };
            dice[0] = new Die(GlobalID, basesides);
            GlobalID ++;
        }
    }
}
