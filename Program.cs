using System;
using static System.Console;
namespace SingletonPattern
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      var fromManager = Singleton.SingleInstance;
      ForegroundColor = ConsoleColor.Green;
      fromManager.LogMessage("request from Manager");
      ForegroundColor = ConsoleColor.Blue;
      var fromEmployee = Singleton.SingleInstance;
      fromEmployee.LogMessage("request from Service Worker");

      ReadLine();
    }
  }
}
