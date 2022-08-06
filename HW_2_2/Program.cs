using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    //Сандин М.С.
    //Написать метод подсчета количества цифр числа.
    internal class Program
    {
        static int counter( int number_input)
        {
            int i = 0; // переменная счётчик
            while (number_input != 0)
            {
                i++;
                number_input = number_input / 10;
                
            }
            return i;
        }
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number of digits of the number is {counter(number)}" );
            Console.ReadKey();
        
        }


    }
}
