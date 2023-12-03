//*********************************************************************
//* Практическая работа № 12                                          *
//* Выполнил: Пирогов Д., группа 2ИСП                                 *
//* Задание: изучить методы создания собственных функций с помощью C# *
//*********************************************************************

using System;

namespace pr12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №12 \n Здравствуйте!");
            while (true)
            {
                try
                {
                    Console.WriteLine("\nВведите любую цифру, чтобы запустить программу для нахождения подстроки из трёх букв, введённых с клавиатуры в исходной строке и замены на другую, также состоящую из трёх букв. (для выхода введите 0): ");
                    int N = Convert.ToInt32(Console.ReadLine());

                    if (N == 0) // если N = 0, то завершаем программу
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else // иначе
                    {
                        Console.Write("\nВведите строку: ");
                        string S = Console.ReadLine();

                    }
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
