﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamPSR2020
{
    [Activity(Label = "Im praying for you", Theme = "@style/AppTheme", MainLauncher = true)]
    public class SplashActivity : Activity
    {

        Button btnNext;
        TextView txtName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_main);

            Init();

        }

        void Init()
        {
            txtName = FindViewById<TextView>(Resource.Id.TVEnterName);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);

            btnNext.Click += btnNext_Click;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(txtName.Text == string.Empty))
            {
                Toast.MakeText(this, "You forgot your name idiot", ToastLength.Long).Show();
                return;
            }
            else
            {
                var mainActivity = new Intent(this, typeof(MainActivity));
                mainActivity.PutExtra("Name", txtName.Text);
                StartActivity(mainActivity);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}