using Inheritance.Pieces.Legs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var shorts = new Shorts
            {
                Color = "Tan",
                Length = Length.School,
                Size = LegSize.Baby,
                NumberOfPockets = 6
            };

            

            var jeans1 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 4
            };

            var jeans2 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Child,
                NumberOfPockets = 4
            };

            var jeans3 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Baby,
                NumberOfPockets = 4
            };

            var skirt = new Skirt
            {
                Color = "Rainbow",
                Size = LegSize.Child,
                NumberOfPockets = 0,
                Material = "Stretchy",
                Length = Length.Church
            };

            var skirt1 = new Skirt
            {
                Color = "Sparkly",
                Size = LegSize.Adult,
                NumberOfPockets = 0,
                Material = "Sequins",
                Length = Length.StreetCorner
            };

            var legs = new List<LegBase>
            {
                shorts,
                skirt,
                jeans1,
                jeans2,
                jeans3,
                skirt1
            };

            foreach (var leg in legs)
            {
                leg.Walk(10);

                if (leg is Skirt s)
                {
                    s.Material = "jeans";
                }
            }

            Console.ReadLine();
        }
    }
}
