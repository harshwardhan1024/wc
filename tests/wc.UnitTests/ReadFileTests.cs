using Xunit;

namespace wc.UnitTests;

public class ReadFileTests
{
    [Fact]
    public void Read_file()
    {
        var text = FileReader.Read("TestFiles/single-line.txt");
        Assert.Equal("Line 1", text.Value);
    }
}
