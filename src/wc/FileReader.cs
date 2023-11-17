namespace wc;

public class FileReader
{
    public static Text Read(string path)
    {
        return new Text(File.ReadAllText(path));
    }
}
