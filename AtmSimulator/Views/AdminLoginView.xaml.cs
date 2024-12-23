using AtmSimulator.ViewModels;

namespace AtmSimulator.Views;

public partial class AdminLoginView : ContentPage
{
    public AdminLoginView(AdminLoginViewModel viewModel)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }
}