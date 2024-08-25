using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAppRldatix.Polymorphism
{
    public class Dog : AnimalPolymorphism
    {
        public override string Name => "Dog";
        public override string Sound => "Woof";
    }
}
