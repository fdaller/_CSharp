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
using Android.Support.V7.App;
using Com.Cepheuen.Elegantnumberbutton.View;

namespace App1
{
    [Activity(Label = "test_activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class test_activity : AppCompatActivity, ElegantNumberButton.IOnValueChangeListener
    {
        public void OnValueChange(ElegantNumberButton view, int oldValue, int newValue)
        {
            Toast.MakeText(this, $"Old Value : {oldValue} - New Value : {newValue}", ToastLength.Short).Show();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.test_view);
            //var btnShow = FindViewById<ElegantNumberButton>(Resource.Id.btnNumber);

            //btnShow.Click += delegate
            //{
            //    Toast.MakeText(this, "Number : " + btnShow.Number, ToastLength.Short).Show();
            //};
            //btnShow.SetOnValueChangeListener(this);
        }
    }
}