using System;
using System.Text.RegularExpressions;
static class LogLine
{
    public static string Message(string logLine)
    {
        const string pattern = @"\[\w+\]: ";
        logLine = Regex.Replace(logLine, pattern, String.Empty);
        logLine = logLine.Trim();
        return logLine;
    }

    public static string LogLevel(string logLine)
    {
        const string pattern = @"\[(\w+)\]: ";
        Match match = Regex.Match(logLine, pattern);
        return match.Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine);
        logLine = Message(logLine);
        return $"{logLine} ({logLevel})";
    }
}
