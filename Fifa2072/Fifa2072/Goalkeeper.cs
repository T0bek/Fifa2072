using System;
using System.Collections.Generic;
using System.Text;

namespace Fifa2072
{
    class Goalkeeper : Player
    {
        public double Handling { get; set; }

        public Goalkeeper()
        {
            Handling = 0;
        }

        public Goalkeeper(double x)
        {
            Handling = x;
        }

        public override void Celebration()
        {
            Console.WriteLine("ALE ŁATWO");
        }
    }
}
