using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKing
{
    internal class Dog:Animal
    {
        public Dog(string name,int age):base(name,age)
        {

        }
        public override string MakeNoise()
        {
            base.MakeNoise();
            return $"Woof!";

        }
        public override string MakeTrick()
        {
            base.MakeTrick();
            return $"Hold my paw, human!";
        }
    }
}
