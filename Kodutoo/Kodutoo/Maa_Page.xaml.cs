using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kodutoo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maa_Page : ContentPage
    {
        Button btn;
        Picker pik, pik2;
        StackLayout st;
        WebView webView;
     
        List<string> 
            lehed = new List<string>()
        {
            
                "https://triptoestonia.com/harjumaa/",
           
                "https://triptoestonia.com/ida-virumaa/",
            
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-vilyandimaa/",            
            
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-xijumaa/",
            
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-yarvamaa/",
            
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-lyaenemaa/",
            
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-lyaene-virumaa/",
           
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-pyarnumaa/",
         
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-pylvamaa/",
        
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-raplamaa/",
       
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-saaremaa/",
         
                "https://triptoestonia.com/et/tartumaa/",
       
                "https://triptoestonia.com/et/valgamaa/",
         
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-jygevamaa/",
          
                "https://triptoestonia.com/et/uezdy-estonii/estonskij-uezd-vyrumaa/" 
            };
        public Maa_Page()
        {

            pik = new Picker
            {
                Title = "Уезд",
                VerticalOptions = LayoutOptions.Start

            };
            pik.Items.Add("Harjumaa");
            pik.Items.Add("Ida-Virumaa");
            pik.Items.Add("Viljandimaa");            
            pik.Items.Add("Hiiumaa");
            pik.Items.Add("Järvamaa");
            pik.Items.Add("Läänemaa");
            pik.Items.Add("Lääne-Viruma");
            pik.Items.Add("Pärnumaa");
            pik.Items.Add("Põlvamaa");
            pik.Items.Add("Raplamaa");
            pik.Items.Add("Saaremaa");
            pik.Items.Add("Tartumaa");
            pik.Items.Add("Valgamaa");
            pik.Items.Add("Jõgevamaa");
            pik.Items.Add("Võrumaa");
            pik2 = new Picker
            {
                Title = "Голод"
            };
            pik2.Items.Add("Tallinn");
            pik2.Items.Add("Jõgeva");
            pik2.Items.Add("Kärdla");
            pik2.Items.Add("Jõhvi");
            pik2.Items.Add("Paide");
            pik2.Items.Add("Haapsalu");
            pik2.Items.Add("Rakvere");
            pik2.Items.Add("Pärnu");
            pik2.Items.Add("Põlva");
            pik2.Items.Add("Rapla");
            pik2.Items.Add("Kuressaare");
            pik2.Items.Add("Tartu");
            pik2.Items.Add("Valga");
            pik2.Items.Add("Viljandi");
            pik2.Items.Add("Võru");
            webView = new WebView
            { };
            btn = new Button()
            {
                Text = "Инфо"
            };
            st = new StackLayout { Children = { pik, pik2, btn } };
            Content = st;

            pik.SelectedIndexChanged += Piker_SelectedIndexChanged;
            pik2.SelectedIndexChanged += Piker2_SelectedIndexChanged;


            btn.Clicked += Btn_Clicked;
        }



          private async void Piker2_SelectedIndexChanged(object sender, EventArgs e)
          {
              pik.SelectedIndex = pik2.SelectedIndex;

          }

          private async void Piker_SelectedIndexChanged(object sender, EventArgs e)
          {

              pik2.SelectedIndex = pik.SelectedIndex;

          }
        private async void Btn_Clicked(object sender, EventArgs e)
        {

            await Browser.OpenAsync(lehed[pik.SelectedIndex], BrowserLaunchMode.SystemPreferred);

        }
    }
}