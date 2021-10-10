using System;

namespace BreadthAndDeepFirstSearch.Trace
{
    public class LogMessage
    {
        public String Message { get; set; }

        public int ThreadId { get; set; }

        public DateTime DateTime { get; set; }

        public LogSeverity Severity { get; set; }

        public String MemberName { get; set; }

        public String SourceFilePath { get; set; }

        public int SourceLineNumber { get; set; }

        public override string ToString()
        {
            return $"{MemberName}@{SourceFilePath}" +
                $"({SourceLineNumber}):{Message}";
        }

    }
}
