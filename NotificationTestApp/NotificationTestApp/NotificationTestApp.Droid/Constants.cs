using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NotificationTestApp.Droid
{
    class Constants
    {
        public const string SenderID = "917497602723"; // Google API Project Number
        public const string ListenConnectionString = "Endpoint=sb://franksnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=AruwyHLAClUOxEq+UzpwJgqHrJX+pb6whdX5wTC7VLs=";
        public const string NotificationHubName = "franksnotificationhub ";
    }
}