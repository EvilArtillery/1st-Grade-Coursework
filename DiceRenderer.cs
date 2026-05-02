using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicey_Chances
{
    public static class DiceRenderer
    {
        public static void DrawDice(Graphics g, DiceVisual dice, Image dieImage = null)
        {
            var polygon = dice.GetScreenPolygon();

            // Optional: clip image to polygon shape
            if (dieImage != null)
            {
                using (var path = new GraphicsPath())
                {
                    path.AddPolygon(polygon);

                    // Save state
                    var oldClip = g.Clip;
                    var oldTransform = g.Transform;

                    // Set clip region to polygon
                    g.SetClip(path, CombineMode.Replace);

                    // Draw image filling the polygon bounds
                    var bounds = dice.GetBounds();
                    g.DrawImage(dieImage, bounds);

                    // Restore
                    g.Clip = oldClip;
                    g.Transform = oldTransform;
                }
            }
            else
            {
                // Fallback: draw colored polygon with value
                using (var brush = new SolidBrush(Color.LightBlue))
                using (var pen = new Pen(Color.DarkBlue, 2))
                {
                    g.FillPolygon(brush, polygon);
                    g.DrawPolygon(pen, polygon);

                    // Draw value in center
                    using (var font = new Font("Arial", dice.Size * 0.5f))
                    using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    {
                        g.DrawString(dice.Value.ToString(), font, Brushes.Black, dice.Position, sf);
                    }
                }
            }

            // Optional: draw hitbox outline for debugging
            // g.DrawPolygon(Pens.Red, polygon);
        }

        // Generate rotated variant for visual variety
        public static float RandomRotation(Random rnd, DiceShape shape)
        {
            if (shape == DiceShape.Square) return 0; // Squares look same rotated
            return (float)(rnd.NextDouble() * Math.PI * 2);
        }
    }
}
