using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace LoginApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Set your main view here
            SetContentView(Resource.Layout.main);
            var signinBtn = FindViewById<Button>(Resource.Id.signInbutton1);
            signinBtn.Click += delegate
            {
                StartActivity(typeof(signInActivity1));
            };
          //  @android: color / background_light
            var signUpbtn = FindViewById<Button>(Resource.Id.SighUpbutton1);
            signUpbtn.Click += delegate
            {
                StartActivity(typeof(signUpActivity1));
            };
        }
    }
}

