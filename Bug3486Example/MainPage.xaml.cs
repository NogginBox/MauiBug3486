using Bug3486Example.ViewModels;
using Microsoft.Maui.Controls;

namespace Bug3486Example
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainPageViewModel();
		}
	}
}
