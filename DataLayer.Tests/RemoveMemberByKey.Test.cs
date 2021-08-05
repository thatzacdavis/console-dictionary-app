using System;
using Xunit;
using console_dictionary_app;
using System.Linq;

namespace DataLayer.Tests
{
    [Collection("Serial")]
    public class RemoveMemberByKey
    {
        [Fact]
        public void DoesNotErrorWhenKeyDoesNotExist()
        {
            console_dictionary_app.DataLayer.ClearDictionary();

            console_dictionary_app.DataLayer.RemoveMemberByKey("zac", "davis");
            Assert.Empty(console_dictionary_app.DataLayer._dictionary);
        }

        [Fact]
        public void ShouldRemoveMemberFromExistingKey()
        {
            console_dictionary_app.DataLayer.ClearDictionary();

            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis");
            console_dictionary_app.DataLayer.RemoveMemberByKey("zac", "davis");
            
            Assert.Single(console_dictionary_app.DataLayer._dictionary);
            Assert.Equal("zac", console_dictionary_app.DataLayer._dictionary.First().Key);
            Assert.Empty(console_dictionary_app.DataLayer._dictionary.First().Value);
        }

        [Fact]
        public void ShouldOnlyRemoveMemberProvidedFromExistingKey()
        {
            console_dictionary_app.DataLayer.ClearDictionary();

            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis");
            console_dictionary_app.DataLayer.AddMemberByKey("zac", "davis2");
            console_dictionary_app.DataLayer.RemoveMemberByKey("zac", "davis");
            
            Assert.Single(console_dictionary_app.DataLayer._dictionary);
            Assert.Equal("zac", console_dictionary_app.DataLayer._dictionary.First().Key);
            Assert.Single(console_dictionary_app.DataLayer._dictionary.First().Value);
            Assert.Equal("davis2", console_dictionary_app.DataLayer._dictionary.First().Value.First());
        }
    }
}
