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
        private LoginPage loginPage;

        public LoginPage(LoginViewModel loginViewModel)
        {
            this.loginPage = loginPage;


            InitializeComponent();
        }
    }
}
