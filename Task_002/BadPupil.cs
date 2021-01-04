using System;

namespace Task_002
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I can study 1h");
        }

        public override void Read()
        {
            Console.WriteLine("I can read 1h after school");
        }

        public override void Write()
        {
            Console.WriteLine("I cant write after school");
        }

        public override void Relax()
        {
            Console.WriteLine("I can relax all day after school");
        }
    }
}