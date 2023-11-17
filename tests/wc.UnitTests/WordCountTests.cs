using Xunit;

namespace wc.UnitTests;

public class WordCountTests
{
    [Theory]
    [InlineData("word1 word2  word3\nword4  word5", 5)]
    public void Correct_count_number_of_words_in_text(string text, int expectedCount)
    {
        Assert.Equal(expectedCount, new Text(text).CountWords());
    }
}
