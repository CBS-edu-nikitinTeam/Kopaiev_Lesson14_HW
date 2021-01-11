
using System;
using System.Collections.Generic;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаю и заполняю словарь с ключами
            Dictionary<string, string> cdkeys = new Dictionary<string, string>(); // Не вижу смысла создавать словарь,
                                                                                  // если ты его используешь только на 22 строке.
                                                                                  // Ну для практики пойдет.
            cdkeys.Add("pro","prokey");
            cdkeys.Add("expert","extrakey");

            // Получаю от пользователя ключ
            Console.WriteLine("Пожалуйста введите ключ для разблокировки Pro и Expert версии. Если нет просто нажмите Enter");
            string userKey = Console.ReadLine();

            DocumentWorker dw;
            // Проверка ключа от пользователя, и использование версии согласно ключу
            if (cdkeys.ContainsValue(userKey))
            {
                // Правильная реализация.
                if (userKey == "prokey")
                {
                    Console.WriteLine("Спачибо что выбрали нашу Pro версию\n");
                    dw = new ProDocumentWorker();
                }
                else
                {
                    Console.WriteLine("Спачибо что выбрали нашу Expert версию\n");
                    dw = new ExpertDocumentWorker(); // Вот что значит преведение.
                }
            }
            else // default block.
            {
                Console.WriteLine("Програмный ключ не обнаружен в базе\n");
                dw = new  DocumentWorker();
            }

            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();

            // Delay
            Console.ReadKey();
        }
    }
}
