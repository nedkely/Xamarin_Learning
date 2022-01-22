using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin_Learning.Views;

namespace Xamarin_Learning.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            LoadPassword_Checked();
        }

        private async void OnLoginClicked(object obj)
        {
            SavePassword_Checked();
            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        bool _SavePassword;
        public bool SavePassword
        {
            get => _SavePassword;
            set
            {
                SetProperty(ref _SavePassword, value);
            }
        }

        string _Username;
        public string Username
        {
            get => _Username;
            set
            {
                SetProperty(ref _Username, value);
            }
        }

        string _Password;
        public string Password
        {
            get => _Password;
            set
            {
                SetProperty(ref _Password, value);
            }
        }

        void SavePassword_Checked()
        {
            Preferences.Set("Username", Username);
            Preferences.Set("Password", Password);
            Preferences.Set("Save_Password", SavePassword);

        }

        void LoadPassword_Checked()
        {
            SavePassword = Preferences.Get("Save_Password", false);
            if (SavePassword)
            {
                Username = Preferences.Get("Username", "");
                Password = Preferences.Get("Password", "");
            }
            else
            {
                Username = "";
                Password = "";
            }
        }
    }
}
