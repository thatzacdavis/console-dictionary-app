using System;
using Xunit;
using console_dictionary_app;
using System.Linq;

namespace DataLayer.Tests
{
    [Collection("Serial")]
    public class AddMemberByKey
    {
        [Fact]
        public void AddsNewKeyWhenMemberAddedForNewKey()
        {
            console_dictionary_app.DataLayer.ClearDictionary();

            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis");
            Assert.Single(console_dictionary_app.DataLayer._dictionary);
        }

        [Fact]
        public void AddsSuppliedKeyAndValue()
        {
            console_dictionary_app.DataLayer.ClearDictionary();

            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis");
            Assert.Equal("zac", console_dictionary_app.DataLayer._dictionary.First().Key);
            Assert.Equal("davis", console_dictionary_app.DataLayer._dictionary.First().Value.First());
        }

        [Fact]
        public void AddsSuppliedValueToExistingKey()
        {
            console_dictionary_app.DataLayer.ClearDictionary();

            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis");
            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis2");
            Assert.Equal("davis2", console_dictionary_app.DataLayer._dictionary.First().Value.ElementAt(1));
        }
    }
}
