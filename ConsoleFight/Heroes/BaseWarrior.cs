using System;
using System.Collections.Generic;
using System.Text;
using ConsoleFight.Interface;

namespace ConsoleFight.Heroes
{
    public abstract class BaseWarrior
    {
        public int HP { get; set; } = 100;
        public virtual int Armor { get; set; } = 10;
        public virtual int Punch { get; set; } = 10;
        
        public virtual void AddSuperPower(ISuperPower superPower, int power)
        {
           
        }
        public bool IsAlive {
            get
            {
                if (HP>0) 
                    {
                    return false;
                    }
               else
                {
                    return true;    
                }
            } 
           
        }
        public int Attack()
        {
            if (Armor > 0)
                return Punch;
            if (Punch == 1)
                return 1;
            return --Punch;
        }

        public void Defense(int power)
        {
            if (Armor > 0)
            {
                var check = power / 2;
                if (check < Armor)
                {
                    Armor -= check;
                }
                else
                {
                    var ext = check - Armor;
                    HP -= ext;
                    Armor = 0;
                }

                HP -= (power - check);
            }
            else
            {
                HP -= power;
            }
        }

        public override string ToString()
        {
            return "Base Hero";
        }
    }
}

