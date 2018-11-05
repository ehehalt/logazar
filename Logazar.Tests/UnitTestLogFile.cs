using System;
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
  }
}