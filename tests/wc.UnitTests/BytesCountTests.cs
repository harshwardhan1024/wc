using Xunit;

namespace wc.UnitTests;

public class BytesCountTests
{
    private const string TEXT = "abc";

    [Theory]
    [InlineData(TEXT, 3)]
    public void Returns_correct_bytes_count(string text, int expectedCount)
    {
        Assert.Equal(expectedCount, new Text(text).CountBytes());
    }

    [Fact]
    public void Returns_bytes_count_from_file()
    {
        var text = FileReader.Read("TestFiles/single-line.txt");
        Assert.Equal(6, text.CountBytes());
    }
}