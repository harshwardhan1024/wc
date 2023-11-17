using Xunit;

namespace wc.Console.UnitTests;

public class ExecutionTests : Fixture
{
    [Fact]
    public void Returns_count_of_lines_when_l_flag_is_passed()
    {
        var process = StartWc("-l TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("2", output);
    }

    [Fact]
    public void Returns_number_of_bytes_when_c_flag_is_passed()
    {
        var process = StartWc("-c TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("14", output);
    }

    [Fact]
    public void Returns_number_of_words_when_w_flag_is_passed()
    {
        var process = StartWc("-w TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("4", output);
    }

    [Fact]
    public void Returns_number_of_characters_when_m_flag_is_passed()
    {
        var process = StartWc("-m TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("13", output);
    }

    [Fact]
    public void Order_of_flag_or_file_path_does_not_matter()
    {
        var process = StartWc("TestFiles/multi-line.txt -c");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("14", output);
    }

    [Fact]
    public void Returns_multiple_results_when_multiple_flags_are_passed()
    {
        var process = StartWc("-c -l TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.True(output.Contains("14") && output.Contains("2"));
    }

    [Fact]
    public void Output_should_be_ascending_order_when_multiple_results_are_there()
    {
        var process = StartWc("-c -l TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("2    14", output);
    }

    [Fact]
    public void When_no_flag_is_passed_then_result_should_be_equal_as_if_l_w_and_m_flags_are_passed()
    {
        var process = StartWc("TestFiles/multi-line.txt");
        var output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.Equal("2    4    13", output);
    }
}
