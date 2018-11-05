using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Logazar;

namespace Logazar.Tests
{
  public class UnitTestLogFile
  {
    [Fact]
    public void TestConstructor()
    {
      var logfile1 = new LogFile();
      Assert.True(String.IsNullOrEmpty(logfile1.FilePath));
      Assert.Equal(0, logfile1.Entries.Count);

      const string filename = "filename";
      var logfile2 = new LogFile(filename);
      Assert.Equal(filename, logfile2.FilePath);
      Assert.Equal(0, logfile2.Entries.Count);
    }

    [Fact]
    public void TestTwoSeperatedEntries()
    {
      var logfile = new LogFile();

      var lines = new List<String>();
      lines.Add("10/26/18 15:09:26 1> [connect] dbname = XE username = SCOTT");
      lines.Add("10/26/18 15:09:26 1> [connect] dbname = XE username = SCOTT");
      
      logfile.Load(lines);

      Assert.Equal(2, logfile.Entries.Count);
      foreach(var entry in logfile.Entries)
      {
        Assert.Equal(LogFile.CONNECT, entry.Type);
      }
    } 

    [Fact]
    public void TestOneEntryWithTwoLines()
    {
      var logfile = new LogFile();

      var lines = new List<String>();
      lines.Add("10/26/18 15:09:26 1> [compile] ALTER SESSION SET nls_numeric_characters = '");
      lines.Add("10/26/18 15:09:26 1> .,' ");
      
      logfile.Load(lines);

      Assert.Equal(1, logfile.Entries.Count);

      var entry = logfile.Entries.First();

      Assert.Equal(LogFile.COMPILE, entry.Type);
      Assert.Equal("ALTER SESSION SET nls_numeric_characters = '.,' ", entry.Data);
    }
  }
}