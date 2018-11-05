using System;
using Xunit;
using Logazar;

namespace Logazar.Tests
{
  public class UnitTestLogEntry
  {
    [Fact]
    public void TestConstructor()
    {
      var entry = new LogEntry();
      Assert.False(entry.Parsed);
      Assert.Empty(entry.Lines);
    }

    [Fact]
    public void TestAddLine()
    {
      var entry = new LogEntry();
      entry.AddLine("newLine");
      Assert.False(entry.Parsed);
      Assert.NotEmpty(entry.Lines);
      Assert.Equal(1, entry.Lines.Count);
    }

    [Fact]
    public void TestConnectLine()
    {
      const String line1 = "10/26/18 15:09:26 1> [connect] dbname = XE username = SCOTT";
      DateTime timeStamp1 = new DateTime(2018, 10, 26, 15, 9, 26);

      var entry1 = new LogEntry();
      entry1.AddLine(line1);
      entry1.Parse();
      Assert.True(entry1.Parsed);
      Assert.Equal(1, entry1.Lines.Count);
      Assert.True(timeStamp1.Equals(entry1.TimeStamp));
      Assert.Equal("1", entry1.Level);
      Assert.Equal("connect", entry1.Type);
      Assert.Equal("dbname = XE username = SCOTT", entry1.Data);

      const string line2 = "11/2/18 15:09:26 1> [connect] dbname = XE username = SCOTT";
      DateTime timeStamp2 = new DateTime(2018, 11, 2, 15, 9, 26);

      var entry2 = new LogEntry();
      entry2.AddLine(line2);
      entry2.Parse();
      Assert.True(entry2.Parsed);
      Assert.Equal(1, entry2.Lines.Count);
      Assert.True(timeStamp2.Equals(entry2.TimeStamp));
      Assert.Equal("1", entry2.Level);
      Assert.Equal("connect", entry1.Type);
      Assert.Equal("dbname = XE username = SCOTT", entry2.Data);
    }

    [Fact]
    public void TestCompileLines()
    {
      const String line1 = "10/26/18 15:09:26 1> [compile] SELECT SYSDATE F";
      const String line2 = "10/26/18 15:09:26 1> ROM DUAL";

      var entry = new LogEntry();
      entry.AddLine(line1);
      entry.AddLine(line2);
      entry.Parse();

      Assert.True(entry.Parsed);
      Assert.Equal(2, entry.Lines.Count);
      Assert.Equal("compile", entry.Type);
      Assert.Equal("SELECT SYSDATE FROM DUAL", entry.Data);
    }

    [Fact]
    public void TestGetDatabaseParameter()
    {
      const String line = "10/26/18 15:09:26 2> [get database parameter] param = 1004";
      var entry = new LogEntry();
      entry.AddLine(line);
      entry.Parse();

      Assert.True(entry.Parsed);
      Assert.Equal("get database parameter", entry.Type);
      Assert.Equal("param = 1004", entry.Data);
    }

    [Fact]
    public void TestFetch()
    {
      const String line = "10/26/18 15:09:26 2> [fetch]";
      var entry = new LogEntry();
      entry.AddLine(line);
      entry.Parse();

      Assert.True(entry.Parsed);
      Assert.Equal("fetch", entry.Type);
      Assert.Equal("", entry.Data);
    }
  }
}
