using System;
using System.Collections.Generic;

namespace Logazar
{
    public class LogEntry
    {
        public IList<String> Lines { get; protected set; } = new List<String>();
        public Boolean Parsed { get; protected set; } = false;

        public LogEntry()
        {

        }

        public void AddLine(String newLine)
        {
            Lines.Add(newLine);
            Parsed = false;
        }
    }
}
