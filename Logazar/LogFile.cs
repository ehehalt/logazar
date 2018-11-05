using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Logazar
{
  public class LogFile
  {
    #region Properties

    public String FilePath { get; set; }
    public IList<LogEntry> Entries { get; set; }

    public const String COMPILE = "compile";
    public const String CONNECT = "connect";

    private static Regex lineRegex;
    private static Regex LineRegex
    {
      get
      {
        if (lineRegex == null)
          lineRegex = new Regex(@"[0-9/: ]+> \[", RegexOptions.Compiled);
        return lineRegex;
      }
    }

    #endregion Properties
    #region Contructors

    public LogFile()
    {
      FilePath = "";
      Entries = new List<LogEntry>();
    }

    public LogFile(string filePath)
      : this()
    {
      FilePath = filePath;
    }

    #endregion Constructors
    #region Public Interface

    public void Load()
    {
      try
      {
        var lines = File.ReadLines(FilePath, Encoding.UTF8);
        Load(lines);
      }
      catch (Exception ex)
      {
        Console.Error.WriteLine(ex.Message);
      }
    }

    public void Load(IEnumerable<string> lines)
    {
      try
      {
        var entry = new LogEntry();
        foreach (String line in lines)
        {
          if (LineRegex.IsMatch(line))
          {
            if (entry.Lines.Count == 0)
            {
              entry.AddLine(line);
            }
            entry.Parse();
            Entries.Add(entry);
            entry = new LogEntry();
          }
          entry.AddLine(line);
        }
      }
      catch (System.Exception ex)
      {
        Console.Error.WriteLine(ex.Message);
      }
    }

    #endregion Public Interface    

  }
}
