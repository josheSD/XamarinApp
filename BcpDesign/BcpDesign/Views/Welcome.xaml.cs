using BcpDesign.ViewModel;
using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BcpDesign.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {

        public Welcome()
        {
            InitializeComponent();
            BindingContext = new ViewModelWelcome();
        }

        private async void EventSignAzureAd(object sender, EventArgs e)
        {
            await SignInAsync();
        }
        public async Task SignInAsync()
        {
            AuthenticationResult authResult = null;
            IEnumerable<IAccount> accounts = await App.PCA.GetAccountsAsync();
            try
            {
                try
                {
                    IAccount firstAccount = accounts.FirstOrDefault();

                    if(firstAccount != null)
                    {
                        ManejarResuesta();
                    }
                    else
                    {
                        authResult = await App.PCA.AcquireTokenInteractive(Constants.Scopes)
                                                  .WithParentActivityOrWindow(App.ParentWindow)
                                                  .WithUseEmbeddedWebView(true)
                                                  .ExecuteAsync();

                        ManejarResuesta();
                    }

                }
                catch (MsalUiRequiredException ex)
                {
                    try
                    {
                        authResult = await App.PCA.AcquireTokenInteractive(Constants.Scopes)
                                                  .WithParentActivityOrWindow(App.ParentWindow)
                                                  .WithUseEmbeddedWebView(true)
                                                  .ExecuteAsync();

                        ManejarResuesta();

                        System.Diagnostics.Debug.WriteLine(ex);

                    }
                    catch (Exception ex2)
                    {
                        System.Diagnostics.Debug.WriteLine(ex2);
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void ManejarResuesta()
        {
            Navigation.PushAsync(new Tabbet());
        }

        private async void EventSignUp(object sender, EventArgs e)
        {
            IEnumerable<IAccount> accounts = await App.PCA.GetAccountsAsync();
            await App.PCA.RemoveAsync(accounts.FirstOrDefault());
        }
    }
}