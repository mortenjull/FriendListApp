using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend;
using FriendListApp.Backend.Enities;
using FriendListApp.Pages;
using Xamarin.Forms;

namespace FriendListApp
{
    public partial class MainPage : ContentPage
    {
        private FriendManager _friendManager;

        public MainPage()
        {
            _friendManager = new FriendManager();

            InitializeComponent();

            this.FriendList.ItemsSource = _friendManager.GetFriends();
        }

        private async void FriendDetails_OnClicked(object sender, EventArgs e)
        {
            Friend friend = FriendList.SelectedItem as Friend;
            await Navigation.PushAsync(new FriendPage(friend));           
        }
    }
}
