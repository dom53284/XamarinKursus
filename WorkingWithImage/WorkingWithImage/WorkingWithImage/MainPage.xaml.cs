using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;

namespace WorkingWithImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var beachImage = new Image { Aspect = Aspect.AspectFit };
            //beachImage.Source = ImageSource.FromFile("WaterFront.jpg");
            beachImage.Source =  Device.OnPlatform(
                iOS: ImageSource.FromFile("Images/WaterFront.jpg"),
                Android: ImageSource.FromFile("WaterFront.jpg"),
                WinPhone: ImageSource.FromFile("Images/WaterFront.png"));
            Content = beachImage;


            var assembly = typeof(EmbeddedImages).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }

        }
    }
}
