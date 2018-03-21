using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            plist = new List<Point>();
            for(int i = yTop; i <= yBottom; i++)
            {
                plist.Add(new Point(x, i, sym));
            }
        }

        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
