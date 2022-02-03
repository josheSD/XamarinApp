using BcpDesign.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void EventSign(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignIn());
        }

        private void EventSignUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
    }
}