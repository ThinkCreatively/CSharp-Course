using System;

static class LogLine
{
  public static string Message(string logLine)
  {
    int startIndex = logLine.IndexOf(":");
    string resultStr = logLine.Substring(startIndex + 1, logLine.Length - startIndex - 1).Trim();

    return resultStr;
  }

  public static string LogLevel(string logLine)
  {
    int startIndex = logLine.IndexOf("[");
    int endIndex = logLine.LastIndexOf("]");
    string resultStr = logLine.Substring(startIndex+1, endIndex-1).ToLower();

    return resultStr;
  }

  public static string Reformat(string logLine)
  {
    return $"{Message(logLine)} ({LogLevel(logLine)})";
  }
}
