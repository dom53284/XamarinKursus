using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMOpgave2.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
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
                versionText = value;
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
                statusText = value;
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
                loginOk = value;
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
                login = value;
            }
        }


        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {

        }






    }
}
