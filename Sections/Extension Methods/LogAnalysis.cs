using System;

public static class LogAnalysis
{
  // TODO: define the 'SubstringAfter()' extension method on the `string` type
  public static string SubstringAfter(this string str, string str1)
  {
    int startIndex = str.IndexOf(str1);
    return str.Substring(startIndex + str1.Length);
  }
  // TODO: define the 'SubstringBetween()' extension method on the `string` type
  public static string SubstringBetween(this string str, string str1, string str2)
  {
    int startIndex = str.IndexOf(str1);
    int endIndex = str.IndexOf(str2);
    string resultStr = "";
    for (int i = startIndex + str1.Length; i < endIndex; i++)
    {
      resultStr += str[i];
    }
    return resultStr;
  }
  // TODO: define the 'Message()' extension method on the `string` type
  public static string Message(this string str)
  {
    return str.SubstringAfter(": ");
  }
  // TODO: define the 'LogLevel()' extension method on the `string` type
  public static string LogLevel(this string str)
  {
    return str.SubstringBetween("[", "]");
  }
}