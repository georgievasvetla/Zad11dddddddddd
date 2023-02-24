using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKing
{
    internal abstract class Animal:IMakeNoise,IMakeTrick
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual string MakeNoise()
        {
            return $"My name is {this.name}. I am {this.age} old";
        }
        public virtual string MakeTrick()
        {
            return $"Look at my trick!";
        }
    }
}
