using System;

namespace Task_003
{
    class Plane : Vehicle
    {
        private double _height;
        private ushort _passengersAmount;
        public Plane(double coordX, double coordY, int price, double speed, ushort year, double height, ushort passengersAmount) : base(coordX, coordY, price, speed, year)
        {
            this._height = height;
            this._passengersAmount = passengersAmount;
        }

        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(_height);
            Console.WriteLine(_passengersAmount);
        }
    }
}