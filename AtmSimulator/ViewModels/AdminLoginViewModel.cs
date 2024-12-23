using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmSimulator.Views;

namespace AtmSimulator.ViewModels
{
    public partial class AdminLoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _login, _password;

        public AsyncRelayCommand LoginInAsyncCommand { get; }

        public AdminLoginViewModel()
        {
            LoginInAsyncCommand = new AsyncRelayCommand(LoginIn);
        }
        private async Task LoginIn()
        {
            if (Login == "admin" && Password == "1234")
            {
                await Shell.Current.DisplayAlert("Welcome Admin", "Redirect to admin page", "OK");
                await Shell.Current.GoToAsync(nameof(AdminView));
            }
        }
    }
}
