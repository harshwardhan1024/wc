using Xunit;

namespace wc.UnitTests;

public class LineCountTests
{
    private const string ONE_LINE = "One line.";
    private const string MULTI_LINE = "Multiline\nText";

    private const string EMPTY_MULTI_LINE = "\n";
    private const string EMPTY_LINE = "";

    [Theory]
    [InlineData(ONE_LINE, 1)]
    [InlineData(MULTI_LINE, 2)]
    [InlineData(EMPTY_MULTI_LINE, 2)]
    [InlineData(EMPTY_LINE, 1)]
    public void Correctly_counts_the_number_of_lines(string text, int expectedLines)
    {
        Assert.Equal(expectedLines, new Text(text).CountLines());
    }

    [Fact]
    public void Counts_the_number_of_lines_from_file()
    {
        var text = FileReader.Read("TestFiles/multi-line.txt");
        Assert.Equal(2, text.CountLines());
    }
}