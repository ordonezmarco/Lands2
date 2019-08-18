﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lands2.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lands2
{
    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            this.MainPage = new NavigationPage(new LoginPage());
        }
        #endregion

        #region Methods
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
        #endregion
    }
}
