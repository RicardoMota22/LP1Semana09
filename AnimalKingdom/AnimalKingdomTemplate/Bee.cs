using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom.AnimalKingdomTemplate
{
    public class Bee : Animal, IICanFly
    {
        public int NumberOfWings => 2;
    
        public override string Sound()
        {
            return base.Sound() + "Bzzzzz";
        }
        
    }
}