using Android.App;
using Android.Widget;
using Android.OS;
using static Android.App.ActionBar;
using Android.Graphics;
using System;
using Android.Views;
using Android.Text;
using Java.Lang;

namespace testapp
{
    [Activity(Label = "testapp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int n = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

        }

        protected override void OnStart()
        {
            base.OnStart();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ScrollView SV = FindViewById<ScrollView>(Resource.Id.ScrollView);
            for (int i = 0; i < 2; i++)                 // Mindestspielerzahl sind 2 Spieler
            {
                CreateEditText(n++);
            }
        }

        protected override void OnResume()
        {
            base.OnResume();
            this.Window.SetSoftInputMode(Android.Views.SoftInput.AdjustNothing);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += (sender, e) =>
            {
                CreateEditText(n++);
                ScrollView SV = FindViewById<ScrollView>(Resource.Id.ScrollView);
                //SV.FullScroll(FocusSearchDirection.Down);
                RunOnUiThread(() =>
                {
                    SV.Post(new Java.Lang.Runnable(ScrollHelper));
                });
            };


        }
        private void ScrollHelper()
        {
            ScrollView sv = (ScrollView)FindViewById(Resource.Id.ScrollView);
            sv.FullScroll(FocusSearchDirection.Down);
        }
        private void CreateEditText(int n)
        {
            EditText ET = new EditText(this);
            LinearLayout.LayoutParams testParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            //ET.Id = Resource.ID.edit_text_test;                             // ID wird aus ids.xml ausgelesen.
            //ET.Gravity = Android.Views.GravityFlags.CenterHorizontal;                   
            ET.SetTextColor(Color.DeepSkyBlue);
            testParams.SetMargins(20, 20, 20, 20);
            ET.SetPadding(20, 20, 20, 20);
            ET.SetTextSize(Android.Util.ComplexUnitType.Dip, 25);
            ET.SetText(n.ToString(), TextView.BufferType.Editable);
            //ET.SetText(Resource.String.app_name);
            testParams.Gravity = Android.Views.GravityFlags.CenterHorizontal;
            ET.LayoutParameters = testParams;
            ET.SetMaxLines(1);
            
            LinearLayout TestLayout = (LinearLayout)FindViewById(Resource.Id.LayoutEditText);

            TestLayout.AddView(ET);

        }
    }
}

