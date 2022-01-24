using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
            
        }
        public override void Say()
        {
            Console.WriteLine("Bul bul");
        }

        public override void Move()
        {
            Console.WriteLine($"{_name} is swimming in the sea");
        }
    }
}
