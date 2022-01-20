using System;
using System.Collections.Generic;
using System.Text;

namespace Fifa2072
{
    class Midfielder : Player
    {
        public double Passing { get; set; }

        public Midfielder()
        {
            Passing = 0;
        }

        public Midfielder(double x)
        {
            Passing = x;
        }

        public override void Celebration()
        {
            Console.WriteLine("JJAAAAAAAAAAAAAAAAAA");
        }
    }
}
