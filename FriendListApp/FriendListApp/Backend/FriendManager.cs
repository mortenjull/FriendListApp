using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendListApp.Backend.Enities;
using Xamarin.Forms;

namespace FriendListApp.Backend
{
    class FriendManager
    {
        private List<Friend> friends;

        public FriendManager()
        {
            friends = new List<Friend>()
            {
                new Friend()
                {
                    Name = "Test",
                    Location = "Test",
                    Image =
                        ImageSource.FromUri(
                            new Uri("https://blog.xamarin.com/wp-content/uploads/2014/12/CircleImages-1024x611.png"))
                },
                new Friend()
                {
                    Name = "Test2",
                    Location = "Test2",
                    Image =
                        ImageSource.FromUri(
                            new Uri("https://blog.xamarin.com/wp-content/uploads/2014/12/CircleImages-1024x611.png"))
                }
            };
            
        }

        public List<Friend> GetFriends()
        {
            return friends;
        }
    }
}
