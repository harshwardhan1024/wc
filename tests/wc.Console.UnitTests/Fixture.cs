using System.Diagnostics;

namespace wc.Console.UnitTests;

public class Fixture
{
    protected string ExecutablePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "wc.Console.exe");
    }

    protected Process? StartWc(string args)
    {
        return Process.Start(new ProcessStartInfo
        {
            FileName = ExecutablePath(),
            RedirectStandardOutput = true,
            Arguments = args
        });
    }
}
