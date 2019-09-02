using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDow, int x, char sym)
        {
            pointLis = new List<Point>();
            for(int y = yUp; y<= yDow; y++)
            {
                Point p = new Point(x, y, sym);
                pointLis.Add(p);
            }
        }
    }
}
