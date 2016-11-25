using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Xamarin.Forms;

namespace OneShotDateTimePage
{

    class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public ClockViewModel()
        {
            this.MyDateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.MyDateTime = DateTime.Now;
                return true;
            });
        }

        public DateTime MyDateTime
        {
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
                            new PropertyChangedEventArgs(nameof(MyDateTime)));
                    }
                }
            }
            get
            {
                return dateTime;
            }
        }
    }


    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OneShotDateTimePage.MainPage();
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
