using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using YasetApp.Helpers;

namespace YasetApp.Pages
{
    public class HomeFilesListPage : ContentPage
    {
        public HomeFilesListPage()
        {
            var headerLabel = new Label
            {
                Text = "Yeat Another Simple Expenses Tracker",
                FontAttributes = FontAttributes.Bold,
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center
            };
            var separatorLine = new BoxView() { Color = Color.White, HeightRequest = 5 };

            var tableView = new TableView
            {
                Intent = TableIntent.Data,
                Root = new TableRoot
                    {
                        new TableSection("Recent expenses records")
                        {
                            new TextCell
                            {
                                Text = "File 1",
                                Command = new Command(async () =>
                                    await Navigation.PushAsync(new ExpensePage("File 1")))
                            },
                        }
                    }
            };

            PageHelper.CreateToolbarButtons(this);
            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    headerLabel,
                    separatorLine,
                    tableView
                }
            };
        }
    }
}
