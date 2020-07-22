using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Linq.Expressions;
using System.Collections.Generic;
using System;
using Android.Content;

namespace TodoList
{
    [Activity(Label = "Todo List", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected ListView ListToDoList;
        protected Button btnAdd;
        protected List<todo> myList = new List<todo>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            myList.AddRange(DatabaseManager.ViewAll());

            ListToDoList = FindViewById<ListView>(Resource.Id.listView1);
            btnAdd = FindViewById<Button>(Resource.Id.btnAddTodo);
            ListToDoList.Adapter = new DataAdapter(this, myList);
            ListToDoList.ItemClick += onListToDoList_Click;
            btnAdd.Click += onbtnAdd_Click;
        }

        private void onbtnAdd_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AddItem));
        }

        private void onListToDoList_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            var position = e.Position; //get the number of the list item you clicked on
            var todoItem = myList[position]; //get the data from the list at the position clicked

            var editItem = new Intent(this, typeof(EditItem));
            editItem.PutExtra("Title", todoItem.title);
            editItem.PutExtra("Details", todoItem.details);
            editItem.PutExtra("ID", todoItem.Id);

            StartActivity(editItem);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}