using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Something
{
    public class PageTwoDetailViewModel: BindableObject, INotifyPropertyChanged
    {

        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = "hello";

        public PageTwoDetailViewModel()
        {
        }

        public void UpdateUsername() {
            Username = "Button Was Clicked";
            OnPropertyChanged(nameof(Username));
        }

    }
}
