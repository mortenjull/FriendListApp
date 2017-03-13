using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend;
using FriendListApp.Backend.Enities;
using Xamarin.Forms;
using Plugin.Media;
using Plugin.Media.Abstractions;

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
            Friend friend = this.BindingContext as Friend;
            DependencyService.Get<ICall>().CallNumber(friend.PhoneNumber);
        }

        private void SMS_OnClicked(object sender, EventArgs e)
        {
            
        }

        private async void TakePicture(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await
                    DisplayAlert("No Camera Support:", "This divice is missing a camara or is not supporting pictures", "Ok");
                return;
            }
            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                Name = "test.jpg"
            });
            if (file == null)            
                return;
            ImageSouce.Text = ImageSource.FromStream(() => file.GetStream()).ToString();
            CircleImage.Source = ImageSource.FromStream(() => file.GetStream());
        }
    }
}
