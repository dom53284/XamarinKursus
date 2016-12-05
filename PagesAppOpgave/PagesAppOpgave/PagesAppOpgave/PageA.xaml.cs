using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PagesAppOpgave
{
    public partial class PageA : ContentPage
    {
        public PageA()
        {
            InitializeComponent();
        }

        private async void PushPageB(object sender, EventArgs e)
        {
            var pageB = new PageB();
            await Navigation.PushAsync(pageB);
            //we could as well write like this
            //await Navigation.PushAsync(new Page2());
        }

    }
}
