using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pupil1 = new ExcelentPupil("Иванов");
            var pupil2 = new GoodPupil("Петров");
            var pupil3 = new BadPupil("Сидоров");

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
            classRoom.ShowActivities();
            Console.ReadKey();
        
        }
    }
}
