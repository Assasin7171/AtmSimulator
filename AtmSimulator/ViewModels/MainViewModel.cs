using AtmSimulator.AppSettings;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AtmSimulator.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private MainStore _store;

    public MainViewModel(MainStore store)
    {
        _store = store;
    }
}