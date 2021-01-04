using System;

namespace Task_003
{
    class Ship : Vehicle
    {
        private int _passengersAmount;
        private string _location;

        public Ship(double coordX, double coordY, int price, double speed, ushort year, int passengersAmount, string location) : base(coordX, coordY, price, speed, year)
        {
            this._location = location;
            this._passengersAmount = passengersAmount;
        }

        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(_location);
            Console.WriteLine(_passengersAmount);
        }
    }
}