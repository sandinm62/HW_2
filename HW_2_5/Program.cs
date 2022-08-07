using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{

    //Сандин М.С.
    //а) Написать программу, которая запрашивает массу и рост человека,
    //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    internal class Program
    {
        static double index()
        {
            double mass, growth, i, normalIndexMin, normalIndexMax;
            normalIndexMin = 18.5;
            normalIndexMax = 24.9;
            Console.Write("Enter you mass (Kg): ");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter you growth (m): ");
            growth = Convert.ToDouble(Console.ReadLine());
            i = mass / (growth * growth);
            Console.Clear();
            if (i < normalIndexMin)
            {

                double mass1 = normalIndexMin * growth * growth; //переменная для подсчёта нормального веса
                mass = mass1 - mass;
                Console.WriteLine($"You need to bulk up: {mass} kg");
            }
            else if (i > normalIndexMax)
            {

                double mass1 = normalIndexMax * growth * growth; //переменная для подсчёта нормального веса
                mass = mass - mass1;
                Console.WriteLine($"You need to lose weight: {mass} kg");
            }
            else
            {
                Console.WriteLine("All right");
            }
            
            return i;
        }
        static void Main(string[] args)
        {
            
                     
            Console.WriteLine("You body mass index: " + "{0:F}", index()); //вызываем метод index и выводим индекс массы тела и округляем колличество знаков после запятой до двух символов
            Console.ReadKey();
        }
    }
}
