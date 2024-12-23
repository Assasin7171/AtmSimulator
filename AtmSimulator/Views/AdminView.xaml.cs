using AtmSimulator.ViewModels;

namespace AtmSimulator.Views;

public partial class AdminView : ContentPage
{
    public AdminView(AdminViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}