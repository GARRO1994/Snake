using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            HorizontLine upline = new HorizontLine(0, 78 ,0 , '*');
            HorizontLine dowline = new HorizontLine(0, 78 ,24 , '*');
            VerticalLine left = new VerticalLine(0, 24, 0, '*');
            VerticalLine right = new VerticalLine(0, 24, 78, '*');
            upline.Drow();
            dowline.Drow();
            left.Drow();
            right.Drow();

            Point p = new Point(4, 5, '@');
            Snake snake = new Snake(p, 4, Derection.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
          
            Console.ReadLine();
        }
    }
}
