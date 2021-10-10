using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthAndDeepFirstSearch.NodeHandle
{
    public class Node
    {
        public int index { get; set; }
        public int parent { get; set; }
        public List<Node> children { get; set; }
        public string label { get; set; }

    }
}
