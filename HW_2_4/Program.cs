using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4
{
    internal class Program
    {

        //Сандин М.С.
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу:
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        // С помощью цикла do while ограничить ввод пароля тремя попытками.
        static bool authentication(string login_aut, string password_aut )
        {

            string login, password;
            int counter = 3;
            do
            {
                Console.Write("Enter you login: ");
                login = Console.ReadLine();
                Console.Write("Enter passowrd: ");
                password = Console.ReadLine();
                counter--;
                if (login == login_aut && password == password_aut)
                {

                    return true;
                   

                }
               
            } while(counter != 0);
            return false;
            

            

        }
        static void Main(string[] args)
        {
            string loginCorrect = "root";
            string passwordCorrect = "GeekBrains";
            Console.WriteLine( authentication(loginCorrect, passwordCorrect) == true ? "Good day" : "Data is not correctli");

           
            Console.ReadKey();


            
            




        }
    }
}
