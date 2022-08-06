using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    //Сандин М.С.
    //Написать метод, возвращающий минимальное из трёх чисел.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            a = 1;
            b = 2;
            c = 3;

            if ( a > b && a > c ) 
            {
                max = a;

            } else if ( b > c && b > a)
            {
                max = b;
            } else
            {
                max = c;
            }


        }
    }
}
