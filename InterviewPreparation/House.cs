using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public class House
    {
        public IMoveable[] Entity { get; set; }

        public House(params IMoveable[] entity)
        {
            Entity = entity;
        }

        public void Fire()
        {
            foreach (var VARIABLE in Entity)
            {
                var animal = VARIABLE.ToAnimal();

                Console.WriteLine($"{animal.Name} is on fire");
            }
            
        }
    }
}
