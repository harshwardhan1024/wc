using wc;

public class Program
{
    private static string[] DEFAULT_FLAGS = new string[] { "-l", "-w", "-m" };

    public static int Main(string[] args)
    {
        var flags = args.Where(arg => arg.StartsWith("-")).ToArray();
        flags = flags.Count() > 0 ? flags : DEFAULT_FLAGS;

        var filepath = args.FirstOrDefault(arg => !arg.StartsWith("-"));

        List<int> counts = PerformCountings(flags, FileReader.Read(filepath));

        PrintResult(counts);

        return 0;
    }

    private static List<int> PerformCountings(string[] flags, Text text)
    {
        var counts = new List<int>();
        foreach (var flag in flags)
        {
            if (flag == "-l")
            {
                counts.Add(text.CountLines());
            }
            else if (flag == "-c")
            {
                counts.Add(text.CountBytes());
            }
            else if (flag == "-w")
            {
                counts.Add(text.CountWords());
            }
            else if (flag == "-m")
            {
                counts.Add(text.CountCharacters());
            }
        }

        return counts;
    }

    private static void PrintResult(List<int> counts)
    {
        counts.Sort();
        for (var i = 0; i < counts.Count; i++)
        {
            if (i > 0)
            {
                Console.Write(@"    ");
            }
            Console.Write(counts[i]);
        }
    }
}