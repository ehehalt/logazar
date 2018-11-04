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

        private static Regex lineRegex = null;
        private static Regex LineRegex 
        { 
          get
          {
            if (lineRegex == null)
              lineRegex = new Regex(@"(?<date>\d+/\d+/\d+) (?<time>\d+:\d+:\d+) (?<level>\d+)> (?<data>.*)$", RegexOptions.Compiled);
            return lineRegex;
          } 
        }

        private static Regex typeRegex = null;
        private static Regex TypeRegex 
        { 
          get
          {
            if (typeRegex == null)
              typeRegex = new Regex(@"\[(?<type>.*?)\] (?<data>.*)$", RegexOptions.Compiled);
            return typeRegex;
          }
        }

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
                var matchFirstLine = LineRegex.Match(Lines.First());
                if (matchFirstLine.Success)
                {
                  var date = matchFirstLine.Groups["date"].ToString();
                  var time = matchFirstLine.Groups["time"].ToString();
                  
                  TimeStamp = CreateTimeStamp(date: date, time: time);
                  Level = matchFirstLine.Groups["level"].ToString();
                  var data = matchFirstLine.Groups["data"].ToString();
                  
                  var matchTypeAndData = TypeRegex.Match(data);
                  if (matchTypeAndData.Success)
                  {
                    Type = matchTypeAndData.Groups["type"].ToString();
                    Data = matchTypeAndData.Groups["data"].ToString();
                  }
                  else
                  {
                    Type = "undefined";
                    Data = data;
                  }
                }

                foreach(var line in Lines.Skip(1))
                {
                  var matchLine = LineRegex.Match(line);
                  if (matchLine.Success)
                  {
                    var data = matchLine.Groups["data"].ToString();
                    Data += data;
                  }
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
