using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public class Dog : Animal
    {
        public Dog(){}
        public Dog(string name) : base(name){}
        public override void Say()
        {
            Console.WriteLine("Woof!");
        }
    }
}
