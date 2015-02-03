using Xamarin.Forms;
using YasetApp.Helpers;

namespace YasetApp.Pages
{
	public class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
            PageHelper.CreateToolbarButtons(this);

            Content = new StackLayout {
				Children = {
					new Label { Text = "Settings" }
				}
			};
		}
	}
}
