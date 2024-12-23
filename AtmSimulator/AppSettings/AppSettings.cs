namespace AtmSimulator.AppSettings;

public class AppSettings
{
    public string IsFirstRunKey = "IsFirstRun";

    public AppSettings()
    {
    }

    public bool IsFirstRun()
    {
        var result = Preferences.Default.Get(IsFirstRunKey, true);

        return result;
    }

    public void SavePreferences(string name,bool booleanValue)
    {
        Preferences.Default.Set(name, booleanValue);
    }

    public void LoadPreferences()
    {

    }

    public void CheckPreferences(string name)
    {

    }



}