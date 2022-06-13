

Console.WriteLine(LogAnalysis.SubstringAfter(" am the 1st test", " "));
Console.ReadKey();

Console.WriteLine(LogAnalysis.SubstringBetween("FIND >>> SOMETHING <===< HERE", ">>> ", " <===<"));

Console.ReadLine();

Console.WriteLine(LogAnalysis.SubstringBetween("[INFO]: File Deleted.", "[", "]"));

Console.ReadLine();
public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimeter)
    {
        return str.Substring(str.IndexOf(delimeter) + delimeter.Length);
    }

    public static string SubstringBetween(this string str, string delimeter1, string delimeter2)
    {
        string del1 = delimeter1.Trim();
        string del2 = delimeter2.Trim();
        string trimmedString = str.Replace(" ", "");

        Console.WriteLine($"Length of the string to find {trimmedString.Length}");

        Console.WriteLine("first delimeter, length of first delimiter, second delimiter, length of second delimter");
        Console.WriteLine(delimeter1 + " " + delimeter1.Trim().Length + " " + delimeter2 + " " + delimeter2.Trim().Length);

        Console.WriteLine("index of first delimeter, kength of first delimeter, index of second delimeter, length of second delimeter");
        Console.WriteLine(trimmedString.IndexOf(delimeter1) + " " + delimeter1.Trim().Length + " " + trimmedString.IndexOf(delimeter2) + " " + delimeter2.Trim().Length);

        Console.WriteLine("Trimmed string:");
        Console.WriteLine(trimmedString);

        return trimmedString.Substring(trimmedString.IndexOf(del1) + del1.Length, trimmedString.IndexOf(del2) - del2.Length);
    }
    public static string Message(this string str)
    {
        return SubstringAfter(str, ": ");
    }
    public static string LogLevel(this string str)
    {
        return SubstringBetween(str, "[", "]");
    }
}