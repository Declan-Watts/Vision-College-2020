using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TodoList
{
    [Activity(Label = "Edit an Item")]
    public class EditItem : Activity
    {
        //This comes in from main activity
        int ID;
        string Title;
        string Details;

        //This binds to layout
        protected TextView txtTitle;
        protected TextView txtDetails;
        protected Button btnEdit;
        protected Button btnDelete;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.EditItem);

            txtTitle = FindViewById<TextView>(Resource.Id.txtEditTitle);
            txtDetails = FindViewById<TextView>(Resource.Id.txtEditDescription);

            btnEdit = FindViewById<Button>(Resource.Id.btnEdit);
            btnDelete = FindViewById<Button>(Resource.Id.btnDelete);
            btnDelete.Click += onBtnDelete_Click;
            btnEdit.Click += onBtnEdit_Click;


            //getting data from the MainActivity
            ID = Intent.GetIntExtra("ID", 0);
            Title = Intent.GetStringExtra("Title");
            Details = Intent.GetStringExtra("Details");

            txtTitle.Text = Title;
            txtDetails.Text = Details;
        }

        private void onBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.EditItem(txtTitle.Text, txtDetails.Text, ID);
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

        private void onBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.DeleteItem(ID);
                Toast.MakeText(this, "Note was Deleted", ToastLength.Long).Show();
                this.Finish();
                StartActivity(typeof(MainActivity));
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, $"There was an Error - {ex}", ToastLength.Long).Show();
                Console.WriteLine($"There was an Error - {ex}");
            }
        }
    }
}