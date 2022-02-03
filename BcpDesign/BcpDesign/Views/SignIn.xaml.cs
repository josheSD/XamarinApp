
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
    public partial class SignIn : ContentPage, IAnimationPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public IPageAnimation PageAnimation { get; } = new FlipPageAnimation { Duration = AnimationDuration.Long, Subtype = AnimationSubtype.FromRight };

        public void OnAnimationFinished(bool isPopAnimation)
        {

        }

        public void OnAnimationStarted(bool isPopAnimation)
        {

        }

        private void EventDashboard(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dashboard());
        }
    }
}