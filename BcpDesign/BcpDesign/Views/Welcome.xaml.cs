using BcpDesign.ViewModel;
using FormsControls.Base;
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
    public partial class Welcome : ContentPage, IAnimationPage
    {
        public Welcome()
        {
            InitializeComponent();
            BindingContext = new ViewModelWelcome();
        }

        public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.Default };

        public void OnAnimationFinished(bool isPopAnimation)
        {

        }

        public void OnAnimationStarted(bool isPopAnimation)
        {

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