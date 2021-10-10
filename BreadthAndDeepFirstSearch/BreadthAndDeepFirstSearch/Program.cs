using System;
using System.IO;
using System.Windows.Forms;

using BreadthAndDeepFirstSearch.Trace;
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
        static void Main(string[] args /* some argument breath OR deep */)
        {
            /* don't rely on the log implementation as of now, use only here */
            Log.Message("Running Program", LogSeverity.Information);

            var createNodeClass = new NodeHandler();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tree(nodes));

            Log.Message("Stopping Program", LogSeverity.Information);
            Log.MessageFile(Directory.GetCurrentDirectory() + "\\log.txt");
            Log.Reset();

            Console.WriteLine("BREAK");
        }
    }
}
