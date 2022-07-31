using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFight.Heroes
{
    public class Infantry : BaseWarrior
    {
        public override int Armor { get; set; } = 8;
        public override int Punch { get; set; } = 12;
    }
}
