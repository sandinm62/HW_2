using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{

    // Сандин М.С.
    // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    internal class Program
    {
        static bool parity(int input_number)
        {
            return input_number % 2 == 0 ? true : false;

        }



        static void Main(string[] args)
        {
            int number;
            int counter = 0;
            
            do
            {
                Console.Write("Enter the number: ");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                } else if ( number < 0)
                {
                    continue;
                }

                if (parity(number) == true)
                counter++;
                
                
            } while (number != 0);

            Console.WriteLine($"The number of even numbers is {counter}");
            Console.ReadKey();
    
        }
    }
}
