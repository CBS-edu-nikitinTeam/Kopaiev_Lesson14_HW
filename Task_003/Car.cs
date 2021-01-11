using System;

namespace Task_003
{
    class Car : Vehicle
    {
        public Car(double coordX, double coordY, int price, double speed, ushort year) : 
            base(coordX, coordY, price, speed, year)
        {

        }

        public new void ShowDetails()
        {
            base.ShowDetails();
        }
    }
}