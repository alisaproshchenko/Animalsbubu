using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public interface IMoveable
    {
        void Move();
        Animal ToAnimal();
    }
}
