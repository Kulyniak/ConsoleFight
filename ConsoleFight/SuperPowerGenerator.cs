using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFight
{
    public static class GenerateSuperPower
        {
            public static int Power()
              {
                   var random = new Random().Next(5,10);
                   return random;
              }
        }

}
