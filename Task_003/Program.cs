using System;
using System.Data.Common;

namespace Task_003
{
    class Program
    {

        static void Main(string[] args)
        {
            Plane boeeng = new Plane(256,545,5888888,789,1999,895,124);
            Ship maria = new Ship(565,545,70000000,150,1997,565,"Hamburg");
            Car mustang = new Car(344,344,20000,354,1965);

            boeeng.ShowDetails();
            Console.Write("\n");
            maria.ShowDetails();
            Console.Write("\n");
            mustang.ShowDetails();
        }
    }
}
