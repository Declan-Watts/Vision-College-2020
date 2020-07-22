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
using SQLite;
using System.IO;
using Android.Content.Res;

namespace TodoList
{
    public static class DatabaseManager
    {
        public static SQLiteConnection conn;
        public static string databasePath;
        public static string databaseName;

        static DatabaseManager()
        {//Set the DB connection string
            databaseName = "TodoDB.sqlite";
            databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, databaseName); //assets folder

            if (databasePath != null)
            {
                conn = new SQLiteConnection(databasePath);
            }
            else
            {
                //Create a new instance of the DB
                conn.CreateTable<todo>();
            }

        }

        public static List<todo> ViewAll()
        {
            try
            {
                //return conn.Query<todo>("select * from todo");
                conn.Get<todo>(1);
                return conn.Table<todo>().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                //making some fake items to stop the system from crashing when the DB doesn't connect
                List<todo> fakeitem = new List<todo>();
                //make a single item
                todo item = new todo
                {
                    Id = 100,
                    date = DateTime.Now.Date,
                    details = "There are no items",
                    title = "No Items"
                };

                fakeitem.AddRange(new[] { item }); //add it to the fake item list
                return fakeitem;
            }
        }

        public static void AddItem(string t, string d)
        {
            try
            {
                var addThis = new todo() { title = t, details = d, date = DateTime.Now.Date };
                conn.Insert(addThis);
            }
            catch (Exception e)
            {
                Console.WriteLine("Add Error:" + e.Message);
            }
        }

        public static void EditItem(string t, string d, int id)
        {
            try
            {
                // http://stackoverflow.com/questions/14007891/how-are-sqlite-records-updated 
                var EditThis = new todo() { title = t, details = d, Id = id };
                conn.Update(EditThis);
                //or this
                //db.Execute("UPDATE todoList Set Title = ?, Details =, WHERE ID = ?", title, details, listid);
            }
            catch (Exception e)
            {
                Console.WriteLine("Update Error:" + e.Message);
            }
        }

        public static void DeleteItem(int listid)
        {
            // https://developer.xamarin.com/guides/cross-platform/application_fundamentals/data/part_3_using_sqlite_orm/ 
            try
            {
                conn.Delete<todo>(listid);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Error:" + ex.Message);
            }
        }

        public static void CopyTheDB()
        {
            // Check if your DB has already been extracted. If the file does not exist move it. 
            //WARNING!!!!!!!!!!! If your DB changes from the first time you install it, ie: you change the tables, and you get errors then comment out the if wrapper so that it is FORCED TO UPDATE. 
            //Otherwise you spend hours staring at code that should run OK but the db, that you can’t see inside of on your phone, is diffferent from the db you are coding to. Sigh	  
            if (!File.Exists(DatabaseManager.databasePath))
            {
                AssetManager Assets = Android.App.Application.Context.Assets;
                using (BinaryReader br = new BinaryReader(Assets.Open(DatabaseManager.databaseName)))
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(DatabaseManager.databasePath, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int len = 0;
                        while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, len);
                        }
                    }
                }
            }
        }
    }

}