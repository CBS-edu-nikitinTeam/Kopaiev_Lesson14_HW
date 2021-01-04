using System.Collections.Generic;
using System.Threading.Channels;

namespace Task_002
{
    class ClassRoom
    {
        private List<Pupil> classMates= new List<Pupil>();

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            classMates.Add(pupil1);
            classMates.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)
        {
            classMates.Add(pupil3);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4) : this(pupil1, pupil2, pupil3)
        {
            classMates.Add(pupil4);
        }

        public void ShowSkills()
        {
            foreach (var classmate in classMates)
            {
                classmate.Study();
                classmate.Read();
                classmate.Write();
                classmate.Relax();
            }
        }

    }
}