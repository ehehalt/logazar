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
    }
}
