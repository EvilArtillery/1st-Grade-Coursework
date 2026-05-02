using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicey_Chances
{
    public partial class GameWindow : Form
    {
        private static readonly Random _rnd = new Random();
        List<Die> dice = new List<Die>();
        List<DiceVisual> currentDice = new List<DiceVisual>();  // Replaces (int, Rectangle)
        private int throwScore = -1, totalScore = -1;
        private int diceSize = 64;
        public Dictionary<int, int> diceAmount = new Dictionary<int, int>();
        private const int HITBOX_PADDING = 5;
        

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

                var visual = FindNonOverlappingPosition(d.Sides.Length, throwResult);
                currentDice.Add(visual);
            }

            panelDiceBox.Invalidate();
            throwScore = result;
            labelThrowScore.Text = "Score: " + throwScore.ToString();
        }

        private void panelDiceBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var dice in currentDice)
            {
                // Try to load shape-specific image, fallback to generic
                string imagePath = "";
                if (dice.SidesCount == 6) imagePath = $"Dice_{dice.Value.ToString()}.png";

                Image img = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
                DiceRenderer.DrawDice(e.Graphics, dice, img);
                img?.Dispose();
            }
        }

        private void buttonCountScore_Click(object sender, EventArgs e)
        {
            if (totalScore == -1) totalScore = 0;
            totalScore += throwScore;
            throwScore = 0;
            labelTotalScore.Text = totalScore.ToString();
            currentDice.Clear();
            panelDiceBox.Invalidate();
        }

        private bool IsOverlapping(DiceVisual candidate)
        {
            var candidatePoly = candidate.GetScreenPolygon();

            foreach (var existing in currentDice)
            {
                var existingPoly = existing.GetScreenPolygon();

                if (PolygonCollision.PolygonsIntersectWithPadding(
                    candidatePoly, existingPoly, HITBOX_PADDING))
                {
                    return true;
                }
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

        private DiceVisual FindNonOverlappingPosition(int sidesCount, int value)
        {
            int margin = 10;
            int attempts = 0;
            DiceVisual candidate;

            var shape = DiceShapes.ShapeForSides(sidesCount);
            float maxX = Math.Max(margin, panelDiceBox.Width - margin);
            float maxY = Math.Max(margin, panelDiceBox.Height - margin);

            do
            {
                candidate = new DiceVisual
                {
                    Value = value,
                    SidesCount = sidesCount,
                    Shape = shape,
                    Size = diceSize / 2f,  // Size is radius
                    Position = new PointF(
                        (float)(_rnd.NextDouble() * (maxX - margin * 2 - diceSize) + margin + diceSize / 2),
                        (float)(_rnd.NextDouble() * (maxY - margin * 2 - diceSize) + margin + diceSize / 2)
                    ),
                    Rotation = DiceRenderer.RandomRotation(_rnd, shape)
                };

                attempts++;
                if (attempts >= 500)
                    throw new InvalidOperationException("Could not place dice without overlap.");

            } while (IsOverlapping(candidate));

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
