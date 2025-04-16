using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class ClassRoom
    {
       
        private List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(params Pupil[] pupils)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i < pupils.Length)
                    this.pupils.Add(pupils[i]);
                else
                    this.pupils.Add(new BadPupil("без фамилии"));
            }
        }
        public void ShowActivities()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine(); 
            }
        }

    }
}
