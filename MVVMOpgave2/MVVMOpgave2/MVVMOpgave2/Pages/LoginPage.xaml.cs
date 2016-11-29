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
            InitializeComponent();

            this.loginViewModel = loginViewModel;

            BindingContext = this.loginViewModel;

            // Binding method #3. Foregår i LoginPage.xaml
            //versionTextLabel.SetBinding<LoginViewModel>(Label.TextProperty, vm => vm.VersionText, BindingMode.OneWay);

            // Binding method #1. Unsafe.
            //statusTextLabel.SetBinding<LoginViewModel>(Label.TextProperty, vm => vm.StatusText, BindingMode.OneWay);
            statusTextLabel.SetBinding(Label.TextProperty, "StatusText", BindingMode.OneWay);


            // Binding method #2. using lambde and safetype
            loginEntry.SetBinding<LoginViewModel>(Entry.TextProperty, vm => vm.Login, BindingMode.TwoWay);
            loginButton.SetBinding<LoginViewModel>(Button.IsEnabledProperty, vm => vm.EntryCodeIsOk, BindingMode.OneWay);


            // Eventcall
            loginButton.Clicked += LoginButtonClicked;

        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            loginEntry.Text = "";
        }
    }
}
