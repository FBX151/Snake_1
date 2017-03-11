using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnakeDrawer.Model
{
    [Serializable]
    public class Snake : Drawer
    {
        // private object wall;

        public Snake(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body) { }

        public void delete()
        {
            foreach (var e in body)
            {
                Console.SetCursorPosition(e.x, e.y);
                Console.Write(" ");
            }
        }

        public void Move(int dx, int dy)
        {
            delete();
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x > 70)
            {
                body[0].x = 0;
            }
            if (body[0].x < 0)
            {
                body[0].x = 70;
            }
            if (body[0].y > 35)
            {
                body[0].y = 0;
            }
            if (body[0].y < 0)
            {
                body[0].y = 35;
            }

            for (int i = 2; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                    Game.GameOver = false;
                }

    }

            if (Game.snake.CanEat(Game.food))
            {
                Game.food.SetRandomPosition();
            }

            for (int i = 0; i < Game.wall.body.Count; i++)
            {

                if (Game.snake.body[0].x == Game.wall.body[i].x && Game.snake.body[0].y == Game.wall.body[i].y)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                    Game.GameOver = true;
                }
            }



            // TODO: can snake eat?                                                                 DONE
            // TODO: check for collision with wall                                                  DONE
            // TODO: check for collision with itself (snake)                                        DONE
            // TODO: check for collision with border (console border (maximum width and height))    DONE
            // TODO: if necessary, load new level of the wall                                       ISN'T NECESSARY
        }

        public bool CanEat(Food f)
        {

            if (body[0].x == f.body[0].x && body[0].y == f.body[0].y)
            {
                body.Add(new Point(f.body[0].x, f.body[0].y));

                return true;
            }
            return false;
        }






            /* public bool CollisionWall(Wall w)
             {
                 for (int i = 0; i < w.body.Count; i++)
                 {
                     if (body[0].x == w.body[i].x && body[0].y == w.body[i].y)
                     {
                         Console.Clear();
                         Console.WriteLine("Game Over");
                         Console.ReadKey();
                         return true;
                     }
                     return false;
                 }
             }*/
        }
}
