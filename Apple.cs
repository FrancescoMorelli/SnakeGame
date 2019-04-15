using System;
namespace Snake
{
    public class Apple
    {
        private int _appleValueX = new Random().Next(6, 69);
        private int _appleValueY = new Random().Next(6, 29);

        public void Draw()
        {
            Console.SetCursorPosition(_appleValueX, _appleValueY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("@");
        }

        public bool WasEaten(Snake snake)
        {
            if (snake.SnakeValueX == _appleValueX && snake.SnakeValueY == _appleValueY)
            {
                Console.SetCursorPosition(_appleValueX, _appleValueY);
                Console.WriteLine(" ");

                _appleValueX = new Random().Next(6, 69);
                _appleValueY = new Random().Next(6, 29);

                return true;
            }
            return false;
        }
    }
}
