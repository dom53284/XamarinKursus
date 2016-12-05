using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IValueConverterOpgave.ViewModel;
using IValueConverterOpgave.Pages;

using Xamarin.Forms;

namespace IValueConverterOpgave.Pages
{
    public partial class SliderPage : ContentPage
    {
        private SliderViewModel sliderViewModel;

        private SliderValueConverter sliderValueConverter = new SliderValueConverter();
        
        public SliderPage(SliderViewModel sliderViewModel)
        {
            InitializeComponent();

            this.sliderViewModel = sliderViewModel;

            BindingContext = this.sliderViewModel;

            slider1.SetBinding<SliderViewModel>(Slider.ValueProperty,
                vm => vm.MyValue, BindingMode.TwoWay, sliderValueConverter);

            slider2.SetBinding<SliderViewModel>(Slider.ValueProperty,
                vm => vm.MyValue, BindingMode.TwoWay);


        }
    }
}
