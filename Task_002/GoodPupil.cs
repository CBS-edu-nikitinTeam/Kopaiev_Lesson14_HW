using System;

namespace Task_002
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I can study 5h");
        }

        public override void Read()
        {
            Console.WriteLine("I can read 3h after school");
        }

        public override void Write()
        {
            Console.WriteLine("I can write 1h after school");
        }

        public override void Relax()
        {
            Console.WriteLine("I can relax 2h after school");
        }
    }
}