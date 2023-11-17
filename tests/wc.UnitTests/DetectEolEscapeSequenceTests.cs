using Xunit;

namespace wc.UnitTests;

public class DetectEolEscapeSequenceTests
{
    [Theory]
    [InlineData("abc\n", "\n")]
    [InlineData("abc\r", "\r")]
    [InlineData("abc\r\n", "\r\n")]
    public void Correctly_identify_EOL_escape_sequences(string text, string expectedEolSequence)
    {
        Assert.Equal(expectedEolSequence, new Text(text).Eol);
    }

    [Fact]
    public void Should_use_line_feed_as_default_when_no_EOL_escape_sequence_is_present()
    {
        Assert.Equal("\n", new Text("abc").Eol);
    }
}
