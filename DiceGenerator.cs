using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicey_Chances
{
    public partial class DiceGenerator : Form
    {
        GameWindow MotherForm;
        public DiceGenerator()
        {
            InitializeComponent();
        }

        public DiceGenerator(GameWindow gameWindow)
        {
            InitializeComponent();
            MotherForm = gameWindow;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MotherForm.DiceListReload();
            Close();
        }

        private void DiceGenerator_Load(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>
                { pictureBox4, pictureBox6, pictureBox8, pictureBox10, pictureBox12, pictureBox20 };
            List<Label> labels = new List<Label> { label4, label6, label8, label10, label12, label20 };
            int[] ints = { 4, 6, 8, 10, 12, 20 };
            int amount;
            for (int i = 0; i < 6; i++)
            {
                pictureBoxes[i].Image = Image.FromFile($"Dice{ints[i]}Sides.jpg");
                if (!MotherForm.diceAmount.TryGetValue(ints[i], out amount)) amount = 0;
                labels[i].Text = amount.ToString();
                labels[i].Location = new Point(pictureBoxes[i].Location.X + pictureBoxes[i].Width / 2 - labels[i].Width / 2,
                    pictureBoxes[i].Location.Y + pictureBoxes[i].Height / 2 - labels[i].Height / 2);
            }
        }

        private void button4Up_Click(object sender, EventArgs e)
        {
            MotherForm.diceAmount[4] += 1;
            MotherForm.AddDie(Enumerable.Range(1, 4).ToArray());
            label4.Text = MotherForm.diceAmount[4].ToString();
        }

        private void button4Down_Click(object sender, EventArgs e)
        {
            if (MotherForm.diceAmount[4] == 0) return;
            MotherForm.diceAmount[4] -= 1;
            MotherForm.RemoveDie(Enumerable.Range(1, 4).ToArray());
            label4.Text = MotherForm.diceAmount[4].ToString();
        }

        private void button6Up_Click(object sender, EventArgs e)
        {
            MotherForm.diceAmount[6] += 1;
            MotherForm.AddDie(Enumerable.Range(1, 6).ToArray());
            label6.Text = MotherForm.diceAmount[6].ToString();
        }

        private void button8Up_Click(object sender, EventArgs e)
        {
            MotherForm.diceAmount[8] += 1;
            MotherForm.AddDie(Enumerable.Range(1, 8).ToArray());
            label8.Text = MotherForm.diceAmount[8].ToString();
        }

        private void button10Up_Click(object sender, EventArgs e)
        {
            MotherForm.diceAmount[10] += 1;
            MotherForm.AddDie(Enumerable.Range(1, 10).ToArray());
            label10.Text = MotherForm.diceAmount[10].ToString();
        }

        private void button12Up_Click(object sender, EventArgs e)
        {
            MotherForm.diceAmount[12] += 1;
            MotherForm.AddDie(Enumerable.Range(1, 12).ToArray());
            label12.Text = MotherForm.diceAmount[12].ToString();
        }

        private void button20Up_Click(object sender, EventArgs e)
        {
            MotherForm.diceAmount[20] += 1;
            MotherForm.AddDie(Enumerable.Range(1, 20).ToArray());
            label20.Text = MotherForm.diceAmount[20].ToString();
        }

        private void button6Down_Click(object sender, EventArgs e)
        {
            if (MotherForm.diceAmount[6] == 0) return;
            MotherForm.diceAmount[6] -= 1;
            MotherForm.RemoveDie(Enumerable.Range(1, 6).ToArray());
            label6.Text = MotherForm.diceAmount[6].ToString();
        }

        private void button8Down_Click(object sender, EventArgs e)
        {
            if (MotherForm.diceAmount[8] == 0) return;
            MotherForm.diceAmount[8] -= 1;
            MotherForm.RemoveDie(Enumerable.Range(1, 8).ToArray());
            label8.Text = MotherForm.diceAmount[8].ToString();
        }

        private void button10Down_Click(object sender, EventArgs e)
        {
            if (MotherForm.diceAmount[10] == 0) return;
            MotherForm.diceAmount[10] -= 1;
            MotherForm.RemoveDie(Enumerable.Range(1, 10).ToArray());
            label10.Text = MotherForm.diceAmount[10].ToString();
        }

        private void button12Down_Click(object sender, EventArgs e)
        {
            if (MotherForm.diceAmount[12] == 0) return;
            MotherForm.diceAmount[12] -= 1;
            MotherForm.RemoveDie(Enumerable.Range(1, 12).ToArray());
            label12.Text = MotherForm.diceAmount[12].ToString();
        }

        private void button20Down_Click(object sender, EventArgs e)
        {
            if (MotherForm.diceAmount[20] == 0) return;
            MotherForm.diceAmount[20] -= 1;
            MotherForm.RemoveDie(Enumerable.Range(1, 20).ToArray());
            label20.Text = MotherForm.diceAmount[20].ToString();
        }
    }
}
