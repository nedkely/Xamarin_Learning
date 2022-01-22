using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Learning.Services;
using Xamarin_Learning.Views;

namespace Xamarin_Learning
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            /// xamarin learning - farhad ganji
            /// 
            /// 
            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
