using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Приветствие");
        Console.WriteLine("ФИО: Лободина Вероника Александровна");
        Console.WriteLine("Группа: ИСП-232");
        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
 
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
             string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Иванов Иван Иванович");
                    break;
                case "2":
                    Console.WriteLine("ИСРПО-1-23");
                    break;
                case "3":
                    Console.WriteLine(DateTime.Now);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}