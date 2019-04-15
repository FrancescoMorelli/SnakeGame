using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace Snake
{
    public class Snake
    {

        public int SnakeValueX { get; set; }
        public int SnakeValueY { get; set; }
        private string movement;


        public Snake(int valueX, int valueY)
        {
            this.SnakeValueX = valueX;
            this.SnakeValueY = valueY;
        }

        public void Draw()
        {


            Console.SetCursorPosition(SnakeValueX, SnakeValueY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O");

        }
        public void Move(ConsoleKeyInfo userDirection)
        {

            if (userDirection.Key == ConsoleKey.UpArrow)
            {
                Console.SetCursorPosition(SnakeValueX, SnakeValueY);
                Console.WriteLine(" ");
                movement = "UP";
            }

            if (userDirection.Key == ConsoleKey.DownArrow)
            {
                Console.SetCursorPosition(SnakeValueX, SnakeValueY);
                Console.WriteLine(" ");
                movement = "DOWN";
            }

            if (userDirection.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(SnakeValueX, SnakeValueY);
                Console.WriteLine(" ");
                movement = "LEFT";
            }

            if (userDirection.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(SnakeValueX, SnakeValueY);
                Console.WriteLine(" ");
                movement = "RIGHT";
            }


            switch (movement)
            {
                case "UP":
                    SnakeValueY--;
                    break;

                case "DOWN":
                    SnakeValueY++;
                    break;

                case "LEFT":
                    SnakeValueX--;
                    break;

                case "RIGHT":
                    SnakeValueX++;
                    break;
            }

        }
    }

}
