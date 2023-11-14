using System;
using System.Collections.Generic;

public class ConfigurationManager
{
    private static ConfigurationManager instance;
    private Dictionary<string, string> settings;

    private ConfigurationManager()
    {
        settings = new Dictionary<string, string>();
    }

    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }

    public string GetSetting(string key)
    {
        if (settings.ContainsKey(key))
        {
            return settings[key];
        }
        return null;
    }

    public void SetSetting(string key, string value)
    {
        if (settings.ContainsKey(key))
        {
            settings[key] = value;
        }
        else
        {
            settings.Add(key, value);
        }
    }

    public void DisplaySettings()
    {
        foreach (var setting in settings)
        {
            Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }
}