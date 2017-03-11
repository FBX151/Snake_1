using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySnakeDrawer.Model;
using System.Threading;

namespace MySnake
{
    class Program
    {
        private static int d;
        //private static object snake;

        public static int SleepInterval { get; private set; }
        public static int Speed { get; private set; }


        public static void MoveSnake()
        {

            while (!Game.GameOver)
            {
                Game.Draw();
                Thread.Sleep(200);
                switch (d)
                {
                    case 1:
                        Game.snake.Move(0, 1);
                        break;
                    case 2:
                        Game.snake.Move(0, -1);
                        break;
                    case 3:
                        Game.snake.Move(1,0);
                        break;
                    case 4:
                        Game.snake.Move(-1,0);
                        break;
                    default:
                        Console.Write("error");
                        break;

                }
            }

        }

    }
}

        

        
    
        static void Main(string[] args)
        {
            Game.Init();
            Thread t = new Thread(MoveSnake);
            t.Start();

            while (!Game.GameOver)
            {
                Game.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        d = 1;
                        // Game.snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        d = 2;
                        //Game.snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        d = 3;
                        //Game.snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        d = 4;
                        //Game.snake.Move(1, 0);
                        break;
                    case ConsoleKey.Escape:
                        Game.GameOver = true;
                        break;
                    case ConsoleKey.F2:
                        Game.snake.save();
                        Game.wall.save();
                        Game.food.save();
                        break;
                    case ConsoleKey.F3:
                        Game.snake.release();
                        Game.wall.release();
                        Game.food.release();

                        break;
                }
                // TODO: remove following expressions and put them in right Class





                if (Game.snake.body.Count == 4)
                {
                    Game.wall.LoadLevel(2);
                }




                System.Threading.Thread.Sleep(Speed);




                /* if (Game.snake.CollisionWall(Game.wall))
                   {
                   Game.GameOver = true;
                   }*/
            }

        }


    }
}

