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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

		public void OnLoginClicked(object sender, EventArgs args)
		{
			App.IsLoggedIn = true;
			var vHomePage = new HomePage();
			Navigation.InsertPageBefore(vHomePage, this);
			Navigation.PopAsync();
		}
	}
}