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
        List<Die> dice = new List<Die>();
        List<(int value, Rectangle rect)> currentDice = new List<(int, Rectangle)>();
        private int throwScore = -1, totalScore = -1;
        private int diceSize = 64;
        public Dictionary<int, int> diceAmount = new Dictionary<int, int>();
        

        public GameWindow()
        {
            InitializeComponent();
            panelDiceBox.Paint += panelDiceBox_Paint;
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            int[] basesides = { 1, 2, 3, 4, 5, 6 };
            dice.Add(new Die());
            dice.Add(new Die());
            diceAmount[4] = 0;
            diceAmount[6] = 2;
            diceAmount[8] = 0;
            diceAmount[10] = 0;
            diceAmount[12] = 0;
            diceAmount[20] = 0;
            labelTotalScore.Text = "0";
            DiceListReload();
        }

        public void DiceListReload()
        {
            listBoxDice.Items.Clear();
            int amount = -1;
            foreach (int i in new List<int>{ 4, 6 ,8, 10, 12, 20})
                if (diceAmount.TryGetValue(i, out amount) && amount != 0)
                    listBoxDice.Items.Add($"{i}-sided dice: " + amount.ToString());
        }

        private void buttonThrowDice_Click(object sender, EventArgs e)
        {
            currentDice.Clear();
            int result = 0;

            foreach (Die d in dice)
            {
                int throwResult = d.Sides[_rnd.Next(d.Sides.Length)];
                result += throwResult;
                Rectangle rect = FindNonOverlappingPosition(_rnd, currentDice.Select(c => c.rect).ToList());
                currentDice.Add((throwResult, rect));
            }
            panelDiceBox.Invalidate();
            if (throwScore == -1) throwScore = 0;
            throwScore = result;
            labelThrowScore.Text = "Score: " + throwScore.ToString();
        }

        private void panelDiceBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var (value, rect) in currentDice)
            {
                e.Graphics.DrawImage(Image.FromFile($"Dice_{value}.png"), rect);
            }
        }

        private void buttonCountScore_Click(object sender, EventArgs e)
        {
            if (totalScore == -1) totalScore = 0;
            totalScore += throwScore;
            labelTotalScore.Text = totalScore.ToString();
            currentDice.Clear();
            panelDiceBox.Invalidate();
        }

        private bool IsOverlapping(Rectangle candidate, List<Rectangle> existingDice)
        {
            // padding gap so dice aren't touching
            const int padding = 5;
            Rectangle padded = new Rectangle(
                candidate.X - padding,
                candidate.Y - padding,
                candidate.Width + (padding * 2),
                candidate.Height + (padding * 2));

            foreach (var rect in existingDice)
            {
                if (padded.IntersectsWith(rect))
                    return true;
            }
            return false;
        }

        private void buttonScoreReset_Click(object sender, EventArgs e)
        {
            totalScore = 0;
            labelTotalScore.Text = totalScore.ToString();
        }

        private void buttonDiceGenerator_Click(object sender, EventArgs e)
        {
            DiceGenerator generator = new DiceGenerator(this);
            generator.ShowDialog();
        }

        private Rectangle FindNonOverlappingPosition(Random random, List<Rectangle> existingDice)
        {
            // margin so dice aren't touching the walls
            int margin = 10;
            int attempts = 0;
            Rectangle candidate;

            int maxX = Math.Max(margin, panelDiceBox.Width - diceSize - margin);
            int maxY = Math.Max(margin, panelDiceBox.Height - diceSize - margin);

            if (maxX <= 0 || maxY <= 0) throw new InvalidOperationException("Panel is too small to fit dice.");

            do
            {
                int x = random.Next(0, maxX + 1);
                int y = random.Next(0, maxY + 1);
                candidate = new Rectangle(x, y, diceSize, diceSize);

                attempts++;
                if (attempts >= 500) throw new InvalidOperationException("Could not place dice without overlap.");

            } while (IsOverlapping(candidate, existingDice));

            return candidate;
        }

        public void AddDie(int[] sides)
        {
            Die die = new Die(sides);
            dice.Add(die);
        }

        public void RemoveDie(int[] sides)
        {
            foreach (Die die in dice)
                if (die.Sides.SequenceEqual(sides))
                {
                    dice.Remove(die);
                    return;
                }
        }
    }
}
