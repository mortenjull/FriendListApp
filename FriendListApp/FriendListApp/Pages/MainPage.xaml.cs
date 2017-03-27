using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend;
using FriendListApp.Backend.Enities;
using FriendListApp.Backend.SQLite;
using FriendListApp.Pages;
using Xamarin.Forms;

namespace FriendListApp
{
    public partial class MainPage : ContentPage
    {
        private FriendManager _friendManager;
        private SQLiteDataBase _database;
        private IEnumerable<Friend> friends;
 
        public MainPage(SQLiteDataBase dataBase)
        {
            _friendManager = new FriendManager(dataBase);
            friends = _friendManager.GetFriends();

            _database = dataBase;

            InitializeComponent();

            this.FriendList.ItemsSource = friends;
        }

        public void Refresh()
        {
            this.FriendList.ItemsSource = null;
            this.FriendList.ItemsSource = _friendManager.GetFriends();
        }
        
        private async void FriendList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Friend friend = FriendList.SelectedItem as Friend;
            await Navigation.PushAsync(new FriendPage(friend));
        }

        private async void FriendAdd_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FriendCreatePage(this._database, this));            
        }
    }
}
