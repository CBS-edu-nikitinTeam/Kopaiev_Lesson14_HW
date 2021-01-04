using System;

namespace Task_002
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I can study 7h");
        }

        public override void Read()
        {
            Console.WriteLine("I can read 5h after school");
        }

        public override void Write()
        {
            Console.WriteLine("I can write 3h after school");
        }

        public override void Relax()
        {
            Console.WriteLine("I don't have time to relax. Cause i'm terminator");
        }
    }
}