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
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        //Если объект может создаваться как с параметрами так и без, тогда необходимо создать оба констрктора
        public Point()
        {
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
