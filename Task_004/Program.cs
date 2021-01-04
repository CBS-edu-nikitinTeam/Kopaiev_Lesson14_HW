
using System;
using System.Collections.Generic;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаю и заполняю словарь с ключами
            Dictionary<string, string> cdkeys = new Dictionary<string, string>();
            cdkeys.Add("pro","prokey");
            cdkeys.Add("expert","extrakey");

            // Получаю от пользователя ключ
            Console.WriteLine("Пожалуйста введите ключ для разблокировки Pro и Expert версии. Если нет просто нажмите Enter");
            string userKey = Console.ReadLine();

            // Проверка ключа от пользователя, и использование версии согласно ключу
            if (cdkeys.ContainsValue(userKey))
            {
                if (userKey == "prokey")
                {
                    Console.WriteLine("Спачибо что выбрали нашу Pro версию\n");
                    ProDocumentWorker dw = new ProDocumentWorker();
                    dw.OpenDocument();
                    dw.EditDocument();
                    dw.SaveDocument();
                }
                else
                {
                    Console.WriteLine("Спачибо что выбрали нашу Expert версию\n");
                    ExpertDocumentWorker dw = new ExpertDocumentWorker();
                    dw.OpenDocument();
                    dw.EditDocument();
                    dw.SaveDocument();
                }
            }
            else // default block.
            {
                Console.WriteLine("Програмный ключ не обнаружен в базе\n");
                DocumentWorker dw = new  DocumentWorker();
                dw.OpenDocument();
                dw.EditDocument();
                dw.SaveDocument();
            }
            // Delay
            Console.ReadKey();
        }
    }
}
