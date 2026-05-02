using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicey_Chances
{
    public enum DiceShape
    {
        Square,    // d6
        Diamond,   // d8
        Rhombus,   //d10
        Triangle,  // d4
        Pentagon,  // might be useful
        Hexagon,   // d20
        Icosagon   // d12
    }
    public static class DiceShapes
    {
        // Returns polygon points centered at (0,0), roughly fitting in -1..1 range
        public static PointF[] GetShape(DiceShape shape)
        {
            switch (shape)
            {
                case DiceShape.Square:
                    return new[] {
                        new PointF(-1, -1), new PointF(1, -1),
                        new PointF(1, 1), new PointF(-1, 1)
                    };

                case DiceShape.Triangle:
                    return new[] {
                        new PointF(0, -1.15f),
                        new PointF(1, 0.58f),
                        new PointF(-1, 0.58f)
                    };

                case DiceShape.Diamond:
                    return new[] {
                        new PointF(0, -0.8f),
                        new PointF(0.85f, 0.3f),
                        new PointF(0, 0.6f),
                        new PointF(-0.85f, 0.3f)
                    };

                case DiceShape.Rhombus:
                    return new[]
                    {
                        new PointF(0, -0.9f),
                        new PointF(0.6f, 0.6f),
                        new PointF(0, 1.3f),
                        new PointF(-0.6f, 0.6f)
                    };

                case DiceShape.Pentagon:
                    return RegularPolygon(5, 1.1f);

                case DiceShape.Hexagon:
                    return RegularPolygon(6, 1.1f);

                case DiceShape.Icosagon:
                    // d12 as 10-sided polygon
                    return RegularPolygon(10, 1.15f);

                default:
                    return GetShape(DiceShape.Square);
            }
        }

        private static PointF[] RegularPolygon(int sides, float radius)
        {
            var points = new PointF[sides];
            for (int i = 0; i < sides; i++)
            {
                double angle = (Math.PI * 2 * i / sides) - Math.PI / 2;
                points[i] = new PointF(
                    (float)(radius * Math.Cos(angle)),
                    (float)(radius * Math.Sin(angle))
                );
            }
            return points;
        }

        // Map side count to shape
        public static DiceShape ShapeForSides(int sides)
        {
            switch (sides)
            {
                case 4: return DiceShape.Triangle;
                case 6: return DiceShape.Square;
                case 8: return DiceShape.Diamond;
                case 10: return DiceShape.Rhombus;
                case 12: return DiceShape.Icosagon;
                case 20: return DiceShape.Hexagon;
                default: return DiceShape.Square;
            }
        }
    }
}
