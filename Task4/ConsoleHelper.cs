using System;

public static class ConsoleHelper
{
    public static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}