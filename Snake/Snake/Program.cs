using System;
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
            int x1 = 1; //int - 32 разрядное (4 байта) целое число со знаком от -2 147 483 648 до 2 147 483 647
            int y1 = 3;
            char sym1 = '*'; //char - 16 разрядное числовое значение (символ Юникод-16)
            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);

            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
