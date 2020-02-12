using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Something
{
    public partial class PageTwo : ContentPage, INotifyPropertyChanged
    {

        public Command Command
        {
            get
            {
                return new Command((Param) => {
                    System.Console.WriteLine(Param);
                });
            }

            /*
            get
            {
                return new Command(async (Param) => {
                    await *Some async method*
                });
            }
             */
        }

        public PageTwo()
        {
            BindingContext = this;
            InitializeComponent();
        }

        async void PrimaryToolBarButtonTapped(object sender, EventArgs e) {
            var obj = ((ToolbarItem)sender);
            System.Console.WriteLine(obj.CommandParameter);
            PageTwoDetail page = new PageTwoDetail();
            await Navigation.PushAsync(page);

        }

    }
}
