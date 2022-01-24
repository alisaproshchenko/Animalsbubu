using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Yehor");
            var n = 9;
            //cat.Say();
            //cat.Move();
            
            var fish = new Fish("Alisa");
            var fish1 = new Fish("Alisa 1");
            var dog = new Dog("General Gavs");
            //fish.Say();
            //fish.Move();

            //var house = new House(fish);
            //house.Fire();

            var animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(fish);
            animals.Add(fish1);
            animals.Add(dog);

            var list = new LinkedList<Animal>();
            list.AddLast(cat);
            list.AddLast(fish);
            list.AddLast(fish1);

            var current = list.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine();
            foreach (var VARIABLE in animals)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadKey();
        }
    }
}
