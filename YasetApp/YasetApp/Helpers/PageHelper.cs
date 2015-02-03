using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using YasetApp.Pages;

namespace YasetApp.Helpers
{
    internal static class PageHelper
    {
        public static void CreateToolbarButtons(HomeFilesListPage page)
        {
            if (page == null) return;
            var newFileButton = new ToolbarItem()
            {
                Icon = "Assets/appbar.page.add.png",
                Text = "New",
                Command = new Command(async () =>
                    await page.Navigation.PushAsync(new ExpensePage("New file", true))),
            };

            var settingsButton = new ToolbarItem()
            {
                Icon = "Assets/appbar.settings.png",
                Text = "Settings",
                Command = new Command(async () =>
                    await page.Navigation.PushAsync(new SettingsPage())),
            };

            page.ToolbarItems.Clear();
            page.ToolbarItems.Add(newFileButton);
            page.ToolbarItems.Add(settingsButton);
        }

        public static void CreateToolbarButtons(ExpensePage page)
        {
            if (page == null) return;
            var saveFile = new ToolbarItem()
            {
                Icon = "Assets/appbar.save.png",
                Text = "New",
                Command = new Command(async () =>
                    await page.Navigation.PopAsync()),
            };

            //var settingsButton = new ToolbarItem()
            //{
            //    Icon = "Assets/appbar.settings.png",
            //    Text = "Settings",
            //    Command = new Command(async () =>
            //        await page.Navigation.PushAsync(new SettingsPage())),
            //};

            page.ToolbarItems.Clear();
            page.ToolbarItems.Add(saveFile);


            if (!page.IsNewFile)
            {
                var deleteFile = new ToolbarItem()
                {
                    Icon = "Assets/appbar.delete.png",
                    Text = "New",
                    Command = new Command(async () =>
                        {
                            var answer = await page.DisplayAlert("Delete confirmation", "Are you sure you want to delete this file?", "Yes", "No");
                            Debug.WriteLine("Answer: " + answer); // writes true or false to the console
                            await page.Navigation.PopAsync();
                        }),
                };
                page.ToolbarItems.Add(deleteFile);
            }

            //page.ToolbarItems.Add(settingsButton);
        }

        public static void CreateToolbarButtons(SettingsPage page)
        {
            if (page == null) return;

            page.ToolbarItems.Clear();
        }
    }
}
