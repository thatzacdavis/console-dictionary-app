using System;
using Xunit;

namespace DataLayer.Tests
{
    public class General
    {
        [Fact]
        public void InitializesWithZeroCountDictionary()
        {
            Assert.Equal(0, console_dictionary_app.DataLayer._dictionary.Count);
        }
    }
}
