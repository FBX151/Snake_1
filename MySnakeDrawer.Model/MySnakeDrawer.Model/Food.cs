

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySnakeDrawer.Model;

namespace MySnakeDrawer.Model
{
    [Serializable]
    public class Food : Drawer
    {
        public bool alive = false;
        public Food(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body)
        {
            SetRandomPosition();
        }

        public void SetRandomPosition()
        {

            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 35);
            body[0] = new Point(x, y);
            WallSnake(body[0]);
        }

                
        public void WallSnake(Point p)
        {
            
                            for (int i = 0; i < Game.snake.body.Count; i++)
            {
                
                while (!alive)
                {
                    if (body[0].x != Game.snake.body[i].x && body[0].y != Game.snake.body[i].y)
                    {
                        alive = true;
                    }
                    SetRandomPosition();
                }

            }

                for (int k = 0; k < Game.wall.body.Count; k++)
                {
                    if (body[0].x == Game.wall.body[k].x && body[0].y == Game.wall.body[k].y)
                    {
                        SetRandomPosition();
                       
                    
                }
            }
        


        }
    }
}
