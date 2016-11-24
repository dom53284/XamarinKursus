using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamlSamples
{
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();

            valueLabel

        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Clicked!",
                "The button labeled '" + (sender as Button).Text + "' has beed clicked",
                "OK");
        }

        //private void SliderValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    valueLabel.Text = e.NewValue.ToString("F3");
        //}
    }
}
