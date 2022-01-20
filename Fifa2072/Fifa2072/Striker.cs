using System;
using System.Collections.Generic;
using System.Text;

namespace Fifa2072
{
    class Striker : Player
    {
        public double Shoting { get; set; }

        public Striker()
        {
            Shoting = 0;
        }

        public Striker(double x)
        {
            Shoting = x;
        }

        public override void Celebration()
        {
            Console.WriteLine("SIIIUUUUUUUUUUUUUUUU");
        }
    }
}
