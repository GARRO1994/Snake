using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point
    {
        public int x, y;
        public char sym;
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Derection derection)
        {
            if(derection == Derection.RIGHT)
            {
                x = x + offset;
            }
            else if(derection == Derection.LEFT)
            {
                x = x - offset;
            }
            else if (derection == Derection.UP)
            {
                y = y - offset;
            }
            else if (derection == Derection.DOWN)
            {
                y = y + offset;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
       public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
