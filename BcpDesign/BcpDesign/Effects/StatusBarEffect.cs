using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BcpDesign.Effects
{
    public class StatusBarEffect : RoutingEffect
    {
        public Color BackgroundColor { get; set; }
        public bool isLight { get; set; }

        public StatusBarEffect() : base("Xamarin.StatusBarEffect")
        {

        }
    }
}
