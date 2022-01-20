using System;
using System.Collections.Generic;
using System.Text;

namespace Fifa2072
{
    class Defender : Player
    {
        public double Defending { get; set; }

        public Defender()
        {
            Defending = 0;
        }

        public Defender(double x)
        {
            Defending = x;
        }

        public override void Celebration()
        {
            Console.WriteLine("PAZDANNNNNNNNNNN");
        }
    }
}
