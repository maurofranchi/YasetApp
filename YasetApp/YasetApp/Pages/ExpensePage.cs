using Xamarin.Forms;
using YasetApp.Helpers;

namespace YasetApp.Pages
{
    public class ExpensePage : ContentPage
	{
        public string FileName { get; set; }
        public bool IsNewFile { get; private set; }

        public ExpensePage (string fileName, bool isNew = false)
		{
            IsNewFile = isNew;
            FileName = fileName;

            PageHelper.CreateToolbarButtons(this);

            Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ExpensePage - " + fileName }
				}
			};
		}
	}
}
