using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise01.Pets
{
    public class Fish : Pet
    {
        public string Color { get; set; }   
        public double Size { get; set; }

        public override string PrintInfo()
        {
          return $" This Fish is fro Race: {Type} and it's {Color}, with {Size} cm Size";
        }
    }
}
