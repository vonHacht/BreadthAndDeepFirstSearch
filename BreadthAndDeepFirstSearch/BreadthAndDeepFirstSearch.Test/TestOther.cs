using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

using BreadthAndDeepFirstSearch.Utils;

namespace BreadthAndDeepFirstSearch.Test
{
    [TestClass]
    public class TestOther
    {
        [TestMethod]
        public void TestContainer()
        {

            var random = new Random();
            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine(String.Format("Random true/false {0}", random.Next(0, 2)));
            }
        }

        [TestMethod]
        public void TestRange()
        {
            IEnumerable<int> squares = 
                Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void TestBooleanList()
        {
            List<bool> booleanList =
                Enumerable.Repeat(false, 100).Select(x => x = RandomTrueAndFalseGenerator.Generate()).ToList();

            Console.WriteLine("STOP");
        }

        [TestMethod]
        public void TestRandom()
        {
            var rnd = new Random();

            List<bool> booleanList = new List<bool>();
            booleanList.Add(rnd.Next(0, 2) == 1 ? true : false);
            booleanList.Add(rnd.Next(0, 2) == 1 ? true : false);
            booleanList.Add(rnd.Next(0, 2) == 1 ? true : false);
            booleanList.Add(rnd.Next(0, 2) == 1 ? true : false);
        }

        [TestMethod]
        public void TestDecimal()
        {
            double d = (double)1031 / 100;

            Console.WriteLine(d);
        }
    }
}
