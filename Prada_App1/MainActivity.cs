using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Prada_App1
{
    [Activity(Label = "Prada_App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ImageButton button1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            button1.Click += OnimageButton1Clicked;
            ImageButton button2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            button2.Click += OnimageButton2Clicked;
            ImageButton button3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            button3.Click += OnimageButton3Clicked;
            ImageButton button4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
            button4.Click += OnimageButton4Clicked;
            ImageButton button5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
            button5.Click += OnimageButton5Clicked;
            ImageButton button6 = FindViewById<ImageButton>(Resource.Id.imageButton6);
            button6.Click += OnimageButton6Clicked;
            ImageButton button7 = FindViewById<ImageButton>(Resource.Id.imageButton7);
            button7.Click += OnimageButton7Clicked;
            ImageButton button8 = FindViewById<ImageButton>(Resource.Id.imageButton8);
            button8.Click += OnimageButton8Clicked;
            ImageButton button9 = FindViewById<ImageButton>(Resource.Id.imageButton9);
            button9.Click += OnimageButton9Clicked;
            ImageButton button10 = FindViewById<ImageButton>(Resource.Id.imageButton10);
            button10.Click += OnimageButton10Clicked;
            ImageButton button11 = FindViewById<ImageButton>(Resource.Id.imageButton11);
            button11.Click += OnimageButton11Clicked;
            ImageButton button12 = FindViewById<ImageButton>(Resource.Id.imageButton12);
            button12.Click += OnimageButton12Clicked;
            ImageButton button13 = FindViewById<ImageButton>(Resource.Id.imageButton13);
            button13.Click += OnimageButton13Clicked;
        }
        void OnimageButton1Clicked(object sender, EventArgs e)
        {
            setMessage("prada");
        }
        void OnimageButton2Clicked(object sender, EventArgs e)
        {
            setMessage("prada");
        }
        void OnimageButton3Clicked(object sender, EventArgs e)
        {
            setMessage("prada");
        }
        void OnimageButton4Clicked(object sender, EventArgs e)
        {
            setMessage("prada");
        }
        void OnimageButton5Clicked(object sender, EventArgs e)
        {
            setMessage("prada");
        }
        void OnimageButton6Clicked(object sender, EventArgs e)
        {
            setMessage("prada");
        }
        void OnimageButton7Clicked(object sender, EventArgs e)
        {
            setMessage("Power");
        }
        void OnimageButton8Clicked(object sender, EventArgs e)
        {
            setMessage("Setting");
        }
        void OnimageButton9Clicked(object sender, EventArgs e)
        {
            setMessage("Multi_Pad");
        }
        void OnimageButton10Clicked(object sender, EventArgs e)
        {
            setMessage("R/L_Pad");
        }
        void OnimageButton11Clicked(object sender, EventArgs e)
        {
            setMessage("Foot_Pad");
        }
        void OnimageButton12Clicked(object sender, EventArgs e)
        {
            setMessage("Rect_Pad1");
        }
        void OnimageButton13Clicked(object sender, EventArgs e)
        {
            setMessage("Abdomen_Pad1");
        }

        public void setMessage(string strMsg)
        {
            Toast message = Toast.MakeText(this, strMsg, ToastLength.Short);
            message.Show();
        }
    }
}

