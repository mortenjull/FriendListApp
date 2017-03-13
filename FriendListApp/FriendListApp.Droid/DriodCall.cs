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
using FriendListApp.Backend;
using FriendListApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(DriodCall))]

namespace FriendListApp.Droid
{

    class DriodCall : ICall
    {
        public void CallNumber(string number)
        {
            var activity = (Activity)Forms.Context;
            var uri = Android.Net.Uri.Parse("tel:" + number);
            var intent = new Intent(Intent.ActionCall, uri);
            activity.StartActivity(intent);
        }
    }
}