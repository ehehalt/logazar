using System;
using System.Collections.Generic;

namespace Logazar
{
    public class LogEntry
    {
        // Original lines
        public IList<String> Lines { get; protected set; } 
        public Boolean Parsed { get; protected set; }

        // Parsed data
        public String Data { get; protected set; }
				public String Type { get; protected set; }
				public String Level { get; protected set; }
				public DateTime TimeStamp { get; protected set; }

				public String TimeStampString
				{
						get
						{
								return TimeStamp.ToShortDateString() + " " + TimeStamp.ToLongTimeString();
						}
				}

        public LogEntry()
        {
            Lines = new List<String>();
            Parsed = false;

						Data = String.Empty;
						Type = String.Empty;
						Level = String.Empty;
						TimeStamp = new DateTime();
						
						
        }

        public void AddLine(String newLine)
        {
            Lines.Add(newLine);
            Parsed = false;
        }
    }
}
