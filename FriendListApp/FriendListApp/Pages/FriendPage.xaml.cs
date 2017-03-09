using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend.Enities;
using Xamarin.Forms;

namespace FriendListApp.Pages
{
    public partial class FriendPage : ContentPage
    {      
        public FriendPage(Friend friend)
        {
            InitializeComponent();

            this.BindingContext = friend;
        }

        private void Call_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SMS_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
