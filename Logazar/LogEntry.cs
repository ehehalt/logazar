using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

				public void Parse()
				{
						if(Lines.Count > 0)
						{
								// First line
								var rxFirstLine = new Regex(@"(?<date>\d+/\d+/\d+.) (?<time>\d+:\d+:\d+)");
								var matchFirstLine = rxFirstLine.Match(Lines.First());
                if (matchFirstLine.Success)
                {
                  var date = matchFirstLine.Groups["date"].ToString();
                  var time = matchFirstLine.Groups["time"].ToString();

                  TimeStamp = CreateTimeStamp(date: date, time: time);
                }
						}

            Parsed = true;
				}

        private DateTime CreateTimeStamp(string date, string time)
        {
          var dateParts = date.Split('/');
          int year = 2000 + Convert.ToInt32(dateParts[2]);
          int month = Convert.ToInt32(dateParts[0]);
          int day = Convert.ToInt32(dateParts[1]);
          var timeParts = time.Split(':');
          int hour = Convert.ToInt32(timeParts[0]);
          int minute = Convert.ToInt32(timeParts[1]);
          int second = Convert.ToInt32(timeParts[2]);
          var timeStamp = new DateTime(year, month, day, hour, minute, second);
          return timeStamp;
        }
    }
}
