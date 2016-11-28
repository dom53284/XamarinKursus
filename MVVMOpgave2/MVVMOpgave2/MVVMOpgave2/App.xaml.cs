using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVMOpgave2.ViewModel;
using MVVMOpgave2.Pages;
using Xamarin.Forms;

namespace MVVMOpgave2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var viewModel = new LoginViewModel();

            MainPage = new LoginPage(viewModel);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
