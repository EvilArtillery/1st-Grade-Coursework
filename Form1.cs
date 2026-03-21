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
        private static Random _rnd = new Random();

        public GameWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var die = new PictureBox();

            die.Width = 70;
            die.Height = 70;
            die.SizeMode = PictureBoxSizeMode.CenterImage;
            die.BackColor = Color.Red;

            // load image from application folder (ensure Dice_One.png is copied to output)
            var imagePath = Path.Combine(Application.StartupPath, "Dice_One.png");
            if (File.Exists(imagePath))
            {
                die.Image = Image.FromFile(imagePath);
            }

            // position relative to DiceBox so the PictureBox appears somewhere inside it
            var maxX = Math.Max(1, DiceBox.Width - die.Width);
            var maxY = Math.Max(1, DiceBox.Height - die.Height);
            die.Location = new Point(_rnd.Next(0, maxX), _rnd.Next(0, maxY));

            // add to DiceBox so it's visually contained there
            DiceBox.Controls.Add(die);
            die.BringToFront();
        }
    }
}
