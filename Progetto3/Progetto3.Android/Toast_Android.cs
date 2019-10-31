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
using Progetto3.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Toast_Android))]
namespace Progetto3.Droid
{
    class Toast_Android: Toast
    {
        public void Show(string message)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}