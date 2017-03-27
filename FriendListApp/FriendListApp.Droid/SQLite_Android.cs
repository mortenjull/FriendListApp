using System;
using System.IO;
using FriendListApp.Backend;
using FriendListApp.Droid;
using Xamarin.Forms;
using SQLite.Net;

[assembly: Dependency(typeof(SQLite_Android))]
namespace FriendListApp.Droid
{
    public class SQLite_Android: ISQL
    {
        public SQLite_Android()
        {
        }

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var fileName = "Friends.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }
    }
}