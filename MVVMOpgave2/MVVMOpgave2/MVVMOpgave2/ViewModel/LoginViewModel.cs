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
        private string versionText = "1.000";
        private string statusText = "indtast telefonnummer";
        private bool loginOk = false;
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

        public bool LoginOk
        {
            get
            {
                return loginOk;
            }

            set
            {
                if (loginOk != value)
                {
                    loginOk = value;
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

                    if (Login.Length == 8)
                    {
                        StatusText = "klar til at logge ind";
                        LoginOk = true;
                    }
                    else
                    {
                        StatusText = "indtast telefonnummer";
                        LoginOk = false;
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
