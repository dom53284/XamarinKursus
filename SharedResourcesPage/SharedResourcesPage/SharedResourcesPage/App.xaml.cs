using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SharedResourcesPage
{
    static class AppConstants
    {
        public static readonly Thickness PagePadding =
            new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

        public static readonly Font TitleFont =
            Font.SystemFontOfSize(Device.OnPlatform(35, 40, 50), FontAttributes.Bold);

        public static readonly Color BackgroundColor =
            Device.OnPlatform(Color.White, Color.Black, Color.Black);

        public static readonly Color ForegroundColor =
            Device.OnPlatform(Color.Black, Color.White, Color.White);
    }


    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new SharedResourcesPage.MainPage();
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
