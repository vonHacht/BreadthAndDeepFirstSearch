using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomNameGeneratorLibrary;

namespace BreadthAndDeepFirstSearch.Utils
{
    public class RandomNumberGenerator
    {
        public static int Generate(int min, int max)
        {
            return (new Random()).Next(min, max);
        }
    }
}
