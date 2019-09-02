using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Snake : Figure
    {
        Derection derection;
        public Snake(Point tail , int length, Derection _derection)
        {
            derection = _derection;
            pointLis = new List<Point>();
            for(int i = 0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, derection);
                pointLis.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pointLis.First();
            pointLis.Remove(tail);
            Point head = GetNextPoint();
            pointLis.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint() {
            Point head = pointLis.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, derection);
            return nextpoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                derection = Derection.LEFT;
            else if (key == ConsoleKey.RightArrow)
                derection = Derection.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                derection = Derection.DOWN;
            else if (key == ConsoleKey.UpArrow)
                derection = Derection.UP;

        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pointLis.Add(food);
                return true;
            }
            else return false; 
        }
    }
}
