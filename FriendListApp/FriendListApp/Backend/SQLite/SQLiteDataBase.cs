using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend.Enities;
using SQLite.Net;
using Xamarin.Forms;

namespace FriendListApp.Backend.SQLite
{
    public class SQLiteDataBase
    {
        private SQLiteConnection _connection;

        public SQLiteDataBase()
        {
            _connection = DependencyService.Get<ISQL>().GetConnection();
            _connection.CreateTable<SQLiteSetup>();
        }

        public IEnumerable<SQLiteSetup> GetFriends()
        {
            return (from f in _connection.Table<SQLiteSetup>()
                select f).ToList();
        }
        public SQLiteSetup GetFriend(int id)
        {
            return _connection.Table<SQLiteSetup>().FirstOrDefault(f => f.ID == id);
        }

        public void DeleteFriend(int id)
        {
            _connection.Delete<SQLiteSetup>(id);
        }

        public void AddFriend(Friend friend)
        {
            var newFriend = new SQLiteSetup
            {
                Image = friend.Image,
                Address = friend.Address,
                FavoriteFood = friend.FavoriteFood,
                PhoneNumber = friend.PhoneNumber,
                Location = friend.Location,
                Name = friend.Name
            };

            _connection.Insert(newFriend);
        }
    }
}
