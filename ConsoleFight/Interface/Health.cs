using System;
using System.Collections.Generic;
using System.Text;
using ConsoleFight.Heroes;

namespace ConsoleFight.Interface
{
    public class Health : ISuperPower
    {
        public void AddSuperPower(BaseWarrior warrior, int power)
        {
            warrior.HP += power;
        }
    }
}
