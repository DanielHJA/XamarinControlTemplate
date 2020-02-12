using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Something
{
    public partial class PageTwoDetail : ContentPage
    {

        PageTwoDetailViewModel viewModel = new PageTwoDetailViewModel();

        public PageTwoDetail()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            viewModel.UpdateUsername();
        }

    }
}
