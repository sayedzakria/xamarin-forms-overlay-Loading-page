using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace overlayexample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Popupage page1 = new Popupage();
            await PopupNavigation.Instance.PushAsync(page1);
            await Task.Delay(5000);
            MessagingCenter.Send<MainPage>(this, "Hi");
        }
    }
}
