using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework9T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");

            int a = 0;
            int b = 0;
            int S = 0;
            try
            {
                Console.Write("Введите целое число. X=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат!");
                Console.ReadKey(); Environment.Exit(0);
            }
            Console.WriteLine("Введите код операции:\n     1 - Сложение\n     2 - Вычитание\n     3 - Произведение\n     4 - Деление");

            Console.Write("Ваш выбор:");
            int c = Convert.ToInt32(Console.ReadLine());

            try
            {


                if (c < 1 || c > 4)
                {
                    throw new Exception("Нет операции с указанным номером!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                if (c == 1)
                {
                    S = a + b;
                    Console.WriteLine("Сумма чисел равна = {0}",S);
                }
                else if (c == 2)
                {
                    S = a - b;
                    Console.WriteLine("Разность чисел равна = {0}", S);
                }
                else if (c == 3)
                {
                    S = a * b;
                    Console.WriteLine("Произведение чисел равно = {0}", S);
                }
                else if (c == 4)
                {
                    S = a / b;
                    Console.WriteLine("Отношение чисел равно = {0}", S);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль недопустимо");
            }

            Console.ReadKey();
        }
    }
}
