using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Walk(int numberOfSteps)
        {
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively and knocked on your window.");
                return;
            }
            base.Walk(numberOfSteps);
        }
    }
}

