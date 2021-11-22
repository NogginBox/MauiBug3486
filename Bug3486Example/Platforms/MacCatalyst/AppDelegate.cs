using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bug3486Example
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}