using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string after) => str[(str.IndexOf(after)+after.Length)..];

    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static string SubstringBetween(this string str, string first, string second) => str[(str.IndexOf(first)+first.Length)..str.IndexOf(second)];
    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string Message(this string str) => str.SubstringAfter(": ");
    // TODO: define the 'Message()' extension method on the `string` type

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
    // TODO: define the 'LogLevel()' extension method on the `string` type
}