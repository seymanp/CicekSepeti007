using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CicekSepeti007
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TumUrunler : ContentPage
	{
		public TumUrunler ()
		{
			InitializeComponent ();
		}

        private void ClkOrkide(object sender, EventArgs e)
        {

        }

        private void Menu(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Navigation.PushModalAsync(menu);
        }
    }
}