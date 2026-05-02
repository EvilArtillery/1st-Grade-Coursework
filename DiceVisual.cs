using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicey_Chances
{
    public class DiceVisual
    {
        public int Value { get; set; }
        public PointF Position { get; set; }      // Center position
        public float Size { get; set; }           // Radius/scale
        public DiceShape Shape { get; set; }
        public int SidesCount { get; set; }
        public float Rotation { get; set; }       // Optional: random rotation per throw

        private PointF[] _cachedPolygon;
        private GraphicsPath _cachedPath;

        // Get polygon points in screen coordinates
        public PointF[] GetScreenPolygon()
        {
            if (_cachedPolygon != null) return _cachedPolygon;

            var baseShape = DiceShapes.GetShape(Shape);
            float cos = (float)Math.Cos(Rotation);
            float sin = (float)Math.Sin(Rotation);

            _cachedPolygon = baseShape.Select(p =>
            {
                // Rotate around origin, then translate to position
                float rx = p.X * cos - p.Y * sin;
                float ry = p.X * sin + p.Y * cos;
                return new PointF(
                    Position.X + rx * Size,
                    Position.Y + ry * Size
                );
            }).ToArray();

            return _cachedPolygon;
        }

        public GraphicsPath GetHitboxPath()
        {
            if (_cachedPath != null) return _cachedPath;

            var pts = GetScreenPolygon();
            _cachedPath = new GraphicsPath();
            _cachedPath.AddPolygon(pts);
            return _cachedPath;
        }

        public void InvalidateCache()
        {
            _cachedPolygon = null;
            _cachedPath?.Dispose();
            _cachedPath = null;
        }

        // Bounding box for quick rejection before precise collision
        public RectangleF GetBounds()
        {
            var pts = GetScreenPolygon();
            float minX = pts.Min(p => p.X);
            float maxX = pts.Max(p => p.X);
            float minY = pts.Min(p => p.Y);
            float maxY = pts.Max(p => p.Y);
            return new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }
    }
}
