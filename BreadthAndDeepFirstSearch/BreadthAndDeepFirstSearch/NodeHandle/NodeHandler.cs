using System;
using System.Collections.Generic;

using BreadthAndDeepFirstSearch.Utils;
using BreadthAndDeepFirstSearch.Trace;

namespace BreadthAndDeepFirstSearch.NodeHandle
{
    public class NodeHandler
    {
        private Node _nodes;
        private int _node;
        private int _solution;
        private int _minRandomNodeNumber = 1;
        private int _maxRandomNodeNumber = 10;
        private List<String> _randomNames = null;
        private List<bool> _randomBool = null;

        public NodeHandler()
        {
            _node = RandomNumberGenerator.Generate(_minRandomNodeNumber, _maxRandomNodeNumber);
            _solution= RandomNumberGenerator.Generate(0, _node);

            CreateNodes(0, ref _nodes);
        }
        
        public NodeHandler(int nodes, int solution) 
        {
            _node = nodes;
            _solution = solution;

            CreateNodes(0, ref _nodes);
        }

        public Node Nodes
        {
            get 
            { 
                return _nodes; 
            }
        }

        public int Solution
        {
            get
            {
                return _solution;
            }
        }


        private void CreateNodes(int parent_id, ref Node parent_node)
        {
            if (_randomNames == null)
                _randomNames = RandomNameGenerator.GenerateList(_node);
            if (_randomBool == null)
                _randomBool = RandomTrueAndFalseGenerator.GenerateList(_node);

            if (parent_id < _node)
            {
                if (parent_node == null)
                {
                    parent_node = new Node();
                    parent_node.index = 0;
                    parent_node.parent = parent_id;
                    parent_node.label = $"FATHER";

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
