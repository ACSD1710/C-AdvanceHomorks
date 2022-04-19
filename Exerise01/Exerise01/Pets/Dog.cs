using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise01.Pets
{
    public class Dog : Pet
    {   public bool GoodBoy { get; set; }  
        public string FavoriteFood { get; set; }
        public override string PrintInfo()
        { string goodBoy = "";
            if (GoodBoy == true)
            {
                goodBoy = "Its good boy and very well trained";
            }else
            {
                goodBoy = "Be careful this dog is good but have to be trained";
            }
             return $" Dog with Name: {Name} and Race: {Type} and this dog {goodBoy}, and its " +
                $"Favorite food is {FavoriteFood}";
        }
    }
}
