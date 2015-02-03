using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace YasetApp.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        private Application app;
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            app = new YasetApp.App();
            LoadApplication(app);
        }

        protected override async void OnBackKeyPress(CancelEventArgs e)
        {
            await app.MainPage.Navigation.PopAsync();
            //base.OnBackKeyPress(e);
        }
    }
}
