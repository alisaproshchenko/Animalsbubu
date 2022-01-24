using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public class Cat : Animal
    {
        public Cat() {}

        public Cat(string name) : base(name){}

        public override void Say()
        {
            Console.WriteLine("Meow");
        }
    }
}
