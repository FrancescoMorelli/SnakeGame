using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{

    class Program
    {
        static void Main(string[] args)
        {
            var realSnake = new Snake(37, 17);
            var apple = new Apple();
            bool gameOn = true;

            PlayGround.BuildWall();

            do
            {
                realSnake.Draw();
                apple.Draw();


                var userInput = Console.ReadKey();


                    realSnake.Move(userInput);

                gameOn = PlayGround.CollisionWall(realSnake);

                if (apple.WasEaten(realSnake))
                {

                }

                //Implement auto-moving snake
                //Make snake longer everytime it eats an apple
                //Keep track of how many apples were eaten(POINTS)

                //Build welcome screen

                //Give player option to read directions

                //Show score

                //Give option to replay the game

                //

            }
            while (gameOn);

        }

    }
}
