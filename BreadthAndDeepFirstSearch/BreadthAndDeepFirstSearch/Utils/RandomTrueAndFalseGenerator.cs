using System;
using System.Collections.Generic;

namespace BreadthAndDeepFirstSearch.Utils
{
    public class RandomTrueAndFalseGenerator
    {
        public static bool Generate()
        {
            if ((new Random()).Next(0, 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<bool> GenerateList(int elements)
        {

            var random = new Random();

            List<bool> booleanList = new List<bool>();
            for(int counter=0; counter < elements; ++counter)
            {
                booleanList.Add(random.Next(0, 2) == 1 ? true : false);
            }

            return booleanList;
        }
    }
}
