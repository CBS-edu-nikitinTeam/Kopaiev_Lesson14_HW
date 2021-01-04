using System;

namespace ExtraTask_001
{
    class PrinterChild2 : PrinterChild1
    {
        Random r = new Random();
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }
    }
}