using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        List<string> list = new List<string>
        {
            "Hosni","Aya","Mariem" ,"Houssem","Siwar","Ala","karim","imen"
        };

		public Page1 ()
		{
            list.Add("oussema");
			InitializeComponent ();
            myLabel.Text = "Hello Xamarin Via " + Device.RuntimePlatform;
            myList.ItemsSource = list;
		}
        protected async void btnClicked(object o,EventArgs e)
        {
            int age = 20;
            //DisplayAlert("Message", "hello" + Device.RuntimePlatform, "ok!");  
           await Navigation.PushAsync(new Page2());

        }
        protected void SearchPressed(object o,EventArgs e)
        {
           
            myList.ItemsSource = list.Where(y=> y.Contains(mySearchBar.Text));
        }
    }
}