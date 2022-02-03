using BcpDesign.Views;
using FormsControls.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BcpDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AnimationNavigationPage(new Welcome());
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
