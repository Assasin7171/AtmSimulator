using AtmSimulator.AppSettings;
using AtmSimulator.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AtmSimulator.ViewModels;

public partial class AdminViewModel : ObservableObject
{
    private readonly AppSettings.AppSettings _appSettings;
    [ObservableProperty]
    private MainStore _mainStore;
    [ObservableProperty]
    private decimal _depositLimit, _withdrawalLimit = Decimal.Zero;
    public AsyncRelayCommand SaveSettingsCommand { get; }

    public AdminViewModel(AppSettings.AppSettings appSettings, MainStore mainStore)
    {
        _appSettings = appSettings;
        _mainStore = mainStore;

        SaveSettingsCommand = new AsyncRelayCommand(SaveSettings);
    }


    private async Task SaveSettings()
    {
        if (_appSettings.IsFirstRun())
        {
            _appSettings.SavePreferences(_appSettings.IsFirstRunKey,false);
        }

        //await Shell.Current.GoToAsync(nameof(MainView));
    }
}