using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PagesAppOpgave
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

        }

        private async void PopPage2(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
