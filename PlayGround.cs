using System;
namespace Snake
{
    public static class PlayGround
    {
        const int startPoint = 5;
        const int finishPointX = 70;

        const int finishPointY = 30;
        public static void BuildWall()
        {
            Console.SetWindowSize(80, 30);

            for (int i = startPoint; i < finishPointY; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(startPoint, i);
                Console.WriteLine("#");
                Console.SetCursorPosition(finishPointX, i);
                Console.WriteLine("#");
            }

            for (int i = startPoint; i <= finishPointX; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, startPoint);
                Console.WriteLine("#");
                Console.SetCursorPosition(i, finishPointY);
                Console.WriteLine("#");
            }
        }

        public static bool CollisionWall(Snake snakePosition)
        {
            if (snakePosition.SnakeValueX == startPoint
                || snakePosition.SnakeValueX == finishPointX
                || snakePosition.SnakeValueY == startPoint
                || snakePosition.SnakeValueY == finishPointY)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\n\n\t\tEnd of the game!\n\n");
                return false;
            }
            return true;
        }
    }
}
