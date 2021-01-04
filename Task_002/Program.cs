namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil john = new ExcelentPupil();
            Pupil arny = new BadPupil();
            Pupil segio = new BadPupil();
            Pupil andrew = new GoodPupil();

            ClassRoom floor1 = new ClassRoom(john,arny,segio,andrew);
            floor1.ShowSkills();
        }
    }
}
