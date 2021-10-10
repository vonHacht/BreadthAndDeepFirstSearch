using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

using BreadthAndDeepFirstSearch.Utils;

namespace BreadthAndDeepFirstSearch.Test
{
    

    [TestClass]
    public class TestUtils
    {
        [TestMethod]
        public void TestRandomNameGeneratorRecursive()
        {
            simpleRecursive(0, 15);
        }

        [TestMethod]
        public void TestRandomNameGeneratorMultipleNames()
        {
            List<String> list = RandomNameGenerator.GenerateList(15);

            Console.WriteLine("This is a random name {0}", list[0]);
            Console.WriteLine("This is a random name {0}", list[1]);
            Console.WriteLine("This is a random name {0}", list[2]);
            Console.WriteLine("This is a random name {0}", list[3]);

        }

        [TestMethod]
        public void TestRandomTrueAndFalseGenerator()
        {
            List<bool> list = RandomTrueAndFalseGenerator.GenerateList(100);

            foreach (bool trueorfalse in list)
            {
                Console.WriteLine(trueorfalse ? "true" : "false");
            }
        }

        private void simpleRecursive(int counter, int stop)
        {
            if (counter < stop)
            {
                Console.WriteLine(String.Format("This is a random name {0}", RandomNameGenerator.Generate()));
                simpleRecursive(++counter, stop);
            }
        }

   
    }
}
