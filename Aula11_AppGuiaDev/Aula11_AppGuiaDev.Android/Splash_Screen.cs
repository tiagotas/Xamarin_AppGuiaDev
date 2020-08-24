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

namespace Aula11_AppGuiaDev.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash",
              MainLauncher = true,
              NoHistory = true, 
              Label = "AppGuiaDev")]
    public class Splash_Screen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //StartActivity(typeof(MainActivity));

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here
        }
    }
}