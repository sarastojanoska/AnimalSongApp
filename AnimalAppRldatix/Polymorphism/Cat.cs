using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAppRldatix.Polymorphism
{
    public class Cat : AnimalPolymorphism 
    {
        public override string Name => "Cat";
        public override string Sound => "Meow";
    }
}
