using System.Globalization;
using System.Text;

namespace wc;

public class Text
{
    private const string WINDOWS_EOL = "\r\n";
    private const string LINUX_EOL = "\n";
    private const string OLD_MACOS_EOL = "\r";

    public Text(string text)
    {
        Value = text;
        Eol = FindEol(text);
    }

    public string Value { get; }

    public string Eol { get; }

    public int CountBytes()
    {
        return Encoding.UTF8.GetByteCount(Value);
    }

    public int CountLines()
    {
        return Value.Split(Eol).Length;
    }

    public int CountWords()
    {
        return Value.Trim()
            .Split()
            .Where(e => !string.IsNullOrWhiteSpace(e))
            .Count();
    }

    public int CountCharacters()
    {
        return new StringInfo(Value).LengthInTextElements;
    }

    private string FindEol(string text)
    {
        if (text.Contains(WINDOWS_EOL))
        {
            return WINDOWS_EOL;
        }
        
        if (text.Contains(OLD_MACOS_EOL))
        {
            return OLD_MACOS_EOL;
        }

        // By default should use LINUX_EOL.
        return LINUX_EOL;
    }
}
