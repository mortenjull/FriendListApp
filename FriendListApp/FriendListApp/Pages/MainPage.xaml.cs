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
        
        private async void FriendList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Friend friend = FriendList.SelectedItem as Friend;
            await Navigation.PushAsync(new FriendPage(friend));
        }
    }
}
