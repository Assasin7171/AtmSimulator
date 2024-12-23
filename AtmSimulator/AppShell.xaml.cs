using AtmSimulator.Views;

namespace AtmSimulator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainView), typeof(MainView));
        Routing.RegisterRoute(nameof(AdminView), typeof(AdminView));
        Routing.RegisterRoute(nameof(AdminLoginView), typeof(AdminLoginView));
    }
}