using System;
using System.Windows.Forms;

using BreadthAndDeepFirstSearch.NodeHandle;
using BreadthAndDeepFirstSearch.Graphics;

namespace BreadthAndDeepFirstSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(/* some argument breath OR deep */)
        {
            // if breadth else deep etc.
            var createNodeClass = new CreateNodeClass();
            var nodes = createNodeClass.Nodes;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tree(nodes));

            //NodeToFile.write("ALL.txt", nodes);

            Console.WriteLine("BREAK");
            
        }
    }
}
