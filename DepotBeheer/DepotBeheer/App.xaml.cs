using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace DepotBeheer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MobileCenter.Start("ios=fea64d75-b2a5-43cb-bce9-6455d0d905e7;" + "uwp=2364ce7d-f3be-4320-85bf-ae56976116ee;" + "android=dcaafe72-b48d-41cb-9a4f-96d411d67ad2", typeof(Analytics), typeof(Crashes));
            MainPage = new DepotBeheer.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
