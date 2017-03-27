﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend;
using FriendListApp.Backend.Enities;
using FriendListApp.Backend.SQLite;
using Xamarin.Forms;

namespace FriendListApp.Pages
{
    public partial class FriendCreatePage : ContentPage
    {
        private FriendManager _friendManager;
        private MainPage parent;

        public FriendCreatePage(SQLiteDataBase database, MainPage parent)
        {
            this._friendManager = new FriendManager(database);
            this.parent = parent;
            InitializeComponent();
        }

        private async void Button_Save(object sender, EventArgs e)
        {
            Friend friend = new Friend()
            {
                Address = this.Address.ToString(),
                FavoriteFood = this.Favorite.ToString(),
                Image = "https://blog.xamarin.com/wp-content/uploads/2014/12/CircleImages-1024x611.png",
                Location = this.Location.ToString(),
                Name = this.Name.ToString(),
                PhoneNumber = this.PhoneNumber.ToString()
            };

            _friendManager.AddFriend(friend);

            await Navigation.PopAsync();

            parent.Refresh();
        }
    }
}