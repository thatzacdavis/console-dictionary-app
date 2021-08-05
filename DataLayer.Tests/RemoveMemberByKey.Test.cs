using System;
using Xunit;
using ConsoleDictionaryApp;
using System.Linq;

namespace DataLayer.Tests
{
    [Collection("Serial")]
    public class RemoveMemberByKey
    {
        [Fact]
        public void DoesNotErrorWhenKeyDoesNotExist()
        {
            ConsoleDictionaryApp.DataLayer.ClearDictionary();

            ConsoleDictionaryApp.DataLayer.RemoveMemberByKey("zac", "davis");
            Assert.Empty(ConsoleDictionaryApp.DataLayer._dictionary);
        }

        [Fact]
        public void ShouldRemoveMemberFromExistingKey()
        {
            ConsoleDictionaryApp.DataLayer.ClearDictionary();

            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis");
            ConsoleDictionaryApp.DataLayer.RemoveMemberByKey("zac", "davis");
            
            Assert.Single(ConsoleDictionaryApp.DataLayer._dictionary);
            Assert.Equal("zac", ConsoleDictionaryApp.DataLayer._dictionary.First().Key);
            Assert.Empty(ConsoleDictionaryApp.DataLayer._dictionary.First().Value);
        }

        [Fact]
        public void ShouldOnlyRemoveMemberProvidedFromExistingKey()
        {
            ConsoleDictionaryApp.DataLayer.ClearDictionary();

            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis");
            ConsoleDictionaryApp.DataLayer.AddMemberByKey("zac", "davis2");
            ConsoleDictionaryApp.DataLayer.RemoveMemberByKey("zac", "davis");
            
            Assert.Single(ConsoleDictionaryApp.DataLayer._dictionary);
            Assert.Equal("zac", ConsoleDictionaryApp.DataLayer._dictionary.First().Key);
            Assert.Single(ConsoleDictionaryApp.DataLayer._dictionary.First().Value);
            Assert.Equal("davis2", ConsoleDictionaryApp.DataLayer._dictionary.First().Value.First());
        }
    }
}
