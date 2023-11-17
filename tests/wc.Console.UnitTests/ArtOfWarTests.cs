using Xunit;

namespace wc.Console.UnitTests;

public class ArtOfWarTests : Fixture
{
    [Fact]
    public void Count_Art_Of_War()
    {
        var process = StartWc("TestFiles/art-of-war.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("7143    58164    332143", output);
    }
}
