using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFight.Heroes
{
    public  class Archer : BaseWarrior
    {
        public override int Armor { get; set; } = 5;
        public override int Punch { get; set; } = 15;
    }
}
