using CommunityToolkit.Mvvm.ComponentModel;

namespace AtmSimulator.AppSettings;

public partial class MainStore : ObservableObject
{
    [ObservableProperty]
    private string _atmNetworkName;

    public MainStore()
    {

    }

}