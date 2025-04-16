using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class BadPupil :Pupil
    {
        public BadPupil(string surname) 
            :base(surname)
        { }
        public override void Study()
        {
            Console.WriteLine($"{Surname} учится плохо!");

        }
        public override void Read()
        {
            Console.WriteLine($"{Surname} читает плохо!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Surname} пишет плохо!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Surname} отдыхает, играя в компьютер!");
        }
    }
}
