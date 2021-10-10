using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.IO;

using BreadthAndDeepFirstSearch.Trace;

namespace BreadthAndDeepFirstSearch.Test
{
    [TestClass]
    public class TestLog
    {
        [TestMethod]
        [DataRow(10)]
        public void TestLogMultipleThreads(int numberOfThreads)
        {
            ManualResetEvent resetEvent = new ManualResetEvent(false);
            int toProcess = numberOfThreads;

            // Start workers.
            for (int i = 0; i < numberOfThreads; i++)
            {
                new Thread(delegate ()
                {
                    Console.WriteLine($"Starting new thread: {Thread.CurrentThread.ManagedThreadId}");
                    Log.Message($"Hi I'm {Thread.CurrentThread.ManagedThreadId}");

                    // If we're the last thread, signal
                    if (Interlocked.Decrement(ref toProcess) == 0)
                        resetEvent.Set();
                }).Start();
            }

            // Wait for workers.
            resetEvent.WaitOne();
        }

        [TestMethod]
        public void TestLogWriteToFile()
        {
            Log.Message($"This is a log message");
            Log.Message($"This is a another log message", Trace.LogSeverity.Error);
            Log.Message($"Yet another log message", Trace.LogSeverity.Information);

            String somePath = Directory.GetCurrentDirectory() + "\\TestLogWriteToFile.txt";

            Log.MessageFile(somePath);
            Log.Reset();

            Console.WriteLine($"Wrote file to {somePath}");

        }
    }
}
