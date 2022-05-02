using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kodutoo
{
    public partial class MainPage : ContentPage
    {       

        public MainPage()
        {
            StackLayout st = new StackLayout();

            Button Maa_btn = new Button()
            {
                Text = "Maa",
                BackgroundColor = Color.LightGreen,
            };
            
            st.Children.Add(Maa_btn);
            
            
            Maa_btn.Clicked += Maa_btn_Clicked;
            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
        }

        private async void Maa_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maa_Page());
        }
    }
}
