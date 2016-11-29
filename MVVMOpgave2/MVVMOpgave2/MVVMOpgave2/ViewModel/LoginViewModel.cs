using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMOpgave2.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string versionText = "Ver. 1.0.0";
        private string statusText = "indtast telefonnummer";
        private bool entryCodeOk = false;
        private string login;

        public event PropertyChangedEventHandler PropertyChanged;

        public string VersionText
        {
            get
            {
                return versionText;
            }

            set
            {
                if (versionText != value)
                {
                    versionText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string StatusText
        {
            get
            {
                return statusText;
            }

            set
            {
                if (statusText != value)
                {
                    statusText = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool EntryCodeIsOk
        {
            get
            {
                return entryCodeOk;
            }

            set
            {
                if (entryCodeOk != value)
                {
                    entryCodeOk = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (Login != value)
                {
                    login = value;
                    OnPropertyChanged();
                    EntryCodeIsOk = (Login.Length == 8);
                    if (EntryCodeIsOk)
                    {
                        StatusText = "klar til at logge ind";
                    }
                    else
                    {
                        StatusText = "indtast telefonnummer";
                    }
                }
            }
        }

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }






    }
}
