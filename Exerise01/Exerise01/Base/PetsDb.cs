using Exerise01.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise01.Base
{
    public class PetsDb<T> where T: Pet
    {
        public List<T> Pets;
      public PetsDb()
        {
            Pets = new List<T>();
        }

        public bool PrintPets()
        {
            foreach(T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
            return false;
        }
        public void Insert(T item)
        {
            Pets.Add(item);

            Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
        }
      public T BuyPet(string name)
        {
           T result =  Pets.SingleOrDefault(x => x.Name.ToLower()==name.ToLower());
            if(result == null)
            {
                Console.WriteLine("Here is not pet by that name ");
                
                
            }
            else
            {
                Console.WriteLine($"Now{result.Name} is in your hands ");
                Pets.Remove(result);
               
            }
            return result;
           
           
        }

        
    }
}
