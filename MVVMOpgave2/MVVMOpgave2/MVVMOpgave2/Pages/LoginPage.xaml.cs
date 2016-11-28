using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMOpgave2.ViewModel;
using Xamarin.Forms;

namespace MVVMOpgave2.Pages
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel loginViewModel;

        public LoginPage(LoginViewModel loginViewModel)
        {
            this.loginViewModel = loginViewModel;

            BindingContext = this.loginViewModel;

            InitializeComponent();


            versionTextLabel.SetBinding<LoginViewModel>(Label.TextProperty, vm => vm.VersionText, BindingMode.OneWay);

            statusTextLabel.SetBinding<LoginViewModel>(Label.TextProperty, vm => vm.StatusText, BindingMode.OneWay);

            loginEntry.SetBinding<LoginViewModel>(Entry.TextProperty, vm => vm.Login, BindingMode.OneWayToSource);

            loginButton.SetBinding<LoginViewModel>(Button.IsEnabledProperty, vm => vm.LoginOk, BindingMode.OneWay);

        }
    }
}
