using System;
class Program
{
    static void Main()
    {
        var configManager = ConfigurationManager.Instance;

        while (true)
        {
            Console.WriteLine("1. Display Settings");
            Console.WriteLine("2. Change Setting");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    configManager.DisplaySettings();
                    break;

                case "2":
                    Console.Write("Enter key: ");
                    string key = Console.ReadLine();
                    Console.Write("Enter value: ");
                    string value = Console.ReadLine();
                    configManager.SetSetting(key, value);
                    Console.WriteLine("Setting changed.");
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}