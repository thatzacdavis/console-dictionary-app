using System;
using Xunit;
using ConsoleDictionaryApp;
using System.Linq;

namespace DataLayer.Tests
{
    [Collection("Serial")]
    public class AddMemberByKey
    {
        [Fact]
        public void AddsNewKeyWhenMemberAddedForNewKey()
        {
            ConsoleDictionaryApp.DataLayer.ClearDictionary();

            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis");
            Assert.Single(ConsoleDictionaryApp.DataLayer._dictionary);
        }

        [Fact]
        public void AddsSuppliedKeyAndValue()
        {
            ConsoleDictionaryApp.DataLayer.ClearDictionary();

            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis");
            Assert.Equal("zac", ConsoleDictionaryApp.DataLayer._dictionary.First().Key);
            Assert.Equal("davis", ConsoleDictionaryApp.DataLayer._dictionary.First().Value.First());
        }

        [Fact]
        public void AddsSuppliedValueToExistingKey()
        {
            ConsoleDictionaryApp.DataLayer.ClearDictionary();

            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis");
            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis2");
            Assert.Equal("davis2", ConsoleDictionaryApp.DataLayer._dictionary.First().Value.ElementAt(1));
        }
    }
}
