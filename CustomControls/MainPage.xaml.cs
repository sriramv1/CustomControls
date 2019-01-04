using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControls.Views;
using Xamarin.Forms;

namespace CustomControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Sections_Clicked(object sender, System.EventArgs e)
        {
            try
            {
               await Navigation.PushAsync(new SectionsPage(), false);
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }

        }
    }
}
