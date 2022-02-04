using BcpDesign.Views;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BcpDesign
{
    public partial class App : Application
    {
        public static readonly string ClientID = "de346d68-cf66-44d8-8aec-288e6bfaf205";
        public static readonly string[] Scopes = { "User.Read" };
        public static readonly string Username = string.Empty;
        public static readonly IPublicClientApplication PCA = PublicClientApplicationBuilder.Create(ClientID)
                        .WithRedirectUri($"msal{ClientID}://auth")
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
