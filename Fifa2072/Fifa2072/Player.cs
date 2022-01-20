using System;
using System.Collections.Generic;
using System.Text;

namespace Fifa2072
{
    class Player
    {
        public double Speed { get; set; }

        public Player()
        {
            Speed = 0;
        }

        public Player(double x)
        {
            Speed = x;
        }

        public virtual void Celebration()
        {
            Console.WriteLine("GOOOOOOL");
        }
    }
}

