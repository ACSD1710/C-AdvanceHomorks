using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise01.Pets
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public double LivesLeft { get; set; }

        public override string PrintInfo()
        {
            string lazyCat = "";
            
            if (Lazy == true)
            {
                lazyCat = "Its LAzy";
            }
            else
            {
                lazyCat = "Be careful this cat is temperamental you can be scratched";
            }
            return $" Cat with Name: {Name} and Race: {Type} and this Cat {lazyCat}, and its " +
                $"This Cat left {LivesLeft} years of life";
        }
    }
}
