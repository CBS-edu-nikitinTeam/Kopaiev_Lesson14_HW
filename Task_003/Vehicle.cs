using System;

namespace Task_003
{
    class Vehicle
    {
        protected double coordX;
        protected double coordY;
        protected int price;
        protected double speed;
        protected ushort year;

        public Vehicle(double coordX, double coordY, int price, double speed, ushort year)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        protected void ShowDetails()
        {
            Console.WriteLine(coordX);
            Console.WriteLine(coordY);
            Console.WriteLine(price);
            Console.WriteLine(speed);
            Console.WriteLine(year);
        }
    }
}