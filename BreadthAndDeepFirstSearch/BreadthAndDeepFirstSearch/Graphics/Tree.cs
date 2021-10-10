using System;
using System.Windows.Forms;

using BreadthAndDeepFirstSearch.NodeHandle;

namespace BreadthAndDeepFirstSearch.Graphics
{
    public partial class Tree : Form
    {
        private Microsoft.Msagl.Drawing.Graph _graph = null;
        private NodeHandler _nodeHandler = null;

        public Tree(NodeHandler nodeHandler, string[] args)
        {
            InitializeComponent();

            _nodeHandler = nodeHandler;
            
            _graph = new Microsoft.Msagl.Drawing.Graph("my beautiful tree");

            _loadGraph(nodeHandler.Nodes);
        }

        private void Graph_Load(object sender, EventArgs e)
        {           
            _drawGraph();
        }

        private void _initializeGraphTest()
        {
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            this.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(viewer);
            this.ResumeLayout();
        }

        private void _loadGraph(Node node)
        {
            foreach (Node child in node.children)
            {
                _graph.AddEdge(node.label, child.label);
                _loadGraph(child);
            }
        }

        private void _loadDeepGraph(Node node, int solution)
        {
            foreach (Node child in node.children)
            {
                _graph.AddEdge(node.label, child.label);
                _loadGraph(child);
            }



        }

        private void _drawGraph()
        {
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            viewer.Graph = _graph;
            this.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(viewer);
            this.ResumeLayout();
        }

        
    }
}
