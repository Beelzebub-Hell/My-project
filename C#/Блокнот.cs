using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        List<string> txtfile = new List<string>()
        {
        };
        Console.WriteLine("# Привет! Это тестовый проект, создан для обучения языка C#.");
        Console.WriteLine("# Для справки пропиши /help.");
        while (true)
        {
            Console.Write("PS С:/User/блокнот.txt> ");
            string input = Console.ReadLine();
            if (input == "/help")
            {
                Console.WriteLine("");
                Console.WriteLine("# /clear - Очистка консоли.");
                Console.WriteLine("# /view - Просмотр что написано в блокноте.");
                Console.WriteLine("# /exit - Выход из программы.");
            }

            else if (input == "/clear")
            {
                Console.Clear();
            }

            else if (input == "/view")
            {
                int i = 0;
                foreach (string views in txtfile)
                {
                    i++;
                    Console.WriteLine($"{i}. {views}");

                }
            }

            else if (input == "/exit")
            {
                Environment.Exit(0);
                Console.WriteLine($"- Консоль очищена.");
            }

            else
            {
                txtfile.Add(input);
                Console.WriteLine($"# Добавлено: {input}.");
            }   
        }
    }
}



