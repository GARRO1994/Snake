using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class HorizontLine : Figure
    {
        public HorizontLine(int xLef, int xRig, int y , char sym)
        {
            pointLis = new List<Point>();
            for(int x = xLef; x<= xRig; x++)
            {
                Point p = new Point(x, y, sym);
                pointLis.Add(p);
            }
        }
    }
}
