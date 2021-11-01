using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_9
{
    class Program
    {
        static void Main(string[] args)
        { //Работа простого калькулятора
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число х=");
            int x = 0;
            int y = 0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine()); //случай, когда введено нецелое число для Х
            }
            catch (FormatException)
            {
                Console.Write("Введенное число X имело неверный формат!");
            }
                        Console.Write("Введите целое число y=");
            try
            {
                y = Convert.ToInt32(Console.ReadLine()); //случай, когда введено нецелое число для Y
            }
            catch (FormatException)
            {
                Console.Write("Введенное число Y имело неверный формат!");
            }
                Console.WriteLine("Введите тип операции: " +
                "1 - сложение, " +
                "2 - вычитание, " +
                "3 - умножение, " +
                "4 - деление");
            Console.Write("Ваш выбор:  ");
            int a = Convert.ToInt32(Console.ReadLine()); //результат вычисления
            switch (a)
            {
                case 1:
                    Console.WriteLine("Результат = {0}", x + y);
                    break;
                case 2:
                    Console.WriteLine("Результат = {0}", x - y);
                    break;
                case 3:
                    Console.WriteLine("Результат = {0}", x * y);
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Результат = {0}", x / y);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.Write("Ошибка! Деление на ноль!");
                    }
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером!");
                    break;
                     }
                    Console.ReadKey();
            }
        } 
    }

           