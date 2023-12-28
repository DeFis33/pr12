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
        static void Replacement()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nВведите исходную строку:");
            Console.ForegroundColor = ConsoleColor.White;
            string S = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nВведите три буквы для поиска:");
            Console.ForegroundColor = ConsoleColor.White;
            string search = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nВведите три буквы для замены:");
            Console.ForegroundColor = ConsoleColor.White;
            string replace = Console.ReadLine();

            if (IsAllLetters(search) && IsAllLetters(replace) && search.Length == 3 && replace.Length == 3)
            {
                string result = Substring(S, search, replace);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\nРезультат замены:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(result);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nОшибка ввода. Пожалуйста, введите три буквы для поиска и три буквы для замены.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static bool IsAllLetters(string str)
        {
            return str.All(char.IsLetter);
        }
        static string Substring(string S, string search, string replace)
        {
            return S.Replace(search, replace);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №12 \n Здравствуйте!");
            while (true)
            {
                try
                {
                    Console.WriteLine("\nХотите ли бы вы запустить программу для нахождения подстроки из трёх букв, введённых с клавиатуры в исходной строке \nи замены на другую, также состоящую из трёх букв? (Да/Нет):");
                    string a = Console.ReadLine();

                    if (a == "Нет")
                    {
                        Console.WriteLine("\nПрограмма завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да") // иначе, если
                    {
                        Replacement();
                        continue;
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
                }
            }
        }
    }
}
// Александр Пушкин начал писать свои первые произведения уже в семь лет.
