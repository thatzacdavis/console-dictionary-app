using System;
using Xunit;

namespace DataLayer.Tests
{
    public class General
    {
        [Fact]
        public void InitializesWithZeroCountDictionary()
        {
            Assert.Equal(console_dictionary_app.DataLayer._dictionary.Count, 0);
        }
    }
}