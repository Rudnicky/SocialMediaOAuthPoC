using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialMediaOAuthPoC.Services;
using SocialMediaOAuthPoC.Views;

namespace SocialMediaOAuthPoC
{
    public partial class App : Application
    {
        public IFacebookLoginService FacebookLoginService { get; private set; }

        public App(IFacebookLoginService facebookLoginService)
        {
            InitializeComponent();

            FacebookLoginService = facebookLoginService;

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
