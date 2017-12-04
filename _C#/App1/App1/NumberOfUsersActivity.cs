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

namespace App1
{
    [Activity(Label = "NumberOfUsersActivity",Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class NumberOfUsersActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NumberOfUsersView);
            Button Button_NOU_Continue = FindViewById<Button>(Resource.Id.Button_NOU_Continue);

            Button_NOU_Continue.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(test_activity));
                StartActivity(intent);
            };
        }
    }
}