using System;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using AvaloniaDialogHostBugWithKeyboard.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaDialogHostBugWithKeyboard.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        public string _loginInput;

        [ObservableProperty]
        public string _passwordInput;

        [RelayCommand]
        private void Login()
        {
            Console.WriteLine("login");
        }

        [RelayCommand]
        private async Task OpenLoginViewAsync()
        {
            var messageViewControl = new LoginViewControl();
            await DialogHost.DialogHost.Show(messageViewControl, "MainDialogHost");
        }
    }
}
