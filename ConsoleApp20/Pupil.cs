using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    abstract class Pupil
    {
        private string surname;

        public string Surname { get { return surname; } set { surname = value; } }
        public Pupil(string surname) 
        {
            Surname = surname;
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

        

    }
}
