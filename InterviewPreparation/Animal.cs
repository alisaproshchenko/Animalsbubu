using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public abstract class Animal : IMoveable
    {
        protected string _name;
        public string Name => _name;

        public Animal()
        {
            _name = "Default animal";
        }

        public Animal(string name)
        {
            _name = name;
        }
        public abstract void Say();
        public virtual void Move()
        {
            Console.WriteLine($"{_name} is walking on the ground");
        }

        public Animal ToAnimal()
        {
            return this;
        }
    }
}
