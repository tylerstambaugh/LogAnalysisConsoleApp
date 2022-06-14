

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

        string firstDelRemoved = trimmedString.Substring(trimmedString.IndexOf(del1) + del1.Length); ;

        string secondDelRemoved = firstDelRemoved.Substring(0, firstDelRemoved.IndexOf(del2));

        return $"{secondDelRemoved}";
    }
    public static string Message(this string str)
    {
        return SubstringAfter(str, ": ");
    }
    public static string LogLevel(this string str)
    {
        return SubstringBetween(str, "[", "]");
    }
