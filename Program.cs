using System;
using System.Threading;

namespace RandomBoxes
{
    class Program
    {
        private static int _width = 50;
        private static int _height = 20;

        static void Main(string[] args)
        {
            //var shapes = CreateRectangles();
            var shapes = CreateTriangles();
            //while (true)
            {
                Show(shapes);
                foreach (var box in shapes)
                {
                    box.Move();
                }
                Thread.Sleep(300);
            }
        }

        private static Shape[] CreateTriangles()
        {
            var random = new Random();
            var shapes = new Shape[5];
            for (var i = 0; i < shapes.Length; i++)
            {
                if (random.Next(0, 1) == 0)
                {
                    shapes[i] = new Rectangle(random, _width, _height);
                }
                else
                {
                    shapes[i] = new Triangle(random, _width, _height / 10);
                }

            }
            return shapes;
        }

        private static void Show(Shape[] boxes)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                for (var col = 0; col < _width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var box in boxes)
                    {
                        var character = box.GetCharacter(row, col);
                        if (character != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void Show(Rectangle[] boxes)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                for (var col = 0; col < _width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var box in boxes)
                    {
                        var character = box.GetCharacter(row, col);
                        if (character != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
