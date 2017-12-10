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

            };


            //Button button1 = FindViewById<Button>(Resource.Id.button1);
            //button1.Click += (sender, e) =>
            //{
            //    CreateEditText();
            //};

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

            for (int index = 0; index < ((ViewGroup)TestLayout).ChildCount; ++index)
            {
                View nextChild = TestLayout.GetChildAt(index);
            }


            ScrollView SV = FindViewById<ScrollView>(Resource.Id.ScrollView);
            scrollToView(SV, ET);                   // Scrollt ganz nach oben????

            //ET.Parent.Parent.Parent.RequestChildFocus(ET, ET);
          
        }

        /**
         * Used to scroll to the given view.
         *
         * @param scrollViewParent Parent ScrollView
         * @param view View to which we need to scroll.
         */
        private void scrollToView(ScrollView scrollViewParent, View view)
        {
            // Get deepChild Offset
            Point childOffset = new Point();
            getDeepChildOffset(scrollViewParent, view.Parent, view, childOffset);
            // Scroll to child.
            scrollViewParent.SmoothScrollTo(0, childOffset.Y);
        }

        /**
         * Used to get deep child offset.
         * <p/>
         * 1. We need to scroll to child in scrollview, but the child may not the direct child to scrollview.
         * 2. So to get correct child position to scroll, we need to iterate through all of its parent views till the main parent.
         *
         * @param mainParent        Main Top parent.
         * @param parent            Parent.
         * @param child             Child.
         * @param accumulatedOffset Accumalated Offset.
         */
        private void getDeepChildOffset(ViewGroup mainParent, IViewParent parent, View child, Point accumulatedOffset)
        {
            ViewGroup parentGroup = (ViewGroup)parent;
            accumulatedOffset.X += child.Left;
            accumulatedOffset.Y += child.Top;
            if (parentGroup.Equals(mainParent))
            {
                return;
            }
            getDeepChildOffset(mainParent, parentGroup.Parent, parentGroup, accumulatedOffset);
        }

    }
}



//LinearLayout TestLayout = (LinearLayout)FindViewById(Resource.Id.LayoutEditText);

//            for (int index = 0; index<((ViewGroup) TestLayout).ChildCount; ++index)
//            {
//                View nextChild = TestLayout.GetChildAt(index);
//            }













  




            
            











