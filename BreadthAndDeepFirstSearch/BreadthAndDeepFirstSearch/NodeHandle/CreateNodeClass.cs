using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BreadthAndDeepFirstSearch.Utils;

namespace BreadthAndDeepFirstSearch.NodeHandle
{
    public class CreateNodeClass
    {
        private Node _nodes;
        private int _node;
        private int _solution;
        private int _minRandomNodeNumber = 1;
        private int _maxRandomNodeNumber = 10;
        private List<String> _randomNames;
        private List<bool> _randomBool;

        public CreateNodeClass()
        {
            _node = RandomNumberGenerator.Generate(_minRandomNodeNumber, _maxRandomNodeNumber);
            _solution= RandomNumberGenerator.Generate(0, _node);
            _randomNames = RandomNameGenerator.GenerateList(_node);
            _randomBool = RandomTrueAndFalseGenerator.GenerateList(_node);

            CreateNodes(0, ref _nodes);
        }
        
        public CreateNodeClass(int nodes, int solution) 
        {
            _node = nodes;
            _solution = solution;
        }

        public Node Nodes
        {
            get 
            { 
                return _nodes; 
            }
        }

        private void CreateNodes(int parent_id, ref Node parent_node)
        {
            if (parent_id < _node)
            {
                if (parent_node == null)
                {
                    parent_node = new Node();
                    parent_node.parent = parent_id;
                    parent_node.label = "FATHER";

                    parent_node.children = new List<Node>();

                    CreateNodes(++parent_id, ref parent_node);
                }
                else 
                {
                    Node newborn = new Node();
                    newborn.children = new List<Node>();
                    newborn.parent = parent_id;
                    newborn.label = _randomNames[parent_id];

                    parent_node.children.Add(newborn);

                    if (_randomBool[parent_id])
                    {
                        CreateNodes(++parent_id, ref parent_node);
                    }
                    else
                    {
                        CreateNodes(++parent_id, ref newborn);
                    }
                }
            }
        }


    }
}
