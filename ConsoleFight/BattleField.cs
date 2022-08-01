using System;
using System.Collections.Generic;
using System.Text;
using ConsoleFight.Heroes;

namespace ConsoleFight
{
    public static class BattleField
    {
        public static void Battle(BaseWarrior warrior1, BaseWarrior warrior2)
        {
            int roundCount = 0;
            do
            {
                Console.WriteLine($"Round {++roundCount}");
                warrior2.Defense(warrior1.Attack());
                warrior1.Defense(warrior2.Attack());
            } while (warrior1.IsAlive && warrior2.IsAlive);

            var winner = warrior1.IsAlive
                ? warrior1
                : warrior2.IsAlive
                    ? warrior2
                    : null;

            var looser = winner != warrior1
                ? warrior1
                : warrior2;

            if (winner != null)
            {
                Console.WriteLine($"{winner} won in {roundCount} round.\n HP left {winner.HP}.\n Looser is {looser}.");
            }
            else
            {
                Console.WriteLine("No winners");
            }
        }
    }
 }

