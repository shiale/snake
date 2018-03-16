using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        //int - 32 разрядное (4 байта) целое число со знаком от -2 147 483 648 до 2 147 483 647
        public int x; 
        public int y;
        //char - 16 разрядное числовое значение (символ Юникод-16)
        public char sym;

        //Конструктор имеет специальный синтаксис
        //1. Он называется так же как класс (в моем случае Point)
        //2. Опускается тип возвращаемого значения т.к. конструктор ничего не возвращает (или возвращает свой тип?)
        public Point(int x=0, int y=0, char sym='0')
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
