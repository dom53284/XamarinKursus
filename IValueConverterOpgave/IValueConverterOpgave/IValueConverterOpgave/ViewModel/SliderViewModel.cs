using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IValueConverterOpgave.ViewModel
{
    public class SliderViewModel : INotifyPropertyChanged
    {
        private double myValue = 1;

        public event PropertyChangedEventHandler PropertyChanged;

        public double MyValue
        {
            get
            {
                return myValue;
            }

            set
            {
                if (myValue != value)
                {
                    myValue = value;
                    OnPropertyChanged();
                }
            }
        }

        //public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
