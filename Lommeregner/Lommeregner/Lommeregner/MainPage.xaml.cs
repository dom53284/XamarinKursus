using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lommeregner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TopLabel.Text = "";
        }

        void OnNumberClick(object sender, EventArgs e)
        {
            TopLabel.Text = TopLabel.Text + (sender as Button).Text;
        }


    }
}
