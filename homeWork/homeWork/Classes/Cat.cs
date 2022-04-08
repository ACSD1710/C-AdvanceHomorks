using homeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.Classes
{
    public class Cat : Animal, ICat
    {
        
        public bool IsLazy { get; set; }    
        public Cat(string name, int yearsOld, string race, string growth, bool lazy) : base(name, yearsOld, race, growth)
        {
            IsLazy = lazy;
            
    }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is {Name}, and it is {YearsOld} years old, from race {Race},\n" +
                 $" and it is with {Growth},  {IsLazy} Lazy ");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} eat {food}");
        }
    }
}
