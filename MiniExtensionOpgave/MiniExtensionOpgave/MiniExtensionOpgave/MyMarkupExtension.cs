using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace MiniExtensionOpgave
{
    class MyMarkupExtension : IMarkupExtension
    {
        public int A { get; set; }
        public int B { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return "Hvor mange æbler vil jeg have? " + (A + B);
        }
    }
}
