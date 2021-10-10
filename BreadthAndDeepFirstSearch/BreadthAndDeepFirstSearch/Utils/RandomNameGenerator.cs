using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomNameGeneratorLibrary;

namespace BreadthAndDeepFirstSearch.Utils
{
    public class RandomNameGenerator
    {
        public static String Generate()
        {
            return (new PersonNameGenerator()).GenerateRandomFirstAndLastName();
        }

        public static List<String> GenerateList(int elements)
        {
            return (new PersonNameGenerator()).GenerateMultipleLastNames(elements).ToList();
        }
    }
}
