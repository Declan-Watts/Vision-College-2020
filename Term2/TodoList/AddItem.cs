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

namespace TodoList
{
    [Activity(Label = "Add an Item")]
    public class AddItem : Activity
    {

        protected Button btnAdd;
        protected EditText txtItemDescription;
        protected EditText txtItemTitle;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AddItem);

            txtItemDescription = FindViewById<EditText>(Resource.Id.txtItemDescription);
            txtItemTitle = FindViewById<EditText>(Resource.Id.txtItemTitle);

            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            btnAdd.Click += onBtnAdd_Click;


            ////getting data from the MainActivity
            //ID = Intent.GetIntExtra("ID", 0);
            //Title = Intent.GetStringExtra("Title");
            //Details = Intent.GetStringExtra("Details");
        }

        private void onBtnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtItemDescription.Text) && !String.IsNullOrEmpty(txtItemTitle.Text))
            {
                try
                {
                    DatabaseManager.AddItem(txtItemTitle.Text, txtItemDescription.Text);
                    Toast.MakeText(this, "Note was Edited", ToastLength.Long).Show();
                    this.Finish();
                    StartActivity(typeof(MainActivity));
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, $"There was an Error - {ex}", ToastLength.Long).Show();
                    Console.WriteLine($"There was an Error - {ex}");
                }
            }
            else
            {
                Toast.MakeText(this, $"Title and Description cannot be Empty", ToastLength.Long).Show();

            }

        }
    }
}