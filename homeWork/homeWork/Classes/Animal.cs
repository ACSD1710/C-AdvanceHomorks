using homeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.Classes
{
    public abstract class Animal :IAnimal
    {
        public string Name { get; set; }
        public int YearsOld { get; set; }   
        public string Race { get; set; }    
        public string Growth { get; set; }

        public abstract void PrintAnimal();

        public Animal(string name, int yearsOld, string race, string growth)
        {
            Name = name;
            YearsOld = yearsOld;
            Race = race;
            Growth = growth; 
        }

        internal void Eat(string food)
        {
            Console.WriteLine($"{Name} eat {food}");
        }

        internal void Bark()
        {
            Console.WriteLine($"{Name} Say: Raw, Raw, Raw ....");

        }
    }
}
