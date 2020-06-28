using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamF_CCSharpWT.Services;
using XamF_CCSharpWT.Views;

namespace XamF_CCSharpWT
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
