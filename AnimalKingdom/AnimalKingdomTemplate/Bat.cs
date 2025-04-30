using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom.AnimalKingdomTemplate
{
    public class Bat : Animal, IMammal, IICanFly
    {
        public int NumberOfNipples => 2;
        public int NumberOfWings => 2;
        public override string Sound()
        {
            return base.Sound() + "Bat sounds";
        }
        
    }
}