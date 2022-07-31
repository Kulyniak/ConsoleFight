using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFight.Heroes
{
    public abstract class BaseWarrior
    {
        public int HP { get; set; } = 100;
        public virtual int Armor { get; set; } = 10;
        public virtual int Punch { get; set; } = 10;

    }
}
