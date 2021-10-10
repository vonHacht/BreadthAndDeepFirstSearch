using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using BreadthAndDeepFirstSearch.NodeHandle;

namespace BreadthAndDeepFirstSearch.Test
{
    

    [TestClass]
    public class TestBreadth
    {
        [TestMethod]
        public void TestRandomConstructor()
        {
            var breadthClass = new NodeHandler();

            var nodes = breadthClass.Nodes;

            Console.WriteLine("STOP");
        }
    }
}
