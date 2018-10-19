using System;

namespace RandomBoxes
{
    class Triangle
    {
        public int directionX { get; private set; }
        public int directionY { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Size { get; private set; }
        private int _minimumSize = 1;

        public Triangle(Random random, int maxX, int maxSize)
        {
            directionX = random.Next(0, 2);
            directionY = random.Next(0, 2);
            X = random.Next(0, maxX - _minimumSize);
            Y = random.Next(0, maxSize - _minimumSize);
            Size = random.Next(_minimumSize, maxSize);
        }

        public string GetCharacter(int row, int col)
        {

            if (row < Y || col < X) return null;
            var internalX = col - X;
            var internalY = row - Y;
            if (internalX > 2 * Size + 2 || internalY > Size + 1) return null;
            if (internalY == Size + 1) return "-";
            var xPositionSlash = Size - internalY;
            var xPositionBackslash = Size + internalY;
            if (internalX == xPositionSlash) return "/";
            if (internalX == xPositionBackslash) return "\\";

            return null;
        }

        public void Move()
        {
            X += directionX;
            Y += directionY;
        }
    }
}



