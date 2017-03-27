using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using Xamarin.Forms;

namespace FriendListApp.Backend.SQLite
{
    public class SQLiteSetup
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FavoriteFood { get; set; }

        public SQLiteSetup()
        {
            
        }
    }
}
