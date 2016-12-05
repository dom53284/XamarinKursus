﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IValueConverterOpgave.Pages;
using IValueConverterOpgave.ViewModel;

using Xamarin.Forms;

namespace IValueConverterOpgave
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.MainPage = new SliderPage(new SliderViewModel());

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