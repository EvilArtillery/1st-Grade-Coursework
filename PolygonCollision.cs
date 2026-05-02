using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicey_Chances
{
    public static class PolygonCollision
    {
        // Separating Axis Theorem (SAT) for convex polygons
        public static bool PolygonsIntersect(PointF[] polyA, PointF[] polyB)
        {
            // Quick AABB rejection
            var boundsA = GetBounds(polyA);
            var boundsB = GetBounds(polyB);
            if (!boundsA.IntersectsWith(boundsB))
                return false;

            // SAT: check all edges of both polygons as separating axes
            var axes = GetAxes(polyA).Concat(GetAxes(polyB)).ToArray();

            foreach (var axis in axes)
            {
                var projA = Project(polyA, axis);
                var projB = Project(polyB, axis);

                if (!IntervalsOverlap(projA, projB))
                    return false; // Found separating axis
            }

            return true; // No separating axis found = intersection
        }

        private static IEnumerable<PointF> GetAxes(PointF[] polygon)
        {
            for (int i = 0; i < polygon.Length; i++)
            {
                var point1 = polygon[i];
                var point2 = polygon[(i + 1) % polygon.Length];

                var side = new PointF(point2.X - point1.X, point2.Y - point1.Y);

                var normal = new PointF(-side.Y, side.X);

                // Normalize
                float len = (float)Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y);
                if (len > 0.001f)
                    yield return new PointF(normal.X / len, normal.Y / len);
            }
        }

        private static (float min, float max) Project(PointF[] polygon, PointF axis)
        {
            float min = float.MaxValue;
            float max = float.MinValue;

            foreach (var p in polygon)
            {
                float dot = p.X * axis.X + p.Y * axis.Y;
                min = Math.Min(min, dot);
                max = Math.Max(max, dot);
            }

            return (min, max);
        }

        private static bool IntervalsOverlap((float min, float max) a, (float min, float max) b)
        {
            return a.max >= b.min && b.max >= a.min;
        }

        private static RectangleF GetBounds(PointF[] poly)
        {
            return new RectangleF(
                poly.Min(p => p.X),
                poly.Min(p => p.Y),
                poly.Max(p => p.X) - poly.Min(p => p.X),
                poly.Max(p => p.Y) - poly.Min(p => p.Y)
            );
        }

        // Padding for "not touching" requirement
        public static bool PolygonsIntersectWithPadding(PointF[] polyA, PointF[] polyB, float padding)
        {
            if (padding <= 0) return PolygonsIntersect(polyA, polyB);

            // Inflate polygons by padding (simplified: expand bounds check)
            var boundsA = GetBounds(polyA);
            var boundsB = GetBounds(polyB);
            boundsA.Inflate(padding, padding);
            boundsB.Inflate(padding, padding);

            if (!boundsA.IntersectsWith(boundsB))
                return false;

            return PolygonsIntersect(polyA, polyB);
        }
    }
}
