using AtmSimulator.ViewModels;

namespace AtmSimulator.Views;

public partial class MainView : ContentPage
{
    private readonly AppSettings.AppSettings _appSettings;
    public MainView(MainViewModel mainViewModel, AppSettings.AppSettings appSettings)
    {
        _appSettings = appSettings;
        BindingContext = mainViewModel;
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (!_appSettings.IsFirstRun()) return;

        try
        {
            await Shell.Current.GoToAsync($"{nameof(AdminView)}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}