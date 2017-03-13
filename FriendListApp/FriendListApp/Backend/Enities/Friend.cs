using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendListApp.Backend.Enities
{
    public class Friend
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ImageSource Image { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FavoriteFood { get; set; }
    }
}
