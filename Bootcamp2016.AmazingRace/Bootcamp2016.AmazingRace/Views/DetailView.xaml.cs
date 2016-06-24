using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bootcamp2016.AmazingRace.Views
{
    public partial class DetailView : ContentPage
    {
        public DetailView()
        {
            InitializeComponent();
            this.BindingContextChanged += DetailView_BindingContextChanged;
        }

        private void DetailView_BindingContextChanged(object sender, EventArgs e)
        {
            MoveMap();
        }

        private void MoveMap()
        {
            try
            {
                double lat = double.Parse(Latitude.Text);
                double lng = double.Parse(Longitude.Text);
                MyMap.MoveToRegion(new MapSpan(MyMap.VisibleRegion.Center, lat, lng));
            } catch { }
        }
    }
}
