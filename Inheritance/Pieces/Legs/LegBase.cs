using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    abstract class LegBase
    {
        public int NumberOfPockets { get; set; }
        public string Color { get; set; }
        public LegSize Size { get; set; }

        public virtual void Walk(int numberOfSteps)
        {
            Console.WriteLine($"The {Size} legs took {numberOfSteps} steps.");
        }
    }
}
