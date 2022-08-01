using System;
using System.Collections.Generic;
using System.Text;
using ConsoleFight.Heroes;

namespace ConsoleFight.Interface
{
    public  class Punch : ISuperPower
    {
        public void AddSuperPower(BaseWarrior warrior, int power)
        {
            warrior.Punch += power;
        }
    }
}
