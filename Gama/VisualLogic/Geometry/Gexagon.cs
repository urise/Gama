using System;

namespace VisualLogic.Geometry
{
    public class Gexagon
    {
        private const double ROOT3 = 1.73205;
        public const int VERTEX_COUNT = 6;

        public static int GetSmallRadiusBySize(int size)
        {
            return Convert.ToInt32(ROOT3*size/2);
        }

        public IPoint Center { get; private set; }
        public int Size { get; private set; }
        public int SmallRadius { get; private set; }
        public Point[] Vertexes { get; private set; }

        public Gexagon(IPoint center, int size)
        {
            Center = center;
            SmallRadius = GetSmallRadiusBySize(size);
            Vertexes = new Point[VERTEX_COUNT];
            int halfSize = size/2;
            Vertexes[0] = new Point(Center.X, Center.Y - size);
            Vertexes[1] = new Point(Center.X + SmallRadius, Center.Y - halfSize);
            Vertexes[2] = new Point(Center.X + SmallRadius, Center.Y + halfSize);
            Vertexes[3] = new Point(Center.X, Center.Y + size);
            Vertexes[4] = new Point(Center.X - SmallRadius, Center.Y + halfSize);
            Vertexes[5] = new Point(Center.X - SmallRadius, Center.Y - halfSize);
        }
    }
}
