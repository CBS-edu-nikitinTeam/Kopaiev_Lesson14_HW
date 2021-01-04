using System;

namespace ExtraTask_001
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }
}