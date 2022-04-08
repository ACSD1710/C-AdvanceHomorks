using homeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.Classes
{
    internal class Dog : Animal, IDog
    {
        
        public bool Trained { get; set; } 
        




        public override void PrintAnimal()
        {
            Console.WriteLine($"This is {Name}, and it is {YearsOld} years old, from race {Race},\n" +
                $" and it is with {Growth} ");
        }

        public void Bark()
        {
            Console.WriteLine("Raw, Raw, Raw ....");
        }

        public Dog(string name, int yearsOld, string race, string growth, bool treined) : base(name, yearsOld, race, growth)
        {
            
            Trained = treined; 
            

        }

       
    }
}
