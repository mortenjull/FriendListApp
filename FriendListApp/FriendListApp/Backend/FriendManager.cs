﻿using System;
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
                    Name = "Morten Vismark",
                    Location = "IDK",
                    Image =
                        ImageSource.FromUri(
                            new Uri("https://blog.xamarin.com/wp-content/uploads/2014/12/CircleImages-1024x611.png")),
                    Address = "AbeKatteVej 12",
                    FavoriteFood = "Tissemand",
                    PhoneNumber = "12345678"
                },
                new Friend()
                {
                    Name = "Tim",
                    Location = "Secundary realm",
                    Image =
                        ImageSource.FromUri(
                            new Uri("https://blog.xamarin.com/wp-content/uploads/2014/12/CircleImages-1024x611.png")),
                    Address = "Wizard bullewand",
                    FavoriteFood = "saltede kiks og nullermænd",
                    PhoneNumber = "12345678"
                }
            };
            
        }

        public List<Friend> GetFriends()
        {
            return friends;
        }
    }
}
