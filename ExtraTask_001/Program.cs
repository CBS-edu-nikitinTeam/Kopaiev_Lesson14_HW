using System;
using System.Drawing;

namespace ExtraTask_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer pr = new PrinterChild2();
            pr.Print("PrinterChild2");
            pr = new PrinterChild1();
            pr.Print("PrinterChild1");
            pr = new Printer();
            pr.Print("Printer");

            //Delay
            Console.ReadKey();
        }
    }
}
