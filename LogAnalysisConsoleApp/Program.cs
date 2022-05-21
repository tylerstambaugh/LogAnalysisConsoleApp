// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(LogAnalysis.SubstringAfter(" am the 1st test", " "));
Console.ReadKey();


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

        Console.WriteLine(trimmedString.Length);
        Console.WriteLine(delimeter1 + " " + delimeter1.Trim().Length + " " + delimeter2 + " " + delimeter2.Trim().Length);
        Console.WriteLine(str.IndexOf(delimeter1) + " " + delimeter1.Trim().Length + " " + str.IndexOf(delimeter2) + " " + delimeter2.Trim().Length);
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
    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}