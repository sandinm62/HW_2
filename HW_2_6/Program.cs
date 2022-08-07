using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_6
{
    //Сандин М.С.
    //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    //«Хорошим» называется число, которое делится на сумму своих цифр.
    //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
    
    internal class Program
    {

        static int amount()
        {
            int count = 0;
            
            for (int number = 1; number <= 1000000000; number++)
            {
                int summ = 0;
                int numberForWhile = number;
                do
                {
                    
                    summ = summ + (numberForWhile % 10);
                    numberForWhile = numberForWhile / 10;
                }
                while (numberForWhile != 0);                
                    
                    
                
                
                if (number %summ == 0)
                    count++;
                
            }
            return count;
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Number of good numbers " + amount()); // вызываем метод посчёта чисел
            DateTime finish = DateTime.Now;
            Console.WriteLine("Time: " + (finish - start));
            Console.ReadKey();
        }
    }
}
