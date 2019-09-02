using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Figure
    {
       protected List<Point> pointLis;
        public void Drow()
        {
            foreach (Point p in pointLis)
            {
                p.Draw();
            }
        }
    }
}
