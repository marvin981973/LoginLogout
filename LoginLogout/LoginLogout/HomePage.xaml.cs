using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginLogout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

		public void OnNextClicked(object sender, EventArgs args)
		{
			Navigation.PushAsync(new FirstPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (!App.IsLoggedIn)
			{
				var vLoginPage = new LoginPage();
				Navigation.InsertPageBefore(vLoginPage, this);
				Navigation.PopAsync();
			}
			else
			{

			}
		}
	}
}