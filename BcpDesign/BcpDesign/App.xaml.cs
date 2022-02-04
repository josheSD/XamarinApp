using BcpDesign.Views;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BcpDesign
{
    public partial class App : Application
    {
        public static readonly IPublicClientApplication PCA = PublicClientApplicationBuilder.Create(Constants.ClientID)
                        .WithRedirectUri($"msal{Constants.ClientID}://auth")
                        .Build();
        public static object ParentWindow { get; set; }

        public App()
        {
            MainPage = new NavigationPage(new Welcome());
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
