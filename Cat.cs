using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKing
{
    internal class Cat:Animal
    {
        public Cat(string name,int age):base(name,age)
        {

        }
        public override string MakeNoise()
        {
            base.MakeNoise();
            return $"Meow";
        }
        public override string MakeTrick()
        {
            base.MakeTrick();
            return $"No trick for you! I'm too lazy!";
        }
    }
}
