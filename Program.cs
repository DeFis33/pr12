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
                    Console.WriteLine("\nХотите ли бы вы запустить программу для нахождения подстроки из трёх букв, введённых с клавиатуры в исходной строке и замены на другую, также состоящую из трёх букв? (Да/Нет):");
                    string a = Console.ReadLine();

                    if (a == "Нет")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да") // иначе, если
                    {
                        Console.Write("\nВведите строку: ");
                        string S = Console.ReadLine();

                    }
                    else // иначе
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! Либо Выход. (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
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
