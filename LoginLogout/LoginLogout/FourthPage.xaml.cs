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
	public partial class FourthPage : ContentPage
	{
		public FourthPage ()
		{
			InitializeComponent ();
		}

		public void OnLogOut(object sender, EventArgs args)
		{
			App.IsLoggedIn = false;
			Navigation.PopToRootAsync();
		}

		public void OnHome(object sender, EventArgs args)
		{
			Navigation.PopToRootAsync();
		}

		public void OnFirst(object sender, EventArgs args)
		{
			Navigation.PushAsync(new FirstPage());
		}
	}
}