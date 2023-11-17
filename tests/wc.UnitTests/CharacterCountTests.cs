using Xunit;

namespace wc.UnitTests;

public class CharacterCountTests
{
    [Theory]
    [InlineData("12345", 5)]
    public void Correctly_count_the_number_of_characters(string text, int expectedCount)
    {
        Assert.Equal(expectedCount, new Text(text).CountCharacters());
    }
}
