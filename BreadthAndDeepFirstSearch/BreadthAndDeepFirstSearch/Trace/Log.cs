using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BreadthAndDeepFirstSearch.Trace
{
    public sealed class Log
    {
        private static readonly object _lock = new object();
        private static Log _instance = null;
        private static String _logFilePath = null;
        private static List<LogMessage> _logMessages = null;

        Log()
        {
            _logMessages = new List<LogMessage>();
        }

        public static void Message(
            String message,
            LogSeverity logSeverity = 0,
            [CallerMemberName] String memberName = "",
            [CallerFilePath] String sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Log();
                    }
                }
            }

            LogMessage logMessage = new LogMessage
            {
                Message = message,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                DateTime = DateTime.UtcNow,
                Severity = logSeverity,
                MemberName = memberName,
                SourceFilePath = sourceFilePath,
                SourceLineNumber = sourceLineNumber
            };

            _logMessages.Add(logMessage);
        }

        public static void MessageFile(String path)
        {
            if (_instance == null)
            {
                throw new Exception("No log messages found !");
            }

            _logFilePath = path;
        }


        public static void Reset()
        {
            if (_logFilePath != null)
            {
                using (StreamWriter writer = new StreamWriter(_logFilePath))
                {
                    foreach (LogMessage logMessage in _logMessages)
                    {
                        writer.WriteLine(logMessage.ToString());
                    }
                }
            }
            if (_instance != null)
                _instance = null;
            if (_logMessages != null)
                _logMessages = null;
        }
    }
}

