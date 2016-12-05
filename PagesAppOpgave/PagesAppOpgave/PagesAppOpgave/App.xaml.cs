using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PagesAppOpgave
{
    public partial class App : Application
    {
        private TabbedPage tabPage = new TabbedPage();
        private NavigationPage navChar = new NavigationPage();
        private NavigationPage navNum = new NavigationPage();

        public App()
        {
            InitializeComponent();
            MainPage = tabPage;
            navChar.Title = "Char";
            navNum.Title = "Num";
            tabPage.Children.Add(navChar);
            tabPage.Children.Add(navNum);

        }

        // Note that OnStart was modified to be async
        protected override async void OnStart()
        {
            var page1 = new Page1();
            var pageA = new PageA();
            await navChar.PushAsync(pageA);
            await navNum.PushAsync(page1);
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
