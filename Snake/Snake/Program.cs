﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1,3,'*');
            //p1.Draw();

            //Point p2 = new Point(4, 5,'#');
            //p2.Draw();

            HorizontalLine Line = new HorizontalLine(1,50,3,'*');
            Line.Draw();

            VerticalLine vLine = new VerticalLine(3, 25, 1, '*');
            vLine.Draw();
                        
            Console.ReadKey();
        }
    }
}
